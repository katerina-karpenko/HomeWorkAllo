using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo
{
    class Connection
    {
        public IWebDriver driver;
        public MainPage mainPage;

        [Before]
        public void CreateDriver()
        {
            driver = new ChromeDriver(@"D:\WebDriver\chromedriver_win32\chromedriver_win32");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [BeforeScenario]
        public MainPage OpenMainPage()
        {
            driver.Navigate().GoToUrl("https://allo.ua/ru");
            driver.Manage().Window.Maximize();
            return new MainPage(driver);
        }

        [AfterScenario]
        public void KillDriver()
        {
            driver.Quit();
        }
    }
}
