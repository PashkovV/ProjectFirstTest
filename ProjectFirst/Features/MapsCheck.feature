Feature: Maps
	The User want to check maps


Scenario: Maps check
Given The User on the home page "https://www.bing.com/"
When The User press 'Maps'
Then The maps page opens "https://www.bing.com/maps?FORM=Z9LH2"