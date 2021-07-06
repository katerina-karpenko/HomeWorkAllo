using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.POM
{
    public class Jobs
    {
        private IWebDriver _driver;
        public By locationOfDnepr = By.XPath("/html/body/div[2]/div[3]/div/div/div/div/article/div/div[1]/div/div/div[2]/div/div/div[2]/a[1]/div/div[2]/div[1]/div[1]/span");
        public By clickOnDropDown = By.XPath("/html/body/div[2]/div[3]/div/div/div/div/article/div/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div/div[2]/span[1]");
        public By cityDnepr = By.XPath("/html/body/div[2]/div[3]/div/div/div/div/article/div/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div/div[3]/div/ul/li[4]");
        public By displayedDnepr = By.XPath("/html/body/div[2]/div[3]/div/div/div/div/article/div/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div/div[3]/div/ul/li[4]");
        public By displayedVacancies = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[3]/ul/li[3]/a");

        public Jobs(IWebDriver driver)
        {
            this._driver = driver;
        }

        public Jobs ClickOnButtonVacanciec()
        {
            _driver.FindElement(displayedVacancies).Click();
            return new Jobs(_driver);
        }

        public Jobs ClickOnDropDownListOfCity()
        {
            _driver.FindElement(clickOnDropDown).Click();
            return new Jobs(_driver);
        }

        public Jobs ClickOnCityDneprInDropDownMenu()
        {
            _driver.FindElement(cityDnepr).Click();
            return new Jobs(_driver);
        }

        public string DisplayedDneprLocationVacancy()
        {
            return _driver.FindElement(displayedDnepr).Text;
        }
    }
}
