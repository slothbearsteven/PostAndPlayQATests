using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        [Test]
        public void SendMessage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.GoToPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            loginPage.emailField.SendKeys("s@s.com");
            loginPage.passwordField.SendKeys("steven");
            loginPage.SubmitAccount();

            HomePage homePage = new HomePage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            homePage.NavigateToChat();

            ChatPage chatPage = new ChatPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            chatPage.messageInput.Click();
            chatPage.messageInput.SendKeys("This is an automated test");
            chatPage.submitButton.Click();

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
