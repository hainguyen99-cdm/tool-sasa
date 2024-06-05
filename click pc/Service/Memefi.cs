using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Service
{
    internal class Memefi
    {
        public static async Task FramMeMefi(RichTextBox textBox, string token)
        {

            try
            {
                var proxy = new WebProxy
                {
                    Address = new Uri($"http://192.168.1.108:10000"),
                    BypassProxyOnLocal = false,
                    UseDefaultCredentials = false,

                    // *** These creds are given to the proxy server, not the web server ***

                };

                // Now create a client handler which uses that proxy
                var httpClientHandler = new HttpClientHandler
                {
                    Proxy = proxy,
                };
                using (HttpClient client = new HttpClient(handler: httpClientHandler, disposeHandler: true))
                {
              
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    string url = "https://api-gw-tg.memefi.club/graphql";
                    string stringJson = @"{
    ""operationName"": ""MutationGameProcessTapsBatch"",
    ""variables"": {
        ""payload"": {
            ""nonce"": ""2fce59d52e9646499608d50997ae98b5700e480de9fd4f0839dde04a49135126"",
            ""tapsCount"": 1
        }
    },
    ""query"": ""mutation MutationGameProcessTapsBatch($payload: TelegramGameTapsBatchInput!) {\n  telegramGameProcessTapsBatch(payload: $payload) {\n    ...FragmentBossFightConfig\n    __typename\n  }\n}\n\nfragment FragmentBossFightConfig on TelegramGameConfigOutput {\n  _id\n  coinsAmount\n  currentEnergy\n  maxEnergy\n  weaponLevel\n  energyLimitLevel\n  energyRechargeLevel\n  tapBotLevel\n  currentBoss {\n    _id\n    level\n    currentHealth\n    maxHealth\n    __typename\n  }\n  freeBoosts {\n    _id\n    currentTurboAmount\n    maxTurboAmount\n    turboLastActivatedAt\n    turboAmountLastRechargeDate\n    currentRefillEnergyAmount\n    maxRefillEnergyAmount\n    refillEnergyLastActivatedAt\n    refillEnergyAmountLastRechargeDate\n    __typename\n  }\n  bonusLeaderDamageEndAt\n  bonusLeaderDamageStartAt\n  bonusLeaderDamageMultiplier\n  nonce\n  __typename\n}""
}";
                    StringContent contentHttp = new StringContent(stringJson, System.Text.Encoding.UTF8, "application/json");
                    while (true)
                    {
                        var httpRequest = await client.PostAsync(url, contentHttp);
                        if (httpRequest.IsSuccessStatusCode)
                        {
                            string result = await httpRequest.Content.ReadAsStringAsync();

                            TextLog(textBox, "taps 500");

                        }
                        else
                        {
                            TextLog(textBox, "fail");
                        }
                        Thread.Sleep(1000);

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
                    //textBox.Clear();
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
