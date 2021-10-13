using System.Threading;
using attestat.Pages;
using TechTalk.SpecFlow;

namespace attestat.Specs
{
    [Binding]
    public class HomeSpec : BaseSpec
    {
        private ThreadLocal<HomePage> HomePage_tl;

        [BeforeScenario]
        public void NavigateHomePage()
        {
            var homePage = new HomePage().Navigate();
            HomePage_tl = new ThreadLocal<HomePage>(() => homePage);
        }

        [Given(@"Search '(.+)'")]
        public CatalogPage SearchHeadPhones(string searchText)
        {
            HomePage_tl.Value.header.Search(searchText);
            return new CatalogPage();
        }
    }
}