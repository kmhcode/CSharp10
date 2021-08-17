try
{
	IConsumer a = new ResourceConsumer("First");
	a.Apply(1);
	a.Dispose();
	int m = int.Parse(args[0]);
	IConsumer b = new ResourceConsumer("Second");
	b.Consume(m);
	int n = int.Parse(args[1]);
	using(IConsumer c = new ResourceConsumer("Third")){
		c.ApplyAll(n);
	}
}
catch {}

