using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using OpenQA.Selenium.Support.UI;

namespace HomeWorkAllo.POM
{
    public class AuthorizationModal
    {
        private IWebDriver _driver;
        public By loginInput = By.Id("auth");
        public By passwordInput = By.Id("v-login-password");
        public By enterButtonInModal = By.ClassName("modal-submit-button");
        public By getLoginForm = By.Id("form-validate-login");
        public By getErrorMessage = By.ClassName("v-validation-error");

        public AuthorizationModal(IWebDriver driver)
        {
            this._driver = driver;
        }

        public AuthorizationModal ClickOnLoginInModal()
        {
            _driver.FindElement(loginInput).Click();
            return new AuthorizationModal(_driver);
        }

        public AuthorizationModal EnterLoginTextIntoModal(string eMail)
        {
            _driver.FindElement(loginInput).SendKeys(eMail);
            return this;
        }

        public AuthorizationModal ClickOnPasswordInModal()
        {
            _driver.FindElement(passwordInput).Click();
            return new AuthorizationModal(_driver);
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

        public string GetLoginFormText()
        {
            return _driver.FindElement(getLoginForm).Text;
        }

    }
}