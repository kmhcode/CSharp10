
partial class Interval
{
	public static Interval operator+(Interval lhs, Interval rhs)
	{
		return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
	}

	public static Interval Parse(string val)
	{
		string[] parts = val.Split(':');
		int m = int.Parse(parts[0]);
		int s = int.Parse(parts[1]);
		return new Interval(m, s);
	}
}

static class Support
{
	public static void Print(object obj, string label)
	{
		var t = obj.GetType();
		Console.WriteLine("{0} {1} = {2}", t.Name, label, obj);
	}

	public static bool Match(object key, params object[] items)
	{
		foreach(object item in items)
		{
			if(item.GetHashCode() == key.GetHashCode() && item.Equals(key))
				return true;
		}
		return false;
	}
}

