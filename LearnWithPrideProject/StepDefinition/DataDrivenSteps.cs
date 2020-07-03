using LearnWithPrideProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LearnWithPrideProject.StepDefinition
{
    [Binding]
    public class DataDrivenSteps
    {

        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }








        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
                    
                                                                                            
        }
        
        [When(@"I enter Username text ""(.*)""")]
        public void WhenIEnterUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }
        
        [When(@"I enter email test ""(.*)""")]
        public void WhenIEnterEmailTest(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }
        
        [When(@"I enter password text ""(.*)""")]
        public void WhenIEnterPasswordText(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }
        
        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithParameterPage.ClickOnSignUpButton();
        }
        
        [Then(@"I am logged in with my username displayed")]
        public void ThenIAmLoggedInWithMyUsernameDisplayed()
        {
            Thread.Sleep(5000);
            Assert.That(dataDrivenWithParameterPage.IsUserLogInDisplayed); //NUnit Assertion
        }
    }
}
