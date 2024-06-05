using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Service
{
    internal class pixelversexyz
    {
       public static string battelId = null;
       public static bool END=false;
        public static string resultBox=null;
        public static async Task Boxing( RichTextBox textBox)
        {
            ClientWebSocket ws = new ClientWebSocket();
            try
            {

                END = false;
                Uri serverUri = new Uri("wss://api-clicker.pixelverse.xyz/socket.io/?EIO=4&transport=websocket");
                await ws.ConnectAsync(serverUri, CancellationToken.None);
                Debug.WriteLine("Connected!");

                var cts = new CancellationTokenSource();
                _ = Task.Run(() => ReceiveMessages(ws, cts.Token, textBox), cts.Token);
                Thread.Sleep(1000);

                //await Received(ws);
                await SendWs(ws, "40{\"tg-id\": 775763659,\"secret\": \"d4db750404f5522c1bfb78c7e3f8c300088d2686f3cac838bee77c21326be2d0\",\"initData\": \"query_id=AAHLNj0uAAAAAMs2PS75J2Iv&user=%7B%22id%22%3A775763659%2C%22first_name%22%3A%22X%22%2C%22last_name%22%3A%22Magneto%22%2C%22username%22%3A%22haidb1%22%2C%22language_code%22%3A%22en%22%2C%22allows_write_to_pm%22%3Atrue%7D&auth_date=1717406997&hash=572e387bf79a0707d2d559ba53aa3f897fa22ca8ff170bf110bf31dcd2c6e49a\"}");
                //get matchId
                while(battelId==null)
                {
                  await Task.Delay(100);

                }

                Debug.WriteLine(battelId);
                if (battelId != null)
                {
                    while (true)
                    {
                        if (END)
                        {
                            break;
                        }
                        await SendWs(ws, "42[\"HIT\",{\"battleId\": \""+battelId+"\"}]");
                        await Task.Delay(100);

                    }
                }
               
                //cts.Cancel(); // Hủy nhận tin nhắn
                              //// Đóng kết nối

                await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
                Debug.WriteLine("Closed!");

            }
            catch (TaskCanceledException ex)
            {
                Debug.WriteLine($"Hoạt động bị hủy: {ex.Message}");
            }
            catch (WebSocketException ex)
            {
                Debug.WriteLine($"Lỗi WebSocket: {ex.Message}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi không mong đợi: {ex.Message}");
            }
            finally
            {
                if (ws != null)
                {
                    try
                    {
                        ws.Dispose(); // Đảm bảo WebSocket được giải phóng
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Lỗi khi giải phóng WebSocket: {ex.Message}");
                    }
                }
                Debug.WriteLine("Đã đóng!");
          
            }
        }


        public static async Task SendWs(ClientWebSocket ws, string message)
        {
            try
            {

                // Gửi tin nhắn
                ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
                await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);
                Debug.WriteLine($"Sent: {message}");

                // Nhận phản hồi
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public static async Task ReceiveMessages(ClientWebSocket ws, CancellationToken cancellationToken, RichTextBox textBox)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested && ws.State == WebSocketState.Open)
                {
                    ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[2048]);
                    WebSocketReceiveResult result = await ws.ReceiveAsync(buffer, cancellationToken);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by client", CancellationToken.None);
                        Debug.WriteLine("Connection closed by server");
                        return;
                    }
                    else
                    {
                        string message = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                        Debug.WriteLine($"Received: {message}");
                        //TextLog(textBox, message);
                        if (message.Contains("START"))
                        {
                            string json = message.Substring(2);
                            JArray jsonArray = JArray.Parse(json);

                            // Extract the battleId value
                            battelId = jsonArray[1]["battleId"].ToString();

                        }

                        if (message.Contains("END"))
                        {
                            string json = message.Substring(2);
                            JArray jsonArray = JArray.Parse(json);

                            // Extract the battleId value
                            resultBox = jsonArray[1]["result"].ToString();
                            TextLog(textBox, resultBox);

                            END = true;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error receiving messages: {e.Message}");
            }
        }
        static void TextLog(RichTextBox textBox, string conttent)
        {

            try
            {
                textBox.Invoke((MethodInvoker)delegate
                {
                    if (textBox.TextLength > 1000)
                    {
                        textBox.Clear();

                    }
                    textBox.AppendText(conttent + "\n");
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.ScrollToCaret();
                });
            }
            catch
            {
                textBox.Clear();
            }
        }
    }
}
