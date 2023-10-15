Feature: AutomationOfInteractions

 Background:
    Given Interactions:I open a web browser and Launch Demo QA Site

     Scenario: Sort numbers in descending order
    Given I navigate to the demo QA site Interactions Page
    When I click the Descending Sort button
    Then the numbers should be sorted in descending order


     Scenario: Drag and drop Scenario
    Given I navigate to the demo QA site Interactions Page
    When I click the droppable button
    Then the validate user is able to do drag and drop
