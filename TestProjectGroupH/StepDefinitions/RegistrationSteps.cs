using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestProjectGroupH.PageObject;

namespace TestProjectGroupH.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }







        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }


        
        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }
        
        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }
        
        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Assert.That(registrationPage.IsNewArticleButtonDisplayed);
        }
    }
}
