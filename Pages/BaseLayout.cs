using OpenQA.Selenium;
using attestat.Waits;
using attestat.Services;

namespace attestat.Pages
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
            this.Driver = WebdriverHandler.Driver.Value;
        }

        public LayoutWait Wait()
        {
            return new LayoutWait(this);
        }

        protected abstract By RootLocator();

        protected virtual IWebElement Root(){
            return Wait().Visible(RootLocator());
        }

        public virtual void RootVisible()
        {
            Wait().Visible(RootLocator());
        }

        public virtual T RootVisible<T>() where T : BaseLayout
        {
            Wait().Visible(RootLocator());
            return (T)this;
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