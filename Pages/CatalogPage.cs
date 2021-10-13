using OpenQA.Selenium;
using attestat.Pages.Blocks;
using attestat.Waits;
using attestat.Services;
using System.Linq;
using System.Collections.Generic;

namespace attestat.Pages
{
    public class CatalogPage : BasePage
    {
        public CatalogSidebarBlock side;
        public override void RootVisible()
        {
            side = new CatalogSidebarBlock();
            GetProducts();
        }

        public List<ProductBlock> GetProducts()
        {
            return new LayoutWait(WebdriverHandler.Driver.Value).PresentAll(By.XPath(ProductBlock.RootLocatorValue)).Select(e => new ProductBlock(e)).ToList();
        }
        protected override By RootLocator()
        {
            throw new System.NotImplementedException();
        }
    }
}