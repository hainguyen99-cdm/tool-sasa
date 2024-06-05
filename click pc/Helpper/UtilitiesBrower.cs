using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools;

namespace crawl_price.Helpper
{
    public static class UtilitiesBrower
    {
        public static IWebDriver OpenBrowser(bool hidden = false, int profileName = 0)
        {
            IWebDriver _webDriver;
        startChrome:
            try
            {
                string profileFolderPath = Path.Combine(Environment.CurrentDirectory, @"Profile");
                string chromeDriverPath = Path.Combine(Environment.CurrentDirectory, @"chromedriver");
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(chromeDriverPath);
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                if (Directory.Exists(profileFolderPath))
                {
                    options.AddArguments("user-data-dir=" + profileFolderPath + "\\" + profileName);
                }
                else
                {
                    Directory.CreateDirectory(profileFolderPath);
                }
                if (hidden) options.AddArguments("--headless");//chay an
                options.AddArguments("--start--maximized");
                //options.AddArguments("--proxy-server=" + "192.168.1.108" + ":" + "10000");
                options.AddArguments("load-extension=" + Environment.CurrentDirectory + "\\extension\\dist");
                options.AddArguments("–disable-blink-features=AutomationControlled");
                options.AddArguments("--user-agent=Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3_5 like Mac OS X; en-us) AppleWebKit/533.17.9 (KHTML, like Gecko) Mobile/8L1");
                _webDriver = new ChromeDriver(chromeDriverService, options, TimeSpan.FromMinutes(2));
                Debug.WriteLine("tao profile");
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString();
                if (error.IndexOf("This version of ChromeDriver") != -1)
                {
                    KillDriver();
                    _webDriver = null;

                }
                else
                {
                    Debug.WriteLine(ex);
                    KillDriver();
                    goto startChrome;
                }

            }
            return _webDriver;

        }
        public static void KillDriver()
        {
            try
            {
                Process.Start("taskkill", "/F /IM chromedriver.exe /T");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            catch (Exception ex)
            {
                Process.Start("taskkill", "/F /IM chromedriver.exe /T");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
        public static ChromeOptions CreateOption(string device)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.EnableMobileEmulation(device);
            return chromeOptions;
        }
        public static void CloseBrower(IWebDriver _webDriver)
        {
            try
            {
                if (_webDriver != null)
                {
                    _webDriver.Close();
                    _webDriver.Quit();
                    _webDriver.Dispose();
                }


            }
            catch { }
        }
    }
}
