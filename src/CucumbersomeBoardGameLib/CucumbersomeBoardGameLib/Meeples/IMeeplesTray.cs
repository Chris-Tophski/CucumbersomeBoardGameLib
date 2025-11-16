using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Meeples
{
	/// <summary>
	/// Representation of a tray of meeples
	/// </summary>
	public interface IMeeplesTray<TMeepleState>
		where TMeepleState : IMeepleState
	{
		IEnumerable<IMeeple<TMeepleState>> Meeples { get; }
	}
}
