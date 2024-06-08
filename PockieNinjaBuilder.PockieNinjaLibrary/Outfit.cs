using System.Drawing;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class Outfit
	{
		public int id { get; set; }

		public string name { get; set; }

		public Bitmap image { get; set; }

		public Bitmap pimage { get; set; }

		public int[] record { get; set; }

		public string type { get; set; }

		public string release { get; set; }

		public int str_init { get; set; }

		public int agi_init { get; set; }

		public int sta_init { get; set; }

		public double str_mul_init { get; set; }

		public double agi_mul_init { get; set; }

		public double sta_mul_init { get; set; }

		public int bmv_str { get; set; }

		public int bmv_agi { get; set; }

		public int bmv_sta { get; set; }

		public bool chinese { get; set; }
	}
}
