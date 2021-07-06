Feature: Jobs
	As a user 
	I want to access vacancies
	In order to view current vacancies in the selected city

Scenario: Displaying vacancies in the selected city
	Given website Allo opened
	When click on the button Вакансии
	When click on drop-down list
	When сhooses a city "Днепр"
	When job list displays only for city "Днепр"
