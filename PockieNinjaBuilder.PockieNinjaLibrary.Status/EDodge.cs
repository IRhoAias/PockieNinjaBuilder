namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class EDodge : Values
	{
		public EDodge(int val)
		{
			name = "Dodge Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
