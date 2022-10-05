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
        }

        [Test]

        //Login
        //Navigate to chats page
        //Select and enter a chat
        //Use dropdown to select character in chat
        //Enter text and submit message
        //Assert that the name includes character name

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
