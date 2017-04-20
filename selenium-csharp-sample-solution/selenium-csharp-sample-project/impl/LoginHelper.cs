using System;

namespace SravniRuTests
{
    public class LoginHelper
    {
        private ApplicationManager manager;
        private PageManager pages;

        public LoginHelper(ApplicationManager manager)
        {
            this.manager = manager;
            this.pages = manager.Pages;
        }

        public void Login(AccountData account)
        {
            pages.driver.Navigate().Refresh();
            pages.PageNoLogin.MenuOpenButton.Click();
            pages.PageNoLogin.OpenLoginFormButton.Click();
            pages.PageNoLogin.UsernameField.SendKeys(account.Username);
            pages.PageNoLogin.UsernameField.Click();

            if (pages.PageNoLogin.IsPasswordFormPresentOnTheScreen())
            {
                pages.PageNoLogin.PasswordField.SendKeys(account.Password);
                pages.PageNoLogin.SubmitButton.Click();
            }
        }

        public bool IsLoggedIn()
        {
            return pages.PageAfterLogin.IsOnThisPage();
        }

        public bool IsLoggedOut()
        {
            return pages.PageNoLogin.IsOnThisPage();
        }

        public void Logout()
        {
            pages.PageAfterLogin.LogoutLink.Click();
        }
    }
}