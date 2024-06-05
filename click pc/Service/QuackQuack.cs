using Newtonsoft.Json.Linq;
using OpenQA.Selenium.DevTools.V122.Page;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace click_pc.Service
{
    internal class QuackQuack
    {

        static async Task<string> TotalEgg(string token)
        {
            string totalEgg = "";
            try { 
            string url = "https://api.quackquack.games/balance/get";
            using(HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + token);
                var response = await client.GetAsync(url);
                  
                if(response.IsSuccessStatusCode) {
                        if (response.Headers.Contains("Token"))
                        {
                          
                            token = response.Headers.GetValues("Token").FirstOrDefault();
                        }
                        
                        string result = await response.Content.ReadAsStringAsync();
                    JObject data=  JObject.Parse(result);
                        JArray jArray = new JArray();
                        jArray = JArray.Parse(data["data"]["data"].ToString());
                        for (int i = 0; i < jArray.Count; i++)
                        {
                            if(jArray[i]["symbol"].ToString()== "EGG")
                            {
                                totalEgg= jArray[i]["balance"].ToString();
                            }
                        }
                        return (totalEgg);
                    }
                else
                {
                    return null;
                }
            }
            }catch (Exception ex)
            {
                return  null;

            }
        }
        static async Task<bool> ClaimEgg(string nestId,List<string> lsDuckId,string token)
        {
            string url = "https://api.quackquack.games/nest/collect";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + token);
                var formData = new Dictionary<string, string>
            {
                { "nest_id", nestId }
                   
  
                // Add more key-value pairs as needed
            };
      
                var content = new FormUrlEncodedContent(formData);
                
                var response = await client.PostAsync(url, content);
                if(response.IsSuccessStatusCode)
                {
                 
                   
                    
                    return true;
                }
                else
                {

                    return false;
                }
          
            }
        }
        static async Task layEgg(string nestId, List<string> lsDuck,string token)
        {
    
            for(int i=0;i<lsDuck.Count;i++) {
              
                try
                {
             
                    Random random = new Random();
                    string duckId = lsDuck[i];
                    Debug.WriteLine(lsDuck[i]+"|"+ nestId);
                    string url = "https://api.quackquack.games/nest/lay-egg";
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("authorization", "Bearer " + token);
                        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36");
                        client.DefaultRequestHeaders.Add("Origin", "https://dd42189ft3pck.cloudfront.net");
                        client.DefaultRequestHeaders.Add("Referer", "https://dd42189ft3pck.cloudfront.net/");


                        var formData = new Dictionary<string, string>
            {
                { "nest_id", nestId },
                { "duck_id", duckId }
            };

                        var content = new FormUrlEncodedContent(formData);
                        var response = await client.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {

                            string result = await response.Content.ReadAsStringAsync();
                            Debug.WriteLine(result);
                        }
                       
                       


                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    continue;
                }
        
            }
         
           
        }
        static async Task<bool> ClaimNumEgg(string token)
        {
            string url = "https://api.quackquack.games/golden-duck/claim";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + token);
                var formData = new Dictionary<string, string>
            {
                { "type", "1" }
  
                // Add more key-value pairs as needed
            };
                var content = new FormUrlEncodedContent(formData);
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        static async Task<string> GetUser(string token)
        {
            string url = "https://api.quackquack.games/common/setting";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + token);
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    //if (response.Headers.Contains("Token"))
                    //{

                    //    token = response.Headers.GetValues("Token").FirstOrDefault();
                    //}
                    string result = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(result);
                    return data["data"]["username"].ToString();

                }
                else
                {
                    return null;
                }
            }
        }

          static async Task<(List<string>,List<string>)> GetNestClaim(string token)
        {
            List<string> lsIdEgg = new List<string>();
            List<string> lsDuck = new List<string>();

            try
            {

                string url = "https://api.quackquack.games/nest/list-reload";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("authorization", "Bearer " + token);
               
          
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        if (response.Headers.Contains("Token"))
                        {

                            token = response.Headers.GetValues("Token").FirstOrDefault();
                        }
                        string result = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(result);
                        JArray jArray = new JArray();
                        JArray jArray1 = new JArray();

                        jArray = JArray.Parse(data["data"]["nest"].ToString());
                        for(int i = 0; i < jArray.Count; i++)
                        {
                            lsIdEgg.Add(jArray[i]["id"].ToString());
                        }
                        jArray1 = JArray.Parse(data["data"]["duck"].ToString());
                        for (int i = 0; i < jArray1.Count; i++)
                        {
                            lsDuck.Add(jArray1[i]["id"].ToString());
                        }
                        return (lsIdEgg,lsDuck);
                    }
                    else
                    {
                        return (lsIdEgg, lsDuck);
                    }

                }

            }
            catch
            {
                return (lsIdEgg, lsDuck);
            }
        }


        public static async void MainClaim(string token,RichTextBox textBox)
        {
      
            List<string> lsIdEgg= new List<string>();
            List<string> lsIdDuck = new List<string>();

            string userName = await GetUser(token);
          

           
            while (true)
            {

                (lsIdEgg, lsIdDuck) = await GetNestClaim(token);
             
                string totalEgg = await TotalEgg(token);

                TextLog(textBox, userName + " totak Egg: " + totalEgg);

                foreach (string key in lsIdEgg)
                {
                    await layEgg(key, lsIdDuck, token);
                    bool check =  await ClaimEgg( key, lsIdDuck,token);
                    if (check)
                    {
                         TextLog(textBox, userName +": Claim "+key+" thành công");

             
                    }
                    else
                    {
                        TextLog(textBox, userName + ":  Claim "+key+" thất bại");
                       
                    }


                    //(bool checkClaim, token) = await ClaimNumEgg(token);
                    //if (checkClaim)
                    //{
                    //    TextLog(textBox, userName + ": Claim 500 thành công");

                    //}
                }
                Thread.Sleep(5000);
             
            }
         
        }
    
        static void TextLog(RichTextBox textBox,string conttent)
        {

            textBox.Invoke((MethodInvoker)delegate
            {
                textBox.Clear();
                textBox.AppendText(conttent + "\n");
                textBox.SelectionStart = textBox.Text.Length;
                textBox.ScrollToCaret();
            });
        }

    }
}
