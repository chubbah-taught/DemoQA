Feature: TextBox

A short summary of the feature

@elements @textbox
Scenario: I enter all data as expected
	Given I am on the homepage
	When I click on Elements section
	And I click on Text Box section
	And I enter "Jane Doe" in Full Name field
	And I enter "janedoe@example.com" in Email field
	And I enter "1234 Elm Street" in Current Address field
	And I enter "5678 Oak Avenue" in Permanent Address field
	And I click on Submit button
	Then a new section appears
	And I see "Name:Jane Doe"
	And I see "Email:janedoe@example.com"
	And I see "Current Address :1234 Elm Street"
	And I see "Permananet Address :5678 Oak Avenue"

# Scenario: I enter Full Name only, as expected
# Scenario: I enter Email only, as expected
# Scenario: I enter Current Address only, as expected
# Scenario: I enter Permanent Address only, as expected