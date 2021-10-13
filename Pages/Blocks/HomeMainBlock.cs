
using OpenQA.Selenium;

namespace attestat.Pages.Blocks{
    public class HomeMainBlock: BaseLayout{
        protected override By RootLocator()
        {
            return By.CssSelector("main");
        }
    }
}