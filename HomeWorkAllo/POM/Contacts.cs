using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAllo.POM
{
    public class Contacts
    {
        private IWebDriver _driver;
        public By getNameField = By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div/form/div[1]/div/div/input");
        public By getEMailField = By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/div/div[2]/div/form/div[2]/div/div[2]/div/input");
        public By getDropDownMenu = By.ClassName("feedback__subject-name");
        public By getChooseOfTopic = By.ClassName("feedback__subject-item");
        public By getMessageField = By.Id("feedback-message");
        public By getSendButton = By.ClassName("feedback__submit-button");
        public By messageForUser = By.ClassName("feedback-success__message");

        public Contacts(IWebDriver driver)
        {
            this._driver = driver;
        }

        public Contacts ClickOnTheNameField()
        {
            _driver.FindElement(getNameField).Click();
            return new Contacts(_driver);
        }

        public Contacts EnterUserName(string nameUser)
        {
            _driver.FindElement(getNameField).SendKeys(nameUser);
            return this;
        }

        public Contacts ClickOnTheEMailField()
        {
            _driver.FindElement(getEMailField).Click();
            return new Contacts(_driver);
        }

        public Contacts EnterEMail(string userEMail)
        {
            _driver.FindElement(getEMailField).SendKeys(userEMail);
            return this;
        }

        public Contacts ClickOnDropDownTopicMenu()
        {
            _driver.FindElement(getDropDownMenu).Click();
            return new Contacts(_driver);
        }

        public Contacts ChooseOfTopicMessage()
        {
            _driver.FindElement(getChooseOfTopic).Click();
            return new Contacts(_driver);
        }

        public Contacts ClickInTheMessageField()
        {
            _driver.FindElement(getMessageField).Click();
            return new Contacts(_driver);
        }

        public Contacts EnterMessageInField(string testText)
        {
            _driver.FindElement(getMessageField).SendKeys(testText);
                return this;
        }

        public Contacts ClickToSendButton()
        {
            _driver.FindElement(getSendButton).Click();
            return new Contacts(_driver);
        }

        public string NotificationFormHasBeenSubmitted()
        {
            return _driver.FindElement(messageForUser).Text;
        }

    }
}
