﻿Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowBasic/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should "PASSED"


	Scenario Outline: Working with Tables
	Given I input following numbers to the calculator
		| Numbers |
		| 50      |
		| 80      |
	When the two numbers are added
	Then I see the result and few more details
		| Results | Logo |
		| 120     | plus |
	Then the result should "PASSED"
