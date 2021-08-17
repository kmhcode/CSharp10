double s = double.Parse(args[0]);
if(args.Length > 1)
{
	int y = int.Parse(args[1]);
	Console.WriteLine("Income in no-risk scheme: {0:0.00}", Investment.Income(s, y, false));
	Console.WriteLine("Income in low-risk scheme: {0:0.00}", Investment.Income(s, y, true));
}
else
{
	Console.WriteLine("Income in smart scheme: {0:0.00}", Investment.Income(s));
}
