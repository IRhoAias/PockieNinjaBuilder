namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Sealing : Values
	{
		public Sealing(int val)
		{
			name = "Sealing Jutsu";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
