using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupH.Utilities;

namespace TestProjectGroupH.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div.ng-scope > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));

        IWebElement Username => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement Email => driver.FindElement(By.CssSelector("input[type='email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));

        IWebElement SignupButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));

        public void ClickOnSignUp()
        {
            SignUp.Click();  
        }

        public void EnterUsername()
        {
            Username.SendKeys("TestingMicrophone47");
        }

        public void EnterEmail()
        {
            Email.SendKeys("TestingMicrophone37@gmail.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("Passwordsecure");
        }

        public void ClickOnSignUpButton()
        {
            SignupButton.Click();
        }

        public bool IsNewArticleButtonDisplayed()
        {
            return NewArticle.Displayed;
        }


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }













    }
}
