using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace click_pc.Helpper
{
    public static class Utilities
    {
        public static string GetDateFromDateTime()
        {
            return DateTime.Now.ToString("MMddyyyyhhmmtt");
        }
        public static void CreateMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }
        public static void Delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                delay--;
            }
        }
        public static List<string> ExtractLink(string html)
        {
            List<string> list = new List<string>();
            Regex regex = new Regex("(?:href|src)=[\"|']?(.*?)[\"|'|>]+", RegexOptions.Singleline | RegexOptions.CultureInvariant);
            if (regex.IsMatch(html))
            {
                foreach (Match match in regex.Matches(html))
                {
                    list.Add(match.Groups[1].Value);
                }
            }

            return list;
        }

        public static string GetIdUser(string cookie)
        {
            string id = "";
            // Tách chuỗi cookie thành các cặp key-value
            string[] cookiePairs = cookie.Split(';');
            foreach (string pair in cookiePairs)
            {
                string trimmedPair = pair.Trim();

                // Kiểm tra xem pair có phải là phần chứa twid không
                if (trimmedPair.StartsWith("twid="))
                {
                    // Lấy giá trị twid bỏ qua phần "twid=u%3D"
                    id = Uri.UnescapeDataString(trimmedPair.Substring("twid=u%3D".Length));
                    break; // Bạn có thể quyết định có nên dừng vòng lặp sau khi tìm thấy twid hay không
                }
            }


            return id;
        }
        public static void AddCookie(IWebDriver driver, string cookieString)
        {
            string[] cookies = cookieString.Split(';');

            // Lặp qua các cookie và thêm vào trình duyệt
            foreach (string key in cookies)
            {
                string[] cookie = key.Split('=');
                string cookieValue = cookie[1].Trim();
                string keys = cookie[0].Trim();

                // Tạo đối tượng Cookie và thêm vào trình duyệt
                Cookie newCookie = new Cookie(keys, cookieValue, "x.com", "/", DateTime.Now.AddHours(1));
                driver.Manage().Cookies.AddCookie(newCookie);
            }

            // Refresh trang để áp dụng các cookies mới
            driver.Navigate().Refresh();

        }
    }
}
