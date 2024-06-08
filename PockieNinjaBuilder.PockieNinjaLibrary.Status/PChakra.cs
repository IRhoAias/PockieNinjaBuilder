namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class PChakra : Values
	{
		public PChakra(int val)
		{
			name = "Chakra";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
