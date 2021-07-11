using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAllo.POM
{
    public class GoodsMarkdown
    {
        private IWebDriver _driver;
        public By markdownText = By.XPath("/html/body/div[1]/header/div[3]/div/h1");
        public By markdownTextCatalog = By.XPath("/html/body/div[1]/main/div/div/div[1]/div/h3/span");

        public GoodsMarkdown(IWebDriver driver)
        {
            this._driver = driver;
        }

        public string DiscountSaleTextOnPage()
        {
            return _driver.FindElement(markdownText).Text;
        }

        public string DiscountSaleCatalogText()
        {
            return _driver.FindElement(markdownTextCatalog).Text;
        }
    }
}
