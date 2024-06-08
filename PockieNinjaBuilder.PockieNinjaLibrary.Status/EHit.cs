namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class EHit : Values
	{
		public EHit(int val)
		{
			name = "Hit Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
