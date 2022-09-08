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
using PostAndPlayTests.FreqMethods;

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
        public void Login() { 
        LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);
        }


        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}