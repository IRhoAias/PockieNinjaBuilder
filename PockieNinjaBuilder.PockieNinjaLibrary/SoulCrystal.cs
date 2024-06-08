using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class SoulCrystal
	{
		public int id { get; set; }

		public int rarity { get; set; }

		public string name { get; set; }

		public Values value { get; set; }

		public int growth { get; set; }

		public string ToStringVal(int level)
		{
			if (value.GetType().Name.Equals("Speed"))
			{
				return value.name + ": " + ((double)value.value + (double)growth * (double)(level - 1)) / 10.0 + "%";
			}
			return value.name + ": " + (value.value + growth * (level - 1));
		}
	}
}
