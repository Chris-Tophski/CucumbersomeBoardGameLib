using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Players
{
	/// <summary>
	/// Some games may assign different roles to different players,
	/// such that players may have different sets of actions to their disposal
	/// or may have to attempt different goals.
	/// A role may be openly known by the other players or held secret in some games.
	/// In games without multiple player roles, a common default role should be assigned.
	/// </summary>
	public interface IPlayerRole
	{

	}
}
