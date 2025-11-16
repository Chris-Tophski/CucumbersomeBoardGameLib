using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Meeples
{
	/// <summary>
	/// Representation of a meeple associated to a player, NPC, enemy, bank etc.
	/// </summary>
	public interface IMeeple<TMeepleState>
		where TMeepleState : IMeepleState
	{
		TMeepleState State { get; }
	}
}
