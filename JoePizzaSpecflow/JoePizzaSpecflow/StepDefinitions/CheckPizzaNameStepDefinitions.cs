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
    public class CheckPizzaNameStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public CheckPizzaNameStepDefinitions() => chromeDriver = new ChromeDriver("D:\\SeleniumChrome\\chromedriver_win32");
        [Given(@"I navigate to pizza website")]
        public void GivenINavigateToPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://vikrampizzeria.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
        }

        [When(@"clicking Get pizza button")]
        public void WhenClickingGetPizzaButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
            var Get_Pizza_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Get_Pizza_Button);

        }

        [Then(@"Pizza list page opens")]
        public void ThenPizzaListPageOpens()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
        }

        [When(@"I click Buy Now button of certain pizza")]
        public void WhenIClickBuyNowButtonOfCertainPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
            var Buy_Now_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div/div[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Buy_Now_Button);
        }

        [Then(@"Pizza checkout page opens up")]
        public void ThenPizzaCheckoutPageOpensUp()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(95000));
        }

        [Then(@"check pizza name if it matches with pizza selected from pizza list")]
        public void ThenCheckPizzaNameIfItMatchesWithPizzaSelectedFromPizzaList()
        {
            chromeDriver.PageSource.Contains("Chicken Kebab");
        }
    }
}
