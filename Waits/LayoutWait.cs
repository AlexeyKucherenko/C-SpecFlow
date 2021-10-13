using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Linq;
using System.Collections.Generic;
using attestat.Pages;

namespace attestat.Waits
{
    public class LayoutWait : BaseWait
    {


        public LayoutWait(IWebDriver driver) : base(driver)
        {

        }
        public LayoutWait(BaseLayout layout) : base(layout.Driver)
        {

        }

        public IWebElement Visible(By locator)
        {
            this.Msg = $"Wait {locator} to be visible";
            return Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement Clickable(By locator)
        {
            this.Msg = $"Wait {locator} to be clickable";
            return Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public List<IWebElement> PresentAll(By locator)
        {
            this.Msg = $"Wait {locator} to be present";
            try
            {
                return Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator)).ToList();
            }
            catch
            {
                return new List<IWebElement>();
            }
        }
    }
}