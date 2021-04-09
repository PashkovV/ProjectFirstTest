Feature: UserAuthorization
	The User want to be authorized on this page
	Before using it


Scenario: Authorization
	Given The User on the authorize page "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1617637152&rver=6.7.6631.0&wp=MBI_SSL&wreply=https%3a%2f%2fwww.bing.com%2fsecure%2fPassport.aspx%3frequrl%3dhttps%253a%252f%252fwww.bing.com%252f%253fsetlang%253den%2526wlexpsignin%253d1%26sig%3d28D4813AD3E86BCF0352912AD2246A84&lc=1033&id=264960&CSRFToken=70901764-0d7d-491d-b496-16910677a374&aadredir=1"
		And The User enter correct login 
		And The User enter correct password 
	When The User press the 'Sign in' button
	Then The home page opens "https://www.bing.com/" 