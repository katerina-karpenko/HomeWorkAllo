using HomeWorkAllo.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class AuthorizationAlloSteps
    {
        public IWebDriver driver;
        public MainPage mainPage;
        public AuthorizationModal authorizationModal;

        [Given(@"website Allo opened")]
        public void GivenWebsiteAlloOpened()
        {
            mainPage = Connection.mainPage;
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

        [Then(@"Error message '(.*)' is displayed")]
        public void ThenErrorMessageIsDisplayed(string p0)
        {
            string actualMessege = authorizationModal.GetLoginFormTextWithErrorPage(p0);
            Assert.AreEqual(p0, actualMessege);
        }
    }
}