using LearnWithPrideProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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


        IWebElement signIn => driver.FindElement(By.XPath("(//a[text()='Sign In'])[1]"));

        IWebElement emailAddress => driver.FindElement(By.XPath("//input[@id='user_email']"));

        IWebElement passwordText => driver.FindElement(By.XPath("//input[@id='user_password']"));

        IWebElement signInButton => driver.FindElement(By.XPath("//input[@id='btn_signin']"));

        IWebElement postItem => driver.FindElement(By.XPath("//li[@class='mr--5']"));

        IWebElement itemName => driver.FindElement(By.XPath("//input[@id='title']"));




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

        public void ClickOnSignIn()
        {
            signIn.Click();
        }

        public void EnterEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void EnterPasswordText(string password)
        {
            passwordText.SendKeys(password);
        }

        public void ClickOnSignInButton()
        {
            signInButton.Click();
        }

        public void ClickOnPostItem()
        {
            postItem.Click();
        }

        public void EnterItemName()
        {
            Thread.Sleep(5000);
            itemName.SendKeys("Testing Iframe");
        }

        public void EnterItemDescription()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='cke_1_contents']/iframe")));
            IWebElement itemDescription = driver.FindElement(By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr']"));
            Thread.Sleep(5000);
            itemDescription.SendKeys("Demonstration of Iframe");
            driver.SwitchTo().DefaultContent();
        }

        public void ChooseFile()
        {
            driver.FindElement(By.XPath("//input[@id='files']")).SendKeys("C:\\Users\\Grandma\\Pictures\\council.jpg");
        }




        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }
    }
}
