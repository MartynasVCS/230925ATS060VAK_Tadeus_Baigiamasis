﻿using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.PiguLT
{
    internal class LoginToPage : BaseTest
    {
        [Test]
        public void LoginToWebShopAccount()
        {
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(Strings.LoginString.InputEmail1);
            LoginPage.EnterLoginPassword(Strings.LoginString.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnMyAccount();
            LoginPage.ClickOnEditProfile();
            LoginPage.GetMyAccountName();

            try
            {
                Assert.That(LoginPage.GetMyAccountName(), 
                    Is.EqualTo(Strings.LoginString.DisplayMyAccountName));
            }
            catch (Exception ex)
            {
                LoginPage.GetTestFailScreenshot();

                throw;
            }
        }
    }
}