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
	Given a player with potential abliity 150
	When I enter potential 100
	And I search
	Then I get every player with potential greater than or equal to 100

Scenario: Search for players by current ability	
	Given a player with current ability 150
	When I enter current ability 100
	And I search
	Then I get every player with current ability greater than or equal to 100

Scenario: Search for players by position
	Given a player with ability 15 in central midfield
	When I enter position central midfield
	And I enter ability in position 15
	And I search
	Then I get every player with ability in central midfield greater than or equal to 15

Scenario: Search for players by age
	Given a player with age 19
	When I enter age 20
	And I search
	Then I get every player with age less than or equal to 20
