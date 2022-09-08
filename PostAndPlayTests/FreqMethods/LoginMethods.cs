using PostAndPlayTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAndPlayTests.FreqMethods
{
    internal class LoginMethods
    {
        public void HappyPathLogin(IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.GoToPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            loginPage.emailField.SendKeys("s@s.com");
            loginPage.passwordField.SendKeys("steven");
            loginPage.SubmitAccount();
        }
    }
}
