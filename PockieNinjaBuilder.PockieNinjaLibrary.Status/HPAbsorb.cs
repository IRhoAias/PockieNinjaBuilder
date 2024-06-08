namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class HPAbsorb : Values
	{
		public HPAbsorb(int val)
		{
			name = "HP Absorb";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
