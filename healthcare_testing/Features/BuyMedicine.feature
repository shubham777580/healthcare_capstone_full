Feature: BuyMedicine

A short summary of the feature

@tag21
Scenario: We need to buy 2 products/medicine and confirm order
	Given we have navigated to website
	When Add medicine/product 1
	When Add medicine/product 2
	Then Click cart button
	Then Cart page opens up
	Then Click on order confirm
	Then clear the old cart products
