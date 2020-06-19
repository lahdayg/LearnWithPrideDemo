using LearnWithPrideProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithPrideProject.PageObject
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement helloSignIn => driver.FindElement(By.XPath("//span[text()='Hello, Sign in']"));

        IWebElement createYourAmazonAccount1 => driver.FindElement(By.CssSelector("#createAccountSubmit"));

        IWebElement yourName => driver.FindElement(By.CssSelector("#ap_customer_name"));

        IWebElement email => driver.FindElement(By.CssSelector("#ap_email"));

        IWebElement password => driver.FindElement(By.CssSelector("#ap_password"));

        IWebElement reEnterPassword => driver.FindElement(By.CssSelector("#ap_password_check"));

        IWebElement createYourAmazonAccount2 => driver.FindElement(By.CssSelector("#continue"));

        IWebElement userLogin => driver.FindElement(By.XPath("//span[text()='Hello, Demo']"));



        public void ClickOnHelloSignIn()
        {
            helloSignIn.Click();
        }

        public void ClickOnCreateYourAmazonAccount1()
        {
            createYourAmazonAccount1.Click();
        }

        public void ClickOnYourName()
        {
            yourName.SendKeys("Demo");
        }

        public void ClickOnEmail()
        {
            email.SendKeys("info@learnwithpride.co.uk");
        }

        public void ClickOnPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void ClickOnReEnterPassword()
        {
            reEnterPassword.SendKeys("PasswordSecure");
        }

        public void ClickOnCreateYourAmazonAccount2()
        {
            createYourAmazonAccount2.Click();
        }

        public bool IsUserLogInDisplayed()

        {
            return userLogin.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }
    }
}
