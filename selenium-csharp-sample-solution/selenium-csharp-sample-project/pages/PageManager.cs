using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SravniRuTests
{
    public class PageManager
    {
        internal IWebDriver driver;
        internal string baseUrl;

        public PageManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            driver = WebDriverFactory.GetDriver(hubUrl, capabilities);

            if (!driver.Url.StartsWith(baseUrl))
            {
                driver.Navigate().GoToUrl(baseUrl);
            }
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            this.baseUrl = baseUrl;

            PageNoLogin = InitElements(new SravniruPageNoLogin(this));
            PageAfterLogin = InitElements(new SravniruPageAfterLogin(this));
            UserProfile = InitElements(new UserProfilePageAfterLogin(this));
        }

        private T InitElements<T>(T page) where T : AnyPage
        {
            PageFactory.InitElements(driver, page);
            return page;
        }

        public SravniruPageNoLogin PageNoLogin { get; set; }

        public SravniruPageAfterLogin PageAfterLogin { get; set; }

        public UserProfilePageAfterLogin UserProfile { get; set; }
    }
}
