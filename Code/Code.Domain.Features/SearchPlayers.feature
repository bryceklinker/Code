Feature: Search for players

Background:
	Given a set of players

@mytag
Scenario: Search for players by name
	Given a player with name Neymar
	When I enter Ney as name
	And I search
	Then I get Neymar in results

Scenario: Search for players by potential
	When I enter potential 100
	And I search
	Then I get every player with potential greater than or equal to 100

Scenario: Search for players by current ability
	When I enter current ability 100
	And I search
	Then I get every player with current ability greater than or equal to 100

Scenario: Search for players by position
	When I enter position central midfield
	And I search
	Then I get every player with position central midfield

Scenario: Search for players by age
	When I enter age 20
	And I search
	Then I get every player with age less than or equal to 20
