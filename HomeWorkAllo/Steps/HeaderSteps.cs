using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class HeaderSteps
    {
        public IWebDriver driver;
        public MainPage mainPage;

        [Given(@"website Allo opened location of the city Kyiv")]
        public void GivenWebsiteAlloOpenedLocationOfTheCityKyiv()
        {
            Connection connection = new Connection();
            connection.CreateDriver();
            mainPage = connection.OpenMainPage();
        }
        
        [When(@"click on location of the city")]
        public void WhenClickOnLocationOfTheCity()
        {
            mainPage.ClickOnCityDropDown();
        }
        
        [When(@"click on the city Dnepr")]
        public void WhenClickOnTheCityDnepr()
        {
            mainPage.ChooseDneprOnDropDown();
        }
        
        [Then(@"the location of the city has changed to the Dnepr")]
        public void ThenTheLocationOfTheCityHasChangedToTheDnepr()
        {
            mainPage.CheckTownText();
        }
    }
}
