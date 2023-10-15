Feature: AutomationOfWidgets

 Background:
    Given Widgets:I open a web browser and Launch Demo QA Site

     Scenario: Validate the AutoComplete Functionality
    Given I navigate to the demo QA site Widgets Page
    When I click the AutoComplete button
    Then Validate the autocomplete functionality


    