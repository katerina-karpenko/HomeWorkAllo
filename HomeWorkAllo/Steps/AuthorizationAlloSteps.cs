using HomeWorkAllo.POM;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class AuthorizationAlloSteps
    {
        public MainPage mainPage;
        public AuthorizationModal authorizationModal;

        [Given(@"website Allo opened")]
        public void GivenWebsiteAlloOpened()
        {
            Connection connection = new Connection();
            connection.CreateDriver();
            mainPage = connection.OpenMainPage();
        }

        [When(@"click on the button ""(.*)""")]
        public void WhenClickOnTheButton(string p0)
        {
            switch (p0)
            {
                case "Вход":
                    mainPage.ClickOnEnterButtonInMainPage();
                    mainPage.GetAuthorizedUserName();
                    break;

                case "Войти":
                    authorizationModal.ClickOnEnterButtonInModal();
                    break;
            }
        }

        [When(@"enter e-mail ""(.*)""")]
        public void WhenEnterE_Mail(string p0)
        {
            authorizationModal.EnterLoginTextIntoModal(p0);
        }

        [When(@"enter password ""(.*)""")]
        public void WhenEnterPassword(string p0)
        {
            authorizationModal.EnterPasswordTextIntoModal(p0);
        }

        [Then(@"Displayed user name equal to ""(.*)""")]
        public void ThenDisplayedUserNameEqualTo(string p0)
        {
            string name = mainPage.GetAuthorizedUserName();
            Assert.AreEqual(p0, name);
        }

    }
}
