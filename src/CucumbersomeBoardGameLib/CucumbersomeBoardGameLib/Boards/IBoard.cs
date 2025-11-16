using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Boards
{
	/// <summary>
	/// Representation of a single board in a board game.
	/// </summary>
	/// <typeparam name="TBoardCellWeb">Type of board cell web used for positioning things</typeparam>
	public interface IBoard<TBoardCellWeb>
		where TBoardCellWeb : IBoardCellWeb
	{
		TBoardCellWeb Cells { get; }
	}
}
