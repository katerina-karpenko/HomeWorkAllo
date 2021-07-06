Feature: Header
As a user
	I want to have access change the city of the website
	In order to view a list of goods in stock 

Scenario: Сhange the location of the city to the Dnepr
	Given website Allo opened location of the city Kyiv
	When click on location of the city
	When click on the city Dnepr
	When click on location of the city
	Then the location of the city has changed to the Dnepr