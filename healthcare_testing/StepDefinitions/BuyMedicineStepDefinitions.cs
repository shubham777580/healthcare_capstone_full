using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace healthcare_testing.StepDefinitions
{
    [Binding]
    public class BuyMedicineStepDefinitions
    {
        private ChromeDriver chromeDriver;
        public BuyMedicineStepDefinitions() => chromeDriver = new ChromeDriver("C:/Users/shubham.mukherjee/Downloads/chromedriver_win32");


        [Given(@"we have navigated to website")]
        public void GivenWeHaveNavigatedToWebsite()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:3000/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [When(@"Add medicine/product (.*)")]
        public void WhenAddMedicineProduct(int p0)
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Med_1_Button = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[1]/div/div/div[4]/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", Med_1_Button);
        }

        [Then(@"Click cart button")]
        public void ThenClickCartButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Med_2_Button = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[2]/div/div/div[4]/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", Med_2_Button);
        }

        [Then(@"Cart page opens up")]
        public void ThenCartPageOpensUp()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Cart_Button = chromeDriver.FindElement(By.XPath("/html/body/div/div/nav[1]/div/div/div[3]/div[2]/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Cart_Button);
            WebDriverWait wait1 = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [Then(@"Click on order confirm")]
        public void ThenClickOnOrderConfirm()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Confirm_Order_Button = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div/a[2]/div/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", Confirm_Order_Button);
        }

        [Then(@"clear the old cart products")]
        public void ThenClearTheOldCartProducts()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Med_1_Button = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[1]/div/div/div[4]/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", Med_1_Button);

            WebDriverWait wait1 = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Med_2_Button = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[2]/div/div/div[4]/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", Med_2_Button);

            }
        }
}
