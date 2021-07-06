Feature: AuthorizationAllo
	As a user 
	I want to enter my account
	In order to get access to additional functions of the site

@mytag
Scenario: User authorization on the Allo
	Given website Allo opened
	When click on the button "Вход"
	When enter e-mail "dionirana@gmail.com"
	When enter password "qwert12345"
	When click on the button "Войти"
	Then Displayed user name equal to "Катерина"

Scenario Outline: When entering invalid data during authorization, an error is displayed
	Given website Allo opened
	When click on the button "Вход"
	When enter e-mail '<e-mail>'
	When enter password '<password>'
	When click on the button "Войти"
	Then Error message '<error_message>' is displayed

	Examples:
		| e-mail              | password   | error_message                                          |
		| dd@gmail.com        | qwert12345 | Пожалуйста, укажите корректный адрес электронной почты |
		| dionirana@gmail.com | 54321trewq | Неверный адрес электронной почты (email) или пароль.   |