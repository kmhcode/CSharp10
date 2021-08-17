using static Support;

switch(args[0])
{
	case "gcd":
		long m = long.Parse(args[1]);
		long n = long.Parse(args[2]);
		Console.WriteLine(GreatestDivisor(m, n));
		break;
	case "reverse":
		var buf = new StringBuilder(args[1].Length);
		ReverseString(args[1], buf);
		Console.WriteLine(buf);
		break;
	case "sequence":
		var bounds = new Limits
		{
			Begin = 1,
			End = int.Parse(args[1]) + 1
		};
		double sum = SequenceSum(t => 2 * t - 1, bounds);
		Console.WriteLine(sum);
		break;
	case "square":
		double[] list = args.Skip(1).Select(double.Parse).ToArray();
		SquareAll(list);
		foreach(double i in list)
			Console.WriteLine(i);
		break;
}

