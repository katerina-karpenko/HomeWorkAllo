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
        public By getButtonVacancy = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[3]/ul/li[3]/a");

        public By getDropDownMenuOfCity = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[1]/div/svg[2]");
        public By getСityDnepr = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[1]/div");
        public By getTextСityDnepr = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[1]/div[2]/div/div/div/input");
        public By getTextAboutEnterInTown = By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[1]/div/div[1]/div[2]/p");

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
        /// Клик выпадающего списка городов.
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


    }
}
