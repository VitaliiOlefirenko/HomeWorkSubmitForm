using OpenQA.Selenium;

namespace TestProject2.Page
{
    public class CreatedStudentPage : BasePage
    {
        public CreatedStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement StudentName => Driver.FindElement(By.XPath("//td[text()='Student Name']/following-sibling::td"));
        public IWebElement StudentEmail => Driver.FindElement(By.XPath("//td[text()='Student Email']/following-sibling::td"));
        public IWebElement StudentGender => Driver.FindElement(By.XPath("//td[text()='Gender']/following-sibling::td"));
        public IWebElement StudentMobile => Driver.FindElement(By.XPath("//td[text()='Mobile']/following-sibling::td"));
        public IWebElement StudentDateOfBirth=> Driver.FindElement(By.XPath("//td[text()='Date of Birth']/following-sibling::td"));
        public IWebElement StudentSubjects => Driver.FindElement(By.XPath("//td[text()='Subjects']/following-sibling::td"));
        public IWebElement StudentHobbies => Driver.FindElement(By.XPath("//td[text()='Hobbies']/following-sibling::td"));
    }
}
