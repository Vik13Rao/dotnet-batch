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
    public class BuyPizzaStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public BuyPizzaStepDefinitions() => chromeDriver = new ChromeDriver("D:\\SeleniumChrome\\chromedriver_win32");
        
        [Given(@"Navigate to pizza website")]
        public void GivenNavigateToPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://vikrampizzeria.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click Get Pizza")]
        public void WhenIClickGetPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Get_Pizza_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Get_Pizza_Button);
        }

        [Then(@"Pizza list shows up")]
        public void ThenPizzaListShowsUp()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click Buy Now")]
        public void WhenIClickBuyNow()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var Buy_Now_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div/div[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Buy_Now_Button);
        }

        [Then(@"Order checkout page opens")]
        public void ThenOrderCheckoutPageOpens()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            

        }

        [When(@"click Confirm Order")]
        public void WhenClickConfirmOrder()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var ConfirmOrder_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", ConfirmOrder_Button);
        }

        [Then(@"Confirmation page show up")]
        public void ThenConfirmationPageShowUp()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }
    }
}
