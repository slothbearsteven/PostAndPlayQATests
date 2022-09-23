using PostAndPlayTests.PageObjects;
using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.FreqMethods
{
    internal class CharactersMethods
    {
           public string characterName = "Selenius Automa";
            public string characterDescription = "This is an automatically created character";
           public string characterStats = "";
        public void CreateCharacterHappy(IWebDriver driver)
        {

            HomePage homePage = new HomePage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            homePage.charactersButton.Click();

            CharactersPage charactersPage = new CharactersPage(driver);
            charactersPage.createCharacterButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            charactersPage.characterNameInput.SendKeys(characterName);
            charactersPage.characterDescriptionInput.Click();
            charactersPage.characterDescriptionInput.SendKeys(characterDescription);
            charactersPage.characterStatsInput.Click();
            charactersPage.characterStatsInput.SendKeys(characterStats);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            charactersPage.submitCharacterButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            driver.Navigate().Refresh();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
    }
}
