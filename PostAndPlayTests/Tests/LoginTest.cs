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
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Login() { 
        LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);

           
           
            Assert.AreEqual("http://post-n-play.herokuapp.com/#/", driver.Url);
        }


        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}