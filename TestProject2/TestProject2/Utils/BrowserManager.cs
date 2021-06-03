using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject2.Utils
{
    class BrowserManager
    {
        public static IWebDriver GetDriver()
        {
            return new ChromeDriver(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/Driver"));
            //switch (GetBrowserType())
            //{
            //    case "chrome":
            //        return new ChromeDriver(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/Driver"));

            //    default:
            //        throw new Exception("Unknown browser type!");
            //}
        }

        public static string GetBrowserType()
        {
            return ConfigurationManager.AppSettings["browserType"];
        }
    }
}
