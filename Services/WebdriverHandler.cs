using System.Threading;
using OpenQA.Selenium;

namespace SF_QATestLab.Services
{
    public static class WebDriverHandler
    {
        public static ThreadLocal<IWebDriver> Driver
        {
            get;
            set;
        }
    }
}