
using OpenQA.Selenium;

namespace SF_QATestLab.Pages.Blocks
{
    public class HomeMainBlock : BaseLayout
    {
        protected override By RootLocator()
        {
            return By.CssSelector("main");
        }
    }
}