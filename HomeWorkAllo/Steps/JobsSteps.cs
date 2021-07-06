using HomeWorkAllo.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class JobsSteps
    {
        public Jobs jobs;

        [When(@"click on the button Вакансии")]
        public void WhenClickOnTheButtonВакансии()
        {
            jobs.ClickOnButtonVacanciec();
        }

        [When(@"click on drop-down list")]
        public void WhenClickOnDrop_DownList()
        {
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
