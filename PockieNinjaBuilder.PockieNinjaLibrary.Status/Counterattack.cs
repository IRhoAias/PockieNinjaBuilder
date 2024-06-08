namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Counterattack : Values
	{
		public Counterattack(int val)
		{
			name = "Counteratk";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
