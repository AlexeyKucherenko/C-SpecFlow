using System.Configuration;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using attestat.Pages.Blocks;

namespace attestat.Pages{
    [Binding]
    class HomePage : BasePage{
        public HeaderBlock header;
        public SidebarBlock side;
        public HomeMainBlock main;

        protected override By RootLocator()
        {
            throw new System.NotImplementedException();
        }

        public override void RootVisible()
        {
            header = new HeaderBlock();
            side = new HomeSidebarBlock();
            main = new HomeMainBlock();
        }

        [Given(@"Rozetka is open")]
        public HomePage Navigate(){
            var  appSettigns = ConfigurationManager.GetSection("environments");
            // TODO
            // base.Navigate(appSettigns.Get("url"));
            return this;
        }
    }
}