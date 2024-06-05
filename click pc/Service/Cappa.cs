using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Service
{
    internal class Cappa
    {
        public static async Task Cappacoin(RichTextBox textBox, string token)
        {

            try
            {

                using (HttpClient client = new HttpClient())
                {
                    string decodedToken = System.Web.HttpUtility.UrlDecode(token);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", decodedToken);
                    string url = "https://clicker.prod-api.tgquest.com/clicker";
                    string stringJson = @"{""count"": 50000000000000}";
                    StringContent contentHttp = new StringContent(stringJson, System.Text.Encoding.UTF8, "application/json");
                    List<Task> tasks = new List<Task>();
                    for (int i = 0; i < 1000; i++)
                    {
                        Task task = Task.Run(async () =>
                        {
                            while (true)
                            {
                                var httpRequest = await client.PostAsync(url, contentHttp);
                                if (httpRequest.IsSuccessStatusCode)
                                {
                                    string result = await httpRequest.Content.ReadAsStringAsync();
                                    Debug.WriteLine(result);
                                    //TextLog(textBox, result);

                                }


                            }
                        });
                        tasks.Add(task);
                    }
                    await Task.WhenAll(tasks);
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
                    textBox.Clear();
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
