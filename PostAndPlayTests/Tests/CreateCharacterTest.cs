using PostAndPlayTests.FreqMethods;
using PostAndPlayTests.PageObjects;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string characterName = "Selenius Automa";
            string characterDescription = "Automated test character";
            string characterStats = "Automation: 15 / Programing:10 / Boxness: 21";
            LoginMethods loginMethods = new LoginMethods();
            loginMethods.HappyPathLogin(driver);

            HomePage homePage = new HomePage(driver);
            homePage.charactersButton.Click();

            CharactersPage charactersPage = new CharactersPage(driver);
            charactersPage.createCharacterButton.Click();
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            charactersPage.characterNameInput.SendKeys(characterName);
          

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            charactersPage.submitCharacterButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            driver.Navigate().Refresh();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
           
            IWebElement createdCharacterName = charactersPage.GetMostRecentCharacterMade(0).FindElement(By.XPath(".//strong"));

            Assert.AreEqual(characterName, createdCharacterName.Text);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
