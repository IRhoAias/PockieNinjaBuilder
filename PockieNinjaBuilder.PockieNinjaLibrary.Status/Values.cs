namespace PockieNinjaBuilder.PockieNinjaLibrary.Status
{
	public class Values
	{
		public string name;

		public int value;

		public new virtual string ToString()
		{
			return name + ": " + value;
		}
	}
}
