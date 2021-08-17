async Task DoComputation(int count)
{
	Console.Write("Computing");
	var c = new Computation();
	int t1 = Environment.TickCount;
	var r = await c.ComputeAsync(1, count);
	int t2 = Environment.TickCount;
	Console.WriteLine("Done!");
	Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, 0.001 * (t2 - t1));
}

int n = args.Length > 0 ? int.Parse(args[0]) : 10;
var job = DoComputation(n);
while(!job.IsCompleted)
{
	Console.Write(".");
	Task.Delay(500).Wait();
}

