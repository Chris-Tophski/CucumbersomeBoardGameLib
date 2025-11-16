using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Tokens
{
	/// <summary>
	/// Representation of a tray of tokens
	/// </summary>
	public interface ITokenTray<TTokenType, TTokenState>
		where TTokenType : ITokenType
		where TTokenState : ITokenState
	{
		IEnumerable<IToken<ITokenType, ITokenState>> Tokens { get; }
	}
}
