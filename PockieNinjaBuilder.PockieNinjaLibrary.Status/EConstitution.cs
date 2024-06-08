namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class EConstitution : Values
	{
		public EConstitution(int val)
		{
			name = "Constitution Enhance";
			value = val;
		}

		public override string ToString()
		{
			return name + ": " + value + "%";
		}
	}
}
