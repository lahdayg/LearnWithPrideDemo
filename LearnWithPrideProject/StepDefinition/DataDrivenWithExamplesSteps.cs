using LearnWithPrideProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace LearnWithPrideProject.StepDefinition
{
    [Binding]
    public class DataDrivenWithExamplesSteps
    {
        DataDrivenWithExamplesPage dataDrivenWithExamplesPage;

        public DataDrivenWithExamplesSteps()
        {
            dataDrivenWithExamplesPage = new DataDrivenWithExamplesPage();
        }




        [Given(@"I navigate to this website ""(.*)""")]
        public void GivenINavigateToThisWebsite(string url)
        {
            dataDrivenWithExamplesPage.NavigateToWebsite(url);

        }
        
        [When(@"I enter username text ""(.*)""")]
        public void WhenIEnterUsernameText(string Username)
        {
            dataDrivenWithExamplesPage.EnterUsername(Username);
        }
        
        [When(@"I enter Email text ""(.*)""")]
        public void WhenIEnterEmailText(string Email)
        {
            dataDrivenWithExamplesPage.EnterEmail(Email);
        }
        
        [When(@"I enter Password text ""(.*)""")]
        public void WhenIEnterPasswordText(string Password)
        {
            dataDrivenWithExamplesPage.EnterPassword(Password);
        }
    }
}
