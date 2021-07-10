using System;
using TechTalk.SpecFlow;

namespace HomeWorkAllo.Steps
{
    [Binding]
    public class GoodsMarkdownSteps
    {
        [Then(@"user sees the item list page")]
        public void ThenUserSeesTheItemListPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user sees the the catalog")]
        public void ThenUserSeesTheTheCatalog()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
