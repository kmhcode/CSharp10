namespace Greeting
{
	public class CasualGreeter
	{
		public string Meet(string visitor) => $"Hi {visitor}";

		public string Leave(string visitor) => $"Bye {visitor}";

	}
	
	public class FormalGreeter
	{
		public string Meet(string visitor) => $"Hello {visitor}";	
	}
}
