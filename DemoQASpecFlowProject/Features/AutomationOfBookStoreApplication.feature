Feature: AutomationOfBookStoreApplication

 Background:
    Given BookStore:I open a web browser and Launch Demo QA Site

    Scenario: Register user and login with the registered credentials
    Given I navigate to the demo QA site Book store  Page
    When I register for new user
    And I navigate to Login page
    Then Validate user should be able to login successfully


