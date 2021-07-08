using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo
{
    [Binding]
    public static class Connection
    {
        public static IWebDriver driver;
        public static MainPage mainPage;

        public static void CreateDriver()
        {
            driver = new ChromeDriver(@"D:\WebDriver\chromedriver_win32\chromedriver_win32");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [BeforeScenario]
        public static MainPage OpenMainPage()
        {
            CreateDriver();
            driver.Navigate().GoToUrl("https://allo.ua/ru");
            driver.Manage().Window.Maximize();
            mainPage = new MainPage(driver);
            return mainPage;
        }

        [AfterScenario]
        public static void KillDriver()
        {
            driver.Quit();
        }
    }
}
