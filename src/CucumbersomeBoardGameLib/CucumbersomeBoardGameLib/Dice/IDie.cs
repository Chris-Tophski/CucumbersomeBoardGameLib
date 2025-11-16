using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Dice
{
	/// <summary>
	/// Representation of a single die for dice games
	/// </summary>
	public interface IDie<TValue>
	{
		TValue Roll();
		IEnumerable<TValue> Values { get; }
	}
}
