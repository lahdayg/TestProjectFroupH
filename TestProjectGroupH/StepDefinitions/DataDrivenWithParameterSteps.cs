using System;
using TechTalk.SpecFlow;
using TestProjectGroupH.PageObject;

namespace TestProjectGroupH.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }



        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter my Username text ""(.*)""")]
        public void GivenIEnterMyUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }

        
        [Given(@"I enter my Email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string emailText)
        {
            dataDrivenWithParameterPage.EnterEmail(emailText);
        }
        
        [Given(@"I enter my Password text ""(.*)""")]
        public void GivenIEnterMyPasswordText(string passwordText)
        {
            dataDrivenWithParameterPage.EnterPassword(passwordText);
        }
    }
}
