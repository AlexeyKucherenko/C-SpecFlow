using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using SF_QATestLab.Services;
using TechTalk.SpecFlow;

namespace SF_QATestLab.Steps
{
    public class BaseSteps
    {
        [Given(@"Open '(.+)'")]
        public void OpenRozetka(string url)
        {
            WebDriverHandler.Driver.Value.Navigate().GoToUrl(url);
        }
    }
}
