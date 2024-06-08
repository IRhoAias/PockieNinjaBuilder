namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class EArmorBreak : Values
	{
		public EArmorBreak(int val)
		{
			name = "Armor Break Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
