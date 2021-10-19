using OpenQA.Selenium;

namespace SF_QATestLab.Pages.Blocks
{
    public abstract class SidebarBlock : BaseLayout
    {
        protected override By RootLocator()
        {
            return By.CssSelector("aside");
        }
    }
}