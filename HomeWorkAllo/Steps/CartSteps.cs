using HomeWorkAllo.POM;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class CartSteps
    {
        public MainPage mainPage;
        public Cart cart;

        [Given(@"user is not logged in")]
        public void GivenUserIsNotLoggedIn()
        {
            mainPage = Connection.mainPage;
        }

        [When(@"user clicks on cart")]
        public void WhenUserClicksOnCart()
        {
            cart = mainPage.ClickTheCart();
        }

        [Then(@"cart is empty")]
        public void ThenCartIsEmpty()
        {
            cart.CartWasEmptyIfUserDontAuthoziration();
        }
    }
}
