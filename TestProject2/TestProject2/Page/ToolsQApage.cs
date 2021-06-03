using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using TestProject2.Models;

namespace TestProject2.Page
{
    public class ToolsQApage : BasePage
    {
        public ToolsQApage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FirstNameField => Driver.FindElement(By.Id("firstName"));
        public IWebElement LastNameField => Driver.FindElement(By.Id("lastName"));
        public IWebElement EmailField => Driver.FindElement(By.XPath("//*[@id='userEmail']"));
        public IWebElement Gender(string gender) => Driver.FindElement(By.XPath($"//label[text()='{gender}']/parent::div"));
        public IWebElement Hobby(string hobby) => Driver.FindElement(By.XPath($"//label[text()='{hobby}']/parent::div"));
        public IWebElement GenderOther => Driver.FindElement(By.CssSelector("[for='gender-radio-3']"));
        public IWebElement Mobile => Driver.FindElement(By.XPath("//*[@id='userNumber']"));
        private IWebElement DateOfBirth => Driver.FindElement(By.Id("dateOfBirthInput"));
        private IWebElement DateOfBirthSelectMonth(string month) => Driver.FindElement(By.CssSelector($".react-datepicker__month-select > option[value='{month}'] "));
        private IWebElement DateOfBirthSelectYear(string year) => Driver.FindElement(By.CssSelector($".react-datepicker__year-select > option[value='{year}'] "));
        private IWebElement DateOfBirthSelectDay(string day) => Driver.FindElements(By.XPath($"//div[contains(@class,'react-datepicker__day') and text()='{day}']")).First();
        public IWebElement Subjects => Driver.FindElement(By.CssSelector("#subjectsContainer .subjects-auto-complete__input > input"));
        public IWebElement Sports => Driver.FindElement(By.XPath("//*[text()='Sports']"));
        public IWebElement Reading => Driver.FindElement(By.XPath("//*[text()='Reading']"));
        public IWebElement Music => Driver.FindElement(By.XPath("//*[text()='Music']"));
        public IWebElement SelectPictureButton => Driver.FindElement(By.ClassName("form-control-file"));
        public IWebElement CurrentAddres => Driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        public IWebElement SubmitButton => Driver.FindElement(By.Id("submit"));

        public CreatedStudentPage CreateNewStudent(Student student) 
        {
            FirstNameField.SendKeys(student.FirstName);
            LastNameField.SendKeys(student.LastName);
            EmailField.SendKeys(student.Email);
            Mobile.SendKeys(student.Phone);
            Subjects.SendKeys(student.Subject);
            SetDateOfBirth(student.DateOfBirthList);
            CurrentAddres.SendKeys(student.CurrentAddress);
            Gender(student.Gender).Click();
            Hobby(student.Hobby).Click();
            ClickSubmitButton();
            return new CreatedStudentPage(Driver);
        }

        public void SetDateOfBirth(List<string> dateOfBirth)
        {
            DateOfBirth.Click();
            DateOfBirthSelectMonth(dateOfBirth[0]).Click();
            DateOfBirthSelectYear(dateOfBirth[1]).Click();
            DateOfBirthSelectDay(dateOfBirth[2]).Click();
        }

        public void ClickSubmitButton()
        {
            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", SubmitButton);
            SubmitButton.Click();
        }
    }
}
