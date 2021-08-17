float SilverScheme(int y) 
{
	return y < 3 ? 6 : 7;
}

double p = double.Parse(args[0]);
int n = int.Parse(args[1]);
Investment inv = new Investment(p, n);
Console.WriteLine("Income in Silver Scheme: {0:0.00}", inv.GetIncome(SilverScheme));
Console.WriteLine("Income in Gold Scheme: {0:0.00}", inv.GetIncome(y => 8 + 0.1f * y));

