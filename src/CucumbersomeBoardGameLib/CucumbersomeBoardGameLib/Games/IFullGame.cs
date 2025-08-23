using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Games
{
	/// <summary>
	/// Base interface for games with full support of all game types
	/// </summary>
	public interface IFullGame
		: IGame, ICardsGame, IDiceGame, IMeeplesGame, ITokensGame
	{

	}
}
