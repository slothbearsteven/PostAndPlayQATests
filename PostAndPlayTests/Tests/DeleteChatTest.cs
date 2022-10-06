using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.Tests
{
    internal class DeleteChatTest
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void DeleteChat()
        {
            ChatsMethods chatsMethods = new ChatsMethods();
            LoginMethods loginMethods = new LoginMethods();


            loginMethods.HappyPathLogin(driver);
            chatsMethods.ChatCreationHappy(driver);

            ChatsPage chatsPage = new ChatsPage(driver);

            int originalChatsAmount = driver.FindElements(By.XPath("//*[@id=\"app\"]/div/div/div[2]/strong/*")).Count;

            chatsPage.deleteChatButton.Click();

            driver.Navigate().Refresh();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            int updatedChatsAmount = driver.FindElements(By.XPath("//*[@id=\"app\"]/div/div/div[2]/strong/*")).Count;

            Assert.AreNotEqual(updatedChatsAmount, originalChatsAmount);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
