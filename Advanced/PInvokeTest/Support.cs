

global using System.Text;
using System.Runtime.InteropServices;

class Support
{
	[DllImport("natsup", EntryPoint="GCD")]
	public extern static long GreatestDivisor(long first, long second);

	[DllImport("natsup")]
	public extern static int ReverseString(string original, StringBuilder reversed);

	public struct Limits
	{
		public int Begin, End;
	}

	public delegate float Sequence(int at);

	[DllImport("natsup")]
	public extern static double SequenceSum(Sequence seq, in Limits lim);

	public unsafe static void SquareAll(double[] values)
	{
		fixed(double* buf = &values[0])
		{
			for(int i = 0; i < values.Length; ++i)
				buf[i] *= buf[i];
		}
	}
}

