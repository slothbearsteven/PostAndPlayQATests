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
        }

        [Test]

        public void DeleteChat()
        {
            ChatsMethods chatsMethods = new ChatsMethods();

            chatsMethods.ChatCreationHappy(driver);

            ChatsPage chatsPage = new ChatsPage(driver);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
