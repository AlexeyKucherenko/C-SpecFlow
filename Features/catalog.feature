Feature: Catalog page tests
Scenario: Headphones are displayed after searching
	Given Open 'https://rozetka.com.ua/'
	And Search 'Headphones'
	Then Headphones are displayed
