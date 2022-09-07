using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.PageObjects
{
    internal class CharactersPage
    {
        private IWebDriver driver;
        public CharactersPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
           
        }

        /*Create element locators for the create character button; character name, stats, and description
         * inputs on character creation modal as well as submit button;
         * item that checks for the amount of child elements existence 
         */
        public IWebElement createCharacterButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div/button"));

        public IWebElement recentCharacterMade => driver.FindElement(By.XPath(""));

        public IWebElement characterNameInput => driver.FindElement(By.Id("charactername"));

        public IWebElement characterStatsInput => driver.FindElement(By.Id("characterstats"));

        public IWebElement characterDescriptionInput => driver.FindElement(By.Id("characterdescription"));





    }
}
