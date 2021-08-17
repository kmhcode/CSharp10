static class Investment
{
	public static double Income(double sum, int years, bool risky)
	{
		float rate = risky ? 8 : 6;
		double amount = sum * Math.Pow(1 + rate / 100, years);
		return amount - sum;
	}

	public static double Income(double sum, int years=1)
	{
		return Income(sum, years, sum < 25000);
	}
}
