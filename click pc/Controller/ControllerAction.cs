using click_pc.Helpper;
using crawl_price.Helpper;
using KAutoHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Controller
{
    internal class ControllerAction
    {
        public static bool login(IWebDriver webDriver, string cookie)
        {
            try
            {
                int indexLogin = 0;
            goX:
                Debug.WriteLine(indexLogin);
                if (indexLogin > 3)
                {
                    return false;
                }
                webDriver.Navigate().GoToUrl("https://twitter.com/Home");
                //check login
                Thread.Sleep(3000);
                webDriver.Navigate().GoToUrl("https://www.google.com/");
                Thread.Sleep(3000);
                webDriver.Navigate().GoToUrl("https://twitter.com/Home");

                string url = webDriver.Url;
                if (url == "https://twitter.com/i/flow/login?redirect_after_login=%2FHome")
                {
                    indexLogin++;
                    Utilities.AddCookie(webDriver, cookie);
                    Thread.Sleep(5000);
                    webDriver.Navigate().GoToUrl("https://twitter.com/Home");
                    url = webDriver.Url;
                    if (url == "https://twitter.com/i/flow/login?redirect_after_login=%2FHome")
                    {
                        goto goX;
                    }
                }
                var screen = CaptureHelper.CaptureScreen();
                var subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\Restry.PNG");
                var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                if (resBitmap != null)
                {
                    webDriver.Navigate().GoToUrl("https://www.google.com/");
                    goto goX;
                }
                Thread.Sleep(1000);
                screen = CaptureHelper.CaptureScreen();
                subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\iconGame.PNG");
                resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                if (resBitmap != null)
                {
                    return true;
                }
            iconEx:
                screen = CaptureHelper.CaptureScreen();
                subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\IconExtension.PNG");
                resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                if (resBitmap != null)
                {
                    AutoControl.MouseClick(resBitmap.Value.X + 10, resBitmap.Value.Y + 10);
                }
                screen = CaptureHelper.CaptureScreen();
                subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\iconGame.PNG");
                resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                if (resBitmap != null)
                {
                    return true;
                }
                Thread.Sleep(1000);
                screen = CaptureHelper.CaptureScreen();
                subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\LogInEX.PNG");
                resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                if (resBitmap != null)
                {
                    AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
                    Thread.Sleep(3000);
                    screen = CaptureHelper.CaptureScreen();
                    subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\AuthorizeApp.PNG");
                    resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                    if (resBitmap != null)
                    {
                        AutoControl.MouseClick(resBitmap.Value.X, resBitmap.Value.Y);
                        Thread.Sleep(5000);
                    checkcf:
                        screen = CaptureHelper.CaptureScreen();
                        subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\ConfirmRefer.PNG");
                        resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                        if (resBitmap != null)
                        {
                            while (true)
                            {
                                screen = CaptureHelper.CaptureScreen();
                                subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\ConfirmRefer.PNG");
                                resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                                if (resBitmap == null)
                                {
                                    break;
                                }
                            }

                        }
                        else
                        {
                            screen = CaptureHelper.CaptureScreen();
                            subBitmap = ImageScanOpenCV.GetImage(Environment.CurrentDirectory + "\\data\\iconGame.PNG");
                            resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
                            if (resBitmap != null)
                            {
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    goto iconEx;
                }
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        } 
    }
}
