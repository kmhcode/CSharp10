delegate float Scheme(int period);

class Investment 
{
	private double invest;
	private int years;

	public Investment(double amount, int period)
	{
		invest = amount;
		years = period;
	}

	public double GetIncome(Scheme interest)
	{
		float rate = interest(years);
		double amount = invest * Math.Pow(1 + rate / 100, years);
		return amount - invest;
	}

}

