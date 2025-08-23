# CucumbersomeBoardGameLib
.net Library for board games with cards, meeples, tokens, dice and rules on them

## License and status
This library is in an unreleased, experimental status and has no license applied to it, yet.

## See also
This library is intended to provide a broad framework for all sorts of board, card, dice and hybrid games.
* For battle card games, see [the C# Battle Card Game Framework (CSBCGF)](https://github.com/finkmoritz/csbcgf).
* For rolling dice, see [DiceRoller](https://github.com/skizzerz/DiceRoller) for example.

## Steps to implement a game
Depending on the game rules, you will have to implement certain interfaces for game logic, setup logic, rules, and other things your game needs.
For example, if you intend to create a game, in which you need cards and dice, you need implementations of `ICard` and `IDie` specific to your game.
You should create a library for your game, that uses this framework and implements some interfaces of it.

1. Collect information about your game. Define the rules. Define, how many players can play it. Define instructions for game setup, playing in rounds, when is who's turn etc.
2. Implement a game class based on `IGame`, `IFullGame` or one or more of the more specific game types like `ICardsGame`, `ITokensGame` etc.
3. Implement classes for elements used by the game, like `ICard`, `IDie`, `IWheel` etc.
4. Implement rules

## Run an implemented game
In your app or service, you should use your library with your specific implementation, but keep in mind, you might need this library as a dependency, too.
1. Use a game builder for creating a new game or use a game serializer for (de)serialization of a game from an external source.
2. Start the game and react to events, until the game's state machine is finished.
3. Cleanup resources, if necessary.
