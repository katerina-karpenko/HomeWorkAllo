using HomeWorkAllo.POM;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class ContactsSteps
    {
        public IWebDriver driver;
        public MainPage mainPage = new MainPage(Connection.driver);
        public Contacts contacts;


        [When(@"click on the button Контакты")]
        public void WhenClickOnTheButtonКонтакты()
        {
            contacts = mainPage.ContactsButton();
        }

        [When(@"enter the user name '(.*)'")]
        public void WhenEnterTheUserName(string p0)
        {
            contacts.EnterUserName(p0);
        }


        [When(@"enter user e-mail '(.*)'")]
        public void WhenEnterUserE_Mail(string p0)
        {
            contacts.EnterEMail(p0);
        }

        [When(@"click on drop-down topic menu")]
        public void WhenClickOnDrop_DownTopicMenu()
        {
            contacts.ClickOnDropDownTopicMenu();
        }

        [When(@"choose on drop-down menu Вопросы по акциям")]
        public void WhenChooseOnDrop_DownMenuВопросыПоАкциям()
        {
            contacts.ChooseOfTopicMessage();
        }



        [When(@"enter message field '(.*)'")]
        public void WhenEnterMessageField(string p0)
        {
            contacts.EnterMessageInField(p0);
        }

        [When(@"click on the button send")]
        public void WhenClickOnTheButtonSend()
        {
            contacts.ClickToSendButton();
        }

        [Then(@"user notification that the form has been submitted")]
        public void ThenUserNotificationThatTheFormHasBeenSubmitted()
        {
            contacts.NotificationFormHasBeenSubmitted();
        }
    }
}
