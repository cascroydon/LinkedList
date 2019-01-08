using System;
using System.Collections.Generic;

class Example
{
	static void Main(string[] args)
	{
		LinkedList<String> LLs = new LinkedList<string>();
		LinkedList<int> LLi = new LinkedList<int>();

		LLs.AddLast("Smell");
		LLs.AddFirst("Dudeo");

		LLi.AddFirst(10);
		LLi.AddLast(9);

		// Linking the lists doesn't work
		//LLs.AddLast(LLi);

		Console.WriteLine("We have the following {0} items in the is the list.", LLs.Count);

		foreach (var item in LLs)
		{
			Console.WriteLine("Node's data is {0}", item);
		}
	}
}
