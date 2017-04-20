using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SravniRuTests
{
    public class SravniruPageNoLogin : AnyPage
    {
        public SravniruPageNoLogin(PageManager pageManager)
            : base(pageManager)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "button[aria-label='toggle menu']")] public IWebElement MenuOpenButton;

        [FindsBy(How = How.CssSelector, Using = "div.mobile-nav.is-visible > div > a[href='/login/']")] public IWebElement OpenLoginFormButton;

        [FindsBy(How = How.CssSelector, Using = "input[name='login']")] public IWebElement UsernameField;

        [FindsBy(How = How.CssSelector, Using = "input[name='passCode']")] public IWebElement PasswordField;

        [FindsBy(How = How.CssSelector, Using = ".authentication__form-buttons input[value='Войти']")] public IWebElement SubmitButton;

        public bool IsOnThisPage()
        {
            return IsElementPresent(By.CssSelector(".authentication__form-buttons input[value='Войти']"));
        }

        public bool IsPasswordFormPresentOnTheScreen()
        {
            return IsElementVisible(By.CssSelector("input[name='passCode']"));
        }

    }
}