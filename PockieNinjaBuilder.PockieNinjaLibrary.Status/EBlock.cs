namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class EBlock : Values
	{
		public EBlock(int val)
		{
			name = "Block Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
