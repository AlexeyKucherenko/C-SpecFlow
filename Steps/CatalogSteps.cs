using System.Threading;
using SF_QATestLab.Pages;
using TechTalk.SpecFlow;
using SF_QATestLab.Services;
using FluentAssertions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.Helpers;

namespace SF_QATestLab.Steps
{
    [Binding, Scope(Feature = "Catalog page tests")]
    public class CatalogSteps : BaseSteps
    {

        [Before]
        public static void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            WebDriverHandler.Driver = new ThreadLocal<IWebDriver>(() => driver);
        }


        [After]
        public static void Teardown()
        {
            WebDriverHandler.Driver.Value.Quit();
        }


        [Given(@"Search '(.+)'")]
        public void SearchHeadphones(string searchText)
        {
            new HomePage().header.Search(searchText);
        }

        [Then(@"Headphones are displayed")]
        public void HeadphonesAreDisplayed()
        {
            new CatalogPage().GetProducts().Should().NotBeEmpty();
        }
    }
}