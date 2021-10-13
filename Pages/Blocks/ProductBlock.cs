using attestat.Services;
using attestat.Waits;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace attestat.Pages.Blocks
{
    public class ProductBlock : BaseLayout
    {

        private readonly string name;
        private readonly IWebElement root;

        public static readonly string RootLocatorValue = "//li[contains(@class, 'catelog-grid__cell')]";
        public ProductBlock(IWebElement root)
        {
            this.root = root;
        }
        public ProductBlock(string name)
        {
            this.name = name;
            root = Root();
        }

        public ProductBlock() : this("")
        {
            root = Root();
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