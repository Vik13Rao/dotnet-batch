Feature: BuyPizza

A short summary of the feature

@tag1
Scenario: Confirming pizza order
	Given Navigate to pizza website
	When I click Get Pizza
	Then Pizza list shows up
	When I click Buy Now 
	Then Order checkout page opens
	When click Confirm Order 
	Then Confirmation page show up
