using HomeWorkAllo.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class JobsSteps
    {
        public IWebDriver driver;
        public MainPage mainPage = new MainPage(Connection.driver);
        public Jobs jobs = new Jobs(Connection.driver);

        [When(@"click on the button Вакансии")]
        public void WhenClickOnTheButtonВакансии()
        {
            jobs = mainPage.ClickOnVacancyButton();
        }

        [When(@"click on drop-down list")]
        public void WhenClickOnDrop_DownList()
        {
            Connection.driver.SwitchTo().Window(Connection.driver.WindowHandles.Last()); 
            jobs.ClickOnDropDownListOfCity();
        }

        [When(@"сhooses a city ""(.*)""")]
        public void WhenСhoosesACity(string p0)
        {
            jobs.ClickOnCityDneprInDropDownMenu();
        }

        [When(@"job list displays only for city ""(.*)""")]
        public void WhenJobListDisplaysOnlyForCity(string p0)
        {
            jobs.DisplayedDneprLocationVacancy();
        }
    }
}
