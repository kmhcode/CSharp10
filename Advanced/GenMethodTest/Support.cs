partial class Interval : IComparable<Interval>
{
	public int CompareTo(Interval? that)
	{
		return this.GetTime() - that!.GetTime();
	}
}

static class Support
{
	public static T Select<T>(int index, T first, T second)
	{
		if((index % 2) == 1)
			return first;
		return second;
	}

	public static T Select<T>(T first, T second) where T : IComparable<T>
	{
		if(first.CompareTo(second) > 0)
			return first;
		return second;
	}
}

