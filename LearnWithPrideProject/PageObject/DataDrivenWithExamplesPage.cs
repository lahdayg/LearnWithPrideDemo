using LearnWithPrideProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithPrideProject.PageObject
{
    class DataDrivenWithExamplesPage
    {

        public DataDrivenWithExamplesPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.XPath("//a[contains(text(),'Sign up')]"));

        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder ='Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//input[@placeholder ='Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@placeholder ='Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@class='btn btn-lg btn-primary pull-xs-right ng-binding']"));

        IWebElement userLogIn => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(4) > a"));




        public void EnterUsername(string Username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            usernameInput.SendKeys(Username + randomInt);
            //usernameInput.SendKeys(Username);


        }

        public void EnterEmail(string Email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailInput.SendKeys(Email + randomInt + "@demo.com");
             //emailInput.SendKeys(Email);


        }

        public void EnterPassword(string Password)
        {
            passwordInput.SendKeys(Password);
        }

        public void ClickOnSignUpButton()
        {
            signUpButton.Click();
        }

        public bool IsUserLogInDisplayed()

        {
            return userLogIn.Displayed;
        }


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}






    

