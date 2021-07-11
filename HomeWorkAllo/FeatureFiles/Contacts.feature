Feature: Contacts
	As a user 
	I want to be able to communicate with the support of the site
	In order to ask important questions for me

Scenario: Ask a question to support
	Given website Allo opened
	When click on the button Контакты
	When enter the user name 'TestUser'
	When enter user e-mail 'wegevi2952@herrain.com'
	When click on drop-down topic menu
	When choose on drop-down menu Вопросы по акциям
	When enter message field 'TestText'
	When click on the button send
	Then user notification that the form has been submitted