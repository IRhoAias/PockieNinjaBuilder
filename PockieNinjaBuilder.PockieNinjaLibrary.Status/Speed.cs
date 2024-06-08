namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Speed : Values
	{
		public Speed(int val)
		{
			name = "Speed";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
