namespace SF_QATestLab.Pages
{
    public abstract class BasePage : BaseLayout
    {
        public BasePage(bool pageVisible = true)
        {

            if (pageVisible)
            {
                RootVisible();
            }
        }

    }
}