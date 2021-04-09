Feature: Language change
	For using this portal
	The User want to be able to change language on the page

@mytag
Scenario Outline: Language change
	Given The User on the language change page "https://www.bing.com/account/general?ru=https%3a%2f%2fwww.bing.com%2f&FORM=O2HV65&id=language_section#language-section"
	When The User press language <language>
	Then The User redirected to the home page "https://www.bing.com/"
	And The User see the button with label <buttonLabel>
	| language  | buttonLabel |
	| Ukrainian | Зображення  |
	| Russian   | Изображения |
	| English   | Images      |

