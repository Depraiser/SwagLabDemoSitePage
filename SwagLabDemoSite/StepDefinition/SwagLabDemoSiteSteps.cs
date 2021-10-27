using NUnit.Framework;
using SwagLabDemoSite.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SwagLabDemoSite.StepDefinition
{
    [Binding]
    public class SwagLabDemoSiteSteps
    {
        SwagLabDemoSitePage swagLabDemoSitePage;


            public SwagLabDemoSiteSteps()
        {
            swagLabDemoSitePage = new SwagLabDemoSitePage();
        }


        [Given(@"the User navigate to the website ""(.*)""")]
        public void GivenTheUserNavigateToTheWebsite(string url)
        {
            swagLabDemoSitePage.NavigateToWebsite(url);
        }

        
        [Given(@"I enter the admin username ""(.*)""")]
        public void GivenIEnterTheAdminUsername(string Name)
        {
            swagLabDemoSitePage.EnterAdminUsername(Name);
        }
        
        [Given(@"I enter the admin password ""(.*)""")]
        public void GivenIEnterTheAdminPassword(string Name)
        {
            swagLabDemoSitePage.EnterAdminPassword(Name);
        }
        
        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            swagLabDemoSitePage.ClickLonginButton();
        }
        
        [Given(@"I select price")]
        public void GivenISelectPrice()
        {
            swagLabDemoSitePage.ClickSelectPrice();
        }
        
        [Given(@"User add Labs Onesie to Cart")]
        public void GivenUserAddLabsOnesieToCart()
        {
            swagLabDemoSitePage.ClickLabOnesie();
        }
        
        [Given(@"I select Test\.allTheThings\(\) T-Shirt \(Red\)")]
        public void GivenISelectTest_AllTheThingsT_ShirtRed()
        {
            swagLabDemoSitePage.ClickTallThings();
        }
        
        [Given(@"Sauce Labs Backpack was added to cart")]
        public void GivenSauceLabsBackpackWasAddedToCart()
        {
            swagLabDemoSitePage.ClickLabsBackpark();
        }
        
        [Given(@"User click on basket")]
        public void GivenUserClickOnBasket()
        {
            swagLabDemoSitePage.ClickBasket();
        }
        
        [When(@"I click on checkout")]
        public void WhenIClickOnCheckout()
        {
            swagLabDemoSitePage.ClickCheckout();
        }
        
        [When(@"I enter my first name ""(.*)""")]
        public void WhenIEnterMyFirstName(string Name)
        {
            swagLabDemoSitePage.EnterFirstName(Name);
        }
        
        [When(@"I enter my last name ""(.*)""")]
        public void WhenIEnterMyLastName(string Name)
        {
            swagLabDemoSitePage.EnterLastName(Name);
        }
        
        [When(@"I enter my post code ""(.*)""")]
        public void WhenIEnterMyPostCode(string Name)
        {
            swagLabDemoSitePage.EnterPostCode(Name);
        }
        
        [When(@"I click on continue")]
        public void WhenIClickOnContinue()
        {
            swagLabDemoSitePage.ClickContinue();
        }
        
        [When(@"I click on finish")]
        public void WhenIClickOnFinish()
        {
            swagLabDemoSitePage.ClickFinish();
        }
        
        [Then(@"I should be able to complete my order")]
        public void ThenIShouldBeAbleToCompleteMyOrder()
        {
            Thread.Sleep(5000);
            Assert.That(swagLabDemoSitePage.ClickHomeButtonDispled);
        }
    }
}
