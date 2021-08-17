using static Support;

if(args.Length > 0)
{		
	int i = int.Parse(args[0]);
	string ss = Select(i, "Monday", "Friday");
	Console.WriteLine($"Selected string = {ss}");
	double sd = Select(i, 3.45, 5.43);
	Console.WriteLine($"Selected double = {sd}");
	Interval si = Select(i, new Interval(7, 20), new Interval(6, 30));
	Console.WriteLine($"Selected Interval = {si}");
}
else
{
	string ss = Select("Monday", "Friday");
	Console.WriteLine($"Selected string = {ss}");
	double sd = Select(3.45, 5.43);
	Console.WriteLine($"Selected double = {sd}");
	Interval si = Select(new Interval(7, 20), new Interval(6, 30));
	Console.WriteLine($"Selected Interval = {si}");
}

