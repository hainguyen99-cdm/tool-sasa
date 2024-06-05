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
    internal class prick
    {
        public static async Task ClaimPrick()
        {
            try
            {
                using (ClientWebSocket ws = new ClientWebSocket())
                {
           
                  
                    //ws.Options.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36");
                    ws.Options.AddSubProtocol("775763659");


                    Uri serverUri = new Uri("wss://swagerbyfalio.com/prick/ws");
                    await ws.ConnectAsync(serverUri, CancellationToken.None);
                    Debug.WriteLine("Connected!");
                    var cts = new CancellationTokenSource();
                    _ = Task.Run(() => ReceiveMessages(ws, cts.Token), cts.Token);
                    //await Received(ws);
                    while(true) {
                    await SendWs(ws, "{\"action\": \"tap\",\"data\": [1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042,1717044640042]}");
                    }
                    //get matchId




                    await Task.Delay(5000); // Đợi thêm để nhận tất cả tin nhắn nếu cần thiết

                    cts.Cancel(); // Hủy nhận tin nhắn
                    ////// Đóng kết nối
                    await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Done", CancellationToken.None);
                    Debug.WriteLine("Closed!");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
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

        public static async Task ReceiveMessages(ClientWebSocket ws, CancellationToken cancellationToken)
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
                    }
                    else
                    {
                        string message = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                        Debug.WriteLine($"Received: {message}");
                        if (message.Contains("find_private_room"))
                        {
                            JObject data = JObject.Parse(message);
                            JObject rpc = JObject.Parse(data["rpc"]["payload"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error receiving messages: {e.Message}");
            }
        }
        public static async Task<string> Received(ClientWebSocket ws)
        {

            ArraySegment<byte> bytesReceived = new ArraySegment<byte>(new byte[2048]);
            WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, CancellationToken.None);
            string response = Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count);
            Debug.WriteLine($"Received: {response}");
            return response;
        }

    }
}
