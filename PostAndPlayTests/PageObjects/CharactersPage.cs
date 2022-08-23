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
            PageFactory.InitElements(driver, this);
        }

        /*Create element locators for the create character button; character name, stats, and description
         * inputs on character creation modal as well as submit button;
         * item that checks for the amount of child elements existence 
         */
    }
}
