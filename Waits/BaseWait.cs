using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SF_QATestLab.Waits
{
    public class BaseWait
    {
        private readonly IWebDriver wd;

        private static int waitTime = 10;
        private static double pollTime = 0.5;
        private static string msg = "";

        public int WaitTime
        {
            get
            {
                return waitTime;
            }
            set
            {
                waitTime = value;
            }
        }
        public double PollTime
        {
            get
            {
                return pollTime;
            }
            set
            {
                pollTime = value;
            }

        }
        public string Msg
        {
            get
            {
                return msg;
            }
            set
            {
                msg = value;
            }
        }
        public BaseWait(IWebDriver wd)
        {
            this.wd = wd;
        }

        public TResult Until<TResult>(Func<IWebDriver, TResult> condition)
        {
            var wdw = new WebDriverWait(new SystemClock(), wd, TimeSpan.FromSeconds(WaitTime), TimeSpan.FromSeconds(PollTime));
            wdw.Message = Msg;
            return wdw.Until(condition);
        }
    }
}