using HomeWorkAllo.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class GoodsMarkdownSteps
    {
        public IWebDriver driver;
        public MainPage mainPage = new MainPage(Connection.driver);
        public GoodsMarkdown goodsMarkdown = new GoodsMarkdown(Connection.driver);

        [When(@"click on the button Уценка")]
        public void WhenClickOnTheButtonУценка()
        {
            goodsMarkdown = mainPage.MarkdownPageClick();
        }

        [Then(@"user sees the item list page")]
        public void ThenUserSeesTheItemListPage()
        {
            Connection.driver.SwitchTo().Window(Connection.driver.WindowHandles.Last());
            string markdownText = goodsMarkdown.DiscountSaleTextOnPage();
            Assert.AreEqual("РАСПРОДАЖА УЦЕНЁННЫХ ТОВАРОВ", markdownText);
        }

        [Then(@"user sees the the catalog")]
        public void ThenUserSeesTheTheCatalog()
        {
            string markdownTextCatalog = goodsMarkdown.DiscountSaleCatalogText();
            Assert.AreEqual("КАТАЛОГ", markdownTextCatalog);
        }
    }
}
