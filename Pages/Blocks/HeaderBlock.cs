using OpenQA.Selenium;
namespace attestat.Pages.Blocks{
    class HeaderBlock : BaseLayout
    {
        private static readonly By SearchBarLocator = By.CssSelector("input[name=search]");
        private static readonly By SearchSubmitLocator = By.XPath("button[class*='search-form__submit']");

        protected override By RootLocator()
        {
            return By.CssSelector("rz-header");
        }
        public HeaderBlock(){
            RootVisible();
        }
        public HeaderBlock TypeSearch(string text)
        {
            TypeText(SearchBarLocator, text);
            return this;
        }

        public void ClickSearch() {

            Click(SearchSubmitLocator);
        }

        public void Search(string text) => TypeSearch(text).ClickSearch();

    }
}