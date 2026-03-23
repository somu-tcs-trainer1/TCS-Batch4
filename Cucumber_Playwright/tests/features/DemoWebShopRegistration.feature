
#Feature: Tests of DemoWebshop Registration Page
    #Scenario: Verify User Registration for valid details
        #Given I am on demowebshop register page
        #When I fill the mandatory fields
        #And I click on Register
        #Then I should see the message for succesful user registration
        #And the successful user is already logged in

    #Scenario: Verify User Registration Unsuccessful for invalid details
        #Given I am on demowebshop register page
        #When I don't fill all the mandatory fields
        #And I click on Register
        #Then I should see the error message asking to enter all mandatory details