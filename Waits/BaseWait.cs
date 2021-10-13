using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace attestat.Waits{
    public class BaseWait
    {
        private IWebDriver wd;

        public TimeSpan Interval
        {
            get; set;
        }

        public TimeSpan Timeout
        {
            get; set;
        }
        public string Msg
        {
            get; set;
        }

        public bool IsPositive
        {
            get; set;
        }
        public BaseWait(IWebDriver wd)
        {
            this.wd = wd;
            IsPositive = true;

        }

        public BaseWait WithConf(double timeoutSec = 10, double intervalMillisec = 500, string msg = "")
        {
            this.Timeout = TimeSpan.FromSeconds(timeoutSec);
            this.Interval = TimeSpan.FromMilliseconds(intervalMillisec);
            this.Msg = msg;
            return this;
        }

        public TResult Until<TResult>(Func<IWebDriver, TResult> condition)
        {
            var wdw = new WebDriverWait(new SystemClock(), wd, Timeout, Interval);
            wdw.Message = Msg;
            return wdw.Until(condition);
        }
    }
}