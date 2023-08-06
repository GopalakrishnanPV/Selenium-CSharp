Feature: autobot automation

Input data entry for autobot website.

@chrome
Scenario Outline: Enter contact information in chrome
	Given i navigate to autobot website
	When i enter the name as "<Name>"
	And i enter the age as <Age>
	And i enter the email as "<Email>"
Examples:
	| Name        | Age | Email              |
	| Test User   | 21  | testuser@test.com  |
	| Test User 2 | 23  | testuser2@test.com |

@chrome
Scenario: Enter contact information in chrome using data table
	Given i navigate to autobot website
	When i fill the user form
		| Name      | Age | Email             |
		| Test User | 21  | testuser@test.com |

@chrome
Scenario: Enter contact information in chrome using datatable and specflow assist
	Given i navigate to autobot website
	When i fill the user form
	#Horizontal table format
		| Name      | Age | Email             |
		| Test User | 21  | testuser@test.com |

		#Vertical table format
		#| Field     | Value             |
		#| Name      | Test User         |
		#| Age       | 21                |
		#| Email     | testuser@test.com |


#@edge
#Scenario: Enter contact information in edge
#	Given i navigate to autobot website
#	#When i enter the name as "Test User"
#	#And i enter the age as 21
#	#And i enter the email as "testuser@test.com"
#	#Then i validate the values
