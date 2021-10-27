Feature: SwagLabDemoSite
	Simple calculator for adding two numbers

@mytag
Scenario: Swag Lab Order Testing
	Given the User navigate to the website "https://www.saucedemo.com/"
	And I enter the admin username "standard_user"
	And I enter the admin password "secret_sauce"
	And I click on the login button
	And I select price
	And User add Labs Onesie to Cart
	And I select Test.allTheThings() T-Shirt (Red)
	And Sauce Labs Backpack was added to cart
	And User click on basket
	When I click on checkout
	And I enter my first name "Depraiser"
	And I enter my last name "Fawe"
	And I enter my post code "CM20 2LJ"
	And I click on continue
	When I click on finish
	Then I should be able to complete my order