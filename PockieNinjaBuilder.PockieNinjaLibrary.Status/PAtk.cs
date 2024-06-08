namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class PAtk : Values
	{
		public PAtk(int val)
		{
			name = "Attack";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
