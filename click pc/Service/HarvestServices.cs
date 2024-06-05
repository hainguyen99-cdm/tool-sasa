using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Service
{
    internal class HarvestServices
    {
        public static string matchId;
        public static bool boolMatch=false;

        public static int watercount;
        public static int currentExp;
        public static int maxExp;

        public static bool protectCoin;
        public static bool protectWater;
        public static bool protectFruit;
        static bool flagWs =false;

        public static async Task<string> LoginGame(string tokenA)
        {
            
            try { 
      
            using(HttpClient  client = new HttpClient())
            {

                client.DefaultRequestHeaders.Add("Authorization", "Basic NTM0QjE0RTAtNzIzNS00NEFDLTg0Q0ItN0MyNjVFQUMxNDdFOg==");
                string url = "https://harvest-heist-api.saworld.io/v2/account/authenticate/custom?";
                string stringJson = $@"{{
    ""id"": ""{}"",
    ""vars"": {{}}
}}";
                StringContent contentHttp = new StringContent(stringJson, System.Text.Encoding.UTF8, "application/json");
                var httpRequest = await client.PostAsync(url, contentHttp);
                if(httpRequest.IsSuccessStatusCode)
                {
                    string result = await httpRequest.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(result);
                        Debug.WriteLine(data["token"].ToString());
                    return data["token"].ToString();
                    }
                    else
                    {
                        return null;
                    }

            }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
        //public static async Task WaterTheTree(string token)
        //{
        //    try {
        //        using (ClientWebSocket ws = new ClientWebSocket())
        //        {
        //            ws.Options.SetRequestHeader("Host", "harvest-heist-api.saworld.io");
        //            ws.Options.SetRequestHeader("Origin", "https://games-sasa.saworld.io");
        //            ws.Options.SetRequestHeader("Upgrade", "websocket");
        //            ws.Options.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36");

        //            Uri serverUri = new Uri("wss://harvest-heist-api.saworld.io/ws?lang=en&status=true&token="+token);
        //            await ws.ConnectAsync(serverUri, CancellationToken.None);
        //            Debug.WriteLine("Connected!");
        //            var cts = new CancellationTokenSource();
        //            _ = Task.Run(() => ReceiveMessages(ws, cts.Token), cts.Token);
        //            //await Received(ws);
        //            await SendWs(ws, "{\"ping\":{},\"cid\":\"1\"}");
        //            //get matchId
        //            SendWs(ws, "{\"rpc\":{\"id\":\"find_private_room\"},\"cid\":\"2\"}");
        //            while (true)
        //            {
        //                if (matchId != null)
        //                {
        //                    break;
        //                }
        //            }
        //            //join Match
        //            await SendWs(ws, "{\"match_join\":{\"match_id\":\"" + matchId + "\"},\"cid\":\"4\"}");
        //            await Task.Delay(1000);
        //            //bơm nước
        //            await SendWs(ws, "{\"match_data_send\": {\"match_id\": \"" + matchId + "\",\"op_code\": \"4\",\"data\": \"eyJxdWFudGl0eSI6MX0=\",\"presences\": []}}");
        //            await Task.Delay(1000);
        //            await SendWs(ws, "{ \"match_data_send\": { \"match_id\": \"" + matchId + "\",\"op_code\": \"7\",\"presences\": []}}");
        //            await Task.Delay(1000);
        //            await SendWs(ws, "{\"ping\":{},\"cid\":\"5\"}");
        //            // thêm khiên
            

        //            //gacha


        //            await Task.Delay(5000); // Đợi thêm để nhận tất cả tin nhắn nếu cần thiết

        //            cts.Cancel(); // Hủy nhận tin nhắn
        //            ////// Đóng kết nối
        //            await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Done", CancellationToken.None);
        //            Debug.WriteLine("Closed!");
        //        }
        //    } catch (Exception e){
        //        Debug.WriteLine(e.Message);
        //    }
        //}
        public static async Task Defen(string token, RichTextBox textBox)
        {
            flagWs = false;
            boolMatch = true;
              ClientWebSocket ws = new ClientWebSocket();
            try
            {


                ws.Options.SetRequestHeader("Host", "harvest-heist-api.saworld.io");
                ws.Options.SetRequestHeader("Origin", "https://games-sasa.saworld.io");
                ws.Options.SetRequestHeader("Upgrade", "websocket");
                ws.Options.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36");

                Uri serverUri = new Uri("wss://harvest-heist-api.saworld.io/ws?lang=en&status=true&token=" + token);
                await ws.ConnectAsync(serverUri, CancellationToken.None);
                Debug.WriteLine("Connected!");
                var cts = new CancellationTokenSource();
                _ = Task.Run(() => ReceiveMessages(ws, cts.Token, textBox), cts.Token);
                //await Received(ws);
                await SendWs(ws, "{\"ping\":{},\"cid\":\"1\"}");
            //get matchId
                  flag1:
                SendWs(ws, "{\"rpc\":{\"id\":\"find_private_room\"},\"cid\":\"2\"}");
               
                while (true)
                {
                    if (matchId != null)
                    {
                        break;
                    }
                }


                //join Match
                await SendWs(ws, "{\"match_join\":{\"match_id\":\"" + matchId + "\"},\"cid\":\"4\"}");
                //if (boolMatch)
                //{
                //    Thread.Sleep(3000);
                //    goto flag1;
                    
                //}

                await Task.Delay(1000);
                while (true)
                {
                    if (flagWs)
                    {
                        break;
                    }

                    await SendWs(ws, "{\"match_data_send\": { \"match_id\": \""+matchId+"\",\"op_code\": \"5\",\"presences\": []}}");
                    await Task.Delay(1000);
                    await SendWs(ws, "{\"match_data_send\": {\"match_id\": \""+matchId+"\",\"op_code\": \"15\",\"presences\": []}}");
                    await Task.Delay(1000);

                    // thêm khiên
                    if (!protectCoin)
                {

                        TextLog(textBox, "Protecting Coin");
                        await SendWs(ws, "{\"match_data_send\":{\"match_id\": \"" + matchId + "\",\"op_code\": \"9\",\"data\": \"eyJ0eXBlIjoxfQ==\",\"presences\": []}}");
                }



                if (!protectFruit)
                {
                        TextLog(textBox, "Protecting Fruit");

                        await SendWs(ws, "{\"match_data_send\":{\"match_id\": \"" + matchId + "\",\"op_code\": \"9\",\"data\": \"eyJ0eXBlIjozfQ==\",\"presences\": []}}");
                }
                if (!protectWater)
                {
                        TextLog(textBox, "Protecting Water");

                        await SendWs(ws, "{\"match_data_send\":{\"match_id\": \"" + matchId + "\",\"op_code\": \"9\",\"data\": \"eyJ0eXBlIjoyfQ==\",\"presences\": []}}");
                }
                    if (currentExp<maxExp) { 
                        if (watercount >= 20)
                        {
                                TextLog(textBox, "Watering the tree");
                            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes("{\"quantity\":"+watercount+"}");
                            string water= System.Convert.ToBase64String(plainTextBytes);
                            await SendWs(ws, "{\"match_data_send\": {\"match_id\": \"" + matchId + "\",\"op_code\": \"4\",\"data\": \""+ water + "\",\"presences\": []}}");
                            await Task.Delay(1000);
                            await SendWs(ws, "{ \"match_data_send\": { \"match_id\": \"" + matchId + "\",\"op_code\": \"7\",\"presences\": []}}");
                        }
                  
                    }
                    //gacha


                
                }
                cts.Cancel(); // Hủy nhận tin nhắn
                              //// Đóng kết nối
                
                //await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
                //Debug.WriteLine("Closed!");

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
            try { 
       
            // Gửi tin nhắn
            ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
            await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);
            Debug.WriteLine($"Sent: {message}");

                // Nhận phản hồi
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
 
        public static async Task ReceiveMessages(ClientWebSocket ws, CancellationToken cancellationToken,RichTextBox textBox)
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
                        flagWs = true;
                    }
                    else
                    {
                        string message = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                        Debug.WriteLine($"Received: {message}");
                         if (message.Contains("find_private_room"))
                             {
                            JObject data = JObject.Parse(message);
                            JObject rpc = JObject.Parse(data["rpc"]["payload"].ToString());
                             matchId = rpc["matchId"].ToString();
                             }
                        if (message.Contains("\"cid\":\"4\""))
                        {
                            if(message.Contains("\"message\":\"Match not found\""))
                            {
                                boolMatch = true;
                            }
                            else
                            {
                                boolMatch=  false;
                            }
                           
                        }
                        if (message.Contains("\"op_code\":\"1\""))
                        {
                            JObject data = JObject.Parse(message);
                            string dataBase64 = data["match_data"]["data"].ToString();

                            var base64EncodedBytes = System.Convert.FromBase64String(dataBase64);
                            Debug.WriteLine(System.Text.Encoding.UTF8.GetString(base64EncodedBytes));
                            data = JObject.Parse(System.Text.Encoding.UTF8.GetString(base64EncodedBytes));
                            watercount = Int32.Parse(data["progress"]["wateringCan"].ToString());
                            protectCoin = bool.Parse(data["progress"]["protectCoin"].ToString());
                            protectWater = bool.Parse(data["progress"]["protectWater"].ToString());
                            protectFruit = bool.Parse(data["progress"]["protectFruit"].ToString());
                            currentExp = Int32.Parse(data["progress"]["currentExp"].ToString());
                            maxExp = Int32.Parse(data["progress"]["maxExp"].ToString());
                            string shame = data["inventories"]["b74a2033-93f2-440e-a79f-4a2cbd1bf372"]["quantity"].ToString();
                            string shield = data["inventories"]["f1d1591c-1688-41c4-a4e9-0d1150c8a069"]["quantity"].ToString();


                            //Debug.WriteLine("wallet: " + data["wallet"]["coin"].ToString());
                            textBox.Invoke((MethodInvoker)delegate
                            {
                                if (textBox.TextLength > 1)
                            {
                                textBox.Clear();
                            }
                            });
                            TextLog(textBox, "watercount: "+ watercount.ToString());
                            TextLog(textBox, "protectCoin: "+ protectCoin.ToString());
                            TextLog(textBox, "protectWater: "+ protectWater.ToString());
                            TextLog(textBox, "protectFruit: "+ protectFruit.ToString());
                            TextLog(textBox, "currentExp: " + currentExp.ToString());
                            TextLog(textBox, "maxExp: " + maxExp.ToString());
                            TextLog(textBox, "Shame: " + shame.ToString());
                            TextLog(textBox, "shield: " + shield.ToString());





                        }

                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error receiving messages: {e.Message}");
                ws.Dispose();
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
        public static async Task<string> GetMatchId(ClientWebSocket ws, string message)
        {
            try {
                string matchId = "";
            // Gửi tin nhắn
            ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
            await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);
            Debug.WriteLine($"Sent: {message}");
 
            // Nhận phản hồi
            ArraySegment<byte> bytesReceived = new ArraySegment<byte>(new byte[1024]);
            WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, CancellationToken.None);
            string response = Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count);
            Debug.WriteLine($"Received: {response}");
            JObject data = JObject.Parse(response);
                if (response.Contains("matchId"))
                {
                    JObject rpc = JObject.Parse(data["rpc"]["payload"].ToString());
                     matchId = rpc["matchId"].ToString();
                }
            
            return matchId;
            }
            catch(Exception ex) 
            {
                Debug.WriteLine(ex.Message );
                return null;
            }

        }

        public static async Task harvesting(ClientWebSocket ws,string matchId)
        {
            try
            {
                SendWs(ws, "{\"match_data_send\": {\"match_id\": \""+ matchId + "\",\"op_code\": \"3\",\"presences\": []}}");
                SendWs(ws, "{\"match_data_send\": {\"match_id\": \""+matchId+"\",\"op_code\": \"5\",\"presences\": []}}");

            }
            catch (Exception ex ) 
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public static async Task GetTokenHH(string token)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Add("Authorization", "Basic NTM0QjE0RTAtNzIzNS00NEFDLTg0Q0ItN0MyNjVFQUMxNDdFOg==");
                    string url = "https://harvest-heist-api.saworld.io/v2/account/authenticate/custom?";
                    string stringJson = @"{
    ""id"": """+token+@""",
    ""vars"": {}
}";
                    StringContent contentHttp = new StringContent(stringJson, System.Text.Encoding.UTF8, "application/json");
                    var httpRequest = await client.PostAsync(url, contentHttp);
                    if (httpRequest.IsSuccessStatusCode)
                    {
                        string result = await httpRequest.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(result);
                        Debug.WriteLine(data["token"].ToString());

                    }

                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
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
