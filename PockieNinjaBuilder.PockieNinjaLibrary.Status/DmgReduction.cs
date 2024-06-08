namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class DmgReduction : Values
	{
		public DmgReduction(int val)
		{
			name = "Reduce dmg";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + (double)value / 10.0 + "%";
		}
	}
}
