using HomeWorkAllo.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo
{
    public class MainPage
    {
        private IWebDriver _driver;
        public By getOnEnterButton = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/div/ul/li[5]/div/div/button[1]");
        public By getNameOfUser = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/div/ul/li[5]/div/div/div[1]/span");
        public By getButtonVacancy = By.CssSelector("#__layout > div > div.v-header > div.main-header-wrapper > div.main-header-first-line-wrapper > div > div.nav-links > ul > li:nth-child(3) > a");
        public By getDropDownMenuOfCity = By.ClassName("geo-label");
        public By getСityDnepr = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[1]/div");
        public By getTextСityDnepr = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[1]/div[2]/div/div/div/input");
        public By getTextAboutEnterInTown = By.Id("city");
        public By getClickOnTheCart = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/div/ul/li[6]/div/div[1]");
        public By clickOnContactsButton = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[3]/ul/li[8]/a");
        public By clickOnBlogPageButton = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[3]/ul/li[1]/a");

        /// <summary>
        /// Создание конструктора.
        /// </summary>
        public MainPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        /// <summary>
        /// Переход в модальное окно входа для авторизации.
        /// </summary>
        public AuthorizationModal ClickOnEnterButtonInMainPage()
        {
            _driver.FindElement(getOnEnterButton).Click();
            return new AuthorizationModal(_driver);
        }

        /// <summary>
        /// Получение имени авторизованного пользователя.
        /// </summary>
        public string GetAuthorizedUserName()
        {
            return _driver.FindElement(getNameOfUser).Text;
        }

        /// <summary>
        /// Переход на вкладку вакансий сайта.
        /// </summary>
        public Jobs ClickOnVacancyButton()
        {
            _driver.FindElement(getButtonVacancy).Click();
            return new Jobs(_driver);
        }

        /// <summary>
        /// Открыть выпадающий список городов.
        /// </summary>
        public MainPage ClickOnCityDropDown()
        {
            _driver.FindElement(getDropDownMenuOfCity).Click();
            return new MainPage(_driver);
        }

        /// <summary>
        /// Выбор города Днепр в локации сайта.
        /// </summary>
        public MainPage ChooseDneprOnDropDown()
        {
            _driver.FindElement(getСityDnepr).Click();
            return new MainPage(_driver);
        }

        /// <summary>
        /// Сверка изменения текста в выпадающем списке после смены локации.
        /// </summary>
        public string CheckTownText()
        {
            return _driver.FindElement(getTextAboutEnterInTown).Text;
        }
        /// <summary>
        /// Открыть корзину.
        /// </summary>
        public Cart ClickTheCart()
        {
            _driver.FindElement(getClickOnTheCart).Click();
            return new Cart(_driver);
        }
        /// <summary>
        /// Переход на страницу Контактов.
        /// </summary>
        public Contacts ContactsButton()
        {
            _driver.FindElement(clickOnContactsButton).Click();
            return new Contacts(_driver);
        }

        public Blog BlogPageClick()
        {
            _driver.FindElement(clickOnBlogPageButton).Click();
            return new Blog(_driver);
        }
    }
}
