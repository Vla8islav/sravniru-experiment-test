using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SravniRuTests
{
    public class SravniruPageAfterLogin : AnyPage
    {
        public SravniruPageAfterLogin(PageManager pageManager)
            : base(pageManager)
        {
        }

        [FindsBy(How = How.LinkText, Using = "выйти")]
        public IWebElement LogoutLink;

        public bool IsOnThisPage()
        {
            return IsElementPresent(By.CssSelector("li.item--log-out > a"));
        }
    }
}
