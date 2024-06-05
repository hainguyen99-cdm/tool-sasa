using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Service
{
    internal class Yescoin
    {
        public static async Task Yescoins(RichTextBox textBox,string token)
        {

            try
            {

                using (HttpClient client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Add("Token", token);
                    string url = "https://api.yescoin.gold/game/collectCoin";
                    string stringJson = "1";
                    StringContent contentHttp = new StringContent(stringJson, System.Text.Encoding.UTF8, "application/json");
                    while (true) { 
                    var httpRequest = await client.PostAsync(url, contentHttp);
                    if (httpRequest.IsSuccessStatusCode)
                    {
                        string result = await httpRequest.Content.ReadAsStringAsync();
               
                        TextLog(textBox, result);

                        }


                    }
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
