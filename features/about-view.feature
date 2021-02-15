Feature: About view

As a I user I would like to view about details of a distribution list

Scenario: Click to about button when it is narrowed down
Given the browser window is narrowed down
And Fast OP is a DL
When I open the card Fast OP 
And click to About button
Then I should see the about details 