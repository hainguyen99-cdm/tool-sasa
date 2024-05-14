using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crawl_price.Extension
{
    public static class WebDriverExtension
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    try
                    {
                        bool isElementFound = IsElementFound(driver, by);
                        if (isElementFound)
                        {
                            IWebElement elementToInteract = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
                            if (elementToInteract != null)
                            {
                                return elementToInteract;
                            }
                            else
                            {
                                return null;
                            }
                        }

                    }
                    catch { }
                }
                catch { }
            }
            return driver.FindElement(by);

        }
        public static bool IsElementFound(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;

            }
        }

    }
}
