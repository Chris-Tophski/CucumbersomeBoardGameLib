using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Boards
{
	/// <summary>
	/// Representation of a transition of a meeple or token from one board cell within the web to another one
	/// </summary>
	public interface IBoardCellTransition
	{
		IBoardCell FromCell { get; }
		IBoardCell ToCell { get; }
	}
}
