using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAllo.POM
{
    public class Blog
    {
        private IWebDriver _driver;
        public By newsText = By.XPath("/html/body/div[2]/header/div/div/div/div/div[2]/div[2]/nav/ul/li[1]/a");
        public By articlText = By.XPath("/html/body/div[2]/header/div/div/div/div/div[2]/div[2]/nav/ul/li[2]/a");
        public By clickToCategories = By.XPath("/html/body/div[2]/header/div/div/div/div/div[2]/div[2]/nav/ul/li[4]/a");
        public By clickToCategoriesGames = By.XPath("/html/body/div[2]/header/div/div/div/div/div[2]/div[2]/nav/ul/li[4]/ul/li[5]/a");
        public By gamesNewsPage = By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/h1");

        public Blog(IWebDriver driver)
        {
            this._driver = driver;
        }

        public string GetNewsText()
        {
            return _driver.FindElement(newsText).Text;
        }

        public string GetArticText()
        {
            return _driver.FindElement(articlText).Text;
        }

        public Blog ClickOnDropDownСategories()
        {
            _driver.FindElement(clickToCategories).Click();
            return new Blog(_driver);
        }

        public Blog ClickOnDropDownСategoriesGames()
        {
            _driver.FindElement(clickToCategoriesGames).Click();
            return new Blog(_driver);
        }

        public Blog CategoriesNewsGames()
        {
            _driver.FindElement(gamesNewsPage).Click();
            return new Blog(_driver);
        }
    }
}
