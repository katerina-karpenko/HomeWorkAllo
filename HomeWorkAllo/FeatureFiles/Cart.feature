Feature: Cart
	As a user
	I want to have access to my cart
	In order to view a content of my order any time 

Scenario: Unauthorized user has empty cart
	Given website Allo opened
	Given User is not logged in
	When User clicks on cart
	Then Cart is empty