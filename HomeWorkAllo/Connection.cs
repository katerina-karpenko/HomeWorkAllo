using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAllo
{
    class Connection
    {
        public IWebDriver driver;
        public MainPage mainPage;

        [OneTimeSetUp]
        public void CreateDriver()
        {
            driver = new ChromeDriver(@"C:D:\WebDriver\chromedriver_win32\");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(13);
        }

        [SetUp]
        public MainPage OpenMainPage()
        {
            driver.Navigate().GoToUrl("https://allo.ua/");
            driver.Manage().Window.Maximize();
            return new MainPage(driver);
        }
    }
}
