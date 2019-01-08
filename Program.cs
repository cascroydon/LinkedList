using System;
using System.Collections.Generic;
using System.Linq;

class Example
{
	static void Main(string[] args)
	{
		LinkedList<object> LLs = new LinkedList<object>();
		LinkedList<object> LLi = new LinkedList<object>();

		LLs.AddLast("Smell");
		LLs.AddFirst("Dudeo");

		LLi.AddFirst(10);
		LLi.AddLast(9);

		IEnumerable<object> LL = LLs.Concat(LLi);

		Console.WriteLine("We have the following {0} items in the is the list.", LL.Count());

		foreach (var item in LL)
		{
			Console.WriteLine("Node's data is {0}", item);
		}
	}
}
