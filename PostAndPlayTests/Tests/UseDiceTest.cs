using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class UseDiceTest
    {
       

        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void UseDice()
        {
            LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);

            HomePage homePage = new HomePage(driver);
            homePage.diceButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            homePage.rollD20Button.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.AreNotEqual("-", homePage.diceResult.Text);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
