using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagLabDemoSite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SwagLabDemoSite.PageObject
{
    class SwagLabDemoSitePage
    {
        public SwagLabDemoSitePage()
        {
            driver = Hooks1.driver;
        }


        IWebDriver driver;




        IWebElement AdminUsername => driver.FindElement(By.CssSelector("#user-name"));

        IWebElement AdminPassword => driver.FindElement(By.CssSelector("#password"));

        IWebElement LoginButton => driver.FindElement(By.CssSelector("#login-button"));

        IWebElement SelectPrice => driver.FindElement(By.CssSelector("#header_container > div.header_secondary_container > div.right_component > span > select"));

        IWebElement LabsOnesie => driver.FindElement(By.XPath("//*[@id='add-to-cart-sauce-labs-onesie']"));

        IWebElement TellThings => driver.FindElement(By.XPath("//*[@id='add-to-cart-test.allthethings()-t-shirt-(red)']"));

        IWebElement LabsBackpack => driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack"));

        IWebElement Basket => driver.FindElement(By.CssSelector("#shopping_cart_container > a"));

        IWebElement Checkout => driver.FindElement(By.CssSelector("#checkout"));

        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='first-name']"));

        IWebElement LastName => driver.FindElement(By.CssSelector("#last-name"));

        IWebElement PostCode => driver.FindElement(By.CssSelector("#postal-code"));

        IWebElement Contiune => driver.FindElement(By.XPath("//*[@id='continue']"));

        IWebElement Finish => driver.FindElement(By.CssSelector("#finish"));

        IWebElement HomeButton => driver.FindElement(By.CssSelector("#back-to-products"));



        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }



        public void EnterAdminUsername(string Name)
        {
           AdminUsername.SendKeys(Name);
        }



        public void EnterAdminPassword(string Name)
        {
            AdminPassword.SendKeys(Name);
        }


        public void ClickLonginButton()
        {
            LoginButton.Click();
        }


        public void ClickSelectPrice()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectPrice);
            select.SelectByText("Price (low to high)");
        }


        public void ClickLabOnesie()
        {
            LabsOnesie.Click();
        }


        public void ClickTallThings()
        {
            TellThings.Click();
        }


        public void ClickLabsBackpark()
        {
            LabsBackpack.Click();
        }


        public void ClickBasket()
        {
            Basket.Click();
        }


        public void ClickCheckout()
        {
            Checkout.Click();
        }


        public void EnterFirstName(string Name)
        {
            FirstName.SendKeys(Name);
        }


        public void EnterLastName(string Name)
        {
            LastName.SendKeys(Name);
        }


        public void EnterPostCode(string Name)
        {
            PostCode.SendKeys(Name);
        }

        internal bool ClickHomeButtonDispled()
        {
            throw new NotImplementedException();
        }

        public void ClickContinue()
        {
            Contiune.Click();
        }


        public void ClickFinish()
        {
            Finish.Click();
        }


       // public void ClickHomeButton()
        //{
          //  HomeButton.Click();
        //}


        public bool IsHomeButtonDisplayed()
        {
            return HomeButton.Displayed;
        }


    }

}
