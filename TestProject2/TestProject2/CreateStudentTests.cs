using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TestProject2.Models;
using TestProject2.Page;
using TestProject2.Utils;

namespace TestProject2
{
    public class CreateStudentTests
    {
        private IWebDriver driver;

        [SetUp]
        public virtual void Init()
        {
            driver = BrowserManager.GetDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }


        [Test]
        public void CreateStudentBasicTest()
        {
            Student testStudent = Randomizer.GenerateNewStudent();
            CreatedStudentPage createdStudentPage  = Navigator
                .NavigateToolsQApage(driver)
                .CreateNewStudent(testStudent);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(testStudent.FirstName + " " + testStudent.LastName, createdStudentPage.StudentName.Text, "Wrong Student Name");
                Assert.AreEqual(testStudent.Email, createdStudentPage.StudentEmail.Text, "Wrong Student Email");
                Assert.AreEqual(testStudent.Gender, createdStudentPage.StudentGender.Text, "Wrong Student Gender");
                Assert.AreEqual(testStudent.Phone, createdStudentPage.StudentMobile.Text, "Wrong Student Mobile");
                Assert.AreEqual(testStudent.Hobby, createdStudentPage.StudentHobbies.Text, "Wrong Student Hobby");
            });

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}