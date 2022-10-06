using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class SendMessageAsCharacterTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SendMessageAsCharacter()
        {
        //Login
            LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);
        
            //Select and enter a subscribed chat
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToSubscribedChat();
            //Use dropdown to select character in chat
            ChatPage chatPage = new ChatPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            chatPage.charactersDropdown.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            string characterBeingSelected = chatPage.characterToSelect.Text;
            chatPage.characterToSelect.Click();
            //Enter text and submit message
            chatPage.messageInput.Click();
            chatPage.messageInput.SendKeys("test");
            Thread.Sleep(500);
            chatPage.submitButton.Click();
            //Assert that the name of user in message sent includes character name
            Thread.Sleep(1000);
         
            Assert.AreEqual(characterBeingSelected,chatPage.characterNameUsed.Text);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
