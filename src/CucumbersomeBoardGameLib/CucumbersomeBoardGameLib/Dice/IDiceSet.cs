using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumbersomeBoardGameLib.Dice
{
	public interface IDiceSet
	{
		IDiceRoll<TKey, TValue> Roll<TKey, TValue>();
	}
}
