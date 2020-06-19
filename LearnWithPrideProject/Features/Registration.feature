Feature: Registration
	In order to use the amazon website
	I will need to register
	So that I can enjoy all the amazing offers

@mytag
Scenario: Register on Amazon
	Given I navigate to Amazon website
	When I click on Hello Sign in
	And I click on create your amazon account
	And I enter my name
	And I enter my Email
	And I enter Password
	And I re-enter Password
	And I click on create your amazon account in the registration page
	#Then my account should be created
