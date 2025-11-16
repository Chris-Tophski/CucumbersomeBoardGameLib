using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Tokens
{
	/// <summary>
	/// Representation of a token, optionally assigned to a player, board, meeple etc.
	/// </summary>
	public interface IToken<TTokenType, TTokenState>
		where TTokenType : ITokenType
		where TTokenState : ITokenState
	{
		TTokenType Type { get; }
		TTokenState State { get; }
	}
}
