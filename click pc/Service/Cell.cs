using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Service
{
    internal class Cell
    {
        public static async Task CelllToken(RichTextBox textBox, string token)
        {

            try
            {

                using (HttpClient client = new HttpClient())
                {
                    string decodedToken = System.Web.HttpUtility.UrlDecode(token);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", decodedToken);
                    string url = "https://cellcoin.org/claim";
             
                    //StringContent contentHttp = new StringContent(stringJson, System.Text.Encoding.UTF8, "application/json");
                    List<Task> tasks = new List<Task>();
                    //for (int i = 0; i < 10; i++)
                    //{
                    //    Task task = Task.Run(async () =>
                        //{
                            while (true)
                            {
                                var httpRequest = await client.PostAsync(url,null);
                                if (httpRequest.IsSuccessStatusCode)
                                {
                                    string result = await httpRequest.Content.ReadAsStringAsync();
                                    JObject data = JObject.Parse(result);
                                    TextLog(textBox,data["initData"]["user"]["first_name"].ToString()+ " oke");

                                }


                            }
                        //});
                    //    tasks.Add(task);
                    //}
                    //await Task.WhenAll(tasks);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

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
