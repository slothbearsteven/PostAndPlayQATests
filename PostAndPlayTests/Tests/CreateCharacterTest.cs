using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.PageObjects;

namespace PostAndPlayTests.Tests
{
    internal class CreateCharacterTest
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void CreateCharacter()
        {
            LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
