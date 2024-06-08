namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Wind : Values
	{
		public Wind(int val)
		{
			name = "Wind";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
