using OpenQA.Selenium;

namespace attestat.Pages.Blocks{
    public abstract class SidebarBlock : BaseLayout{
        protected override By RootLocator()
        {
            return By.CssSelector("aside");
        }
    }
}