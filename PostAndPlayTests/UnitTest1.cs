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

namespace PostAndPlayTests
{
    public class Test
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void SendMessageTest()
        {
            LoginPage login = new LoginPage(driver);
            login.GoToPage();
            login.Login();


        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}