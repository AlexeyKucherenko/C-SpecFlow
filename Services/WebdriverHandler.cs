using System.Threading;
using OpenQA.Selenium;

namespace attestat.Services
{
    public static class WebdriverHandler
    {
        private static ThreadLocal<IWebDriver> driver;

        public static ThreadLocal<IWebDriver> Driver
        {
            get;
            set;
        }
    }
}