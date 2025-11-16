using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Boards
{
	/// <summary>
	/// Representation of a set of boards in a board game.
	/// </summary>
	/// <typeparam name="TBoardCellWeb">Type of board cell web used for positioning things</typeparam>
	public interface IBoardSet<TBoardCellWeb>
		where TBoardCellWeb : IBoardCellWeb
	{
		IEnumerable<IBoard<TBoardCellWeb>> Boards { get; }
	}
}
