using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PostAndPlayTests.Pages;

namespace PostAndPlayTests.Tests
{
    public class LoginTest
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void Login()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.GoToPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            loginPage.emailField.SendKeys("s@s.com");
            loginPage.passwordField.SendKeys("steven");
            loginPage.SubmitAccount();


        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}