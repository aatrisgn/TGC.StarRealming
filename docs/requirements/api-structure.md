# API Structure

This requirement describes how the API presentation layer should work and which endpoints to create.

Currently there is no Database integration, so just create the scaffolding.

## API Structure

- Prefer controllers over minimal apis
- Always use Request / response pattern for API endpoints
- Each endpoint should have its own Query or Command definition inside application depending on whether it is GET or PUT/POST/DELETE/PATCH.

Since I would like to use onion architecture / Clean architecture, I want to implement a mediator pattern. Inside the package TGC.Api.Communication there is already an interface called IMediator which can be used for Command / Queries. The command / queries needs to implement either BaseQuery or BaseCommand from same repo. For each API action, I want a QueryHandler/CommandHandler. The interfacing is already added and just needs to be re-used by implementing the interfaces. The query/command handlers should return result/IResult which contains a definition whether the action failed or not, and if it didn't fail, then the result. Upon failure, it returns the relevant statuscode to return to the caller.

## API Authentication
- Add default authentication to use Azure B2C. Leave the configuration values empty for now.

## API Endpoints
Create the following endpoints in lower capitalization:

- GET: /players/{PLAYER_ID} --> Get specific player by ID
- GET: /Players/{PLAYER_ID}/games --> Get all games a given player has participated in
- POST: /Players --> Create new player based on a reference to profile. The profile reference should be passed in the body.
- PUT: /Players/{PLAYER_ID} --> Update existing player

- POST: /Profiles --> Create new profile
- GET: /Profiles/{PROFILE_ID} --> Get profile by ID
- PUT: /Profiles/{PROFILE_ID} --> Update profile

- GET: /leagues --> Get all leagues
- GET: /leagues/my/{PLAYER_ID} --> Get all leagues associated with a given user
- DELETE: /leagues/{LEAGUE_ID} --> Deactivates league

- GET: /leagues/{LEAGUE_ID}/seasons --> Get all league seasons
- GET: /leagues/{LEAGUE_ID}/seasons/{season_id}/tournaments --> Get all tournaments associated with a league season
- GET: /leagues/{LEAGUE_ID}/seasons/{season_id}/tournaments/{tournament_id} --> Get a specific tournament from a league season
- GET: /leagues/{LEAGUE_ID}/seasons/{season_id}/games --> Get all games associated with a league season
- GET: /leagues/{LEAGUE_ID}/seasons/{season_id}/games/{GAME_ID} --> Get a specific game from a league season
- DELETE: /leagues/{LEAGUE_ID}/seasons/{season_id} --> Deactivate season

- GET: /tournaments/{tournament_id} --> Get a specific tournament more broadly searched
- GET: /tournaments/my/{PLAYER_ID} --> Get all tournaments associated with a given user
- DELETE: /tournaments/{tournament_id} --> Deactivates a given tournament

- GET: /games/{GAME_ID} --> Get specific game
- GET: /games/search --> Search after a game based on query parameters. This could be players attending a game, the summary or date. The results should be paginated in pages of 100 with query parameter for page as well.
- GET: /games/my/{PLAYER_ID} --> Get paginated games in bunch of 100 based on player id. Page should be added as query paremeter
- POST: /games --> create new game. Since this game is initiated by one of the players, the game should initially be accepted by player 1, but player 2 should be pending.
- PUT: /games/{GAME_ID} update an existing game. Both acceptance status, point updates, who was winner, etc.
- DELETE: /games/{GAME_ID} --> Deactivates a game
