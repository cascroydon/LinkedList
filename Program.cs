using System;
using System.Collections;

class Example
{
	public class MyList : IEnumerable
	{
		private class Link : IEnumerable
		{
			public object content;
			Link next = null;

			public Link(object content, Link next = null)
			{
				this.content = content;
				this.next = next;
			}

			public IEnumerator GetEnumerator()
			{
				return GetEnumerator(this);
			}

			static public IEnumerator GetEnumerator(Link link)
			{
				return new LinkWalker(link);
			}

			private class LinkWalker : IEnumerator
			{
				Link start;
				Link current;

				public object Current => current.content;

				public LinkWalker(Link start)
				{
					this.start = new Link(null, start);
					Reset();
				}

				public bool MoveNext()
				{
					current = current.next;
					return current != null;
				}

				public void Reset()
				{
					current = start;
				}
			}

			public Link Next(Link next)
			{
				this.next = next;
				return next;
			}
		}

		int count;
		Link head;
		Link tail;

		public void Clear()
		{
			count = 0;
			head = null;
			tail = null;
		}

		public MyList()
		{
			Clear();
		}

		public IEnumerator GetEnumerator()
		{
			return Link.GetEnumerator(head);
		}

		public bool IsEmpty()
		{
			return count == 0;
		}

		void CreateList(object content)
		{
			head = tail = new Link(content);
			count = 1;
		}

		public void AddFirst(object content)
		{
			if (IsEmpty())
			{
				CreateList(content);
			}
			else
			{
				head = new Link(content, head);
				count++;
			}
		}

		public void AddLast(object content)
		{
			if (IsEmpty())
			{
				CreateList(content);
			}
			else
			{
				tail = tail.Next(new Link(content));
				count++;
			}
		}

		public int Count()
		{
			return count;
		}

		public void Concatenate(MyList list)
		{
			if (!list.IsEmpty())
			{
				if (IsEmpty())
				{
					head = list.head;
					tail = list.tail;
					count = list.count;
				}
				else
				{
					tail.Next(list.head);
					tail = list.tail;
					count += list.count;
				}
				list.Clear();
			}
		}
	}

	static void Main(string[] args)
	{
		MyList LLs = new MyList();
		MyList LLi = new MyList();

		LLs.AddLast("Smell");
		LLs.AddFirst("Dudeo");

		LLi.AddFirst(10);
		LLi.AddLast(9);

		LLs.Concatenate(LLi);

		Console.WriteLine("We have the following {0} items in the is the list.", LLs.Count());

		foreach (var item in LLs)
		{
			Console.WriteLine("Node's data is {0}", item);
		}
	}
}
