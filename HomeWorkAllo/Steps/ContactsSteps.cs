using HomeWorkAllo.POM;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class ContactsSteps
    {
        public MainPage mainPage;
        public Contacts contacts;

        [When(@"click on the button Контакты")]
        public void WhenClickOnTheButtonКонтакты()
        {
            mainPage.Contacts();
        }

        [When(@"click on the name field")]
        public void WhenClickOnTheNameField()
        {
            contacts.ClickOnTheNameField();
        }

        [When(@"enter the user name '(.*)'")]
        public void WhenEnterTheUserName(string p0)
        {
            contacts.EnterUserName(p0);
        }

        [When(@"click on the e-mail field")]
        public void WhenClickOnTheE_MailField()
        {
            contacts.ClickOnTheEMailField();
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

        [When(@"click in the message field")]
        public void WhenClickInTheMessageField()
        {
            contacts.ClickInTheMessageField();
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
