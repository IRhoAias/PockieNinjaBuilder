namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Illusion : Values
	{
		public Illusion(int val)
		{
			name = "Illusion";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
