Feature: Blog
	As a user 
	I want to read the news
	In order to in order to find out information on a topic of interest to me

Scenario: Displaying news block
	Given website Allo opened
	When click on the button Blog 
	#When click on the button category
	#When select a category Игры 
	#Then the user is on the Игры block
	Then User see News button
	Then User see Articl button