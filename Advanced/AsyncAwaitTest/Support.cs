
class Computation
{
	private long CalculatedValue(int amount)
	{
		int t = Environment.TickCount + 100 * amount;
		while(Environment.TickCount < t);
		return amount * amount;
	}

	public long Compute(int first, int last)
	{
		return Enumerable.Range(first, last)
				.AsParallel()
				.Select(CalculatedValue)
				.Sum();
	}

	public Task<long> ComputeAsync(int first, int last)
	{
		return Task<long>.Run(() => Compute(first, last));
	}
}

