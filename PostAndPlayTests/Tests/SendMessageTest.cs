using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.Pages;


namespace PostAndPlayTests.Tests
{
    internal class SendMessageTest
    {

        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void SendMessage()
        {
            LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);

            HomePage homePage = new HomePage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            homePage.NavigateToSubscribedChat();

            ChatPage chatPage = new ChatPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            chatPage.messageInput.Click();
            chatPage.messageInput.SendKeys("This is an automated test");
            chatPage.submitButton.Click();

            driver.Navigate().Refresh();
            string expectedText = "This is an automated test";
           
            Assert.AreEqual(expectedText,chatPage.messageSent.Text);
        }
      
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
