using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SF_QATestLab.Pages.Blocks;

namespace SF_QATestLab.Pages
{
    [Binding]
    class HomePage : BasePage
    {
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
    }
}