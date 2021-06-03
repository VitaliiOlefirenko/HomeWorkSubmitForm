using OpenQA.Selenium;
using TestProject2.Page;

namespace TestProject2.Utils
{
    public class Navigator
    {
        public static ToolsQApage NavigateToolsQApage (IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            return new ToolsQApage(driver);
        }
    }
}
