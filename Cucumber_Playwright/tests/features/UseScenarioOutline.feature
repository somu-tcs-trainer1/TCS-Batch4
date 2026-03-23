Feature: Example of using Scenario Outline
    Scenario Outline: Implementing Scenario Outline
        Given I am on the page "<url>"
        When I want to enter <employee ID>
        
Examples:
|url|                                   employee ID |
|"https://demowebshop.tricentis.com/"|  34 |
|"https://testautomationpractice.blogspot.com/"|24 |
|"https://playwright.dev/"| 56 |

