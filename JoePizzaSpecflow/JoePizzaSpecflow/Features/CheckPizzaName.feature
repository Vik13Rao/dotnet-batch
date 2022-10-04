Feature: CheckPizzaName

A short summary of the feature

@tag1
Scenario: Checking pizza name in checkout page
	Given I navigate to pizza website
	When  clicking Get pizza button 
	Then Pizza list page opens
	When I click Buy Now button of certain pizza
	Then Pizza checkout page opens up
	 
	Then check pizza name if it matches with pizza selected from pizza list
