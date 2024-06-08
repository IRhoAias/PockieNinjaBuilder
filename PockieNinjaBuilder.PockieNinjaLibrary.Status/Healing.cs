namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Healing : Values
	{
		public Healing(int val)
		{
			name = "Healing";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
