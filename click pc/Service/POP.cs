using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Service
{
    internal class POP
    {
        public static async Task GetPowPOP()
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    //string decodedToken = System.Web.HttpUtility.UrlDecode(token);
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI2MzA0MzIiLCJqdGkiOiI0YjAzNjYzMS04NmQxLTQ5YjktOGZmNi03ZTZiMzFmOTcxMWIiLCJpYXQiOiIxNzE3MTI2ODc5IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiI2MzA0MzIiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiaGFpZGIxIiwiQ2hhdElEIjoiNzc1NzYzNjU5IiwiVGVsZUlEIjoiNzc1NzYzNjU5IiwiZXhwIjoxNzQ4MjMwODc5LCJpc3MiOiJ0ZWxlYm90YXBpIiwiYXVkIjoidGVsZWJvdGFwaSJ9.xwIX344z9ro7YNHyaQtDbDJDqjSEJVPAc6gxUcc-yHk");
                    string url = "https://api.poplaunch.io/user/getUser2?oldTapcount=0&oldTapTimeTs=0";
                    string stringJson = @"{""ClickCount"": 10000}";
                    StringContent contentHttp = new StringContent(stringJson, System.Text.Encoding.UTF8, "application/json");
                    List<Task> tasks = new List<Task>();
                    //while (true) { 
                    //for (int i = 0; i < 500; i++)
                    //{
                    //    Task task = Task.Run(async () =>
                    //    {
                    //        while (true)
                    //        {
                    //            var httpRequest = await client.GetAsync(url);
                    //            if (httpRequest.IsSuccessStatusCode)
                    //            {
                    //                string result = await httpRequest.Content.ReadAsStringAsync();
                    //                JObject keyValuePairs = JObject.Parse(result);
                    //                if (keyValuePairs["power"].ToString() == "5000")
                    //                {
                    //                    break;
                    //                }
                    //                Debug.WriteLine(result);
                    //                //TextLog(textBox, result);

                    //            }


                    //        }
                    //    });
                    //    tasks.Add(task);
                    //}
                    //await Task.WhenAll(tasks);
                    for (int i = 0; i < 1000; i++)
                    {
                        Task task = Task.Run(async () =>
                        {
                            var httpRequest = await client.PutAsync("https://api.poplaunch.io/user/savecoin2", contentHttp);
                
                            if (httpRequest.IsSuccessStatusCode)
                            {
                                string result = await httpRequest.Content.ReadAsStringAsync();


                                Debug.WriteLine(result);
                                //TextLog(textBox, result);

                            }
                           
                        });
                            } 
                    //}
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

            }
        }
    }
}
