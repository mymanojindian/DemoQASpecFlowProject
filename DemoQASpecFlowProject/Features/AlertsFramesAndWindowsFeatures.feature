Feature: AlertsFramesAndWindowsFeatures


 Background:
    Given Windows : I open a web browser and Launch Demo QA Site


Scenario: Validate  Windows Functionality.
        Given I navigate to the demo QA site FramesWindowAlert Page
        When  I navigate to browser windows page
        And   Select new Window
        Then  Validate user is able to handle Multiple window


Scenario: Validate  Alerts Functionality.
        Given I navigate to the demo QA site FramesWindowAlert Page
        When  I navigate to Alerts page
        And   Select new Alerts
        Then  Validate user is able to handle Alerts