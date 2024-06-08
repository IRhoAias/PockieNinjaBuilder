namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Fire : Values
	{
		public Fire(int val)
		{
			name = "Fire";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
