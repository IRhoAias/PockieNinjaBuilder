namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Lightning : Values
	{
		public Lightning(int val)
		{
			name = "Lightning";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
