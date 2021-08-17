
interface IStackReader<out V>
{
	V Pop();
	bool Empty();
}

partial class SimpleStack<V> : IStackReader<V>
{
}

static class Support
{
	public static void PopPrint(IStackReader<object> store)
	{
		for(int n = 0; !store.Empty(); ++n)
		{
			if(n > 0)
				Console.Write(", ");
			Console.Write(store.Pop());
		}
		Console.WriteLine();
	}
}

