﻿using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class LoginToPage : BaseTest
    {
        [Test]
        public void LoginToWebShopAccount()
        {
            HomePage.ClickAllowAllCookies();
            HomePage.HoverOnProfileIcon();
            HomePage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(TestData.Login.InputEmail1);
            LoginPage.EnterLoginPassword(TestData.Login.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            HomePage.HoverOnProfileIcon();
            LoginPage.ClickOnMyAccount();
            LoginPage.ClickOnEditProfile();
            LoginPage.GetMyAccountName();

            Assert.That(LoginPage.GetMyAccountName(), Is.EqualTo(TestData.Login.DisplayMyAccountName));
        }
    }
}
