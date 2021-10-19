using OpenQA.Selenium;
using SF_QATestLab.Waits;
using SF_QATestLab.Services;

namespace SF_QATestLab.Pages
{
    public abstract class BaseLayout
    {
        public IWebDriver Driver
        {
            get;
            private set;
        }


        public BaseLayout()
        {
            this.Driver = WebDriverHandler.Driver.Value;
        }

        public LayoutWait Wait()
        {
            return new LayoutWait(this);
        }

        protected abstract By RootLocator();

        protected virtual IWebElement RootElement()
        {
            return Wait().Visible(RootLocator());
        }

        public virtual void RootVisible()
        {
            RootElement();
        }

        public bool isRootVisible()
        {
            try
            {
                RootVisible();
                return true;
            }
            catch (WebDriverException)
            {
                return false;
            }
        }

        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Click(By locator)
        {
            Wait().Clickable(locator).Click();
        }

        public void TypeText(By locator, string text)
        {
            Wait().Visible(locator).SendKeys(text);
        }

    }
}