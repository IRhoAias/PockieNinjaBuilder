namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class PHP : Values
	{
		public PHP(int val)
		{
			name = "HP";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
