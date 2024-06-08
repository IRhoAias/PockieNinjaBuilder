namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Earth : Values
	{
		public Earth(int val)
		{
			name = "Earth";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
