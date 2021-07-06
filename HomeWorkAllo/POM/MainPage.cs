using HomeWorkAllo.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAllo
{
    public class MainPage
    {
        private IWebDriver _driver;
        public By getOnEnterButton = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/div/ul/li[5]/div/div/button[1]");
        public By getNameOfUser = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/div/ul/li[5]/div/div/div[1]/span");

        public MainPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public AuthorizationModal ClickOnEnterButtonInMainPage()
        {
            _driver.FindElement(getOnEnterButton).Click();
            return new AuthorizationModal(_driver);
        }

        public string GetAuthorizedUserName()
        {
            return _driver.FindElement(getNameOfUser).Text;
        }
    }
}
