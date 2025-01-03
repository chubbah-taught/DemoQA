Feature: Test functions under Elements/Text Box

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
		Then output section appears
		And I see "Jane Doe" in name field
		And I see "janedoe@example.com" in email field
		And I see "1234 Elm Street" in current address field
		And I see "5678 Oak Avenue" in permanent address field

@elements @textbox
	Scenario: I enter invalid email address
		Given I am on the homepage
		When I click on Elements section
		And I click on Text Box section
		And I enter "Jane Doe" in Full Name field
		And I enter "invalidemail" in Email field
		And I enter "1234 Elm Street" in Current Address field
		And I enter "5678 Oak Avenue" in Permanent Address field
		And I click on Submit button
		Then email field state is changed to error state
		And output section is empty