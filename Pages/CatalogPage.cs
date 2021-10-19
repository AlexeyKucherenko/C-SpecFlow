using OpenQA.Selenium;
using SF_QATestLab.Pages.Blocks;
using System.Linq;
using System.Collections.Generic;

namespace SF_QATestLab.Pages
{
    public class CatalogPage : BasePage
    {
        public CatalogSidebarBlock side;
        public override void RootVisible()
        {
            side = new CatalogSidebarBlock();
            GetProducts();
        }

        protected override By RootLocator()
        {
            throw new System.NotImplementedException();
        }
        public List<ProductBlock> GetProducts()
        {
            return Wait().PresentAll(By.XPath(ProductBlock.RootLocatorValue)).Select(e => new ProductBlock(e)).ToList();
        }
    }
}