using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace JoePizzaSpecflow.StepDefinitions
{
    [Binding]
    public class JoePizzaTitleStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public JoePizzaTitleStepDefinitions() => chromeDriver = new ChromeDriver("D:\\SeleniumChrome\\chromedriver_win32");
        
        [Given(@"opening the website")]
        public void GivenOpeningTheWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://vikrampizzeria.azurewebsites.net/");
            
        }

        [Then(@"check the title")]
        public void ThenCheckTheTitle()
        {
            Assert.IsTrue(chromeDriver.Title.Contains("Home page - JoePizzeria"));
            
        }
    }
}
