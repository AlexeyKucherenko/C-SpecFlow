using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using attestat.Services;
using TechTalk.SpecFlow;

namespace attestat.Specs
{
    public class BaseSpec
    {

        [BeforeTestRun]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            WebdriverHandler.Driver = new ThreadLocal<IWebDriver>(() => new ChromeDriver());

        }


        [TearDown]
        public void Teardown()
        {
            WebdriverHandler.Driver.Value.Quit();
        }
    }
}
