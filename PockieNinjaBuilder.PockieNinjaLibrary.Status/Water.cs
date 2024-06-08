namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Water : Values
	{
		public Water(int val)
		{
			name = "Water";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
