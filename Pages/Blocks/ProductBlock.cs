using OpenQA.Selenium;

namespace SF_QATestLab.Pages.Blocks
{
    public class ProductBlock : BaseLayout
    {

        private readonly string name;
        private readonly IWebElement root;

        public static readonly string RootLocatorValue = "//li[contains(@class, 'catalog-grid__cell')]";
        public ProductBlock(IWebElement root)
        {
            this.root = root;
        }
        public ProductBlock(string name)
        {
            this.name = name;
            root = RootElement();
        }

        public ProductBlock() : this("")
        {
            root = RootElement();
        }

        protected override By RootLocator()
        {
            var locatorVal = RootLocatorValue;
            if (name.Length != 0)
            {
                locatorVal += $"[contains(.,'{name}')]";
            }

            return By.XPath(locatorVal);
        }
    }
}