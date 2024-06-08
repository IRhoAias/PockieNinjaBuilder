namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class EPierce : Values
	{
		public EPierce(int val)
		{
			name = "Pierce Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
