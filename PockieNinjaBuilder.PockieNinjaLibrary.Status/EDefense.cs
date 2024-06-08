namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class EDefense : Values
	{
		public EDefense(int val)
		{
			name = "Defense Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
