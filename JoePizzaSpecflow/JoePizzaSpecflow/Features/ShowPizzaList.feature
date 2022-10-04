Feature: ShowPizzaList

With this feature, we are going to read the privacy policy

@tag1
Scenario: Display Pizzas from home screen
	Given I have navigate to pizza website
	When I click on Get Pizza button
	Then List of pizza page shows up

