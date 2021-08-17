using static Support;

Interval a = new Interval(5, 15);
Print(a, "first");
Interval b = new Interval(3, 50);
Print(b, "second");
Interval c = a + b;
Print(c, "sum");
if(args.Length > 0)
{
	Interval i = Interval.Parse(args[0]);
	if(Match(i, a, b, c))
		Console.WriteLine("Found match!");
	else
		Console.WriteLine("No match found!");
}
Rectangle d = new Rectangle(30, 29);
Print(d, "frame");

