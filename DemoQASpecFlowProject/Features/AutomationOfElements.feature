Feature: AutomationOfElements

 Background:
    Given I open a web browser and Launch Demo QA Site

    Scenario: Verify details post submission
        Given I navigate to the demo QA site Element Page
        When I enter the following in the text box
        | attributes        | value                   |
        | FullName          | Manojkumar              |
        | Email             | mymanojindian@gmail.com |
        | CurrentAddress    | Chennai                 |
        | PermanentAddress  | Madurai                 |  
        And I submit the form
        Then the submitted text should be same as entered

        
    Scenario: Verify details post CheckBox Selection
        Given I navigate to the demo QA site Element Page
        When I select Notes under Desktop section
        And Select the desktop menu
        Then Validate selected elements are displayed below

    Scenario: Edit the WebTable Content
        Given I navigate to the demo QA site Element Page
        When I select WebtableLink 
        And I Edit the WebTable
        Then Validate the Changes


