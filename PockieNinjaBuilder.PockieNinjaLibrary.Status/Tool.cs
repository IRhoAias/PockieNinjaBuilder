namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Tool : Values
	{
		public Tool(int val)
		{
			name = "Ninja Tools";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
