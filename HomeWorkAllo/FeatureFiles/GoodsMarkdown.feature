Feature: GoodsMarkdown
	As a user 
	I want to see the markup of goods on the site
	In order to buy goods at a good price

Scenario: Display markdown items
	Given website Allo opened
	When click on the button Уценка
	Then user sees the item list page
	Then user sees the the catalog