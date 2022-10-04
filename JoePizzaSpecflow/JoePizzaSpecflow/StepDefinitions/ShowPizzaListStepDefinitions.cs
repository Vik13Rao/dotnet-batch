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
    public class ShowPizzaListStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public ShowPizzaListStepDefinitions() => chromeDriver = new ChromeDriver("D:\\SeleniumChrome\\chromedriver_win32");
        
        [Given(@"I have navigate to pizza website")]
        public void GivenIHaveNavigateToPizzaWebsite()
        {

            chromeDriver.Navigate().GoToUrl("https://vikrampizzeria.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
        }

        [When(@"I click on Get Pizza button")]
        public void WhenIClickOnGetPizzaButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
            var Get_Pizza_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Get_Pizza_Button);

        }

        [Then(@"List of pizza page shows up")]
        public void ThenListOfPizzaPageShowsUp()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
        }
    }
}
