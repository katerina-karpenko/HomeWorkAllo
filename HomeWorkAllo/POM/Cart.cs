using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAllo.POM
{
    public class Cart
    {
        private IWebDriver _driver;
        public By theCartWasEmpty = By.XPath("/html/body/div[3]/div/div/div[3]/div/div[1]/div/p[1]");

        /// <summary>
        /// Создание конструктора.
        /// </summary>
        public Cart(IWebDriver driver)
        {
            this._driver = driver;
        }

        /// <summary>
        /// Корзина пуста у неавторизованного пользователя.
        /// </summary>
        public string CartWasEmptyIfUserDontAuthoziration()
        {
            return _driver.FindElement(theCartWasEmpty).Text;
        }
    }
}
