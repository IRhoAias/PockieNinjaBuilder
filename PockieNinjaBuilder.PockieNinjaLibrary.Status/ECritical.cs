namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class ECritical : Values
	{
		public ECritical(int val)
		{
			name = "Critical Strike Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
