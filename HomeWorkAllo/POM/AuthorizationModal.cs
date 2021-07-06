using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAllo.POM
{
    public class AuthorizationModal
    {
        private IWebDriver _driver;
        public By loginInput = By.XPath("/html/body/div[4]/div/div/div[2]/div/div/div[1]/div[1]/form/div/div[1]/div[1]/div[1]/input");
        public By passwordInput = By.XPath("/html/body/div[4]/div/div/div[2]/div/div/div[1]/div[1]/form/div/div[1]/div[2]/div[1]/input");
        public By enterButtonInModal = By.XPath("/html/body/div[4]/div/div/div[2]/div/div/div[1]/div[1]/form/div/button");
        public By getErrorMessageLogin = By.XPath("/html/body/div[4]/div/div/div[2]/div/div/div[1]/div[1]/form/div/div[1]/div[1]/div[2]/div/span");
        public By getErrorMessagePassword = By.XPath("/html/body/div[4]/div/div/div[2]/div/div/div[1]/div[1]/form/div/div[1]/div[1]/div[2]/div");

        public AuthorizationModal(IWebDriver driver)
        {
            this._driver = driver;
        }

        public AuthorizationModal EnterLoginTextIntoModal(string loginText)
        {
            _driver.FindElement(loginInput).SendKeys(loginText);
            return this;
        }

        public AuthorizationModal EnterPasswordTextIntoModal(string passwordText)
        {
            _driver.FindElement(passwordInput).SendKeys(passwordText);
            return this;
        }

        public AuthorizationModal ClickOnEnterButtonInModal()
        {
            _driver.FindElement(enterButtonInModal).Click();
            return new AuthorizationModal(_driver);
        }

        public AuthorizationModal ErrorMessageWhenUseInvalidLoginText(string invalidLogin)
        {
            _driver.FindElement(getErrorMessageLogin).SendKeys(invalidLogin);
            return this;
        }

        public AuthorizationModal ErrorMessageWhenUseInvalidPasswordText(string invalidPassword)
        {
            _driver.FindElement(getErrorMessagePassword).SendKeys(invalidPassword);
            return this;
        }
    }
}
