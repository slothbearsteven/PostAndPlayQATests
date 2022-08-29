using PostAndPlayTests.PageObjects;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class CreateChatTest
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

            NavBar navBar = new NavBar(driver);
            navBar.chatsButton.Click();

            ChatsPage chatsPage = new ChatsPage(driver);    
            chatsPage.chatNameInput.Click();
            chatsPage.chatNameInput.SendKeys("automated test Chat");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            chatsPage.createChatButton.Click();

            string expectedText = "automated test Chat";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.AreEqual(expectedText, chatsPage.recentlyCreatedChat.Text);




        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
