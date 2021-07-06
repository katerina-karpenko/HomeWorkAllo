using HomeWorkAllo.POM;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class AuthorizationAlloSteps
    {
        Connection connection;
        public MainPage mainPage;
        public AuthorizationModal authorizationModal;

        [Given(@"website Allo opened")]
        public void GivenWebsiteAlloOpened()
        {
            connection = new Connection();
            connection.CreateDriver();
            mainPage = connection.OpenMainPage();
        }

        [When(@"click on the button Вход")]
        public void WhenClickOnTheButtonВход()
        {
            authorizationModal = mainPage.ClickOnEnterButtonInMainPage();
        }

        [When(@"click on the login field")]
        public void WhenClickOnTheLoginField()
        {
            authorizationModal.ClickOnLoginInModal();
        }
        
        [When(@"enter e-mail '(.*)'")]
        public void WhenEnterE_Mail(string p0)
        {
            authorizationModal.EnterLoginTextIntoModal(p0);
        }
        
        [When(@"click on the password field")]
        public void WhenClickOnThePasswordField()
        {
            authorizationModal.ClickOnPasswordInModal();
        }
        
        [When(@"enter password '(.*)'")]
        public void WhenEnterPassword(string p0)
        {
            authorizationModal.EnterPasswordTextIntoModal(p0);
        }
        
        [When(@"click on the button Войти")]
        public void WhenClickOnTheButtonВойти()
        {
            authorizationModal.ClickOnEnterButtonInModal();
        }
        
        [Then(@"Displayed user name equal to Катерина")]
        public void ThenDisplayedUserNameEqualToКатерина()
        {
            string actualMessege = mainPage.GetAuthorizedUserName();
            Assert.AreEqual("Катерина", actualMessege);
        }

        [AfterScenario]
        public void After()
        {
            connection.KillDriver();
        }
    }
}
