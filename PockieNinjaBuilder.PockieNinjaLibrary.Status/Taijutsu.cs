namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Taijutsu : Values
	{
		public Taijutsu(int val)
		{
			name = "Taijutsu";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
