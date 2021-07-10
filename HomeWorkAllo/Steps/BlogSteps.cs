using HomeWorkAllo.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class BlogSteps
    {

        //public IWebDriver driver;
        public MainPage mainPage = new MainPage(Connection.driver);
        public Blog blog = new Blog(Connection.driver);

        [When(@"click on the button Blog")]
        public void WhenClickOnTheButtonBlog()
        {
            blog = mainPage.BlogPageClick();
        }
        
        [Then(@"User see News button")]
        public void ThenUserSeeNewsButton()
        {
            Connection.driver.SwitchTo().Window(Connection.driver.WindowHandles.Last());
            string newsText = blog.GetNewsText();
            Assert.AreEqual("НОВОСТИ", newsText);
        }
        
        [Then(@"User see Articl button")]
        public void ThenUserSeeArticlButton()
        {
            string articlText = blog.GetArticText();
            Assert.AreEqual("СТАТЬИ", articlText);
        }
    }
}
