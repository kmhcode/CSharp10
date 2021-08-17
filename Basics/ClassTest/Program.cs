double s = double.Parse(args[0]);
int y = int.Parse(args[1]);
var inv = new Investment(s, y);
Console.WriteLine("Income in no-risk scheme: {0:0.00}", inv.Income());
inv.AllowRisk(true);
Console.WriteLine("Income in low-risk scheme: {0:0.00}", inv.Income());
#if !OLD_VERSION
inv.AdjustRisk(RiskLevel.High);
Console.WriteLine("Income in high-risk scheme: {0:0.00}", inv.Income());
#endif

