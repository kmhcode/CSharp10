#nullable disable

using System.Collections;

namespace LinqTest
{
	partial class SimpleStack<V> : IEnumerable<V>
	{
		class Node
		{
			internal V Value;
			internal Node Below;
		}

		private Node top;

		public void Push(V item)
		{
			top = new Node {Value=item, Below=top};
		}

		public V Pop()
		{
			V item = top.Value;
			top = top.Below;
			return item;
		}	

		public bool Empty()
		{
			return top == null;
		}

		public void Add(V item) => Push(item);

		public IEnumerator<V> GetEnumerator()
		{
			for(Node n = top; n != null; n = n.Below)
				yield return n.Value;
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}

