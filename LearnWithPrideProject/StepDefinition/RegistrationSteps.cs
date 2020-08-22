using LearnWithPrideProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LearnWithPrideProject.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }




        [Given(@"I navigate to Amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            registrationPage.NavigateToWebsite();

        }
        
        [When(@"I click on Hello Sign in")]
        public void WhenIClickOnHelloSignIn()
        {
            registrationPage.ClickOnHelloSignIn();
        }
        
        [When(@"I click on create your amazon account")]
        public void WhenIClickOnCreateYourAmazonAccount()
        {
            Thread.Sleep(5000);
            registrationPage.ClickOnCreateYourAmazonAccount1();
        }
        
        [When(@"I enter my name")]
        public void WhenIEnterMyName()
        {
            registrationPage.ClickOnYourName();
        }
        
        [When(@"I enter my Email")]
        public void WhenIEnterMyEmail()
        {
            registrationPage.ClickOnEmail();
        }
        
        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            registrationPage.ClickOnPassword();
        }
        
        [When(@"I re-enter Password")]
        public void WhenIRe_EnterPassword()
        {
            registrationPage.ClickOnReEnterPassword();
        }

        [When(@"I click on create your amazon account in the registration page")]
        public void WhenIClickOnCreateYourAmazonAccountInTheRegistrationPage()
        {
            registrationPage.ClickOnCreateYourAmazonAccount2();
        }

        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsUserLogInDisplayed);
        }

        [Given(@"I click on Sign in")]
        public void GivenIClickOnSignIn()
        {
            registrationPage.ClickOnSignIn();
        }

        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string email)
        {
            registrationPage.EnterEmailAddress(email);
        }

        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            registrationPage.EnterPasswordText(password);
        }

        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            registrationPage.ClickOnSignInButton();
        }

        [When(@"I click on post item")]
        public void WhenIClickOnPostItem()
        {
            registrationPage.ClickOnPostItem();
        }

        [When(@"I enter item description")]
        public void WhenIEnterItemDescription()
        {
            registrationPage.EnterItemDescription();
        }

        [When(@"I enter item name")]
        public void WhenIEnterItemName()
        {
            registrationPage.EnterItemName();
        }

        [When(@"I click on choose file")]
        public void WhenIClickOnChooseFile()
        {
            registrationPage.ChooseFile();
        }


    }
}
