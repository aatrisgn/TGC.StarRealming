# Domain entities

This requirement file describes the domain entities used for StarRealming. The application is based on the deck-building game Star Realms and is for tracking scores over a prolonged period of time.

All domain entities will have a last udpdated, created, active, last updated by and created by property

## Profile

Each player will have a profile. The profile entity will be related to the technical side of the player. This will be for containing information in relation to login. Azure B2C is expected to be used for login. The profile entity will therefore contain a shadow copy of some of the information for the Azure B2C profile. This would be email and ID.

## Player

The player entity will contain information about the game-side of the profile. Player is the domain-relevant side, whereas profile is the technical-side.

The player entity will have a player name, catch phrase and link to a profile picture.

## Game

The game entitiy will be used to reflect a match between two players. It should reflect who won, who lost, the life of the winner when match is over, optional reference to which tournament it was part of, if not part of a tournament, which league season it was part of, notes about the game and an optional summary. It should also have to values indicating whether a game was accepted by both players. The accceptance of a game can be pending, accepted, denied for both players.

Players in a game refer to the domain entity Player.

Game can only invole 1v1.

## League

A league is a representation of an unknown amount of league seasons for a given period of time. The league entity needs a name, a catch phrase and logo. It also needs a list of League admins who can administer it. League admins are players with special priviledges to manage the league, such as creating and closing league seasons.

The league will hold historic numbers of game results, but the data is represented on the games. Since no player can win a league, they win seasons, there is never a winner - Just historic records.

## League Season

A league season is a undefined list of games within a start date and end date. A league season can have a set of players associated who participate in said season. There should also be a winner of the given league season as well as standing. The season needs a description. A given league season can have one or many tournaments. Tournaments games doesn't count towards the league season score.

The winner of a league season will reference a player. The player will automatically be set when the season is completed. A season can be marked as completed by an admin.

The standing in a league is expected to be based on games won and the average life left of games won. That means, it can always deterministically be calculated by related games. There is no reason to store any standings since they can always be computed.

## Tournament

A tournament represents a fixed amount of games depending on the tournament type and number of players.

A tournament can be of three types: Round Robin, knock-out, group knock-out.

Round Robin requires three or more players.

Knock-out requires 4 or more players (Preferably, an equal amount of players)

Group-knockout requires at least 5 players, but preferably a number divisionable by 4.

## League Admins

Legaue admins is a mapping between players and leagues. Any number of players can be admins and a single player can be admin on multiple leagues. This should be a navigation property on league, but described as its own entity.