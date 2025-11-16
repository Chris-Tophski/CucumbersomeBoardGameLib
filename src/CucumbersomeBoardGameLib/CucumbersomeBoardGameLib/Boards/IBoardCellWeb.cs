using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Boards
{
	/// <summary>
	/// Representation of the web of cells on a board
	/// </summary>
	public interface IBoardCellWeb
	{
		IEnumerable<IBoardCell> Cells { get; }
	}
}
