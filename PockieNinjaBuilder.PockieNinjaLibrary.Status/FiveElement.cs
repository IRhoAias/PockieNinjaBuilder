namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class FiveElement : Values
	{
		public FiveElement(int val)
		{
			name = "Five Elements";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
