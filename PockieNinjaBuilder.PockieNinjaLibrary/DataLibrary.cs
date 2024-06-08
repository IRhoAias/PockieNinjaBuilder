using PockieNinjaBuilder.PockieNinjaLibrary.Status;
using PockieNinjaBuilder.Properties;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class DataLibrary
	{
		public static string progname = "Pockie Ninja Builder";

		public static double version = 0.93;

		public static Values[][][] bankaistats = new Values[3][][]
		{
			new Values[10][]
			{
				new Values[3]
				{
					new Strength(40),
					new Agility(40),
					new Stamina(40)
				},
				new Values[3]
				{
					new Strength(60),
					new Agility(60),
					new Stamina(60)
				},
				new Values[3]
				{
					new Strength(80),
					new Agility(80),
					new Stamina(80)
				},
				new Values[3]
				{
					new Strength(100),
					new Agility(100),
					new Stamina(100)
				},
				new Values[3]
				{
					new Strength(120),
					new Agility(120),
					new Stamina(120)
				},
				new Values[3]
				{
					new Strength(140),
					new Agility(140),
					new Stamina(140)
				},
				new Values[3]
				{
					new Strength(160),
					new Agility(160),
					new Stamina(160)
				},
				new Values[3]
				{
					new Strength(180),
					new Agility(180),
					new Stamina(180)
				},
				new Values[3]
				{
					new Strength(200),
					new Agility(200),
					new Stamina(200)
				},
				new Values[3]
				{
					new Strength(220),
					new Agility(220),
					new Stamina(220)
				}
			},
			new Values[10][]
			{
				new Values[3]
				{
					new ArmorBreak(48),
					new Critical(36),
					new Dodge(36)
				},
				new Values[3]
				{
					new ArmorBreak(64),
					new Critical(48),
					new Dodge(48)
				},
				new Values[3]
				{
					new ArmorBreak(80),
					new Critical(60),
					new Dodge(60)
				},
				new Values[3]
				{
					new ArmorBreak(96),
					new Critical(72),
					new Dodge(72)
				},
				new Values[3]
				{
					new ArmorBreak(112),
					new Critical(84),
					new Dodge(84)
				},
				new Values[3]
				{
					new ArmorBreak(128),
					new Critical(96),
					new Dodge(96)
				},
				new Values[3]
				{
					new ArmorBreak(144),
					new Critical(108),
					new Dodge(108)
				},
				new Values[3]
				{
					new ArmorBreak(160),
					new Critical(120),
					new Dodge(120)
				},
				new Values[3]
				{
					new ArmorBreak(176),
					new Critical(132),
					new Dodge(132)
				},
				new Values[3]
				{
					new ArmorBreak(192),
					new Critical(144),
					new Dodge(144)
				}
			},
			new Values[10][]
			{
				new Values[3]
				{
					new PAtk(100),
					new Speed(100),
					new PHP(100)
				},
				new Values[3]
				{
					new PAtk(120),
					new Speed(120),
					new PHP(120)
				},
				new Values[3]
				{
					new PAtk(140),
					new Speed(140),
					new PHP(140)
				},
				new Values[3]
				{
					new PAtk(160),
					new Speed(160),
					new PHP(160)
				},
				new Values[3]
				{
					new PAtk(180),
					new Speed(180),
					new PHP(180)
				},
				new Values[3]
				{
					new PAtk(200),
					new Speed(200),
					new PHP(200)
				},
				new Values[3]
				{
					new PAtk(220),
					new Speed(220),
					new PHP(220)
				},
				new Values[3]
				{
					new PAtk(240),
					new Speed(240),
					new PHP(240)
				},
				new Values[3]
				{
					new PAtk(260),
					new Speed(260),
					new PHP(260)
				},
				new Values[3]
				{
					new PAtk(280),
					new Speed(280),
					new PHP(280)
				}
			}
		};

		public static SoulCrystal[] bankaicrystal = new SoulCrystal[54]
		{
			new SoulCrystal
			{
				id = 0,
				rarity = 0,
				name = "Sky",
				value = new Strength(8),
				growth = 4
			},
			new SoulCrystal
			{
				id = 1,
				rarity = 0,
				name = "Dusk",
				value = new Agility(8),
				growth = 4
			},
			new SoulCrystal
			{
				id = 2,
				rarity = 0,
				name = "Evil",
				value = new Stamina(8),
				growth = 4
			},
			new SoulCrystal
			{
				id = 3,
				rarity = 0,
				name = "Ice",
				value = new Defense(8),
				growth = 4
			},
			new SoulCrystal
			{
				id = 4,
				rarity = 0,
				name = "Slay",
				value = new MaxAtk(2),
				growth = 1
			},
			new SoulCrystal
			{
				id = 5,
				rarity = 0,
				name = "Chaos",
				value = new MinAtk(2),
				growth = 1
			},
			new SoulCrystal
			{
				id = 6,
				rarity = 1,
				name = "Gulf",
				value = new Strength(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 7,
				rarity = 1,
				name = "Oath",
				value = new Agility(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 8,
				rarity = 1,
				name = "Bone",
				value = new Stamina(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 9,
				rarity = 1,
				name = "Weep",
				value = new Defense(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 10,
				rarity = 1,
				name = "Time",
				value = new ArmorBreak(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 11,
				rarity = 1,
				name = "Dark",
				value = new Dodge(8),
				growth = 4
			},
			new SoulCrystal
			{
				id = 12,
				rarity = 1,
				name = "Moon",
				value = new Hit(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 13,
				rarity = 1,
				name = "Acme",
				value = new HP(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 14,
				rarity = 1,
				name = "Soul",
				value = new MaxAtk(4),
				growth = 2
			},
			new SoulCrystal
			{
				id = 15,
				rarity = 1,
				name = "Gust",
				value = new Speed(10),
				growth = 5
			},
			new SoulCrystal
			{
				id = 16,
				rarity = 1,
				name = "Dust",
				value = new Chakra(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 17,
				rarity = 1,
				name = "Hymn",
				value = new Critical(8),
				growth = 4
			},
			new SoulCrystal
			{
				id = 18,
				rarity = 1,
				name = "Atom",
				value = new Constitution(10),
				growth = 5
			},
			new SoulCrystal
			{
				id = 19,
				rarity = 1,
				name = "Wing",
				value = new Block(8),
				growth = 4
			},
			new SoulCrystal
			{
				id = 20,
				rarity = 1,
				name = "Wind",
				value = new Pierce(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 21,
				rarity = 1,
				name = "Pure",
				value = new MinAtk(4),
				growth = 2
			},
			new SoulCrystal
			{
				id = 22,
				rarity = 2,
				name = "Daft",
				value = new Strength(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 23,
				rarity = 2,
				name = "Bow",
				value = new Agility(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 24,
				rarity = 2,
				name = "Rosy",
				value = new Stamina(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 25,
				rarity = 2,
				name = "Loop",
				value = new Defense(22),
				growth = 11
			},
			new SoulCrystal
			{
				id = 26,
				rarity = 2,
				name = "Life",
				value = new ArmorBreak(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 27,
				rarity = 2,
				name = "Fly",
				value = new Dodge(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 28,
				rarity = 2,
				name = "Blow",
				value = new Hit(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 29,
				rarity = 2,
				name = "Kirin",
				value = new HP(22),
				growth = 11
			},
			new SoulCrystal
			{
				id = 30,
				rarity = 2,
				name = "Seal",
				value = new MaxAtk(6),
				growth = 3
			},
			new SoulCrystal
			{
				id = 31,
				rarity = 2,
				name = "Wolf",
				value = new Speed(16),
				growth = 8
			},
			new SoulCrystal
			{
				id = 32,
				rarity = 2,
				name = "Neat",
				value = new Chakra(22),
				growth = 11
			},
			new SoulCrystal
			{
				id = 33,
				rarity = 2,
				name = "Tone",
				value = new Critical(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 34,
				rarity = 2,
				name = "Iron",
				value = new Constitution(18),
				growth = 9
			},
			new SoulCrystal
			{
				id = 35,
				rarity = 2,
				name = "Imp",
				value = new Block(12),
				growth = 6
			},
			new SoulCrystal
			{
				id = 36,
				rarity = 2,
				name = "Pith",
				value = new Pierce(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 37,
				rarity = 2,
				name = "Doom",
				value = new MinAtk(6),
				growth = 3
			},
			new SoulCrystal
			{
				id = 38,
				rarity = 3,
				name = "Void",
				value = new Strength(30),
				growth = 15
			},
			new SoulCrystal
			{
				id = 39,
				rarity = 3,
				name = "Star",
				value = new Agility(30),
				growth = 15
			},
			new SoulCrystal
			{
				id = 40,
				rarity = 3,
				name = "Jade",
				value = new Stamina(30),
				growth = 15
			},
			new SoulCrystal
			{
				id = 41,
				rarity = 3,
				name = "Vajra",
				value = new Defense(34),
				growth = 17
			},
			new SoulCrystal
			{
				id = 42,
				rarity = 3,
				name = "Sky",
				value = new ArmorBreak(30),
				growth = 15
			},
			new SoulCrystal
			{
				id = 43,
				rarity = 3,
				name = "Mist",
				value = new Dodge(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 44,
				rarity = 3,
				name = "Hope",
				value = new Hit(30),
				growth = 15
			},
			new SoulCrystal
			{
				id = 45,
				rarity = 3,
				name = "Eden",
				value = new HP(34),
				growth = 17
			},
			new SoulCrystal
			{
				id = 46,
				rarity = 3,
				name = "Aim",
				value = new MaxAtk(10),
				growth = 5
			},
			new SoulCrystal
			{
				id = 47,
				rarity = 3,
				name = "Haze",
				value = new Speed(24),
				growth = 12
			},
			new SoulCrystal
			{
				id = 48,
				rarity = 3,
				name = "Omen",
				value = new Chakra(34),
				growth = 17
			},
			new SoulCrystal
			{
				id = 49,
				rarity = 3,
				name = "Fade",
				value = new Critical(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 50,
				rarity = 3,
				name = "Fall",
				value = new Constitution(28),
				growth = 14
			},
			new SoulCrystal
			{
				id = 51,
				rarity = 3,
				name = "Bane",
				value = new Block(20),
				growth = 10
			},
			new SoulCrystal
			{
				id = 52,
				rarity = 3,
				name = "Ruin",
				value = new Pierce(30),
				growth = 15
			},
			new SoulCrystal
			{
				id = 53,
				rarity = 3,
				name = "Aeon",
				value = new MinAtk(10),
				growth = 5
			}
		};

		public static int[][] pray;

		public static int[][][] forgeatk;

		public static int[][][] forgedef;

		public static double[] inscription;

		public static double[][] enhancementweapon;

		public static int[][] enhancementgear;

		public static Wing[] wings;

		public static string[] petcategories;

		public static PetSkill[] petskills;

		public static Pet[] pets;

		public static int[][][] zanpakuto;

		public static Title[] titles;

		public static int[][] maxValMatrix;

		public static Enchantment[] enchantments;

		public static Gem[] gems;

		public static Equipment[] equipment;

		public static Set[] sets;

		public static Bloodsoul[][] bloodsouls;

		public static int[] ninjarank;

		public static Values[][] records;

		public static Outfit[] outfits;

		public static Bloodline[] bloodlines;

		static DataLibrary()
		{
			int[][] array = new int[7][]
			{
				new int[21]
				{
					0, 5, 11, 18, 26, 35, 45, 56, 68, 81,
					95, 110, 126, 143, 161, 180, 200, 221, 243, 266,
					290
				},
				null,
				null,
				null,
				null,
				null,
				null
			};
			int[][] array2 = array;
			int[] array3 = new int[21];
			array2[1] = array3;
			int[][] array4 = array;
			array3 = new int[21];
			array3[4] = 33;
			array4[2] = array3;
			array[3] = new int[21]
			{
				0, 7, 15, 25, 36, 49, 63, 78, 95, 113,
				133, 154, 176, 200, 225, 252, 0, 0, 0, 0,
				0
			};
			array[4] = new int[21]
			{
				0, 8, 18, 29, 42, 56, 72, 90, 109, 130,
				152, 176, 202, 229, 258, 288, 322, 359, 399, 0,
				490
			};
			array[5] = new int[21]
			{
				0, 8, 18, 29, 42, 56, 72, 90, 109, 130,
				152, 176, 202, 229, 258, 288, 322, 359, 399, 0,
				490
			};
			array[6] = new int[21]
			{
				0, 8, 18, 29, 42, 56, 72, 90, 109, 130,
				152, 176, 202, 229, 258, 288, 322, 359, 399, 0,
				490
			};
			pray = array;
			int[][][] array5 = new int[8][][];
			int[][][] array6 = array5;
			array = new int[5][]
			{
				new int[2] { 2, 3 },
				null,
				null,
				null,
				null
			};
			int[][] array7 = array;
			array3 = new int[2];
			array7[1] = array3;
			int[][] array8 = array;
			array3 = new int[2];
			array8[2] = array3;
			int[][] array9 = array;
			array3 = new int[2];
			array9[3] = array3;
			int[][] array10 = array;
			array3 = new int[2];
			array10[4] = array3;
			array6[0] = array;
			int[][][] array11 = array5;
			array = new int[5][]
			{
				new int[2] { 2, 3 },
				null,
				null,
				null,
				null
			};
			int[][] array12 = array;
			array3 = new int[2];
			array12[1] = array3;
			int[][] array13 = array;
			array3 = new int[2];
			array13[2] = array3;
			int[][] array14 = array;
			array3 = new int[2];
			array14[3] = array3;
			int[][] array15 = array;
			array3 = new int[2];
			array15[4] = array3;
			array11[1] = array;
			int[][][] array16 = array5;
			array = new int[5][]
			{
				new int[2] { 2, 3 },
				null,
				null,
				null,
				null
			};
			int[][] array17 = array;
			array3 = new int[2];
			array17[1] = array3;
			int[][] array18 = array;
			array3 = new int[2];
			array18[2] = array3;
			int[][] array19 = array;
			array3 = new int[2];
			array19[3] = array3;
			int[][] array20 = array;
			array3 = new int[2];
			array20[4] = array3;
			array16[2] = array;
			int[][][] array21 = array5;
			array = new int[5][]
			{
				new int[2] { 2, 3 },
				null,
				null,
				null,
				null
			};
			int[][] array22 = array;
			array3 = new int[2];
			array22[1] = array3;
			int[][] array23 = array;
			array3 = new int[2];
			array23[2] = array3;
			int[][] array24 = array;
			array3 = new int[2];
			array24[3] = array3;
			int[][] array25 = array;
			array3 = new int[2];
			array25[4] = array3;
			array21[3] = array;
			int[][][] array26 = array5;
			array = new int[5][]
			{
				new int[2] { 2, 3 },
				null,
				null,
				null,
				null
			};
			int[][] array27 = array;
			array3 = new int[2];
			array27[1] = array3;
			int[][] array28 = array;
			array3 = new int[2];
			array28[2] = array3;
			int[][] array29 = array;
			array3 = new int[2];
			array29[3] = array3;
			int[][] array30 = array;
			array3 = new int[2];
			array30[4] = array3;
			array26[4] = array;
			int[][][] array31 = array5;
			array = new int[5][]
			{
				new int[2] { 3, 4 },
				null,
				null,
				null,
				null
			};
			int[][] array32 = array;
			array3 = new int[2];
			array32[1] = array3;
			int[][] array33 = array;
			array3 = new int[2];
			array33[2] = array3;
			int[][] array34 = array;
			array3 = new int[2];
			array34[3] = array3;
			int[][] array35 = array;
			array3 = new int[2];
			array35[4] = array3;
			array31[5] = array;
			int[][][] array36 = array5;
			array = new int[5][]
			{
				new int[2] { 3, 4 },
				new int[2] { 5, 7 },
				new int[2] { 9, 12 },
				null,
				null
			};
			int[][] array37 = array;
			array3 = new int[2];
			array37[3] = array3;
			int[][] array38 = array;
			array3 = new int[2];
			array38[4] = array3;
			array36[6] = array;
			int[][][] array39 = array5;
			array = new int[5][]
			{
				new int[2] { 4, 5 },
				new int[2] { 6, 8 },
				null,
				null,
				null
			};
			int[][] array40 = array;
			array3 = new int[2];
			array40[2] = array3;
			array[3] = new int[2] { 15, 19 };
			array[4] = new int[2] { 22, 27 };
			array39[7] = array;
			forgeatk = array5;
			array5 = new int[8][][]
			{
				new int[8][]
				{
					new int[0],
					new int[0],
					new int[0],
					new int[0],
					new int[0],
					new int[0],
					new int[0],
					new int[0]
				},
				null,
				null,
				null,
				null,
				null,
				null,
				null
			};
			int[][][] array41 = array5;
			array = new int[8][]
			{
				new int[5] { 12, 0, 0, 0, 0 },
				new int[5] { 15, 24, 0, 0, 0 },
				null,
				null,
				null,
				null,
				null,
				null
			};
			int[][] array42 = array;
			array3 = new int[5];
			array42[2] = array3;
			array[3] = new int[5] { 20, 0, 0, 0, 0 };
			array[4] = new int[5] { 23, 0, 0, 0, 0 };
			array[5] = new int[5] { 26, 41, 0, 0, 0 };
			array[6] = new int[5] { 28, 45, 78, 0, 0 };
			array[7] = new int[5] { 31, 49, 0, 0, 165 };
			array41[1] = array;
			array5[2] = new int[8][]
			{
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0]
			};
			array5[3] = new int[8][]
			{
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0],
				new int[0]
			};
			array5[4] = new int[8][]
			{
				new int[5] { 17, 0, 0, 0, 0 },
				new int[5] { 20, 0, 0, 0, 0 },
				new int[5] { 23, 0, 0, 0, 0 },
				new int[5] { 26, 0, 0, 0, 0 },
				new int[5] { 29, 0, 0, 0, 0 },
				new int[5] { 32, 0, 0, 0, 0 },
				new int[5] { 36, 57, 97, 0, 0 },
				new int[5] { 39, 62, 0, 0, 208 }
			};
			array5[5] = new int[8][]
			{
				new int[5] { 18, 0, 0, 0, 0 },
				new int[5] { 21, 0, 0, 0, 0 },
				new int[5] { 24, 0, 0, 0, 0 },
				new int[5] { 27, 0, 0, 0, 0 },
				new int[5] { 31, 0, 0, 0, 0 },
				new int[5] { 34, 54, 0, 0, 0 },
				new int[5] { 37, 60, 101, 0, 0 },
				new int[5] { 40, 65, 0, 146, 215 }
			};
			array5[6] = new int[8][]
			{
				new int[5] { 18, 0, 0, 0, 0 },
				new int[5] { 21, 0, 0, 0, 0 },
				new int[5] { 24, 0, 0, 0, 0 },
				new int[5] { 27, 0, 0, 0, 0 },
				new int[5] { 31, 0, 0, 0, 0 },
				new int[5] { 34, 54, 0, 0, 0 },
				new int[5] { 37, 60, 102, 0, 0 },
				new int[5] { 40, 65, 0, 0, 218 }
			};
			int[][][] array43 = array5;
			array = new int[8][]
			{
				new int[5] { 17, 0, 0, 0, 0 },
				new int[5] { 20, 0, 0, 0, 0 },
				null,
				null,
				null,
				null,
				null,
				null
			};
			int[][] array44 = array;
			array3 = new int[5];
			array44[2] = array3;
			array[3] = new int[5] { 27, 0, 0, 0, 0 };
			array[4] = new int[5] { 30, 0, 0, 0, 0 };
			array[5] = new int[5] { 33, 0, 0, 0, 0 };
			array[6] = new int[5] { 36, 58, 99, 0, 0 };
			array[7] = new int[5] { 40, 64, 0, 144, 212 };
			array43[7] = array;
			forgedef = array5;
			inscription = new double[17]
			{
				0.0, 0.033, 0.064, 0.107, 0.149, 0.183, 0.235, 0.288, 0.341, 0.393,
				0.451, 0.522, 0.605, 0.685, 0.781, 0.884, 1.0
			};
			double[][] array45 = new double[17][];
			double[] array46 = new double[2];
			array45[0] = array46;
			array45[1] = new double[2] { 0.04, 0.05 };
			array45[2] = new double[2] { 0.09, 0.1 };
			array45[3] = new double[2] { 0.14, 0.15 };
			array45[4] = new double[2] { 0.19, 0.2 };
			array45[5] = new double[2] { 0.24, 0.25 };
			array45[6] = new double[2] { 0.29, 0.3 };
			array45[7] = new double[2] { 0.34, 0.35 };
			array45[8] = new double[2] { 0.39, 0.4 };
			array45[9] = new double[2] { 0.44, 0.45 };
			array45[10] = new double[2] { 0.49, 0.5 };
			array45[11] = new double[2] { 0.54, 0.55 };
			array45[12] = new double[2] { 0.59, 0.6 };
			array45[13] = new double[2] { 0.64, 0.65 };
			array45[14] = new double[2] { 0.69, 0.7 };
			array45[15] = new double[2] { 0.74, 0.75 };
			array45[16] = new double[2] { 0.79, 0.8 };
			enhancementweapon = array45;
			array = new int[24][];
			int[][] array47 = array;
			array3 = new int[17];
			array47[0] = array3;
			array[1] = new int[17]
			{
				0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
				10, 11, 12, 13, 14, 15, 16
			};
			array[2] = new int[17]
			{
				0, 2, 4, 6, 8, 10, 12, 14, 16, 18,
				20, 22, 24, 26, 28, 30, 32
			};
			array[3] = new int[17]
			{
				0, 3, 6, 9, 12, 15, 18, 21, 24, 27,
				30, 33, 36, 39, 42, 45, 48
			};
			array[4] = new int[17]
			{
				0, 4, 8, 12, 16, 20, 24, 28, 32, 36,
				40, 44, 48, 52, 56, 60, 64
			};
			array[5] = new int[17]
			{
				0, 5, 10, 15, 20, 25, 30, 35, 40, 45,
				50, 55, 60, 65, 70, 75, 80
			};
			array[6] = new int[17]
			{
				0, 6, 12, 18, 24, 30, 36, 42, 48, 54,
				60, 66, 72, 78, 84, 90, 96
			};
			array[7] = new int[17]
			{
				0, 7, 14, 21, 28, 35, 42, 49, 56, 63,
				70, 77, 84, 91, 98, 105, 112
			};
			array[8] = new int[17]
			{
				0, 8, 16, 24, 32, 40, 48, 56, 64, 72,
				80, 88, 96, 104, 112, 120, 128
			};
			array[9] = new int[17]
			{
				0, 9, 18, 27, 36, 45, 54, 63, 72, 81,
				90, 99, 108, 117, 126, 135, 144
			};
			array[10] = new int[17]
			{
				0, 10, 20, 30, 40, 50, 60, 70, 80, 90,
				100, 110, 120, 130, 140, 150, 160
			};
			array[11] = new int[17]
			{
				0, 11, 22, 33, 44, 55, 66, 77, 88, 99,
				110, 121, 132, 143, 154, 165, 176
			};
			array[12] = new int[17]
			{
				0, 12, 24, 36, 48, 60, 72, 84, 96, 108,
				120, 132, 144, 156, 168, 180, 192
			};
			array[13] = new int[17]
			{
				0, 13, 26, 39, 52, 65, 78, 91, 104, 117,
				130, 143, 156, 169, 182, 195, 208
			};
			array[14] = new int[17]
			{
				0, 14, 28, 42, 56, 70, 84, 98, 112, 126,
				140, 154, 168, 182, 196, 210, 224
			};
			array[15] = new int[17]
			{
				0, 15, 30, 45, 60, 75, 90, 105, 120, 135,
				150, 165, 180, 195, 210, 225, 240
			};
			array[16] = new int[17]
			{
				0, 16, 32, 48, 64, 80, 96, 112, 128, 144,
				160, 176, 192, 208, 224, 240, 256
			};
			array[17] = new int[17]
			{
				0, 17, 34, 51, 68, 85, 102, 119, 136, 153,
				170, 187, 204, 221, 238, 255, 272
			};
			array[18] = new int[17]
			{
				0, 18, 36, 54, 72, 90, 108, 126, 144, 162,
				180, 198, 216, 234, 252, 270, 288
			};
			array[19] = new int[17]
			{
				0, 19, 38, 57, 76, 95, 114, 133, 152, 171,
				190, 209, 228, 247, 266, 285, 304
			};
			array[20] = new int[17]
			{
				0, 20, 40, 60, 80, 100, 120, 140, 160, 180,
				200, 220, 240, 260, 280, 300, 320
			};
			array[21] = new int[17]
			{
				0, 21, 42, 63, 84, 105, 126, 147, 168, 189,
				210, 231, 252, 273, 294, 315, 336
			};
			array[22] = new int[17]
			{
				0, 22, 44, 66, 88, 110, 132, 154, 176, 198,
				220, 242, 264, 286, 308, 330, 352
			};
			array[23] = new int[17]
			{
				0, 23, 46, 69, 92, 115, 138, 161, 184, 207,
				230, 253, 276, 299, 322, 345, 368
			};
			enhancementgear = array;
			wings = new Wing[5]
			{
				new Wing
				{
					id = 0,
					name = "Judical Wings",
					image = Resources.JudicalWings,
					bonus = 0,
					values = new Values[25][]
					{
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(142),
							new Hit(99),
							new ArmorBreak(112),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(166),
							new Hit(109),
							new ArmorBreak(126),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(191),
							new Hit(120),
							new ArmorBreak(141),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(217),
							new Hit(131),
							new ArmorBreak(156),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(244),
							new Hit(143),
							new ArmorBreak(172),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(272),
							new Hit(155),
							new ArmorBreak(188),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(303),
							new Hit(168),
							new ArmorBreak(206),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(335),
							new Hit(182),
							new ArmorBreak(225),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(368),
							new Hit(196),
							new ArmorBreak(244),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(411),
							new Hit(214),
							new ArmorBreak(269),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(459),
							new Hit(234),
							new ArmorBreak(297),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(513),
							new Hit(257),
							new ArmorBreak(329),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(641),
							new Hit(311),
							new ArmorBreak(404),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(718),
							new Hit(343),
							new ArmorBreak(449),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(1815),
							new Hit(801),
							new ArmorBreak(1086),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						},
						new Values[4]
						{
							new HP(120),
							new Hit(89),
							new ArmorBreak(99),
							new DmgReduction(20)
						}
					}
				},
				new Wing
				{
					id = 1,
					name = "Fallen Wings",
					image = Resources.DemonWings,
					bonus = 0,
					values = new Values[25][]
					{
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(162),
							new Hit(108),
							new ArmorBreak(118),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(186),
							new Hit(118),
							new ArmorBreak(132),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(211),
							new Hit(129),
							new ArmorBreak(147),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(237),
							new Hit(140),
							new ArmorBreak(162),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(264),
							new Hit(152),
							new ArmorBreak(178),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(292),
							new Hit(164),
							new ArmorBreak(194),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(323),
							new Hit(177),
							new ArmorBreak(212),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(355),
							new Hit(191),
							new ArmorBreak(231),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(388),
							new Hit(205),
							new ArmorBreak(250),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(431),
							new Hit(223),
							new ArmorBreak(275),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(479),
							new Hit(243),
							new ArmorBreak(303),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(533),
							new Hit(266),
							new ArmorBreak(335),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(661),
							new Hit(320),
							new ArmorBreak(410),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(738),
							new Hit(352),
							new ArmorBreak(455),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(1835),
							new Hit(810),
							new ArmorBreak(1092),
							new DmgReduction(50)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new ArmorBreak(105),
							new DmgReduction(30)
						}
					}
				},
				new Wing
				{
					id = 2,
					name = "Gods Wings",
					image = Resources.WingsOfGods,
					bonus = 5,
					values = new Values[25][]
					{
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(322),
							new Hit(115),
							new ArmorBreak(128),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(346),
							new Hit(125),
							new ArmorBreak(142),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(371),
							new Hit(136),
							new ArmorBreak(157),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(397),
							new Hit(147),
							new ArmorBreak(172),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(424),
							new Hit(159),
							new ArmorBreak(188),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(452),
							new Hit(171),
							new ArmorBreak(204),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(483),
							new Hit(184),
							new ArmorBreak(222),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(515),
							new Hit(198),
							new ArmorBreak(241),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(548),
							new Hit(212),
							new ArmorBreak(260),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(591),
							new Hit(230),
							new ArmorBreak(285),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(639),
							new Hit(250),
							new ArmorBreak(313),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(693),
							new Hit(273),
							new ArmorBreak(345),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(821),
							new Hit(327),
							new ArmorBreak(420),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(898),
							new Hit(359),
							new ArmorBreak(465),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(1995),
							new Hit(817),
							new ArmorBreak(1102),
							new DmgReduction(50)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Hit(105),
							new ArmorBreak(115),
							new DmgReduction(30)
						}
					}
				},
				new Wing
				{
					id = 3,
					name = "Illusion Wings",
					image = Resources.IllusionWings,
					bonus = 5,
					values = new Values[25][]
					{
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(322),
							new Dodge(115),
							new Defense(128),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(346),
							new Dodge(125),
							new Defense(142),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(371),
							new Dodge(136),
							new Defense(157),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(397),
							new Dodge(147),
							new Defense(172),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(424),
							new Dodge(159),
							new Defense(188),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(452),
							new Dodge(171),
							new Defense(204),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(483),
							new Dodge(184),
							new Defense(222),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(515),
							new Dodge(198),
							new Defense(241),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(548),
							new Dodge(212),
							new Defense(260),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(591),
							new Dodge(230),
							new Defense(285),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(639),
							new Dodge(250),
							new Defense(313),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(693),
							new Dodge(273),
							new Defense(345),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(821),
							new Dodge(327),
							new Defense(420),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(898),
							new Dodge(359),
							new Defense(465),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(1995),
							new Dodge(817),
							new Defense(1102),
							new DmgReduction(50)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(300),
							new Dodge(105),
							new Defense(115),
							new DmgReduction(30)
						}
					}
				},
				new Wing
				{
					id = 4,
					name = "Dim Wings",
					image = Resources.DimWings,
					bonus = 0,
					values = new Values[25][]
					{
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(162),
							new Hit(108),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(186),
							new Hit(118),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(211),
							new Hit(129),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(237),
							new Hit(140),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(264),
							new Hit(152),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(292),
							new Hit(164),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(323),
							new Hit(177),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(355),
							new Hit(191),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(388),
							new Hit(205),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(431),
							new Hit(223),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(479),
							new Hit(243),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(533),
							new Hit(266),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(661),
							new Hit(320),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(738),
							new Hit(352),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(40)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(1835),
							new Hit(810),
							new Critical(62),
							new DmgReduction(50)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						},
						new Values[4]
						{
							new HP(140),
							new Hit(98),
							new Critical(62),
							new DmgReduction(30)
						}
					}
				}
			};
			petcategories = new string[7] { "All", "Artificial", "Plant", "Beast", "Channeling", "Dragon", "Tailed Beast" };
			petskills = new PetSkill[84]
			{
				new PetSkill
				{
					id = 0,
					name = "Ferocious",
					type = 0,
					value = new Values[1]
					{
						new PAtk(50)
					}
				},
				new PetSkill
				{
					id = 1,
					name = "[E]Ferocious",
					type = 0,
					value = new Values[1]
					{
						new PAtk(100)
					}
				},
				new PetSkill
				{
					id = 2,
					name = "[卍]Ferocious",
					type = 0,
					value = new Values[1]
					{
						new PAtk(150)
					}
				},
				new PetSkill
				{
					id = 3,
					name = "Strong",
					type = 0,
					value = new Values[1]
					{
						new MaxAtk(6)
					}
				},
				new PetSkill
				{
					id = 4,
					name = "[E]Strong",
					type = 0,
					value = new Values[1]
					{
						new MaxAtk(13)
					}
				},
				new PetSkill
				{
					id = 5,
					name = "[卍]Strong",
					type = 0,
					value = new Values[1]
					{
						new MaxAtk(20)
					}
				},
				new PetSkill
				{
					id = 6,
					name = "Disarm",
					type = 0,
					value = new Values[1]
					{
						new ArmorBreak(26)
					}
				},
				new PetSkill
				{
					id = 7,
					name = "[E]Disarm",
					type = 0,
					value = new Values[1]
					{
						new ArmorBreak(51)
					}
				},
				new PetSkill
				{
					id = 8,
					name = "[卍]Disarm",
					type = 0,
					value = new Values[1]
					{
						new ArmorBreak(77)
					}
				},
				new PetSkill
				{
					id = 9,
					name = "Sharpness",
					type = 0,
					value = new Values[1]
					{
						new Speed(50)
					}
				},
				new PetSkill
				{
					id = 10,
					name = "[E]Sharpness",
					type = 0,
					value = new Values[1]
					{
						new Speed(100)
					}
				},
				new PetSkill
				{
					id = 11,
					name = "[卍]Sharpness",
					type = 0,
					value = new Values[1]
					{
						new Speed(150)
					}
				},
				new PetSkill
				{
					id = 12,
					name = "Thick Skin",
					type = 0,
					value = new Values[1]
					{
						new Defense(29)
					}
				},
				new PetSkill
				{
					id = 13,
					name = "[E]Thick Skin",
					type = 0,
					value = new Values[1]
					{
						new Defense(58)
					}
				},
				new PetSkill
				{
					id = 14,
					name = "[卍]Thick Skin",
					type = 0,
					value = new Values[1]
					{
						new Defense(87)
					}
				},
				new PetSkill
				{
					id = 15,
					name = "Nimble",
					type = 0,
					value = new Values[1]
					{
						new Dodge(19)
					}
				},
				new PetSkill
				{
					id = 16,
					name = "[E]Nimble",
					type = 0,
					value = new Values[1]
					{
						new Dodge(38)
					}
				},
				new PetSkill
				{
					id = 17,
					name = "[卍]Nimble",
					type = 0,
					value = new Values[1]
					{
						new Dodge(57)
					}
				},
				new PetSkill
				{
					id = 18,
					name = "Vivacious",
					type = 0,
					value = new Values[1]
					{
						new PHP(50)
					}
				},
				new PetSkill
				{
					id = 19,
					name = "[E]Vivacious",
					type = 0,
					value = new Values[1]
					{
						new PHP(100)
					}
				},
				new PetSkill
				{
					id = 20,
					name = "[卍]Vivacious",
					type = 0,
					value = new Values[1]
					{
						new PHP(150)
					}
				},
				new PetSkill
				{
					id = 21,
					name = "Sandbag",
					type = 0,
					value = new Values[1]
					{
						new HP(25)
					}
				},
				new PetSkill
				{
					id = 22,
					name = "[E]Sandbag",
					type = 0,
					value = new Values[1]
					{
						new HP(50)
					}
				},
				new PetSkill
				{
					id = 23,
					name = "[卍]Sandbag",
					type = 0,
					value = new Values[1]
					{
						new HP(75)
					}
				},
				new PetSkill
				{
					id = 24,
					name = "Sagacity",
					type = 0,
					value = new Values[1]
					{
						new Chakra(25)
					}
				},
				new PetSkill
				{
					id = 25,
					name = "[E]Sagacity",
					type = 0,
					value = new Values[1]
					{
						new Chakra(50)
					}
				},
				new PetSkill
				{
					id = 26,
					name = "[卍]Sagacity",
					type = 0,
					value = new Values[1]
					{
						new Chakra(75)
					}
				},
				new PetSkill
				{
					id = 27,
					name = "Withstand",
					type = 0,
					value = new Values[1]
					{
						new Block(19)
					}
				},
				new PetSkill
				{
					id = 28,
					name = "[E]Withstand",
					type = 0,
					value = new Values[1]
					{
						new Block(38)
					}
				},
				new PetSkill
				{
					id = 29,
					name = "[卍]Withstand",
					type = 0,
					value = new Values[1]
					{
						new Block(57)
					}
				},
				new PetSkill
				{
					id = 30,
					name = "Vision",
					type = 0,
					value = new Values[1]
					{
						new Hit(29)
					}
				},
				new PetSkill
				{
					id = 31,
					name = "[E]Vision",
					type = 0,
					value = new Values[1]
					{
						new Hit(58)
					}
				},
				new PetSkill
				{
					id = 32,
					name = "[卍]Vision",
					type = 0,
					value = new Values[1]
					{
						new Hit(87)
					}
				},
				new PetSkill
				{
					id = 33,
					name = "Rampage",
					type = 0,
					value = new Values[1]
					{
						new Critical(17)
					}
				},
				new PetSkill
				{
					id = 34,
					name = "[E]Rampage",
					type = 0,
					value = new Values[1]
					{
						new Critical(34)
					}
				},
				new PetSkill
				{
					id = 35,
					name = "[卍]Rampage",
					type = 0,
					value = new Values[1]
					{
						new Critical(51)
					}
				},
				new PetSkill
				{
					id = 36,
					name = "Sharp Claws",
					type = 0,
					value = new Values[1]
					{
						new Pierce(29)
					}
				},
				new PetSkill
				{
					id = 37,
					name = "[E]Sharp Claws",
					type = 0,
					value = new Values[1]
					{
						new Pierce(58)
					}
				},
				new PetSkill
				{
					id = 38,
					name = "[卍]Sharp Claws",
					type = 0,
					value = new Values[1]
					{
						new Pierce(87)
					}
				},
				new PetSkill
				{
					id = 39,
					name = "Calm",
					type = 0,
					value = new Values[1]
					{
						new Constitution(26)
					}
				},
				new PetSkill
				{
					id = 40,
					name = "[E]Calm",
					type = 0,
					value = new Values[1]
					{
						new Constitution(52)
					}
				},
				new PetSkill
				{
					id = 41,
					name = "[卍]Calm",
					type = 0,
					value = new Values[1]
					{
						new Constitution(78)
					}
				},
				new PetSkill
				{
					id = 42,
					name = "Greedy",
					type = 0,
					value = new Values[0]
				},
				new PetSkill
				{
					id = 43,
					name = "[E]Greedy",
					type = 0,
					value = new Values[0]
				},
				new PetSkill
				{
					id = 44,
					name = "[卍]Greedy",
					type = 0,
					value = new Values[0]
				},
				new PetSkill
				{
					id = 45,
					name = "Water Release Enhance",
					type = 0,
					value = new Values[1]
					{
						new Water(100)
					}
				},
				new PetSkill
				{
					id = 46,
					name = "Wind Release Enhance",
					type = 0,
					value = new Values[1]
					{
						new Wind(100)
					}
				},
				new PetSkill
				{
					id = 47,
					name = "Fire Release Enhance",
					type = 0,
					value = new Values[1]
					{
						new Fire(100)
					}
				},
				new PetSkill
				{
					id = 48,
					name = "Earth Release Enhance",
					type = 0,
					value = new Values[1]
					{
						new Earth(100)
					}
				},
				new PetSkill
				{
					id = 49,
					name = "Lightning Release Enhance",
					type = 0,
					value = new Values[1]
					{
						new Lightning(100)
					}
				},
				new PetSkill
				{
					id = 50,
					name = "Dash",
					type = 0,
					value = new Values[1]
					{
						new ArmorBreak(68)
					}
				},
				new PetSkill
				{
					id = 51,
					name = "Natural Enemy",
					type = 3,
					value = new Values[1]
					{
						new Critical(48)
					}
				},
				new PetSkill
				{
					id = 52,
					name = "False Tooth",
					type = 3,
					value = new Values[1]
					{
						new MinAtk(18)
					}
				},
				new PetSkill
				{
					id = 53,
					name = "Barks Armor",
					type = 2,
					value = new Values[1]
					{
						new Defense(80)
					}
				},
				new PetSkill
				{
					id = 54,
					name = "Fence Sitter",
					type = 2,
					value = new Values[1]
					{
						new Constitution(72)
					}
				},
				new PetSkill
				{
					id = 55,
					name = "Mystic Energy",
					type = 4,
					value = new Values[1]
					{
						new Chakra(86)
					}
				},
				new PetSkill
				{
					id = 56,
					name = "X-Ray Vision",
					type = 4,
					value = new Values[1]
					{
						new Pierce(100)
					}
				},
				new PetSkill
				{
					id = 57,
					name = "Nihility",
					type = 4,
					value = new Values[1]
					{
						new Dodge(67)
					}
				},
				new PetSkill
				{
					id = 58,
					name = "Dragonmight",
					type = 5,
					value = new Values[1]
					{
						new HP(86)
					}
				},
				new PetSkill
				{
					id = 59,
					name = "Dragonscale",
					type = 5,
					value = new Values[1]
					{
						new Defense(100)
					}
				},
				new PetSkill
				{
					id = 60,
					name = "Armor Corrosion",
					type = 5,
					value = new Values[1]
					{
						new ArmorBreak(89)
					}
				},
				new PetSkill
				{
					id = 61,
					name = "Dragon Wing",
					type = 5,
					value = new Values[1]
					{
						new Block(67)
					}
				},
				new PetSkill
				{
					id = 62,
					name = "Divine Speed(Dark Wing only)",
					type = 5,
					value = new Values[1]
					{
						new Speed(100)
					}
				},
				new PetSkill
				{
					id = 63,
					name = "Aiming Device",
					type = 1,
					value = new Values[1]
					{
						new Hit(80)
					}
				},
				new PetSkill
				{
					id = 64,
					name = "Outfit Clone",
					type = 1,
					value = new Values[3]
					{
						new Strength(26),
						new Agility(26),
						new Stamina(26)
					}
				},
				new PetSkill
				{
					id = 65,
					name = "Ancient Rampage",
					type = 6,
					value = new Values[1]
					{
						new Strength(60)
					}
				},
				new PetSkill
				{
					id = 66,
					name = "Ancient Swiftshadow",
					type = 6,
					value = new Values[1]
					{
						new Agility(60)
					}
				},
				new PetSkill
				{
					id = 67,
					name = "Ancient Royal Armor",
					type = 6,
					value = new Values[1]
					{
						new Stamina(60)
					}
				},
				new PetSkill
				{
					id = 68,
					name = "Ancient Thick Skin",
					type = 6,
					value = new Values[1]
					{
						new Defense(68)
					}
				},
				new PetSkill
				{
					id = 69,
					name = "Ancient Vision",
					type = 6,
					value = new Values[1]
					{
						new Hit(68)
					}
				},
				new PetSkill
				{
					id = 70,
					name = "[S]Sharp Claw",
					type = 0,
					value = new Values[1]
					{
						new Pierce(130)
					}
				},
				new PetSkill
				{
					id = 71,
					name = "[S]Sharpness",
					type = 0,
					value = new Values[1]
					{
						new Speed(200)
					}
				},
				new PetSkill
				{
					id = 72,
					name = "[S]Vision",
					type = 0,
					value = new Values[1]
					{
						new Hit(140)
					}
				},
				new PetSkill
				{
					id = 73,
					name = "[S]Rampage",
					type = 0,
					value = new Values[1]
					{
						new Critical(76)
					}
				},
				new PetSkill
				{
					id = 74,
					name = "[S]Vivacious",
					type = 0,
					value = new Values[1]
					{
						new PHP(200)
					}
				},
				new PetSkill
				{
					id = 75,
					name = "[S]Sandbag",
					type = 0,
					value = new Values[1]
					{
						new HP(100)
					}
				},
				new PetSkill
				{
					id = 76,
					name = "[S]Nimble",
					type = 0,
					value = new Values[1]
					{
						new Dodge(85)
					}
				},
				new PetSkill
				{
					id = 77,
					name = "[S]Withstand",
					type = 0,
					value = new Values[1]
					{
						new Block(85)
					}
				},
				new PetSkill
				{
					id = 78,
					name = "[S]Calm",
					type = 0,
					value = new Values[1]
					{
						new Constitution(117)
					}
				},
				new PetSkill
				{
					id = 79,
					name = "[S]Thick Skin",
					type = 0,
					value = new Values[1]
					{
						new Defense(130)
					}
				},
				new PetSkill
				{
					id = 80,
					name = "[S]Disarm",
					type = 0,
					value = new Values[1]
					{
						new ArmorBreak(115)
					}
				},
				new PetSkill
				{
					id = 81,
					name = "[S]Strong",
					type = 0,
					value = new Values[1]
					{
						new MaxAtk(30)
					}
				},
				new PetSkill
				{
					id = 82,
					name = "[S]Ferocious",
					type = 0,
					value = new Values[1]
					{
						new PAtk(200)
					}
				},
				new PetSkill
				{
					id = 83,
					name = "[S]Sagacity",
					type = 0,
					value = new Values[1]
					{
						new Chakra(100)
					}
				}
			};
			pets = new Pet[40]
			{
				new Pet
				{
					id = 0,
					name = "Vulture",
					type = 3,
					image = Resources.Vulture
				},
				new Pet
				{
					id = 1,
					name = "Sweet Potato",
					type = 2,
					image = Resources.SweetPotato
				},
				new Pet
				{
					id = 2,
					name = "Treant",
					type = 2,
					image = Resources.Treant
				},
				new Pet
				{
					id = 3,
					name = "Sushi Monster",
					type = 1,
					image = Resources.SushiMonster
				},
				new Pet
				{
					id = 4,
					name = "Bloodbat",
					type = 3,
					image = Resources.Bloodbat
				},
				new Pet
				{
					id = 5,
					name = "Corn Demon",
					type = 2,
					image = Resources.CornDemon
				},
				new Pet
				{
					id = 6,
					name = "Bun Monster",
					type = 1,
					image = Resources.BunMonster
				},
				new Pet
				{
					id = 7,
					name = "Sunflower",
					type = 2,
					image = Resources.Sunflower
				},
				new Pet
				{
					id = 8,
					name = "Stinger Bee",
					type = 3,
					image = Resources.StingerBee
				},
				new Pet
				{
					id = 9,
					name = "Maneater Blossom",
					type = 2,
					image = Resources.ManeaterBlossom
				},
				new Pet
				{
					id = 10,
					name = "Riceball",
					type = 1,
					image = Resources.Riceball
				},
				new Pet
				{
					id = 11,
					name = "Frostbore",
					type = 5,
					image = Resources.Frostbore
				},
				new Pet
				{
					id = 12,
					name = "Firebore",
					type = 5,
					image = Resources.Firebore
				},
				new Pet
				{
					id = 13,
					name = "Azure Dragon",
					type = 5,
					image = Resources.AzureDragon
				},
				new Pet
				{
					id = 14,
					name = "Dark Wing",
					type = 5,
					image = Resources.DarkWing
				},
				new Pet
				{
					id = 15,
					name = "Toadling",
					type = 4,
					image = Resources.Toadling
				},
				new Pet
				{
					id = 16,
					name = "Akamaru",
					type = 4,
					image = Resources.Akamaru
				},
				new Pet
				{
					id = 17,
					name = "Soul",
					type = 4,
					image = Resources.Soul
				},
				new Pet
				{
					id = 18,
					name = "Lily",
					type = 4,
					image = Resources.Lily
				},
				new Pet
				{
					id = 19,
					name = "Shukaku",
					type = 6,
					image = Resources.Shukaku
				},
				new Pet
				{
					id = 20,
					name = "Nekomata",
					type = 6,
					image = Resources.Nekomata
				},
				new Pet
				{
					id = 21,
					name = "Isonade",
					type = 6,
					image = Resources.Isonade
				},
				new Pet
				{
					id = 22,
					name = "Sokou",
					type = 6,
					image = Resources.Soukou
				},
				new Pet
				{
					id = 23,
					name = "Houkou",
					type = 6,
					image = Resources.Houkou
				},
				new Pet
				{
					id = 24,
					name = "Raijuu",
					type = 6,
					image = Resources.Raijuu
				},
				new Pet
				{
					id = 25,
					name = "Mujina",
					type = 6,
					image = Resources.Mujina
				},
				new Pet
				{
					id = 26,
					name = "Giant Ox",
					type = 6,
					image = Resources.GiantOx
				},
				new Pet
				{
					id = 27,
					name = "Demon Fox",
					type = 6,
					image = Resources.DemonFox
				},
				new Pet
				{
					id = 28,
					name = "10-Tails",
					type = 6,
					image = Resources.TenTails
				},
				new Pet
				{
					id = 29,
					name = "Tonton",
					type = 3,
					image = Resources.Tonton
				},
				new Pet
				{
					id = 30,
					name = "Noba",
					type = 4,
					image = Resources.Noba
				},
				new Pet
				{
					id = 31,
					name = "Manda",
					type = 4,
					image = Resources.Manda
				},
				new Pet
				{
					id = 32,
					name = "Kurōdo",
					type = 4,
					image = Resources.Kurodo
				},
				new Pet
				{
					id = 33,
					name = "Katsuyu",
					type = 4,
					image = Resources.Katsuyu
				},
				new Pet
				{
					id = 34,
					name = "Enma",
					type = 4,
					image = Resources.Enma
				},
				new Pet
				{
					id = 35,
					name = "Pakkun",
					type = 3,
					image = Resources.Pakkun
				},
				new Pet
				{
					id = 36,
					name = "Super Beast",
					type = 4,
					image = Resources.SuperBeast
				},
				new Pet
				{
					id = 37,
					name = "Reindeer",
					type = 3,
					image = Resources.Reindeer
				},
				new Pet
				{
					id = 38,
					name = "Bunny",
					type = 3,
					image = Resources.Bunny
				},
				new Pet
				{
					id = 39,
					name = "Chopper",
					type = 3,
					image = Resources.Chopper
				}
			};
			zanpakuto = new int[19][][]
			{
				new int[2][]
				{
					new int[2] { 12, 45 },
					new int[2] { 12, 107 }
				},
				new int[2][]
				{
					new int[2] { 12, 45 },
					new int[2] { 12, 107 }
				},
				new int[2][]
				{
					new int[2] { 12, 45 },
					new int[2] { 12, 107 }
				},
				new int[2][]
				{
					new int[2] { 11, 40 },
					new int[2] { 11, 91 }
				},
				new int[2][]
				{
					new int[2] { 5, 20 },
					new int[2] { 5, 47 }
				},
				new int[2][]
				{
					new int[2] { 5, 20 },
					new int[2] { 5, 47 }
				},
				new int[2][]
				{
					new int[2] { 14, 50 },
					new int[2] { 14, 116 }
				},
				new int[2][]
				{
					new int[2] { 12, 45 },
					new int[2] { 12, 104 }
				},
				new int[2][]
				{
					new int[2] { 11, 40 },
					new int[2] { 11, 91 }
				},
				new int[2][]
				{
					new int[2] { 8, 30 },
					new int[2] { 8, 72 }
				},
				new int[2][]
				{
					new int[2] { 20, 70 },
					new int[2] { 20, 153 }
				},
				new int[2][]
				{
					new int[2] { 11, 40 },
					new int[2] { 11, 91 }
				},
				new int[2][]
				{
					new int[2] { 20, 70 },
					new int[2] { 20, 153 }
				},
				new int[2][]
				{
					new int[2] { 11, 40 },
					new int[2] { 11, 91 }
				},
				new int[2][]
				{
					new int[2] { 8, 30 },
					new int[2] { 8, 68 }
				},
				new int[2][]
				{
					new int[2] { 12, 45 },
					new int[2] { 12, 103 }
				},
				new int[2][]
				{
					new int[2] { 8, 30 },
					new int[2] { 8, 72 }
				},
				new int[2][]
				{
					new int[2] { 12, 45 },
					new int[2] { 12, 104 }
				},
				new int[2][]
				{
					new int[2] { 17, 60 },
					new int[2] { 17, 128 }
				}
			};
			titles = new Title[102]
			{
				new Title
				{
					id = 0,
					name = "Blue Beast",
					image = Resources.BlueBeast,
					values = new Values[3]
					{
						new PAtk(80),
						new Critical(34),
						new Hit(55)
					}
				},
				new Title
				{
					id = 1,
					name = "Yellow Flash",
					image = Resources.YellowFlash,
					values = new Values[3]
					{
						new Speed(80),
						new Dodge(37),
						new Critical(34)
					}
				},
				new Title
				{
					id = 2,
					name = "Guardian of Sand",
					image = Resources.GuardianOfSand,
					values = new Values[3]
					{
						new Defense(118),
						new PHP(40),
						new Hit(55)
					}
				},
				new Title
				{
					id = 3,
					name = "Night Dancer",
					image = Resources.NightDancer,
					values = new Values[3]
					{
						new Dodge(74),
						new Speed(40),
						new PHP(40)
					}
				},
				new Title
				{
					id = 4,
					name = "Blade of Chaos",
					image = Resources.BladeOfChaos,
					values = new Values[3]
					{
						new Hit(111),
						new Critical(34),
						new ArmorBreak(52)
					}
				},
				new Title
				{
					id = 5,
					name = "Red Sunset",
					image = Resources.RedSunset,
					values = new Values[3]
					{
						new Critical(68),
						new ArmorBreak(52),
						new Hit(55)
					}
				},
				new Title
				{
					id = 6,
					name = "White Fang",
					image = Resources.WhiteFang,
					values = new Values[3]
					{
						new ArmorBreak(104),
						new PAtk(40),
						new Critical(34)
					}
				},
				new Title
				{
					id = 7,
					name = "Ninja Hero",
					image = Resources.NinjaHero,
					values = new Values[3]
					{
						new PAtk(30),
						new Speed(30),
						new PHP(30)
					}
				},
				new Title
				{
					id = 8,
					name = "卍Blue Beast",
					image = Resources.BlueBeast,
					values = new Values[3]
					{
						new Strength(98),
						new Hit(58),
						new ArmorBreak(55)
					}
				},
				new Title
				{
					id = 9,
					name = "卍Yellow Flash",
					image = Resources.YellowFlash,
					values = new Values[3]
					{
						new Agility(98),
						new PAtk(40),
						new Speed(40)
					}
				},
				new Title
				{
					id = 10,
					name = "卍Guardian of Sand",
					image = Resources.GuardianOfSand,
					values = new Values[3]
					{
						new Defense(124),
						new Block(55),
						new PHP(40)
					}
				},
				new Title
				{
					id = 11,
					name = "卍Night Dancer",
					image = Resources.NightDancer,
					values = new Values[3]
					{
						new Dodge(78),
						new Pierce(58),
						new ArmorBreak(55)
					}
				},
				new Title
				{
					id = 12,
					name = "卍Blade of Chaos",
					image = Resources.BladeOfChaos,
					values = new Values[3]
					{
						new Hit(116),
						new PHP(40),
						new PAtk(40)
					}
				},
				new Title
				{
					id = 13,
					name = "卍Red Sunset",
					image = Resources.RedSunset,
					values = new Values[3]
					{
						new Critical(71),
						new ArmorBreak(55),
						new Speed(40)
					}
				},
				new Title
				{
					id = 14,
					name = "卍White Fang",
					image = Resources.WhiteFang,
					values = new Values[3]
					{
						new ArmorBreak(109),
						new Constitution(58),
						new Hit(58)
					}
				},
				new Title
				{
					id = 15,
					name = "卍Ninja Hero",
					image = Resources.NinjaHero,
					values = new Values[3]
					{
						new PAtk(50),
						new Speed(50),
						new PHP(50)
					}
				},
				new Title
				{
					id = 16,
					name = "Brave Aries",
					image = Resources.Aries,
					values = new Values[3]
					{
						new PAtk(41),
						new MinAtk(11),
						new Critical(33)
					}
				},
				new Title
				{
					id = 17,
					name = "Steady Taurus",
					image = Resources.Taurus,
					values = new Values[3]
					{
						new PHP(41),
						new Stamina(47),
						new Constitution(49)
					}
				},
				new Title
				{
					id = 18,
					name = "Witty Gemini",
					image = Resources.Gemini,
					values = new Values[3]
					{
						new Speed(41),
						new Agility(47),
						new Dodge(36)
					}
				},
				new Title
				{
					id = 19,
					name = "Tender Cancer",
					image = Resources.Cancer,
					values = new Values[3]
					{
						new Block(36),
						new HP(43),
						new Chakra(43)
					}
				},
				new Title
				{
					id = 20,
					name = "Passionate Leo",
					image = Resources.Leo,
					values = new Values[3]
					{
						new Critical(33),
						new Strength(47),
						new ArmorBreak(49)
					}
				},
				new Title
				{
					id = 21,
					name = "Faultless Virgo",
					image = Resources.Virgo,
					values = new Values[3]
					{
						new Defense(55),
						new Critical(33),
						new MinAtk(11)
					}
				},
				new Title
				{
					id = 22,
					name = "Impartial Libra",
					image = Resources.Libra,
					values = new Values[3]
					{
						new Dodge(36),
						new Defense(55),
						new Block(36)
					}
				},
				new Title
				{
					id = 23,
					name = "Mysterious Scorpio",
					image = Resources.Scorpio,
					values = new Values[3]
					{
						new Pierce(54),
						new Hit(54),
						new Block(36)
					}
				},
				new Title
				{
					id = 24,
					name = "Optimistic Sagittarius",
					image = Resources.Sagillarius,
					values = new Values[3]
					{
						new Hit(54),
						new Speed(41),
						new Critical(33)
					}
				},
				new Title
				{
					id = 25,
					name = "Resolute Capricornus",
					image = Resources.Capricornus,
					values = new Values[3]
					{
						new ArmorBreak(49),
						new Block(36),
						new Stamina(47)
					}
				},
				new Title
				{
					id = 26,
					name = "Independent Aquarius",
					image = Resources.Aquarius,
					values = new Values[3]
					{
						new Pierce(54),
						new Dodge(36),
						new MaxAtk(11)
					}
				},
				new Title
				{
					id = 27,
					name = "Artistic Pisces",
					image = Resources.Pisces,
					values = new Values[3]
					{
						new Block(36),
						new Defense(55),
						new Chakra(43)
					}
				},
				new Title
				{
					id = 28,
					name = "Pupil Ninja",
					image = Resources.PupilNinja,
					values = new Values[3]
					{
						new Strength(13),
						new Agility(13),
						new Stamina(13)
					}
				},
				new Title
				{
					id = 29,
					name = "Junior Ninja",
					image = Resources.JuniorNinja,
					values = new Values[3]
					{
						new Strength(15),
						new Agility(15),
						new Stamina(15)
					}
				},
				new Title
				{
					id = 30,
					name = "Senior Ninja",
					image = Resources.SeniorNinja,
					values = new Values[3]
					{
						new Strength(17),
						new Agility(17),
						new Stamina(17)
					}
				},
				new Title
				{
					id = 31,
					name = "Undergraduate Ninja",
					image = Resources.UndergraduateNinja,
					values = new Values[3]
					{
						new Strength(19),
						new Agility(19),
						new Stamina(19)
					}
				},
				new Title
				{
					id = 32,
					name = "Postgraduate Ninja",
					image = Resources.PostgraduateNinja,
					values = new Values[3]
					{
						new Strength(21),
						new Agility(21),
						new Stamina(21)
					}
				},
				new Title
				{
					id = 33,
					name = "Ninja Genius",
					image = Resources.NinjaGenius,
					values = new Values[3]
					{
						new Strength(23),
						new Agility(23),
						new Stamina(23)
					}
				},
				new Title
				{
					id = 34,
					name = "Ninja Graduate",
					image = Resources.NinjaGraduate,
					values = new Values[3]
					{
						new Strength(25),
						new Agility(25),
						new Stamina(25)
					}
				},
				new Title
				{
					id = 35,
					name = "Emperor of Login",
					image = Resources.EmperorOfLogin,
					values = new Values[4]
					{
						new ArmorBreak(75),
						new Critical(49),
						new Dodge(53),
						new Block(53)
					}
				},
				new Title
				{
					id = 36,
					name = "King of Login",
					image = Resources.KingOfLogin,
					values = new Values[4]
					{
						new ArmorBreak(54),
						new Critical(35),
						new Dodge(38),
						new Block(38)
					}
				},
				new Title
				{
					id = 37,
					name = "Kage",
					image = Resources.Kage,
					values = new Values[6]
					{
						new Hit(40),
						new ArmorBreak(40),
						new Constitution(40),
						new PAtk(30),
						new Speed(30),
						new PHP(30)
					}
				},
				new Title
				{
					id = 38,
					name = "Distinguished",
					image = Resources.Distinguished,
					values = new Values[0]
				},
				new Title
				{
					id = 39,
					name = "Go for Love!",
					image = Resources.GoForLove,
					values = new Values[1]
					{
						new HP(59)
					}
				},
				new Title
				{
					id = 40,
					name = "Strive to win",
					image = Resources.StriveToWin,
					values = new Values[0]
				},
				new Title
				{
					id = 41,
					name = "Come Come Paradise",
					image = Resources.ComeComeParadise,
					values = new Values[1]
					{
						new Speed(40)
					}
				},
				new Title
				{
					id = 42,
					name = "Burning up, Youth!",
					image = Resources.BurningUpYouth,
					values = new Values[1]
					{
						new PAtk(50)
					}
				},
				new Title
				{
					id = 43,
					name = "Legendary fat sheep",
					image = Resources.LegendaryFatSheep,
					values = new Values[0]
				},
				new Title
				{
					id = 44,
					name = "Secret of Final Release",
					image = Resources.SecretOfFinalRelease,
					values = new Values[2]
					{
						new ArmorBreak(45),
						new Defense(51)
					}
				},
				new Title
				{
					id = 45,
					name = "Wake of Sharingan",
					image = Resources.WakeOfSharingan,
					values = new Values[2]
					{
						new ArmorBreak(52),
						new Defense(59)
					}
				},
				new Title
				{
					id = 46,
					name = "Special Jounin",
					image = Resources.SpecialJounin,
					values = new Values[0]
				},
				new Title
				{
					id = 47,
					name = "Invincible Man",
					image = Resources.InvincibleMan,
					values = new Values[0]
				},
				new Title
				{
					id = 48,
					name = "The Lionhearted",
					image = Resources.TheLionhearted,
					values = new Values[0]
				},
				new Title
				{
					id = 49,
					name = "Conspicuous Failure",
					image = Resources.ConspicuousFailure,
					values = new Values[0]
				},
				new Title
				{
					id = 50,
					name = "Jounin Summoner",
					image = Resources.JouninSummoner,
					values = new Values[4]
					{
						new Hit(45),
						new ArmorBreak(45),
						new Critical(40),
						new Dodge(40)
					}
				},
				new Title
				{
					id = 51,
					name = "Bloodline Limit Disciple",
					image = Resources.BloodlineLimitDisciple,
					values = new Values[4]
					{
						new Block(78),
						new ArmorBreak(78),
						new Critical(51),
						new Dodge(50)
					}
				},
				new Title
				{
					id = 52,
					name = "Tailed Beast Killer",
					image = Resources.TailedBeastKiller,
					values = new Values[3]
					{
						new Critical(30),
						new Strength(40),
						new ArmorBreak(45)
					}
				},
				new Title
				{
					id = 53,
					name = "Tailed Beast Defender",
					image = Resources.TailedBeastDefender,
					values = new Values[3]
					{
						new Hit(27),
						new Speed(20),
						new MinAtk(17)
					}
				},
				new Title
				{
					id = 54,
					name = "Adventurer",
					image = Resources.Adventurer,
					values = new Values[0]
				},
				new Title
				{
					id = 55,
					name = "Angel of Mercy",
					image = Resources.AngelOfMercy,
					values = new Values[0]
				},
				new Title
				{
					id = 56,
					name = "Band Collector",
					image = Resources.BandCollector,
					values = new Values[0]
				},
				new Title
				{
					id = 57,
					name = "Young Hero",
					image = Resources.YoungHero,
					values = new Values[0]
				},
				new Title
				{
					id = 58,
					name = "Agent of Soul Reaper",
					image = Resources.AgentOfSoulReaper,
					values = new Values[0]
				},
				new Title
				{
					id = 59,
					name = "Mystic Organization",
					image = Resources.MysticOrganization,
					values = new Values[0]
				},
				new Title
				{
					id = 60,
					name = "Rookie of Card",
					image = Resources.RookieOfCard,
					values = new Values[0]
				},
				new Title
				{
					id = 61,
					name = "Proud of the Village",
					image = Resources.ProudOfTheVillage,
					values = new Values[0]
				},
				new Title
				{
					id = 62,
					name = "Beyond God",
					image = Resources.BeyondGod,
					values = new Values[0]
				},
				new Title
				{
					id = 63,
					name = "Expert of Card",
					image = Resources.ExpertOfCard,
					values = new Values[0]
				},
				new Title
				{
					id = 64,
					name = "Card Mastery",
					image = Resources.CardMastery,
					values = new Values[0]
				},
				new Title
				{
					id = 65,
					name = "Palace Captain",
					image = Resources.PalaceCaptain,
					values = new Values[4]
					{
						new Hit(70),
						new ArmorBreak(55),
						new Critical(50),
						new Dodge(70)
					}
				},
				new Title
				{
					id = 66,
					name = "Supreme Jounin",
					image = Resources.SupremeJounin,
					values = new Values[4]
					{
						new Hit(55),
						new ArmorBreak(70),
						new Critical(70),
						new Dodge(50)
					}
				},
				new Title
				{
					id = 67,
					name = "Blessing Ninja",
					image = Resources.BlessingNinja,
					values = new Values[3]
					{
						new ArmorBreak(70),
						new Critical(70),
						new Dodge(50)
					}
				},
				new Title
				{
					id = 68,
					name = "Special Blessing Ninja",
					image = Resources.SpecialBlessingNinja,
					values = new Values[4]
					{
						new MaxAtk(40),
						new ArmorBreak(70),
						new Critical(70),
						new Dodge(50)
					}
				},
				new Title
				{
					id = 69,
					name = "Pirate's Friendship",
					image = Resources.PirateFriendship,
					values = new Values[5]
					{
						new ArmorBreak(60),
						new Critical(60),
						new Dodge(40),
						new PHP(50),
						new Pierce(60)
					}
				},
				new Title
				{
					id = 70,
					name = "Gray Gatherer",
					image = Resources.GrayGatherer,
					values = new Values[0]
				},
				new Title
				{
					id = 71,
					name = "Gray Keeper",
					image = Resources.GrayKeeper,
					values = new Values[0]
				},
				new Title
				{
					id = 72,
					name = "Gray Collector",
					image = Resources.GrayCollector,
					values = new Values[0]
				},
				new Title
				{
					id = 73,
					name = "Gray Collection",
					image = Resources.GrayCollection,
					values = new Values[0]
				},
				new Title
				{
					id = 74,
					name = "Gray Book Catalogue",
					image = Resources.GrayBookCatalogue,
					values = new Values[0]
				},
				new Title
				{
					id = 75,
					name = "Blue Gatherer",
					image = Resources.BlueGatherer,
					values = new Values[0]
				},
				new Title
				{
					id = 76,
					name = "Blue Keeper",
					image = Resources.BlueKeeper,
					values = new Values[0]
				},
				new Title
				{
					id = 77,
					name = "Blue Collector",
					image = Resources.BlueCollector,
					values = new Values[0]
				},
				new Title
				{
					id = 78,
					name = "Blue Collection",
					image = Resources.BlueCollection,
					values = new Values[0]
				},
				new Title
				{
					id = 79,
					name = "Blue Book Catalogue",
					image = Resources.BlueBookCatalogue,
					values = new Values[0]
				},
				new Title
				{
					id = 80,
					name = "Orange Gatherer",
					image = Resources.OrangeGatherer,
					values = new Values[0]
				},
				new Title
				{
					id = 81,
					name = "Orange Keeper",
					image = Resources.OrangeKeeper,
					values = new Values[0]
				},
				new Title
				{
					id = 82,
					name = "Orange Collector",
					image = Resources.OrangeCollector,
					values = new Values[0]
				},
				new Title
				{
					id = 83,
					name = "Orange Collection",
					image = Resources.OrangeCollection,
					values = new Values[0]
				},
				new Title
				{
					id = 84,
					name = "Orange Book Catalogue",
					image = Resources.OrangeBookCatalogue,
					values = new Values[0]
				},
				new Title
				{
					id = 85,
					name = "Mighty Orange Collector",
					image = Resources.MightyOrangeCollector,
					values = new Values[0]
				},
				new Title
				{
					id = 86,
					name = "Orange Ruler",
					image = Resources.OrangeRuler,
					values = new Values[0]
				},
				new Title
				{
					id = 87,
					name = "Ruler of all Orange Rulers",
					image = Resources.KingOfKingsOrangeOutfit,
					values = new Values[0]
				},
				new Title
				{
					id = 88,
					name = "God of Orange Outfit",
					image = Resources.DeityOfOrangeOutfit,
					values = new Values[0]
				},
				new Title
				{
					id = 89,
					name = "Ultra-God of Orange Outfit",
					image = Resources.UltraDeityOfOrangeOutfit,
					values = new Values[0]
				},
				new Title
				{
					id = 90,
					name = "Kage of Orange Outfit",
					image = Resources.HokageOfOrangeOutfit,
					values = new Values[0]
				},
				new Title
				{
					id = 91,
					name = "Kage of all Orange Outfit Kages",
					image = Resources.HokageOfHokageOrangeOutfit,
					values = new Values[0]
				},
				new Title
				{
					id = 92,
					name = "Return of King",
					image = Resources.ReturnOfKing,
					values = new Values[3]
					{
						new MaxAtk(64),
						new Critical(104),
						new ArmorBreak(114)
					}
				},
				new Title
				{
					id = 93,
					name = "Pirate King",
					image = Resources.PirateKing,
					values = new Values[5]
					{
						new ArmorBreak(114),
						new Hit(112),
						new MaxAtk(34),
						new Speed(120),
						new HP(124)
					}
				},
				new Title
				{
					id = 94,
					name = "The No.1 Swordman",
					image = Resources.No1Swordman,
					values = new Values[4]
					{
						new Agility(106),
						new Speed(120),
						new Dodge(71),
						new Critical(67)
					}
				},
				new Title
				{
					id = 95,
					name = "Son of Demon",
					image = Resources.SonOfDemon,
					values = new Values[4]
					{
						new Stamina(106),
						new Defense(121),
						new Constitution(100),
						new Hit(106)
					}
				},
				new Title
				{
					id = 96,
					name = "Sniper King",
					image = Resources.SniperKing,
					values = new Values[4]
					{
						new PAtk(120),
						new Critical(67),
						new Hit(106),
						new MaxAtk(32)
					}
				},
				new Title
				{
					id = 97,
					name = "Yonko the Redhair",
					image = Resources.YonkoTheRedhair,
					values = new Values[4]
					{
						new Agility(106),
						new Speed(120),
						new ArmorBreak(107),
						new Dodge(71)
					}
				},
				new Title
				{
					id = 98,
					name = "Yonko the Whitebeard",
					image = Resources.YonkoTheWhitebeard,
					values = new Values[4]
					{
						new HP(117),
						new Defense(121),
						new Constitution(100),
						new Block(71)
					}
				},
				new Title
				{
					id = 99,
					name = "Dark King",
					image = null,
					values = new Values[4]
					{
						new Strength(106),
						new Critical(67),
						new MinAtk(32),
						new HP(117)
					}
				},
				new Title
				{
					id = 100,
					name = "Ninja Wizard",
					image = Resources.NinjaWizard,
					values = new Values[3]
					{
						new Strength(30),
						new Agility(30),
						new Stamina(30)
					}
				},
				new Title
				{
					id = 101,
					name = "Ninja Graduate",
					image = Resources.NinjaGraduate2,
					values = new Values[3]
					{
						new Strength(35),
						new Agility(35),
						new Stamina(35)
					}
				}
			};
			maxValMatrix = new int[27][]
			{
				new int[24]
				{
					34, 37, 39, 42, 45, 47, 51, 53, 57, 60,
					63, 66, 70, 73, 77, 80, 84, 87, 92, 95,
					98, 101, 106, 111
				},
				new int[24]
				{
					34, 37, 39, 42, 45, 47, 51, 53, 57, 60,
					63, 66, 70, 73, 77, 80, 84, 87, 92, 95,
					98, 101, 106, 111
				},
				new int[24]
				{
					34, 37, 39, 42, 45, 47, 51, 53, 57, 60,
					63, 66, 70, 73, 77, 80, 84, 87, 92, 95,
					98, 101, 106, 111
				},
				new int[24]
				{
					29, 31, 33, 35, 37, 39, 42, 44, 47, 50,
					53, 55, 58, 61, 64, 67, 70, 73, 76, 79,
					82, 85, 0, 0
				},
				new int[24]
				{
					1, 1, 2, 3, 4, 5, 6, 8, 9, 11,
					12, 14, 16, 18, 21, 23, 26, 29, 32, 35,
					38, 41, 0, 0
				},
				new int[24]
				{
					1, 1, 2, 3, 4, 5, 6, 8, 9, 11,
					12, 14, 16, 18, 21, 23, 26, 29, 32, 35,
					38, 41, 0, 0
				},
				new int[24]
				{
					32, 37, 40, 43, 46, 49, 52, 55, 58, 62,
					65, 69, 72, 76, 80, 84, 87, 92, 96, 100,
					104, 108, 0, 117
				},
				new int[24]
				{
					51, 54, 56, 58, 61, 63, 66, 68, 70, 73,
					75, 78, 80, 82, 85, 87, 89, 91, 94, 96,
					98, 100, 103, 106
				},
				new int[24]
				{
					29, 31, 33, 35, 37, 39, 42, 44, 47, 50,
					53, 55, 58, 61, 64, 67, 70, 73, 76, 79,
					82, 85, 0, 0
				},
				new int[24]
				{
					34, 36, 37, 39, 40, 42, 44, 45, 47, 48,
					50, 52, 53, 55, 56, 58, 59, 61, 62, 64,
					66, 68, 69, 70
				},
				new int[24]
				{
					5, 9, 12, 16, 20, 25, 29, 34, 40, 45,
					51, 57, 64, 70, 77, 85, 92, 100, 108, 117,
					126, 135, 0, 0
				},
				new int[24]
				{
					29, 31, 33, 35, 37, 39, 42, 44, 47, 50,
					53, 55, 58, 61, 64, 67, 70, 73, 76, 79,
					82, 85, 0, 0
				},
				new int[24]
				{
					5, 9, 12, 16, 20, 25, 29, 34, 40, 45,
					51, 57, 64, 70, 77, 85, 92, 100, 108, 117,
					126, 135, 0, 0
				},
				new int[24]
				{
					29, 31, 33, 35, 37, 39, 42, 44, 47, 50,
					53, 55, 58, 61, 64, 67, 70, 73, 76, 79,
					82, 85, 0, 0
				},
				new int[24]
				{
					27, 29, 30, 32, 34, 36, 38, 39, 41, 43,
					45, 46, 48, 50, 52, 53, 55, 57, 59, 60,
					62, 64, 0, 67
				},
				new int[24]
				{
					41, 43, 46, 0, 51, 54, 57, 59, 0, 65,
					67, 70, 73, 75, 78, 80, 82, 84, 88, 91,
					94, 97, 99, 101
				},
				new int[24]
				{
					34, 36, 37, 39, 40, 42, 44, 45, 47, 48,
					50, 52, 53, 55, 56, 58, 59, 61, 62, 64,
					66, 68, 69, 70
				},
				new int[24]
				{
					51, 54, 56, 58, 61, 63, 66, 68, 70, 73,
					75, 78, 80, 82, 85, 87, 89, 91, 94, 96,
					98, 100, 103, 106
				},
				new int[24]
				{
					37, 42, 46, 49, 52, 55, 59, 62, 66, 70,
					73, 77, 81, 86, 90, 94, 98, 100, 108, 112,
					116, 120, 124, 128
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				},
				new int[24]
				{
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22, 22, 22, 22, 22, 22, 22,
					22, 22, 22, 22
				}
			};
			enchantments = new Enchantment[184]
			{
				new Enchantment
				{
					id = 0,
					name = "Lv.1 Top Enchantment Stone",
					level = 21,
					position = "01001000",
					values = new Values[2]
					{
						new Block(10),
						new Constitution(5)
					}
				},
				new Enchantment
				{
					id = 1,
					name = "Lv.1 Top Enchantment Stone",
					level = 21,
					position = "01001000",
					values = new Values[2]
					{
						new Block(5),
						new Defense(9)
					}
				},
				new Enchantment
				{
					id = 2,
					name = "Lv.2 Top Enchantment Stone",
					level = 31,
					position = "01001000",
					values = new Values[2]
					{
						new Block(14),
						new Dodge(7)
					}
				},
				new Enchantment
				{
					id = 3,
					name = "Lv.2 Top Enchantment Stone",
					level = 31,
					position = "01001000",
					values = new Values[2]
					{
						new Block(5),
						new Defense(10)
					}
				},
				new Enchantment
				{
					id = 4,
					name = "Lv.3 Top Enchantment Stone",
					level = 41,
					position = "01001000",
					values = new Values[1]
					{
						new Block(18)
					}
				},
				new Enchantment
				{
					id = 5,
					name = "Lv.3 Top Enchantment Stone",
					level = 41,
					position = "01001000",
					values = new Values[2]
					{
						new Block(11),
						new Constitution(7)
					}
				},
				new Enchantment
				{
					id = 6,
					name = "Lv.3 Top Enchantment Stone",
					level = 41,
					position = "01001000",
					values = new Values[2]
					{
						new Block(6),
						new Defense(11)
					}
				},
				new Enchantment
				{
					id = 7,
					name = "Lv.4 Top Enchantment Stone",
					level = 51,
					position = "01001000",
					values = new Values[2]
					{
						new HP(5),
						new Block(24)
					}
				},
				new Enchantment
				{
					id = 8,
					name = "Lv.4 Top Enchantment Stone",
					level = 51,
					position = "01001000",
					values = new Values[3]
					{
						new Agility(7),
						new Strength(9),
						new Constitution(9)
					}
				},
				new Enchantment
				{
					id = 9,
					name = "Lv.5 Top Enchantment Stone",
					level = 61,
					position = "01001000",
					values = new Values[2]
					{
						new HP(6),
						new Block(25)
					}
				},
				new Enchantment
				{
					id = 10,
					name = "Lv.5 Top Enchantment Stone",
					level = 61,
					position = "01001000",
					values = new Values[3]
					{
						new Agility(7),
						new Strength(10),
						new Constitution(9)
					}
				},
				new Enchantment
				{
					id = 11,
					name = "Lv.5 Top Enchantment Stone",
					level = 61,
					position = "01001000",
					values = new Values[2]
					{
						new MaxAtk(1),
						new Dodge(27)
					}
				},
				new Enchantment
				{
					id = 12,
					name = "Lv.5 Top Enchantment Stone",
					level = 61,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(11),
						new Block(12)
					}
				},
				new Enchantment
				{
					id = 13,
					name = "Lv.6 Top Enchantment Stone",
					level = 71,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(13),
						new Block(26)
					}
				},
				new Enchantment
				{
					id = 14,
					name = "Lv.6 Top Enchantment Stone",
					level = 71,
					position = "01001000",
					values = new Values[3]
					{
						new Stamina(13),
						new Constitution(10),
						new ArmorBreak(15)
					}
				},
				new Enchantment
				{
					id = 15,
					name = "Lv.7 Top Enchantment Stone",
					level = 81,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(15),
						new Block(29)
					}
				},
				new Enchantment
				{
					id = 16,
					name = "Lv.7 Top Enchantment Stone",
					level = 81,
					position = "01001000",
					values = new Values[3]
					{
						new Stamina(15),
						new Constitution(11),
						new ArmorBreak(17)
					}
				},
				new Enchantment
				{
					id = 17,
					name = "Lv.1 Armor Enchantment Stone",
					level = 21,
					position = "00000100",
					values = new Values[2]
					{
						new Block(10),
						new Dodge(10)
					}
				},
				new Enchantment
				{
					id = 18,
					name = "Lv.1 Armor Enchantment Stone",
					level = 21,
					position = "00000100",
					values = new Values[3]
					{
						new Block(7),
						new Dodge(7),
						new HP(3)
					}
				},
				new Enchantment
				{
					id = 19,
					name = "Lv.1 Armor Enchantment Stone",
					level = 21,
					position = "00000100",
					values = new Values[3]
					{
						new Block(8),
						new Dodge(8),
						new Constitution(4)
					}
				},
				new Enchantment
				{
					id = 20,
					name = "Lv.1 Armor Enchantment Stone",
					level = 21,
					position = "00000100",
					values = new Values[3]
					{
						new Block(10),
						new Dodge(10),
						new Defense(2)
					}
				},
				new Enchantment
				{
					id = 21,
					name = "Lv.2 Armor Enchantment Stone",
					level = 31,
					position = "00000100",
					values = new Values[2]
					{
						new Block(11),
						new Dodge(11)
					}
				},
				new Enchantment
				{
					id = 22,
					name = "Lv.2 Armor Enchantment Stone",
					level = 31,
					position = "00000100",
					values = new Values[3]
					{
						new Block(8),
						new Dodge(8),
						new HP(3)
					}
				},
				new Enchantment
				{
					id = 23,
					name = "Lv.2 Armor Enchantment Stone",
					level = 31,
					position = "00000100",
					values = new Values[3]
					{
						new Block(8),
						new Dodge(8),
						new Constitution(5)
					}
				},
				new Enchantment
				{
					id = 24,
					name = "Lv.3 Armor Enchantment Stone",
					level = 41,
					position = "00000100",
					values = new Values[2]
					{
						new Block(12),
						new Dodge(12)
					}
				},
				new Enchantment
				{
					id = 25,
					name = "Lv.3 Armor Enchantment Stone",
					level = 41,
					position = "00000100",
					values = new Values[3]
					{
						new Block(8),
						new Dodge(8),
						new HP(4)
					}
				},
				new Enchantment
				{
					id = 26,
					name = "Lv.3 Armor Enchantment Stone",
					level = 41,
					position = "00000100",
					values = new Values[3]
					{
						new Block(12),
						new Dodge(12),
						new Defense(2)
					}
				},
				new Enchantment
				{
					id = 27,
					name = "Lv.3 Armor Enchantment Stone",
					level = 41,
					position = "00000100",
					values = new Values[3]
					{
						new Block(9),
						new Dodge(9),
						new Constitution(5)
					}
				},
				new Enchantment
				{
					id = 28,
					name = "Lv.4 Armor Enchantment Stone",
					level = 51,
					position = "00000100",
					values = new Values[1]
					{
						new HP(14)
					}
				},
				new Enchantment
				{
					id = 29,
					name = "Lv.4 Armor Enchantment Stone",
					level = 51,
					position = "00000100",
					values = new Values[2]
					{
						new ArmorBreak(2),
						new Defense(20)
					}
				},
				new Enchantment
				{
					id = 30,
					name = "Lv.4 Armor Enchantment Stone",
					level = 51,
					position = "00000100",
					values = new Values[2]
					{
						new Critical(13),
						new Agility(12)
					}
				},
				new Enchantment
				{
					id = 31,
					name = "Lv.5 Armor Enchantment Stone",
					level = 61,
					position = "00000100",
					values = new Values[1]
					{
						new HP(18)
					}
				},
				new Enchantment
				{
					id = 32,
					name = "Lv.5 Armor Enchantment Stone",
					level = 61,
					position = "00000100",
					values = new Values[2]
					{
						new ArmorBreak(3),
						new Defense(22)
					}
				},
				new Enchantment
				{
					id = 33,
					name = "Lv.5 Armor Enchantment Stone",
					level = 61,
					position = "00000100",
					values = new Values[2]
					{
						new Critical(14),
						new Agility(14)
					}
				},
				new Enchantment
				{
					id = 34,
					name = "Lv.5 Armor Enchantment Stone",
					level = 61,
					position = "00000100",
					values = new Values[3]
					{
						new Stamina(11),
						new PHP(9),
						new Dodge(10)
					}
				},
				new Enchantment
				{
					id = 35,
					name = "Lv.6 Armor Enchantment Stone",
					level = 71,
					position = "00000100",
					values = new Values[2]
					{
						new Strength(6),
						new Dodge(28)
					}
				},
				new Enchantment
				{
					id = 36,
					name = "Lv.6 Armor Enchantment Stone",
					level = 71,
					position = "00000100",
					values = new Values[3]
					{
						new HP(8),
						new Speed(8),
						new Block(20)
					}
				},
				new Enchantment
				{
					id = 37,
					name = "Lv.7 Armor Enchantment Stone",
					level = 81,
					position = "00000100",
					values = new Values[2]
					{
						new Strength(9),
						new Dodge(30)
					}
				},
				new Enchantment
				{
					id = 38,
					name = "Lv.7 Armor Enchantment Stone",
					level = 81,
					position = "00000100",
					values = new Values[3]
					{
						new HP(10),
						new Speed(10),
						new Block(21)
					}
				},
				new Enchantment
				{
					id = 39,
					name = "Lv.1 Bottom Enchantment Stone",
					level = 21,
					position = "00000011",
					values = new Values[1]
					{
						new Dodge(16)
					}
				},
				new Enchantment
				{
					id = 40,
					name = "Lv.1 Bottom Enchantment Stone",
					level = 21,
					position = "00000011",
					values = new Values[2]
					{
						new Dodge(13),
						new Block(6)
					}
				},
				new Enchantment
				{
					id = 41,
					name = "Lv.1 Bottom Enchantment Stone",
					level = 21,
					position = "00000011",
					values = new Values[2]
					{
						new Dodge(5),
						new Defense(9)
					}
				},
				new Enchantment
				{
					id = 42,
					name = "Lv.1 Bottom Enchantment Stone",
					level = 21,
					position = "00000011",
					values = new Values[2]
					{
						new Dodge(10),
						new Constitution(5)
					}
				},
				new Enchantment
				{
					id = 43,
					name = "Lv.2 Bottom Enchantment Stone",
					level = 31,
					position = "00000011",
					values = new Values[1]
					{
						new Dodge(17)
					}
				},
				new Enchantment
				{
					id = 44,
					name = "Lv.2 Bottom Enchantment Stone",
					level = 31,
					position = "00000011",
					values = new Values[2]
					{
						new Dodge(14),
						new Block(7)
					}
				},
				new Enchantment
				{
					id = 45,
					name = "Lv.2 Bottom Enchantment Stone",
					level = 31,
					position = "00000011",
					values = new Values[2]
					{
						new Dodge(5),
						new Defense(10)
					}
				},
				new Enchantment
				{
					id = 46,
					name = "Lv.3 Bottom Enchantment Stone",
					level = 41,
					position = "00000011",
					values = new Values[2]
					{
						new Dodge(11),
						new Constitution(7)
					}
				},
				new Enchantment
				{
					id = 47,
					name = "Lv.3 Bottom Enchantment Stone",
					level = 41,
					position = "00000011",
					values = new Values[2]
					{
						new Dodge(6),
						new Defense(11)
					}
				},
				new Enchantment
				{
					id = 48,
					name = "Lv.4 Bottom Enchantment Stone",
					level = 51,
					position = "00000011",
					values = new Values[2]
					{
						new Constitution(7),
						new Block(22)
					}
				},
				new Enchantment
				{
					id = 49,
					name = "Lv.4 Bottom Enchantment Stone",
					level = 51,
					position = "00000011",
					values = new Values[2]
					{
						new Critical(7),
						new Defense(18)
					}
				},
				new Enchantment
				{
					id = 50,
					name = "Lv.4 Bottom Enchantment Stone",
					level = 51,
					position = "00000011",
					values = new Values[3]
					{
						new Critical(9),
						new Dodge(17),
						new PAtk(7)
					}
				},
				new Enchantment
				{
					id = 51,
					name = "Lv.4 Bottom Enchantment Stone",
					level = 51,
					position = "00000011",
					values = new Values[3]
					{
						new MaxAtk(2),
						new ArmorBreak(13),
						new Dodge(16)
					}
				},
				new Enchantment
				{
					id = 52,
					name = "Lv.5 Bottom Enchantment Stone",
					level = 61,
					position = "00000011",
					values = new Values[3]
					{
						new Pierce(9),
						new Hit(9),
						new PHP(9)
					}
				},
				new Enchantment
				{
					id = 53,
					name = "Lv.5 Bottom Enchantment Stone",
					level = 61,
					position = "00000011",
					values = new Values[3]
					{
						new MaxAtk(2),
						new ArmorBreak(15),
						new Dodge(17)
					}
				},
				new Enchantment
				{
					id = 54,
					name = "Lv.5 Bottom Enchantment Stone",
					level = 61,
					position = "00000011",
					values = new Values[3]
					{
						new Critical(10),
						new Dodge(18),
						new PAtk(7)
					}
				},
				new Enchantment
				{
					id = 55,
					name = "Lv.5 Bottom Enchantment Stone",
					level = 61,
					position = "00000011",
					values = new Values[2]
					{
						new Critical(8),
						new Defense(20)
					}
				},
				new Enchantment
				{
					id = 56,
					name = "Lv.6 Bottom Enchantment Stone",
					level = 71,
					position = "00000011",
					values = new Values[2]
					{
						new Hit(11),
						new Pierce(14)
					}
				},
				new Enchantment
				{
					id = 57,
					name = "Lv.6 Bottom Enchantment Stone",
					level = 71,
					position = "00000011",
					values = new Values[3]
					{
						new PAtk(8),
						new Constitution(11),
						new ArmorBreak(17)
					}
				},
				new Enchantment
				{
					id = 58,
					name = "Lv.7 Bottom Enchantment Stone",
					level = 81,
					position = "00000011",
					values = new Values[2]
					{
						new Hit(13),
						new Pierce(17)
					}
				},
				new Enchantment
				{
					id = 59,
					name = "Lv.7 Bottom Enchantment Stone",
					level = 81,
					position = "00000011",
					values = new Values[3]
					{
						new PAtk(10),
						new Constitution(13),
						new ArmorBreak(18)
					}
				},
				new Enchantment
				{
					id = 60,
					name = "Lv.1 Accessory Enchantment Stone",
					level = 21,
					position = "00110000",
					values = new Values[1]
					{
						new Critical(13)
					}
				},
				new Enchantment
				{
					id = 61,
					name = "Lv.1 Accessory Enchantment Stone",
					level = 21,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(10),
						new Pierce(4)
					}
				},
				new Enchantment
				{
					id = 62,
					name = "Lv.1 Accessory Enchantment Stone",
					level = 21,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(8),
						new ArmorBreak(11)
					}
				},
				new Enchantment
				{
					id = 63,
					name = "Lv.2 Accessory Enchantment Stone",
					level = 31,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(11),
						new Hit(5)
					}
				},
				new Enchantment
				{
					id = 64,
					name = "Lv.2 Accessory Enchantment Stone",
					level = 31,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(11),
						new Pierce(5)
					}
				},
				new Enchantment
				{
					id = 65,
					name = "Lv.2 Accessory Enchantment Stone",
					level = 31,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(9),
						new ArmorBreak(13)
					}
				},
				new Enchantment
				{
					id = 66,
					name = "Lv.3 Accessory Enchantment Stone",
					level = 41,
					position = "00110000",
					values = new Values[1]
					{
						new Critical(15)
					}
				},
				new Enchantment
				{
					id = 67,
					name = "Lv.3 Accessory Enchantment Stone",
					level = 41,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(12),
						new Hit(5)
					}
				},
				new Enchantment
				{
					id = 68,
					name = "Lv.3 Accessory Enchantment Stone",
					level = 41,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(9),
						new ArmorBreak(15)
					}
				},
				new Enchantment
				{
					id = 69,
					name = "Lv.4 Accessory Enchantment Stone",
					level = 51,
					position = "00110000",
					values = new Values[1]
					{
						new ArmorBreak(37)
					}
				},
				new Enchantment
				{
					id = 70,
					name = "Lv.4 Accessory Enchantment Stone",
					level = 51,
					position = "00110000",
					values = new Values[2]
					{
						new MaxAtk(2),
						new Critical(16)
					}
				},
				new Enchantment
				{
					id = 71,
					name = "Lv.4 Accessory Enchantment Stone",
					level = 51,
					position = "00110000",
					values = new Values[3]
					{
						new Constitution(9),
						new Stamina(11),
						new Defense(4)
					}
				},
				new Enchantment
				{
					id = 72,
					name = "Lv.4 Accessory Enchantment Stone",
					level = 51,
					position = "00110000",
					values = new Values[3]
					{
						new Block(14),
						new Hit(9),
						new Speed(7)
					}
				},
				new Enchantment
				{
					id = 73,
					name = "Lv.5 Accessory Enchantment Stone",
					level = 61,
					position = "00110000",
					values = new Values[1]
					{
						new ArmorBreak(41)
					}
				},
				new Enchantment
				{
					id = 74,
					name = "Lv.5 Accessory Enchantment Stone",
					level = 61,
					position = "00110000",
					values = new Values[3]
					{
						new Constitution(10),
						new Stamina(12),
						new Defense(4)
					}
				},
				new Enchantment
				{
					id = 75,
					name = "Lv.5 Accessory Enchantment Stone",
					level = 61,
					position = "00110000",
					values = new Values[3]
					{
						new Block(15),
						new Hit(10),
						new Speed(8)
					}
				},
				new Enchantment
				{
					id = 76,
					name = "Lv.5 Accessory Enchantment Stone",
					level = 61,
					position = "00110000",
					values = new Values[2]
					{
						new MaxAtk(2),
						new Critical(17)
					}
				},
				new Enchantment
				{
					id = 77,
					name = "Lv.6 Accessory Enchantment Stone",
					level = 71,
					position = "00110000",
					values = new Values[3]
					{
						new Agility(9),
						new ArmorBreak(28),
						new Defense(10)
					}
				},
				new Enchantment
				{
					id = 78,
					name = "Lv.6 Accessory Enchantment Stone",
					level = 71,
					position = "00110000",
					values = new Values[2]
					{
						new MaxAtk(2),
						new Critical(25)
					}
				},
				new Enchantment
				{
					id = 79,
					name = "Lv.7 Accessory Enchantment Stone",
					level = 81,
					position = "00110000",
					values = new Values[3]
					{
						new Agility(10),
						new ArmorBreak(30),
						new Defense(12)
					}
				},
				new Enchantment
				{
					id = 80,
					name = "Lv.7 Accessory Enchantment Stone",
					level = 81,
					position = "00110000",
					values = new Values[2]
					{
						new MaxAtk(5),
						new Critical(27)
					}
				},
				new Enchantment
				{
					id = 81,
					name = "Lv.1 Weapon Enchantment Stone",
					level = 21,
					position = "10000000",
					values = new Values[1]
					{
						new Critical(13)
					}
				},
				new Enchantment
				{
					id = 82,
					name = "Lv.1 Weapon Enchantment Stone",
					level = 21,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(10),
						new Hit(4)
					}
				},
				new Enchantment
				{
					id = 83,
					name = "Lv.1 Weapon Enchantment Stone",
					level = 21,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(10),
						new Pierce(4)
					}
				},
				new Enchantment
				{
					id = 84,
					name = "Lv.1 Weapon Enchantment Stone",
					level = 21,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(8),
						new ArmorBreak(11)
					}
				},
				new Enchantment
				{
					id = 85,
					name = "Lv.1 Weapon Enchantment Stone",
					level = 21,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(4),
						new MaxAtk(1)
					}
				},
				new Enchantment
				{
					id = 86,
					name = "Lv.2 Weapon Enchantment Stone",
					level = 31,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(11),
						new Hit(5)
					}
				},
				new Enchantment
				{
					id = 87,
					name = "Lv.2 Weapon Enchantment Stone",
					level = 31,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(11),
						new Pierce(5)
					}
				},
				new Enchantment
				{
					id = 88,
					name = "Lv.2 Weapon Enchantment Stone",
					level = 31,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(9),
						new ArmorBreak(13)
					}
				},
				new Enchantment
				{
					id = 89,
					name = "Lv.3 Weapon Enchantment Stone",
					level = 41,
					position = "10000000",
					values = new Values[1]
					{
						new Critical(15)
					}
				},
				new Enchantment
				{
					id = 90,
					name = "Lv.3 Weapon Enchantment Stone",
					level = 41,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(12),
						new Hit(5)
					}
				},
				new Enchantment
				{
					id = 91,
					name = "Lv.3 Weapon Enchantment Stone",
					level = 41,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(12),
						new Pierce(5)
					}
				},
				new Enchantment
				{
					id = 92,
					name = "Lv.3 Weapon Enchantment Stone",
					level = 41,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(9),
						new ArmorBreak(15)
					}
				},
				new Enchantment
				{
					id = 93,
					name = "Lv.3 Weapon Enchantment Stone",
					level = 41,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(5),
						new MaxAtk(3)
					}
				},
				new Enchantment
				{
					id = 94,
					name = "Lv.4 Weapon Enchantment Stone",
					level = 51,
					position = "10000000",
					values = new Values[2]
					{
						new Hit(11),
						new Critical(15)
					}
				},
				new Enchantment
				{
					id = 95,
					name = "Lv.4 Weapon Enchantment Stone",
					level = 51,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(18),
						new ArmorBreak(16)
					}
				},
				new Enchantment
				{
					id = 96,
					name = "Lv.4 Weapon Enchantment Stone",
					level = 51,
					position = "10000000",
					values = new Values[3]
					{
						new Critical(14),
						new ArmorBreak(22),
						new Dodge(5)
					}
				},
				new Enchantment
				{
					id = 97,
					name = "Lv.4 Weapon Enchantment Stone",
					level = 51,
					position = "10000000",
					values = new Values[3]
					{
						new Agility(6),
						new Critical(14),
						new Pierce(10)
					}
				},
				new Enchantment
				{
					id = 98,
					name = "Lv.4 Weapon Enchantment Stone",
					level = 51,
					position = "10000000",
					values = new Values[2]
					{
						new Strength(5),
						new MaxAtk(3)
					}
				},
				new Enchantment
				{
					id = 99,
					name = "Lv.5 Weapon Enchantment Stone",
					level = 61,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(15),
						new Hit(12)
					}
				},
				new Enchantment
				{
					id = 100,
					name = "Lv.5 Weapon Enchantment Stone",
					level = 61,
					position = "10000000",
					values = new Values[2]
					{
						new Critical(19),
						new ArmorBreak(18)
					}
				},
				new Enchantment
				{
					id = 101,
					name = "Lv.5 Weapon Enchantment Stone",
					level = 61,
					position = "10000000",
					values = new Values[3]
					{
						new Critical(15),
						new ArmorBreak(25),
						new Dodge(5)
					}
				},
				new Enchantment
				{
					id = 102,
					name = "Lv.5 Weapon Enchantment Stone",
					level = 61,
					position = "10000000",
					values = new Values[3]
					{
						new Agility(7),
						new Critical(15),
						new Pierce(10)
					}
				},
				new Enchantment
				{
					id = 103,
					name = "Lv.5 Weapon Enchantment Stone",
					level = 61,
					position = "10000000",
					values = new Values[2]
					{
						new Strength(5),
						new MaxAtk(4)
					}
				},
				new Enchantment
				{
					id = 104,
					name = "Lv.6 Weapon Enchantment Stone",
					level = 71,
					position = "10000000",
					values = new Values[2]
					{
						new Hit(11),
						new Critical(21)
					}
				},
				new Enchantment
				{
					id = 105,
					name = "Lv.6 Weapon Enchantment Stone",
					level = 71,
					position = "10000000",
					values = new Values[3]
					{
						new Strength(8),
						new Critical(10),
						new Pierce(14)
					}
				},
				new Enchantment
				{
					id = 106,
					name = "Lv.7 Weapon Enchantment Stone",
					level = 81,
					position = "10000000",
					values = new Values[2]
					{
						new Hit(15),
						new Critical(22)
					}
				},
				new Enchantment
				{
					id = 107,
					name = "Lv.7 Weapon Enchantment Stone",
					level = 81,
					position = "10000000",
					values = new Values[3]
					{
						new Strength(9),
						new Critical(12),
						new Pierce(16)
					}
				},
				new Enchantment
				{
					id = 108,
					name = "Common Dragon Egg Stone",
					level = 51,
					position = "00000011",
					values = new Values[2]
					{
						new Defense(32),
						new PHP(48)
					}
				},
				new Enchantment
				{
					id = 109,
					name = "Common Ice Crystal Stone",
					level = 51,
					position = "00000011",
					values = new Values[1]
					{
						new Constitution(61)
					}
				},
				new Enchantment
				{
					id = 110,
					name = "Common Princess Stone",
					level = 51,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(25),
						new ArmorBreak(37)
					}
				},
				new Enchantment
				{
					id = 111,
					name = "Common Knowledge Stone",
					level = 51,
					position = "00110000",
					values = new Values[2]
					{
						new Chakra(14),
						new Tool(20)
					}
				},
				new Enchantment
				{
					id = 112,
					name = "Common Starlight Stone",
					level = 51,
					position = "10000100",
					values = new Values[3]
					{
						new Hit(44),
						new Pierce(44),
						new MaxAtk(2)
					}
				},
				new Enchantment
				{
					id = 113,
					name = "Common Ocean Heart",
					level = 51,
					position = "01001000",
					values = new Values[3]
					{
						new HP(9),
						new Block(42),
						new Water(20)
					}
				},
				new Enchantment
				{
					id = 114,
					name = "Common Gem Fossil",
					level = 51,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(45),
						new Illusion(20)
					}
				},
				new Enchantment
				{
					id = 115,
					name = "Common Rose Stone",
					level = 51,
					position = "10000100",
					values = new Values[1]
					{
						new Speed(39)
					}
				},
				new Enchantment
				{
					id = 116,
					name = "Exquisite Dragon Egg Stone",
					level = 61,
					position = "00000011",
					values = new Values[2]
					{
						new Defense(35),
						new PHP(54)
					}
				},
				new Enchantment
				{
					id = 117,
					name = "Exquisite Ice Crystal Stone",
					level = 61,
					position = "00000011",
					values = new Values[1]
					{
						new Constitution(66)
					}
				},
				new Enchantment
				{
					id = 118,
					name = "Exquisite Princess Stone",
					level = 61,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(27),
						new ArmorBreak(41)
					}
				},
				new Enchantment
				{
					id = 119,
					name = "Exquisite Knowledge Stone",
					level = 61,
					position = "00110000",
					values = new Values[2]
					{
						new Chakra(17),
						new Tool(20)
					}
				},
				new Enchantment
				{
					id = 120,
					name = "Exquisite Starlight Stone",
					level = 61,
					position = "10000100",
					values = new Values[3]
					{
						new Hit(46),
						new Pierce(46),
						new MaxAtk(3)
					}
				},
				new Enchantment
				{
					id = 121,
					name = "Exquisite Ocean Heart",
					level = 61,
					position = "01001000",
					values = new Values[3]
					{
						new HP(11),
						new Block(45),
						new Water(20)
					}
				},
				new Enchantment
				{
					id = 122,
					name = "Exquisite Gem Fossil",
					level = 61,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(48),
						new Illusion(20)
					}
				},
				new Enchantment
				{
					id = 123,
					name = "Exquisite Rose Stone",
					level = 61,
					position = "10000100",
					values = new Values[1]
					{
						new Speed(43)
					}
				},
				new Enchantment
				{
					id = 124,
					name = "Perfect Dragon Egg Stone",
					level = 71,
					position = "00000011",
					values = new Values[2]
					{
						new Defense(39),
						new PHP(59)
					}
				},
				new Enchantment
				{
					id = 125,
					name = "Perfect Ice Crystal Stone",
					level = 71,
					position = "00000011",
					values = new Values[1]
					{
						new Constitution(71)
					}
				},
				new Enchantment
				{
					id = 126,
					name = "Perfect Princess Stone",
					level = 71,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(29),
						new ArmorBreak(46)
					}
				},
				new Enchantment
				{
					id = 127,
					name = "Perfect Knowledge Stone",
					level = 71,
					position = "00110000",
					values = new Values[2]
					{
						new Chakra(21),
						new Tool(20)
					}
				},
				new Enchantment
				{
					id = 128,
					name = "Perfect Starlight Stone",
					level = 71,
					position = "10000100",
					values = new Values[3]
					{
						new Hit(49),
						new Pierce(49),
						new MaxAtk(4)
					}
				},
				new Enchantment
				{
					id = 129,
					name = "Perfect Ocean Heart",
					level = 71,
					position = "01001000",
					values = new Values[3]
					{
						new HP(14),
						new Block(48),
						new Water(20)
					}
				},
				new Enchantment
				{
					id = 130,
					name = "Perfect Gem Fossil",
					level = 71,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(51),
						new Illusion(20)
					}
				},
				new Enchantment
				{
					id = 131,
					name = "Perfect Rose Stone",
					level = 71,
					position = "10000100",
					values = new Values[1]
					{
						new Speed(48)
					}
				},
				new Enchantment
				{
					id = 132,
					name = "Legend Dragon Egg Stone",
					level = 81,
					position = "00000011",
					values = new Values[2]
					{
						new Defense(43),
						new PHP(65)
					}
				},
				new Enchantment
				{
					id = 133,
					name = "Legend Ice Crystal Stone",
					level = 81,
					position = "00000011",
					values = new Values[1]
					{
						new Constitution(75)
					}
				},
				new Enchantment
				{
					id = 134,
					name = "Legend Princess Stone",
					level = 81,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(31),
						new ArmorBreak(50)
					}
				},
				new Enchantment
				{
					id = 135,
					name = "Legend Knowledge Stone",
					level = 81,
					position = "00110000",
					values = new Values[2]
					{
						new Chakra(25),
						new Tool(20)
					}
				},
				new Enchantment
				{
					id = 136,
					name = "Legend Starlight Stone",
					level = 81,
					position = "10000100",
					values = new Values[3]
					{
						new Hit(52),
						new Pierce(52),
						new MaxAtk(5)
					}
				},
				new Enchantment
				{
					id = 137,
					name = "Legend Ocean Heart",
					level = 81,
					position = "01001000",
					values = new Values[3]
					{
						new HP(16),
						new Block(50),
						new Water(20)
					}
				},
				new Enchantment
				{
					id = 138,
					name = "Legend Gem Fossil",
					level = 81,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(54),
						new Illusion(20)
					}
				},
				new Enchantment
				{
					id = 139,
					name = "Legend Rose Stone",
					level = 81,
					position = "10000100",
					values = new Values[1]
					{
						new Speed(52)
					}
				},
				new Enchantment
				{
					id = 140,
					name = "Immortal Dragon Egg Stone",
					level = 91,
					position = "00000011",
					values = new Values[2]
					{
						new Defense(47),
						new PHP(70)
					}
				},
				new Enchantment
				{
					id = 141,
					name = "Immortal Ice Crystal Stone",
					level = 91,
					position = "00000011",
					values = new Values[1]
					{
						new Constitution(80)
					}
				},
				new Enchantment
				{
					id = 142,
					name = "Immortal Princess Stone",
					level = 91,
					position = "00110000",
					values = new Values[2]
					{
						new Critical(33),
						new ArmorBreak(55)
					}
				},
				new Enchantment
				{
					id = 143,
					name = "Immortal Knowledge Stone",
					level = 91,
					position = "00110000",
					values = new Values[2]
					{
						new Chakra(29),
						new Tool(20)
					}
				},
				new Enchantment
				{
					id = 144,
					name = "Immortal Starlight Stone",
					level = 91,
					position = "10000100",
					values = new Values[3]
					{
						new Hit(54),
						new Pierce(54),
						new MaxAtk(6)
					}
				},
				new Enchantment
				{
					id = 145,
					name = "Immortal Ocean Heart",
					level = 91,
					position = "01001000",
					values = new Values[3]
					{
						new HP(19),
						new Block(53),
						new Water(20)
					}
				},
				new Enchantment
				{
					id = 146,
					name = "Immortal Gem Fossil",
					level = 91,
					position = "01001000",
					values = new Values[2]
					{
						new Dodge(57),
						new Illusion(20)
					}
				},
				new Enchantment
				{
					id = 147,
					name = "Immortal Rose Stone",
					level = 91,
					position = "10000100",
					values = new Values[1]
					{
						new Speed(57)
					}
				},
				new Enchantment
				{
					id = 148,
					name = "Azure Dragon's Vigor",
					level = 81,
					position = "01001000",
					values = new Values[2]
					{
						new ArmorBreak(50),
						new PAtk(19)
					}
				},
				new Enchantment
				{
					id = 149,
					name = "White Tiger's Vigor",
					level = 81,
					position = "00110000",
					values = new Values[2]
					{
						new Hit(53),
						new Stamina(28)
					}
				},
				new Enchantment
				{
					id = 150,
					name = "Black Tortoise's Vigor",
					level = 81,
					position = "10000100",
					values = new Values[2]
					{
						new HP(15),
						new Defense(42)
					}
				},
				new Enchantment
				{
					id = 151,
					name = "Vermillion Bird's Vigor",
					level = 81,
					position = "00000011",
					values = new Values[2]
					{
						new Speed(52),
						new Dodge(56)
					}
				},
				new Enchantment
				{
					id = 152,
					name = "Sunstone",
					level = 81,
					position = "01001000",
					values = new Values[3]
					{
						new Hit(60),
						new MaxAtk(6),
						new Lightning(20)
					}
				},
				new Enchantment
				{
					id = 153,
					name = "Moonstone",
					level = 81,
					position = "10000100",
					values = new Values[2]
					{
						new Agility(28),
						new Critical(45)
					}
				},
				new Enchantment
				{
					id = 154,
					name = "Dawn Stone",
					level = 81,
					position = "00110000",
					values = new Values[3]
					{
						new HP(20),
						new Constitution(75),
						new Healing(20)
					}
				},
				new Enchantment
				{
					id = 155,
					name = "Aerolite Stone",
					level = 81,
					position = "00000011",
					values = new Values[2]
					{
						new Hit(60),
						new MinAtk(5)
					}
				},
				new Enchantment
				{
					id = 156,
					name = "Azure Dragon's Heart",
					level = 91,
					position = "01001000",
					values = new Values[2]
					{
						new ArmorBreak(65),
						new PAtk(25)
					}
				},
				new Enchantment
				{
					id = 157,
					name = "White Tiger's Heart",
					level = 91,
					position = "00110000",
					values = new Values[2]
					{
						new Hit(69),
						new Stamina(36)
					}
				},
				new Enchantment
				{
					id = 158,
					name = "Black Tortoise's Heart",
					level = 91,
					position = "10000100",
					values = new Values[2]
					{
						new HP(20),
						new Defense(55)
					}
				},
				new Enchantment
				{
					id = 159,
					name = "Vermillion Bird's Heart",
					level = 91,
					position = "00000011",
					values = new Values[2]
					{
						new Speed(68),
						new Dodge(73)
					}
				},
				new Enchantment
				{
					id = 160,
					name = "Heliocenter Stone",
					level = 91,
					position = "01001000",
					values = new Values[3]
					{
						new Hit(78),
						new MaxAtk(8),
						new Lightning(30)
					}
				},
				new Enchantment
				{
					id = 161,
					name = "Selenocenter Stone",
					level = 91,
					position = "10000100",
					values = new Values[2]
					{
						new Agility(36),
						new Critical(59)
					}
				},
				new Enchantment
				{
					id = 162,
					name = "Dawncenter Stone",
					level = 91,
					position = "00110000",
					values = new Values[3]
					{
						new HP(26),
						new Constitution(98),
						new Healing(30)
					}
				},
				new Enchantment
				{
					id = 163,
					name = "Meteocenter Stone",
					level = 91,
					position = "00000011",
					values = new Values[2]
					{
						new Hit(78),
						new MinAtk(7)
					}
				},
				new Enchantment
				{
					id = 164,
					name = "Soul of Azure Dragon",
					level = 71,
					position = "01001000",
					values = new Values[2]
					{
						new ArmorBreak(46),
						new PAtk(18)
					}
				},
				new Enchantment
				{
					id = 165,
					name = "Soul of Black Tortoise",
					level = 71,
					position = "10000100",
					values = new Values[2]
					{
						new HP(14),
						new Defense(39)
					}
				},
				new Enchantment
				{
					id = 166,
					name = "Soul of Vermillion Bird",
					level = 71,
					position = "00000011",
					values = new Values[2]
					{
						new Speed(48),
						new Dodge(51)
					}
				},
				new Enchantment
				{
					id = 167,
					name = "Soul of White Tiger",
					level = 71,
					position = "00110000",
					values = new Values[2]
					{
						new Hit(49),
						new Stamina(26)
					}
				},
				new Enchantment
				{
					id = 168,
					name = "Bloodthirsty Enchantment Stone",
					level = 91,
					position = "01001000",
					values = new Values[2]
					{
						new Defense(60),
						new Fire(30)
					}
				},
				new Enchantment
				{
					id = 169,
					name = "Illusion Enchantment Stone",
					level = 91,
					position = "00110000",
					values = new Values[2]
					{
						new Hit(90),
						new HPAbsorb(30)
					}
				},
				new Enchantment
				{
					id = 170,
					name = "Holy Enchantment Stone",
					level = 91,
					position = "10000100",
					values = new Values[2]
					{
						new Critical(75),
						new DmgReduction(30)
					}
				},
				new Enchantment
				{
					id = 171,
					name = "Eternal Enchantment Stone",
					level = 91,
					position = "00000011",
					values = new Values[3]
					{
						new MaxAtk(15),
						new Block(45),
						new Water(30)
					}
				},
				new Enchantment
				{
					id = 172,
					name = "[S]Azure Dragon's Heart",
					level = 101,
					position = "01001000",
					values = new Values[2]
					{
						new ArmorBreak(85),
						new PAtk(33)
					}
				},
				new Enchantment
				{
					id = 173,
					name = "[S]White Tiger's Heart",
					level = 101,
					position = "00110000",
					values = new Values[2]
					{
						new Hit(90),
						new Stamina(46)
					}
				},
				new Enchantment
				{
					id = 174,
					name = "[S]Black Tortoise's Heart",
					level = 101,
					position = "10000100",
					values = new Values[2]
					{
						new HP(26),
						new Defense(76)
					}
				},
				new Enchantment
				{
					id = 175,
					name = "[S]Vermillion Bird's Heart",
					level = 101,
					position = "00000011",
					values = new Values[2]
					{
						new Speed(89),
						new Dodge(95)
					}
				},
				new Enchantment
				{
					id = 176,
					name = "[S]Heliocenter Stone",
					level = 101,
					position = "01001000",
					values = new Values[3]
					{
						new Hit(102),
						new MaxAtk(10),
						new Lightning(43)
					}
				},
				new Enchantment
				{
					id = 177,
					name = "[S]Selenocenter Stone",
					level = 101,
					position = "10000100",
					values = new Values[2]
					{
						new Agility(46),
						new Critical(77)
					}
				},
				new Enchantment
				{
					id = 178,
					name = "[S]Dawncenter Stone",
					level = 101,
					position = "00110000",
					values = new Values[3]
					{
						new HP(34),
						new Constitution(128),
						new Healing(43)
					}
				},
				new Enchantment
				{
					id = 179,
					name = "[S]Meteocenter Stone",
					level = 101,
					position = "00000011",
					values = new Values[2]
					{
						new Hit(102),
						new MinAtk(9)
					}
				},
				new Enchantment
				{
					id = 180,
					name = "[S]Bloodthirsty Enchantment Stone",
					level = 101,
					position = "01001000",
					values = new Values[2]
					{
						new Defense(86),
						new Fire(43)
					}
				},
				new Enchantment
				{
					id = 181,
					name = "[S]Illusion Enchantment Stone",
					level = 101,
					position = "00110000",
					values = new Values[2]
					{
						new Hit(129),
						new HPAbsorb(40)
					}
				},
				new Enchantment
				{
					id = 182,
					name = "[S]Holy Enchantment Stone",
					level = 101,
					position = "10000100",
					values = new Values[2]
					{
						new Critical(108),
						new DmgReduction(40)
					}
				},
				new Enchantment
				{
					id = 183,
					name = "[S]Eternal Enchantment Stone",
					level = 101,
					position = "00000011",
					values = new Values[3]
					{
						new MaxAtk(21),
						new Block(64),
						new Water(43)
					}
				}
			};
			gems = new Gem[108]
			{
				new Gem
				{
					id = 0,
					name = "Ruby 1",
					level = 1,
					values = new Values[1]
					{
						new Strength(14)
					}
				},
				new Gem
				{
					id = 1,
					name = "Ruby 2",
					level = 11,
					values = new Values[1]
					{
						new Strength(21)
					}
				},
				new Gem
				{
					id = 2,
					name = "Ruby 3",
					level = 21,
					values = new Values[1]
					{
						new Strength(28)
					}
				},
				new Gem
				{
					id = 3,
					name = "Ruby 4",
					level = 31,
					values = new Values[1]
					{
						new Strength(35)
					}
				},
				new Gem
				{
					id = 4,
					name = "Ruby 5",
					level = 41,
					values = new Values[1]
					{
						new Strength(42)
					}
				},
				new Gem
				{
					id = 5,
					name = "Ruby 6",
					level = 51,
					values = new Values[1]
					{
						new Strength(49)
					}
				},
				new Gem
				{
					id = 6,
					name = "Ruby 7",
					level = 61,
					values = new Values[1]
					{
						new Strength(56)
					}
				},
				new Gem
				{
					id = 7,
					name = "Ruby 8",
					level = 71,
					values = new Values[1]
					{
						new Strength(63)
					}
				},
				new Gem
				{
					id = 8,
					name = "Ruby 9",
					level = 81,
					values = new Values[1]
					{
						new Strength(70)
					}
				},
				new Gem
				{
					id = 9,
					name = "Ruby 10",
					level = 91,
					values = new Values[1]
					{
						new Strength(77)
					}
				},
				new Gem
				{
					id = 10,
					name = "Ruby 11",
					level = 101,
					values = new Values[1]
					{
						new Strength(84)
					}
				},
				new Gem
				{
					id = 11,
					name = "Ruby 12",
					level = 111,
					values = new Values[1]
					{
						new Strength(91)
					}
				},
				new Gem
				{
					id = 12,
					name = "Ruby 13",
					level = 121,
					values = new Values[1]
					{
						new Strength(98)
					}
				},
				new Gem
				{
					id = 13,
					name = "Sapphire 1",
					level = 1,
					values = new Values[1]
					{
						new Agility(14)
					}
				},
				new Gem
				{
					id = 14,
					name = "Sapphire 2",
					level = 11,
					values = new Values[1]
					{
						new Agility(21)
					}
				},
				new Gem
				{
					id = 15,
					name = "Sapphire 3",
					level = 21,
					values = new Values[1]
					{
						new Agility(28)
					}
				},
				new Gem
				{
					id = 16,
					name = "Sapphire 4",
					level = 31,
					values = new Values[1]
					{
						new Agility(35)
					}
				},
				new Gem
				{
					id = 17,
					name = "Sapphire 5",
					level = 41,
					values = new Values[1]
					{
						new Agility(42)
					}
				},
				new Gem
				{
					id = 18,
					name = "Sapphire 6",
					level = 51,
					values = new Values[1]
					{
						new Agility(49)
					}
				},
				new Gem
				{
					id = 19,
					name = "Sapphire 7",
					level = 61,
					values = new Values[1]
					{
						new Agility(56)
					}
				},
				new Gem
				{
					id = 20,
					name = "Sapphire 8",
					level = 71,
					values = new Values[1]
					{
						new Agility(63)
					}
				},
				new Gem
				{
					id = 21,
					name = "Sapphire 9",
					level = 81,
					values = new Values[1]
					{
						new Agility(70)
					}
				},
				new Gem
				{
					id = 22,
					name = "Sapphire 10",
					level = 91,
					values = new Values[1]
					{
						new Agility(77)
					}
				},
				new Gem
				{
					id = 23,
					name = "Sapphire 11",
					level = 101,
					values = new Values[1]
					{
						new Agility(84)
					}
				},
				new Gem
				{
					id = 24,
					name = "Sapphire 12",
					level = 111,
					values = new Values[1]
					{
						new Agility(91)
					}
				},
				new Gem
				{
					id = 25,
					name = "Sapphire 13",
					level = 121,
					values = new Values[1]
					{
						new Agility(98)
					}
				},
				new Gem
				{
					id = 26,
					name = "Topaz 1",
					level = 1,
					values = new Values[1]
					{
						new Stamina(14)
					}
				},
				new Gem
				{
					id = 27,
					name = "Topaz 2",
					level = 11,
					values = new Values[1]
					{
						new Stamina(21)
					}
				},
				new Gem
				{
					id = 28,
					name = "Topaz 3",
					level = 21,
					values = new Values[1]
					{
						new Stamina(28)
					}
				},
				new Gem
				{
					id = 29,
					name = "Topaz 4",
					level = 31,
					values = new Values[1]
					{
						new Stamina(35)
					}
				},
				new Gem
				{
					id = 30,
					name = "Topaz 5",
					level = 41,
					values = new Values[1]
					{
						new Stamina(42)
					}
				},
				new Gem
				{
					id = 31,
					name = "Topaz 6",
					level = 51,
					values = new Values[1]
					{
						new Stamina(49)
					}
				},
				new Gem
				{
					id = 32,
					name = "Topaz 7",
					level = 61,
					values = new Values[1]
					{
						new Stamina(56)
					}
				},
				new Gem
				{
					id = 33,
					name = "Topaz 8",
					level = 71,
					values = new Values[1]
					{
						new Stamina(63)
					}
				},
				new Gem
				{
					id = 34,
					name = "Topaz 9",
					level = 81,
					values = new Values[1]
					{
						new Stamina(70)
					}
				},
				new Gem
				{
					id = 35,
					name = "Topaz 10",
					level = 91,
					values = new Values[1]
					{
						new Stamina(77)
					}
				},
				new Gem
				{
					id = 36,
					name = "Topaz 11",
					level = 101,
					values = new Values[1]
					{
						new Stamina(84)
					}
				},
				new Gem
				{
					id = 37,
					name = "Topaz 12",
					level = 111,
					values = new Values[1]
					{
						new Stamina(91)
					}
				},
				new Gem
				{
					id = 38,
					name = "Topaz 13",
					level = 121,
					values = new Values[1]
					{
						new Stamina(98)
					}
				},
				new Gem
				{
					id = 39,
					name = "Emerald 1",
					level = 1,
					values = new Values[1]
					{
						new Speed(12)
					}
				},
				new Gem
				{
					id = 40,
					name = "Emerald 2",
					level = 11,
					values = new Values[1]
					{
						new Speed(18)
					}
				},
				new Gem
				{
					id = 41,
					name = "Emerald 3",
					level = 21,
					values = new Values[1]
					{
						new Speed(24)
					}
				},
				new Gem
				{
					id = 42,
					name = "Emerald 4",
					level = 31,
					values = new Values[1]
					{
						new Speed(30)
					}
				},
				new Gem
				{
					id = 43,
					name = "Emerald 5",
					level = 41,
					values = new Values[1]
					{
						new Speed(36)
					}
				},
				new Gem
				{
					id = 44,
					name = "Emerald 6",
					level = 51,
					values = new Values[1]
					{
						new Speed(42)
					}
				},
				new Gem
				{
					id = 45,
					name = "Emerald 7",
					level = 61,
					values = new Values[1]
					{
						new Speed(48)
					}
				},
				new Gem
				{
					id = 46,
					name = "Emerald 8",
					level = 71,
					values = new Values[1]
					{
						new Speed(54)
					}
				},
				new Gem
				{
					id = 47,
					name = "Emerald 9",
					level = 81,
					values = new Values[1]
					{
						new Speed(60)
					}
				},
				new Gem
				{
					id = 48,
					name = "Emerald 10",
					level = 91,
					values = new Values[1]
					{
						new Speed(66)
					}
				},
				new Gem
				{
					id = 49,
					name = "Emerald 11",
					level = 101,
					values = new Values[1]
					{
						new Speed(72)
					}
				},
				new Gem
				{
					id = 50,
					name = "Emerald 12",
					level = 111,
					values = new Values[1]
					{
						new Speed(78)
					}
				},
				new Gem
				{
					id = 51,
					name = "Emerald 13",
					level = 121,
					values = new Values[1]
					{
						new Speed(84)
					}
				},
				new Gem
				{
					id = 52,
					name = "Diamond 1",
					level = 1,
					values = new Values[1]
					{
						new PAtk(12)
					}
				},
				new Gem
				{
					id = 53,
					name = "Diamond 2",
					level = 11,
					values = new Values[1]
					{
						new PAtk(18)
					}
				},
				new Gem
				{
					id = 54,
					name = "Diamond 3",
					level = 21,
					values = new Values[1]
					{
						new PAtk(24)
					}
				},
				new Gem
				{
					id = 55,
					name = "Diamond 4",
					level = 31,
					values = new Values[1]
					{
						new PAtk(30)
					}
				},
				new Gem
				{
					id = 56,
					name = "Diamond 5",
					level = 41,
					values = new Values[1]
					{
						new PAtk(36)
					}
				},
				new Gem
				{
					id = 57,
					name = "Diamond 6",
					level = 51,
					values = new Values[1]
					{
						new PAtk(42)
					}
				},
				new Gem
				{
					id = 58,
					name = "Diamond 7",
					level = 61,
					values = new Values[1]
					{
						new PAtk(48)
					}
				},
				new Gem
				{
					id = 59,
					name = "Diamond 8",
					level = 71,
					values = new Values[1]
					{
						new PAtk(54)
					}
				},
				new Gem
				{
					id = 60,
					name = "Diamond 9",
					level = 81,
					values = new Values[1]
					{
						new PAtk(60)
					}
				},
				new Gem
				{
					id = 61,
					name = "Diamond 10",
					level = 91,
					values = new Values[1]
					{
						new PAtk(66)
					}
				},
				new Gem
				{
					id = 62,
					name = "Diamond 11",
					level = 101,
					values = new Values[1]
					{
						new PAtk(72)
					}
				},
				new Gem
				{
					id = 63,
					name = "Diamond 12",
					level = 111,
					values = new Values[1]
					{
						new PAtk(78)
					}
				},
				new Gem
				{
					id = 64,
					name = "Diamond 13",
					level = 121,
					values = new Values[1]
					{
						new PAtk(84)
					}
				},
				new Gem
				{
					id = 65,
					name = "Agate 1",
					level = 1,
					values = new Values[1]
					{
						new PHP(12)
					}
				},
				new Gem
				{
					id = 66,
					name = "Agate 2",
					level = 11,
					values = new Values[1]
					{
						new PHP(18)
					}
				},
				new Gem
				{
					id = 67,
					name = "Agate 3",
					level = 21,
					values = new Values[1]
					{
						new PHP(24)
					}
				},
				new Gem
				{
					id = 68,
					name = "Agate 4",
					level = 31,
					values = new Values[1]
					{
						new PHP(30)
					}
				},
				new Gem
				{
					id = 69,
					name = "Agate 5",
					level = 41,
					values = new Values[1]
					{
						new PHP(36)
					}
				},
				new Gem
				{
					id = 70,
					name = "Agate 6",
					level = 51,
					values = new Values[1]
					{
						new PHP(42)
					}
				},
				new Gem
				{
					id = 71,
					name = "Agate 7",
					level = 61,
					values = new Values[1]
					{
						new PHP(48)
					}
				},
				new Gem
				{
					id = 72,
					name = "Agate 8",
					level = 71,
					values = new Values[1]
					{
						new PHP(54)
					}
				},
				new Gem
				{
					id = 73,
					name = "Agate 9",
					level = 81,
					values = new Values[1]
					{
						new PHP(60)
					}
				},
				new Gem
				{
					id = 74,
					name = "Agate 10",
					level = 91,
					values = new Values[1]
					{
						new PHP(66)
					}
				},
				new Gem
				{
					id = 75,
					name = "Agate 11",
					level = 101,
					values = new Values[1]
					{
						new PHP(72)
					}
				},
				new Gem
				{
					id = 76,
					name = "Agate 12",
					level = 111,
					values = new Values[1]
					{
						new PHP(78)
					}
				},
				new Gem
				{
					id = 77,
					name = "Agate 13",
					level = 121,
					values = new Values[1]
					{
						new PHP(84)
					}
				},
				new Gem
				{
					id = 78,
					name = "Stone of Venus",
					level = 91,
					values = new Values[2]
					{
						new ArmorBreak(55),
						new Speed(51)
					}
				},
				new Gem
				{
					id = 79,
					name = "Stone of Jupiter",
					level = 91,
					values = new Values[2]
					{
						new Dodge(44),
						new PHP(51)
					}
				},
				new Gem
				{
					id = 80,
					name = "Stone of Mars",
					level = 91,
					values = new Values[2]
					{
						new HP(61),
						new PAtk(51)
					}
				},
				new Gem
				{
					id = 81,
					name = "Stone of Daystar",
					level = 91,
					values = new Values[2]
					{
						new Constitution(62),
						new Strength(60)
					}
				},
				new Gem
				{
					id = 82,
					name = "Stone of Saturn",
					level = 91,
					values = new Values[2]
					{
						new Pierce(68),
						new Stamina(60)
					}
				},
				new Gem
				{
					id = 83,
					name = "Stone of Phospherus",
					level = 91,
					values = new Values[2]
					{
						new Defense(72),
						new Agility(60)
					}
				},
				new Gem
				{
					id = 84,
					name = "Heart of Shukaku",
					level = 71,
					values = new Values[1]
					{
						new Strength(77)
					}
				},
				new Gem
				{
					id = 85,
					name = "Heart of Nekomata",
					level = 71,
					values = new Values[1]
					{
						new Agility(77)
					}
				},
				new Gem
				{
					id = 86,
					name = "Heart of Isonade",
					level = 71,
					values = new Values[1]
					{
						new Stamina(77)
					}
				},
				new Gem
				{
					id = 87,
					name = "Heart of Sokou",
					level = 71,
					values = new Values[1]
					{
						new Speed(66)
					}
				},
				new Gem
				{
					id = 88,
					name = "Heart of Houkou",
					level = 71,
					values = new Values[1]
					{
						new PAtk(66)
					}
				},
				new Gem
				{
					id = 89,
					name = "Heart of Raijuu",
					level = 71,
					values = new Values[1]
					{
						new PHP(66)
					}
				},
				new Gem
				{
					id = 90,
					name = "Gem of Venus",
					level = 101,
					values = new Values[2]
					{
						new ArmorBreak(72),
						new Speed(65)
					}
				},
				new Gem
				{
					id = 91,
					name = "Gem of Jupiter",
					level = 101,
					values = new Values[2]
					{
						new Dodge(52),
						new PHP(65)
					}
				},
				new Gem
				{
					id = 92,
					name = "Gem of Mars",
					level = 101,
					values = new Values[2]
					{
						new HP(80),
						new PAtk(65)
					}
				},
				new Gem
				{
					id = 93,
					name = "Gem of Daystar",
					level = 101,
					values = new Values[2]
					{
						new Constitution(75),
						new Strength(80)
					}
				},
				new Gem
				{
					id = 94,
					name = "Gem of Saturn",
					level = 101,
					values = new Values[2]
					{
						new Pierce(78),
						new Stamina(80)
					}
				},
				new Gem
				{
					id = 95,
					name = "Gem of Phospherus",
					level = 101,
					values = new Values[2]
					{
						new Defense(92),
						new Agility(80)
					}
				},
				new Gem
				{
					id = 96,
					name = "Heart of Shukaku+1",
					level = 81,
					values = new Values[2]
					{
						new Strength(77),
						new ArmorBreak(37)
					}
				},
				new Gem
				{
					id = 97,
					name = "Heart of Nekomata+1",
					level = 81,
					values = new Values[2]
					{
						new Agility(77),
						new Critical(28)
					}
				},
				new Gem
				{
					id = 98,
					name = "Heart of Isonade+1",
					level = 81,
					values = new Values[2]
					{
						new Stamina(77),
						new Hit(50)
					}
				},
				new Gem
				{
					id = 99,
					name = "Heart of Sokou+1",
					level = 81,
					values = new Values[2]
					{
						new Speed(66),
						new MaxAtk(10)
					}
				},
				new Gem
				{
					id = 100,
					name = "Heart of Houkou+1",
					level = 81,
					values = new Values[2]
					{
						new PAtk(66),
						new Defense(42)
					}
				},
				new Gem
				{
					id = 101,
					name = "Heart of Raijuu+1",
					level = 81,
					values = new Values[2]
					{
						new PHP(66),
						new Constitution(42)
					}
				},
				new Gem
				{
					id = 102,
					name = "Heart of Venus",
					level = 101,
					values = new Values[2]
					{
						new ArmorBreak(89),
						new Speed(79)
					}
				},
				new Gem
				{
					id = 103,
					name = "Heart of Jupiter",
					level = 101,
					values = new Values[2]
					{
						new Dodge(60),
						new PHP(79)
					}
				},
				new Gem
				{
					id = 104,
					name = "Heart of Mars",
					level = 101,
					values = new Values[2]
					{
						new HP(99),
						new PAtk(79)
					}
				},
				new Gem
				{
					id = 105,
					name = "Heart of Daystar",
					level = 101,
					values = new Values[2]
					{
						new Constitution(88),
						new Strength(100)
					}
				},
				new Gem
				{
					id = 106,
					name = "Heart of Saturn",
					level = 101,
					values = new Values[2]
					{
						new Pierce(88),
						new Stamina(100)
					}
				},
				new Gem
				{
					id = 107,
					name = "Heart of Phospherus",
					level = 101,
					values = new Values[2]
					{
						new Defense(112),
						new Agility(100)
					}
				}
			};
			Equipment[] array48 = new Equipment[809];
			array48[0] = new Equipment
			{
				id = 0,
				name = "1 Weapon",
				image = Resources._1fist,
				level = 1,
				attack = new int[2] { 14, 16 },
				type = 0
			};
			array48[1] = new Equipment
			{
				id = 1,
				name = "Child's Armor",
				image = Resources._2armor,
				level = 2,
				defense = 71,
				type = 5
			};
			array48[2] = new Equipment
			{
				id = 2,
				name = "Child's Hat",
				image = Resources._3helm,
				level = 3,
				defense = 24,
				type = 4
			};
			array48[3] = new Equipment
			{
				id = 3,
				name = "Blue Tourmaline",
				image = Resources._4amulet,
				level = 4,
				type = 3
			};
			array48[4] = new Equipment
			{
				id = 4,
				name = "Child's Shoes",
				image = Resources._5boots,
				level = 5,
				defense = 20,
				type = 7
			};
			array48[5] = new Equipment
			{
				id = 5,
				name = "6 Weapon",
				image = Resources._6fist,
				level = 6,
				attack = new int[2] { 19, 23 },
				type = 0
			};
			array48[6] = new Equipment
			{
				id = 6,
				name = "Village Wear",
				image = Resources._7armor,
				level = 7,
				defense = 87,
				type = 5
			};
			array48[7] = new Equipment
			{
				id = 7,
				name = "Bamboo Gloves",
				image = Resources._8gloves,
				level = 8,
				defense = 22,
				type = 1
			};
			array48[8] = new Equipment
			{
				id = 8,
				name = "Bamboo Belt",
				image = Resources._9belt,
				level = 9,
				defense = 19,
				type = 6
			};
			array48[9] = new Equipment
			{
				id = 9,
				name = "Goldjade Ring",
				image = Resources._10ring,
				level = 10,
				type = 2
			};
			array48[10] = new Equipment
			{
				id = 10,
				name = "11 Weapon",
				image = Resources._11fist,
				level = 11,
				attack = new int[2] { 27, 32 },
				type = 0
			};
			array48[11] = new Equipment
			{
				id = 11,
				name = "Ironplate Chest",
				image = Resources._12armor,
				level = 12,
				defense = 103,
				type = 5
			};
			array48[12] = new Equipment
			{
				id = 12,
				name = "Ironhawk Hat",
				image = Resources._13helm,
				level = 13,
				defense = 34,
				type = 4
			};
			array48[13] = new Equipment
			{
				id = 13,
				name = "Purple Tourmaline",
				image = Resources._14amulet,
				level = 14,
				type = 3
			};
			array48[14] = new Equipment
			{
				id = 14,
				name = "Iron Warboots",
				image = Resources._15boots,
				level = 15,
				defense = 28,
				type = 7
			};
			array48[15] = new Equipment
			{
				id = 15,
				name = "16 Weapon",
				image = Resources._16fist,
				level = 16,
				attack = new int[2] { 34, 41 },
				type = 0
			};
			array48[16] = new Equipment
			{
				id = 16,
				name = "Vibrant Barment",
				image = Resources._17armor,
				level = 17,
				defense = 119,
				type = 5
			};
			array48[17] = new Equipment
			{
				id = 17,
				name = "Athletic Gloves",
				image = Resources._18gloves,
				level = 18,
				defense = 30,
				type = 1
			};
			array48[18] = new Equipment
			{
				id = 18,
				name = "Athletic Belt",
				image = Resources._19belt,
				level = 19,
				defense = 25,
				type = 6
			};
			array48[19] = new Equipment
			{
				id = 19,
				name = "Flora Ring",
				image = Resources._20_floraring,
				level = 20,
				type = 2
			};
			array48[20] = new Equipment
			{
				id = 20,
				name = "21 Weapon",
				image = Resources._21fist,
				level = 21,
				attack = new int[2] { 42, 51 },
				type = 0
			};
			array48[21] = new Equipment
			{
				id = 21,
				name = "Light Leather Chestguard",
				image = Resources._22armor,
				level = 22,
				defense = 135,
				type = 5
			};
			array48[22] = new Equipment
			{
				id = 22,
				name = "Light Leather Hat",
				image = Resources._23helm,
				level = 23,
				defense = 44,
				type = 4
			};
			array48[23] = new Equipment
			{
				id = 23,
				name = "Deep Blue Pendant",
				image = Resources._24amulet,
				level = 24,
				type = 3
			};
			array48[24] = new Equipment
			{
				id = 24,
				name = "Light Leather Boots",
				image = Resources._25boots,
				level = 25,
				defense = 36,
				type = 7
			};
			array48[25] = new Equipment
			{
				id = 25,
				name = "26 Weapon",
				image = Resources._26fist,
				level = 26,
				attack = new int[2] { 50, 60 },
				type = 0
			};
			array48[26] = new Equipment
			{
				id = 26,
				name = "Tortoise Chest",
				image = Resources._27armor,
				level = 27,
				defense = 151,
				type = 5
			};
			array48[27] = new Equipment
			{
				id = 27,
				name = "Tortoise Gloves",
				image = Resources._28gloves,
				level = 28,
				defense = 38,
				type = 1
			};
			array48[28] = new Equipment
			{
				id = 28,
				name = "Tortoise Belt",
				image = Resources._29belt,
				level = 29,
				defense = 32,
				type = 6
			};
			array48[29] = new Equipment
			{
				id = 29,
				name = "Lush Ring",
				image = Resources._30ring,
				level = 30,
				type = 2
			};
			array48[30] = new Equipment
			{
				id = 30,
				name = "31 Weapon",
				image = Resources._31fist,
				level = 31,
				attack = new int[2] { 59, 71 },
				type = 0
			};
			array48[31] = new Equipment
			{
				id = 31,
				name = "Veiled Garb",
				image = Resources._32armor,
				level = 32,
				defense = 167,
				type = 5
			};
			array48[32] = new Equipment
			{
				id = 32,
				name = "Veiled Faceguard",
				image = Resources._33helm,
				level = 33,
				defense = 55,
				type = 4
			};
			array48[33] = new Equipment
			{
				id = 33,
				name = "Rose Resolve",
				image = Resources._34amulet,
				level = 34,
				type = 3
			};
			array48[34] = new Equipment
			{
				id = 34,
				name = "Veiled Boots",
				image = Resources._35boots,
				level = 35,
				defense = 44,
				type = 7
			};
			array48[35] = new Equipment
			{
				id = 35,
				name = "36 Weapon",
				image = Resources._36fist,
				level = 36,
				attack = new int[2] { 67, 82 },
				type = 0
			};
			array48[36] = new Equipment
			{
				id = 36,
				name = "Feline Coat Armor",
				image = Resources._37armor,
				level = 37,
				defense = 183,
				type = 5
			};
			array48[37] = new Equipment
			{
				id = 37,
				name = "Feline Gloves",
				image = Resources._38gloves,
				level = 38,
				defense = 46,
				type = 1
			};
			array48[38] = new Equipment
			{
				id = 38,
				name = "Feline Belt",
				image = Resources._39belt,
				level = 39,
				defense = 39,
				type = 6
			};
			array48[39] = new Equipment
			{
				id = 39,
				name = "Turmeric Ring",
				image = Resources._40ring,
				level = 40,
				type = 2
			};
			array48[40] = new Equipment
			{
				id = 40,
				name = "41 Weapon",
				image = Resources._41fist,
				level = 41,
				attack = new int[2] { 77, 93 },
				type = 0
			};
			array48[41] = new Equipment
			{
				id = 41,
				name = "Flamecloud Warchest",
				image = Resources._42armor,
				level = 42,
				defense = 199,
				type = 5
			};
			array48[42] = new Equipment
			{
				id = 42,
				name = "Flamecloud Hat",
				image = Resources._43helm,
				level = 43,
				defense = 65,
				type = 4
			};
			array48[43] = new Equipment
			{
				id = 43,
				name = "Roren Resolve",
				image = Resources._44amulet,
				level = 44,
				type = 3
			};
			array48[44] = new Equipment
			{
				id = 44,
				name = "Flamecloud Warboots",
				image = Resources._45boots,
				level = 45,
				defense = 52,
				type = 7
			};
			array48[45] = new Equipment
			{
				id = 45,
				name = "46 Weapon",
				image = Resources._46fist,
				level = 46,
				attack = new int[2] { 86, 105 },
				type = 0
			};
			array48[46] = new Equipment
			{
				id = 46,
				name = "Windstorm Clothes",
				image = Resources._47armor,
				level = 47,
				defense = 215,
				type = 5
			};
			array48[47] = new Equipment
			{
				id = 47,
				name = "Windstorm Girdle",
				image = Resources._48gloves,
				level = 48,
				defense = 54,
				type = 1
			};
			array48[48] = new Equipment
			{
				id = 48,
				name = "Windstorm Girdle",
				image = Resources._49belt,
				level = 49,
				defense = 45,
				type = 6
			};
			array48[49] = new Equipment
			{
				id = 49,
				name = "Prosperous Ring",
				image = Resources._50ring,
				level = 50,
				type = 2
			};
			array48[50] = new Equipment
			{
				id = 50,
				name = "51 Weapon",
				image = Resources._51fist,
				level = 51,
				attack = new int[2] { 96, 117 },
				type = 0
			};
			array48[51] = new Equipment
			{
				id = 51,
				name = "Catspring Armor",
				image = Resources._52armor,
				level = 52,
				defense = 231,
				type = 5
			};
			array48[52] = new Equipment
			{
				id = 52,
				name = "Catspring Helm",
				image = Resources._53helm,
				level = 53,
				defense = 75,
				type = 4
			};
			array48[53] = new Equipment
			{
				id = 53,
				name = "Majestic Heart",
				image = Resources._54amulet,
				level = 54,
				type = 3
			};
			array48[54] = new Equipment
			{
				id = 54,
				name = "Catspring Boots",
				image = Resources._55boots,
				level = 55,
				defense = 60,
				type = 7
			};
			array48[55] = new Equipment
			{
				id = 55,
				name = "56 Weapon",
				image = Resources._56fist,
				level = 56,
				attack = new int[2] { 106, 130 },
				type = 0
			};
			array48[56] = new Equipment
			{
				id = 56,
				name = "Adamanite Warchest",
				image = Resources._57armor,
				level = 57,
				defense = 247,
				type = 5
			};
			array48[57] = new Equipment
			{
				id = 57,
				name = "Adamantine Gloves",
				image = Resources._58gloves,
				level = 58,
				defense = 62,
				type = 1
			};
			array48[58] = new Equipment
			{
				id = 58,
				name = "Adamantine Belt",
				image = Resources._59belt,
				level = 59,
				defense = 52,
				type = 6
			};
			array48[59] = new Equipment
			{
				id = 59,
				name = "Love Ring",
				image = Resources._60_lovering,
				level = 60,
				type = 2
			};
			array48[60] = new Equipment
			{
				id = 60,
				name = "61 Weapon",
				image = Resources._61fist,
				level = 61,
				attack = new int[2] { 117, 143 },
				type = 0
			};
			array48[61] = new Equipment
			{
				id = 61,
				name = "Netherchill Warchest",
				image = Resources._62armor,
				level = 62,
				defense = 263,
				type = 5
			};
			array48[62] = new Equipment
			{
				id = 62,
				name = "Netherchill Battle Helm",
				image = Resources._63helm,
				level = 63,
				defense = 86,
				type = 4
			};
			array48[63] = new Equipment
			{
				id = 63,
				name = "Froststar Necklace",
				image = Resources._64amulet,
				level = 64,
				type = 3
			};
			array48[64] = new Equipment
			{
				id = 64,
				name = "Netherchill Warboots",
				image = Resources._65boots,
				level = 65,
				defense = 68,
				type = 7
			};
			array48[65] = new Equipment
			{
				id = 65,
				name = "66 Weapon",
				image = Resources._66fist,
				level = 66,
				attack = new int[2] { 129, 156 },
				type = 0
			};
			array48[66] = new Equipment
			{
				id = 66,
				name = "Darksoul Warchest",
				image = Resources._67armor,
				level = 67,
				defense = 279,
				type = 5
			};
			array48[67] = new Equipment
			{
				id = 67,
				name = "Netherchill Gloves",
				image = Resources._68gloves,
				level = 68,
				defense = 70,
				type = 1
			};
			array48[68] = new Equipment
			{
				id = 68,
				name = "Netherchill Steel Belt",
				image = Resources._69belt,
				level = 69,
				defense = 58,
				type = 6
			};
			array48[69] = new Equipment
			{
				id = 69,
				name = "Froststar Ring",
				image = Resources._70ring,
				level = 70,
				type = 2
			};
			array48[70] = new Equipment
			{
				id = 70,
				name = "71 Weapon",
				image = Resources._71fist,
				level = 71,
				attack = new int[2] { 139, 170 },
				type = 0
			};
			array48[71] = new Equipment
			{
				id = 71,
				name = "",
				image = Resources._72armor,
				level = 72,
				defense = 295,
				type = 5
			};
			array48[72] = new Equipment
			{
				id = 72,
				name = "Purple Horn Helm",
				image = Resources._73helm,
				level = 73,
				defense = 96,
				type = 4
			};
			array48[73] = new Equipment
			{
				id = 73,
				name = "",
				image = Resources._74amulet,
				level = 74,
				type = 3
			};
			array48[74] = new Equipment
			{
				id = 74,
				name = "Purple Boots",
				image = Resources._75boots,
				level = 75,
				defense = 76,
				type = 7
			};
			array48[75] = new Equipment
			{
				id = 75,
				name = "76 Weapon",
				image = Resources._76fist,
				level = 76,
				attack = new int[2] { 151, 184 },
				type = 0
			};
			array48[76] = new Equipment
			{
				id = 76,
				name = "Demon Light Armor",
				image = Resources._77armor,
				level = 77,
				defense = 311,
				type = 5
			};
			array48[77] = new Equipment
			{
				id = 77,
				name = "Purple Gloves",
				image = Resources._78gloves,
				level = 78,
				defense = 78,
				type = 1
			};
			array48[78] = new Equipment
			{
				id = 78,
				name = "Purple Belt",
				image = Resources._79belt,
				level = 79,
				defense = 65,
				type = 6
			};
			array48[79] = new Equipment
			{
				id = 79,
				name = "Aurora Ring",
				image = Resources._80ring,
				level = 80,
				type = 2
			};
			array48[80] = new Equipment
			{
				id = 80,
				name = "81 Weapon",
				image = Resources._81fist,
				level = 81,
				attack = new int[2] { 163, 198 },
				type = 0
			};
			array48[81] = new Equipment
			{
				id = 81,
				name = "Wonderland Coat",
				image = Resources._82armor,
				level = 82,
				defense = 327,
				type = 5
			};
			array48[82] = new Equipment
			{
				id = 82,
				name = "Fiend Helm",
				image = Resources._83helm,
				level = 83,
				defense = 106,
				type = 4
			};
			array48[83] = new Equipment
			{
				id = 83,
				name = "Brave Heart",
				image = Resources._84amulet,
				level = 84,
				type = 3
			};
			array48[84] = new Equipment
			{
				id = 84,
				name = "High Winds Boots",
				image = Resources._85boots,
				level = 85,
				defense = 84,
				type = 7
			};
			array48[85] = new Equipment
			{
				id = 85,
				name = "86 Weapon",
				image = Resources._86fist,
				level = 86,
				attack = new int[2] { 176, 213 },
				type = 0
			};
			array48[86] = new Equipment
			{
				id = 86,
				name = "Magic Dragon Armor",
				image = Resources._87armor,
				level = 87,
				defense = 343,
				type = 5
			};
			array48[87] = new Equipment
			{
				id = 87,
				name = "Demon Break Gloves",
				image = Resources._88gloves,
				level = 88,
				defense = 86,
				type = 1
			};
			array48[88] = new Equipment
			{
				id = 88,
				name = "Heaven Belt",
				image = Resources._89belt,
				level = 89,
				defense = 71,
				type = 6
			};
			array48[89] = new Equipment
			{
				id = 89,
				name = "Dark Gold Ring",
				image = Resources._90ring,
				level = 90,
				type = 2
			};
			array48[90] = new Equipment
			{
				id = 90,
				name = "91 Weapon",
				image = Resources._91fist,
				level = 91,
				attack = new int[2] { 189, 228 },
				type = 0
			};
			array48[91] = new Equipment
			{
				id = 91,
				name = "Devil Lock Armor",
				image = Resources._92armor,
				level = 92,
				defense = 359,
				type = 5
			};
			array48[92] = new Equipment
			{
				id = 92,
				name = "Manes Wind Hat",
				image = Resources._93helm,
				level = 93,
				defense = 117,
				type = 4
			};
			array48[93] = new Equipment
			{
				id = 93,
				name = "War Amulet",
				image = Resources._94amulet,
				level = 94,
				type = 3
			};
			array48[94] = new Equipment
			{
				id = 94,
				name = "Manes Wind Boots",
				image = Resources._95boots,
				level = 95,
				defense = 92,
				type = 7
			};
			array48[95] = new Equipment
			{
				id = 95,
				name = "96 Weapon",
				image = Resources._96fist,
				level = 96,
				attack = new int[2] { 198, 238 },
				type = 0
			};
			array48[96] = new Equipment
			{
				id = 96,
				name = "Manes Voice Robe",
				image = Resources._97armor,
				level = 97,
				defense = 375,
				type = 5
			};
			array48[97] = new Equipment
			{
				id = 97,
				name = "Manes Wind Glove",
				image = Resources._98gloves,
				level = 98,
				defense = 94,
				type = 1
			};
			array48[98] = new Equipment
			{
				id = 98,
				name = "Manes Wind Belt",
				image = Resources._99belt,
				level = 99,
				defense = 77,
				type = 6
			};
			array48[99] = new Equipment
			{
				id = 99,
				name = "War Ring",
				image = Resources._100ring,
				level = 100,
				type = 2
			};
			Equipment equipment = new Equipment
			{
				id = 100,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment.attack = array3;
			equipment.type = 0;
			array48[100] = equipment;
			array48[101] = new Equipment
			{
				id = 101,
				name = "Armor",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[102] = new Equipment
			{
				id = 102,
				name = "Hat",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 4
			};
			array48[103] = new Equipment
			{
				id = 103,
				name = "Amulet",
				image = Resources.empty,
				level = 0,
				type = 3
			};
			array48[104] = new Equipment
			{
				id = 104,
				name = "Boots",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 7
			};
			Equipment equipment2 = new Equipment
			{
				id = 105,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment2.attack = array3;
			equipment2.type = 0;
			array48[105] = equipment2;
			array48[106] = new Equipment
			{
				id = 106,
				name = "Robe",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[107] = new Equipment
			{
				id = 107,
				name = "Glove",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 1
			};
			array48[108] = new Equipment
			{
				id = 108,
				name = "Belt",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 6
			};
			array48[109] = new Equipment
			{
				id = 109,
				name = "Ring",
				image = Resources.empty,
				level = 0,
				type = 2
			};
			Equipment equipment3 = new Equipment
			{
				id = 110,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment3.attack = array3;
			equipment3.type = 0;
			array48[110] = equipment3;
			array48[111] = new Equipment
			{
				id = 111,
				name = "Armor",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[112] = new Equipment
			{
				id = 112,
				name = "Hat",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 4
			};
			array48[113] = new Equipment
			{
				id = 113,
				name = "Amulet",
				image = Resources.empty,
				level = 0,
				type = 3
			};
			array48[114] = new Equipment
			{
				id = 114,
				name = "Boots",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 7
			};
			Equipment equipment4 = new Equipment
			{
				id = 115,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment4.attack = array3;
			equipment4.type = 0;
			array48[115] = equipment4;
			array48[116] = new Equipment
			{
				id = 116,
				name = "Robe",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[117] = new Equipment
			{
				id = 117,
				name = "Glove",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 1
			};
			array48[118] = new Equipment
			{
				id = 118,
				name = "Belt",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 6
			};
			array48[119] = new Equipment
			{
				id = 119,
				name = "Ring",
				image = Resources.empty,
				level = 0,
				type = 2
			};
			Equipment equipment5 = new Equipment
			{
				id = 120,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment5.attack = array3;
			equipment5.type = 0;
			array48[120] = equipment5;
			array48[121] = new Equipment
			{
				id = 121,
				name = "Armor",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[122] = new Equipment
			{
				id = 122,
				name = "Hat",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 4
			};
			array48[123] = new Equipment
			{
				id = 123,
				name = "Amulet",
				image = Resources.empty,
				level = 0,
				type = 3
			};
			array48[124] = new Equipment
			{
				id = 124,
				name = "Boots",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 7
			};
			Equipment equipment6 = new Equipment
			{
				id = 125,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment6.attack = array3;
			equipment6.type = 0;
			array48[125] = equipment6;
			array48[126] = new Equipment
			{
				id = 126,
				name = "Robe",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[127] = new Equipment
			{
				id = 127,
				name = "Glove",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 1
			};
			array48[128] = new Equipment
			{
				id = 128,
				name = "Belt",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 6
			};
			array48[129] = new Equipment
			{
				id = 129,
				name = "Ring",
				image = Resources.empty,
				level = 0,
				type = 2
			};
			Equipment equipment7 = new Equipment
			{
				id = 130,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment7.attack = array3;
			equipment7.type = 0;
			array48[130] = equipment7;
			array48[131] = new Equipment
			{
				id = 131,
				name = "Armor",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[132] = new Equipment
			{
				id = 132,
				name = "Hat",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 4
			};
			array48[133] = new Equipment
			{
				id = 133,
				name = "Amulet",
				image = Resources.empty,
				level = 0,
				type = 3
			};
			array48[134] = new Equipment
			{
				id = 134,
				name = "Boots",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 7
			};
			Equipment equipment8 = new Equipment
			{
				id = 135,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment8.attack = array3;
			equipment8.type = 0;
			array48[135] = equipment8;
			array48[136] = new Equipment
			{
				id = 136,
				name = "Robe",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[137] = new Equipment
			{
				id = 137,
				name = "Glove",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 1
			};
			array48[138] = new Equipment
			{
				id = 138,
				name = "Belt",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 6
			};
			array48[139] = new Equipment
			{
				id = 139,
				name = "Ring",
				image = Resources.empty,
				level = 0,
				type = 2
			};
			Equipment equipment9 = new Equipment
			{
				id = 140,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment9.attack = array3;
			equipment9.type = 0;
			array48[140] = equipment9;
			array48[141] = new Equipment
			{
				id = 141,
				name = "Armor",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[142] = new Equipment
			{
				id = 142,
				name = "Hat",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 4
			};
			array48[143] = new Equipment
			{
				id = 143,
				name = "Amulet",
				image = Resources.empty,
				level = 0,
				type = 3
			};
			array48[144] = new Equipment
			{
				id = 144,
				name = "Boots",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 7
			};
			Equipment equipment10 = new Equipment
			{
				id = 145,
				name = "Weapon",
				image = Resources.empty,
				level = 0
			};
			array3 = new int[2];
			equipment10.attack = array3;
			equipment10.type = 0;
			array48[145] = equipment10;
			array48[146] = new Equipment
			{
				id = 146,
				name = "Robe",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 5
			};
			array48[147] = new Equipment
			{
				id = 147,
				name = "Glove",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 1
			};
			array48[148] = new Equipment
			{
				id = 148,
				name = "Belt",
				image = Resources.empty,
				level = 0,
				defense = 0,
				type = 6
			};
			array48[149] = new Equipment
			{
				id = 149,
				name = "Ring",
				image = Resources.empty,
				level = 0,
				type = 2
			};
			array48[150] = new Equipment
			{
				id = 150,
				name = "Beastlord Helm",
				image = Resources.beastlordhelm,
				level = 21,
				set = 1,
				defense = 44,
				type = 4
			};
			array48[151] = new Equipment
			{
				id = 151,
				name = "Beastlord Warchest",
				image = Resources.beastlordarmor,
				level = 21,
				vlevel = 27,
				set = 1,
				defense = 151,
				type = 5
			};
			array48[152] = new Equipment
			{
				id = 152,
				name = "Amaterasu Order",
				image = Resources.beastlordamulet,
				level = 21,
				set = 1,
				type = 3
			};
			array48[153] = new Equipment
			{
				id = 153,
				name = "Beastlord Warboots",
				image = Resources.beastlordboots,
				level = 21,
				set = 1,
				defense = 36,
				type = 7
			};
			array48[154] = new Equipment
			{
				id = 154,
				name = "Goldface Helm",
				image = Resources.gildedhelm,
				level = 31,
				set = 2,
				defense = 55,
				type = 4
			};
			array48[155] = new Equipment
			{
				id = 155,
				name = "Gilded Warchest",
				image = Resources.gildedarmor,
				level = 31,
				vlevel = 37,
				set = 2,
				defense = 183,
				type = 5
			};
			array48[156] = new Equipment
			{
				id = 156,
				name = "Springwater Pendant",
				image = Resources.gildedamulet,
				level = 31,
				set = 2,
				type = 3
			};
			array48[157] = new Equipment
			{
				id = 157,
				name = "Gilded Warboots",
				image = Resources.gildedboots,
				level = 31,
				set = 2,
				defense = 44,
				type = 7
			};
			array48[158] = new Equipment
			{
				id = 158,
				name = "Tengu Bamboo Hat",
				image = Resources.tenguhelm,
				level = 31,
				set = 3,
				defense = 55,
				type = 4
			};
			array48[159] = new Equipment
			{
				id = 159,
				name = "Tengu Vestment",
				image = Resources.tenguarmor,
				level = 31,
				vlevel = 37,
				set = 3,
				defense = 183,
				type = 5
			};
			array48[160] = new Equipment
			{
				id = 160,
				name = "Yamabuki Jade",
				image = Resources.tenguamulet,
				level = 31,
				set = 3,
				type = 3
			};
			array48[161] = new Equipment
			{
				id = 161,
				name = "Tengu Boots",
				image = Resources.tenguboots,
				level = 31,
				set = 3,
				defense = 44,
				type = 7
			};
			array48[162] = new Equipment
			{
				id = 162,
				name = "Quicksilver Helm",
				image = Resources.quicksilverhelm,
				level = 41,
				set = 4,
				defense = 65,
				type = 4
			};
			array48[163] = new Equipment
			{
				id = 163,
				name = "Quicksilver Armor",
				image = Resources.quicksilverarmor,
				level = 41,
				vlevel = 47,
				set = 4,
				defense = 215,
				type = 5
			};
			array48[164] = new Equipment
			{
				id = 164,
				name = "Ragefire Talisman",
				image = Resources.quicksilveramulet,
				level = 41,
				set = 4,
				type = 3
			};
			array48[165] = new Equipment
			{
				id = 165,
				name = "Quicksilver Boots",
				image = Resources.quicksilverboots,
				level = 41,
				set = 4,
				defense = 52,
				type = 7
			};
			array48[166] = new Equipment
			{
				id = 166,
				name = "Ferocious Helm",
				image = Resources.ferocioushelm,
				level = 41,
				set = 5,
				defense = 65,
				type = 4
			};
			array48[167] = new Equipment
			{
				id = 167,
				name = "Ferocious Warchest",
				image = Resources.ferociousarmor,
				level = 41,
				vlevel = 47,
				set = 5,
				defense = 215,
				type = 5
			};
			array48[168] = new Equipment
			{
				id = 168,
				name = "Earthen Talisman",
				image = Resources.ferociousamulet,
				level = 41,
				set = 5,
				type = 3
			};
			array48[169] = new Equipment
			{
				id = 169,
				name = "Ferocious Warboots",
				image = Resources.ferociousboots,
				level = 41,
				set = 5,
				defense = 52,
				type = 7
			};
			array48[170] = new Equipment
			{
				id = 170,
				name = "Deity's Crown",
				image = Resources.deityhelm,
				level = 41,
				set = 6,
				defense = 65,
				type = 4
			};
			array48[171] = new Equipment
			{
				id = 171,
				name = "Deity's Battle Suit",
				image = Resources.deityarmor,
				level = 41,
				vlevel = 47,
				set = 6,
				defense = 215,
				type = 5
			};
			array48[172] = new Equipment
			{
				id = 172,
				name = "Darkborn Pendant",
				image = Resources.deityamulet,
				level = 41,
				set = 6,
				type = 3
			};
			array48[173] = new Equipment
			{
				id = 173,
				name = "Deity's Boots",
				image = Resources.deityboots,
				level = 41,
				set = 6,
				defense = 52,
				type = 7
			};
			array48[174] = new Equipment
			{
				id = 174,
				name = "Oni Helm",
				image = Resources.onihelm,
				level = 51,
				set = 7,
				defense = 60,
				type = 4
			};
			array48[175] = new Equipment
			{
				id = 175,
				name = "Oni Warchest",
				image = Resources.oniarmor,
				level = 51,
				vlevel = 57,
				set = 7,
				defense = 231,
				type = 5
			};
			array48[176] = new Equipment
			{
				id = 176,
				name = "Darkfeather Bell",
				image = Resources.oniamulet,
				level = 51,
				set = 7,
				type = 3
			};
			array48[177] = new Equipment
			{
				id = 177,
				name = "Oni Warboots",
				image = Resources.oniboots,
				level = 51,
				set = 7,
				defense = 75,
				type = 7
			};
			array48[178] = new Equipment
			{
				id = 178,
				name = "Balanced Faceguard",
				image = Resources.balancedhelm,
				level = 51,
				set = 8,
				defense = 75,
				type = 4
			};
			array48[179] = new Equipment
			{
				id = 179,
				name = "Balanced Battle Suit",
				image = Resources.balancedarmor,
				level = 51,
				vlevel = 57,
				set = 8,
				defense = 231,
				type = 5
			};
			array48[180] = new Equipment
			{
				id = 180,
				name = "Frostron Bell",
				image = Resources.balancedamulet,
				level = 51,
				set = 8,
				type = 3
			};
			array48[181] = new Equipment
			{
				id = 181,
				name = "Balanced Boots",
				image = Resources.balancedboots,
				level = 51,
				set = 8,
				defense = 60,
				type = 7
			};
			array48[182] = new Equipment
			{
				id = 182,
				name = "Cosmic Helm",
				image = Resources.cosmichelm,
				level = 51,
				set = 9,
				defense = 75,
				type = 4
			};
			array48[183] = new Equipment
			{
				id = 183,
				name = "Cosmic Armor",
				image = Resources.cosmicarmor,
				level = 51,
				vlevel = 57,
				set = 9,
				defense = 231,
				type = 5
			};
			array48[184] = new Equipment
			{
				id = 184,
				name = "Brightburn Bell",
				image = Resources.cosmicamulet,
				level = 51,
				set = 9,
				type = 3
			};
			array48[185] = new Equipment
			{
				id = 185,
				name = "Cosmic Boots",
				image = Resources.cosmicboots,
				level = 51,
				set = 9,
				defense = 60,
				type = 7
			};
			array48[186] = new Equipment
			{
				id = 186,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 10,
				defense = 0,
				type = 4
			};
			array48[187] = new Equipment
			{
				id = 187,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 10,
				defense = 0,
				type = 5
			};
			array48[188] = new Equipment
			{
				id = 188,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 10,
				type = 3
			};
			array48[189] = new Equipment
			{
				id = 189,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 10,
				defense = 0,
				type = 7
			};
			array48[190] = new Equipment
			{
				id = 190,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 11,
				defense = 0,
				type = 4
			};
			array48[191] = new Equipment
			{
				id = 191,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 11,
				defense = 0,
				type = 5
			};
			array48[192] = new Equipment
			{
				id = 192,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 11,
				type = 3
			};
			array48[193] = new Equipment
			{
				id = 193,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 11,
				defense = 0,
				type = 7
			};
			array48[194] = new Equipment
			{
				id = 194,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 12,
				defense = 0,
				type = 4
			};
			array48[195] = new Equipment
			{
				id = 195,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 12,
				defense = 0,
				type = 5
			};
			array48[196] = new Equipment
			{
				id = 196,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 12,
				type = 3
			};
			array48[197] = new Equipment
			{
				id = 197,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 12,
				defense = 0,
				type = 7
			};
			array48[198] = new Equipment
			{
				id = 198,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 13,
				defense = 0,
				type = 4
			};
			array48[199] = new Equipment
			{
				id = 199,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 13,
				defense = 0,
				type = 5
			};
			array48[200] = new Equipment
			{
				id = 200,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 13,
				type = 3
			};
			array48[201] = new Equipment
			{
				id = 201,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 13,
				defense = 0,
				type = 7
			};
			array48[202] = new Equipment
			{
				id = 202,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 14,
				defense = 0,
				type = 4
			};
			array48[203] = new Equipment
			{
				id = 203,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 14,
				defense = 0,
				type = 5
			};
			array48[204] = new Equipment
			{
				id = 204,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 14,
				type = 3
			};
			array48[205] = new Equipment
			{
				id = 205,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 14,
				defense = 0,
				type = 7
			};
			array48[206] = new Equipment
			{
				id = 206,
				name = "Dinosaur Weapon",
				image = Resources.dinosaurweapon,
				level = 91,
				vlevel = 96,
				set = 15,
				attack = new int[2] { 189, 228 },
				type = 0
			};
			array48[207] = new Equipment
			{
				id = 207,
				name = "Dinosaur Armor",
				image = Resources.dinosaurarmor,
				level = 91,
				vlevel = 97,
				set = 15,
				defense = 375,
				type = 5
			};
			array48[208] = new Equipment
			{
				id = 208,
				name = "Dinosaur Helm",
				image = Resources.dinosaurhelm,
				level = 91,
				vlevel = 93,
				set = 15,
				defense = 117,
				type = 4
			};
			array48[209] = new Equipment
			{
				id = 209,
				name = "Dinosaur Boots",
				image = Resources.dinosaurboots,
				level = 91,
				vlevel = 95,
				set = 15,
				defense = 92,
				type = 7
			};
			array48[210] = new Equipment
			{
				id = 210,
				name = "Dinosaur Talisman",
				image = Resources.dinosauramulet,
				level = 91,
				vlevel = 94,
				set = 15,
				type = 3
			};
			array48[211] = new Equipment
			{
				id = 211,
				name = "Dinosaur Glove",
				image = Resources.dinosaurgloves,
				level = 91,
				vlevel = 98,
				set = 15,
				defense = 94,
				type = 1
			};
			array48[212] = new Equipment
			{
				id = 212,
				name = "Dinosaur Belt",
				image = Resources.dinosaurbelt,
				level = 91,
				vlevel = 99,
				set = 15,
				defense = 77,
				type = 6
			};
			array48[213] = new Equipment
			{
				id = 213,
				name = "Dinosaur Ring",
				image = Resources.dinosaurring,
				level = 91,
				vlevel = 100,
				set = 15,
				type = 2
			};
			array48[214] = new Equipment
			{
				id = 214,
				name = "Hidden Dragon Weapon",
				image = Resources.hiddenweapon,
				level = 91,
				vlevel = 96,
				set = 16,
				attack = new int[2] { 189, 228 },
				type = 0
			};
			array48[215] = new Equipment
			{
				id = 215,
				name = "Hidden Dragon Armor",
				image = Resources.hiddenarmor,
				level = 91,
				vlevel = 97,
				set = 16,
				defense = 375,
				type = 5
			};
			array48[216] = new Equipment
			{
				id = 216,
				name = "Hidden Dragon Helm",
				image = Resources.hiddenhelm,
				level = 91,
				vlevel = 93,
				set = 16,
				defense = 117,
				type = 4
			};
			array48[217] = new Equipment
			{
				id = 217,
				name = "Hidden Dragon Boots",
				image = Resources.hiddenboots,
				level = 91,
				vlevel = 95,
				set = 16,
				defense = 92,
				type = 7
			};
			array48[218] = new Equipment
			{
				id = 218,
				name = "Hidden Dragon Talisman",
				image = Resources.hiddenamulet,
				level = 91,
				vlevel = 94,
				set = 16,
				type = 3
			};
			array48[219] = new Equipment
			{
				id = 219,
				name = "Hidden Dragon Glove",
				image = Resources.hiddengloves,
				level = 91,
				vlevel = 98,
				set = 16,
				defense = 94,
				type = 1
			};
			array48[220] = new Equipment
			{
				id = 220,
				name = "Hidden Dragon Belt",
				image = Resources.hiddenbelt,
				level = 91,
				vlevel = 99,
				set = 16,
				defense = 77,
				type = 6
			};
			array48[221] = new Equipment
			{
				id = 221,
				name = "Hidden Dragon Ring",
				image = Resources.hiddenring,
				level = 91,
				vlevel = 100,
				set = 16,
				type = 2
			};
			array48[222] = new Equipment
			{
				id = 222,
				name = "Blood Dragon Weapon",
				image = Resources.blooddragonweapon,
				level = 91,
				vlevel = 96,
				set = 17,
				attack = new int[2] { 189, 228 },
				type = 0
			};
			array48[223] = new Equipment
			{
				id = 223,
				name = "Blood Dragon Armor",
				image = Resources.blooddragonarmor,
				level = 91,
				vlevel = 97,
				set = 17,
				defense = 375,
				type = 5
			};
			array48[224] = new Equipment
			{
				id = 224,
				name = "Blood Dragon Helm",
				image = Resources.blooddragonhelm,
				level = 91,
				vlevel = 93,
				set = 17,
				defense = 117,
				type = 4
			};
			array48[225] = new Equipment
			{
				id = 225,
				name = "Blood Dragon Boots",
				image = Resources.blooddragonboots,
				level = 91,
				vlevel = 95,
				set = 17,
				defense = 92,
				type = 7
			};
			array48[226] = new Equipment
			{
				id = 226,
				name = "Blood Dragon Talisman",
				image = Resources.blooddragonamulet,
				level = 91,
				vlevel = 94,
				set = 17,
				type = 3
			};
			array48[227] = new Equipment
			{
				id = 227,
				name = "Blood Dragon Glove",
				image = Resources.blooddragongloves,
				level = 91,
				vlevel = 98,
				set = 17,
				defense = 94,
				type = 1
			};
			array48[228] = new Equipment
			{
				id = 228,
				name = "Blood Dragon Belt",
				image = Resources.blooddragonbelt,
				level = 91,
				vlevel = 99,
				set = 17,
				defense = 77,
				type = 6
			};
			array48[229] = new Equipment
			{
				id = 229,
				name = "Blood Dragon Ring",
				image = Resources.blooddragonring,
				level = 91,
				vlevel = 100,
				set = 17,
				type = 2
			};
			array48[230] = new Equipment
			{
				id = 230,
				name = "R.Dinosaur Weapon",
				image = Resources.dinosaurweapon,
				level = 101,
				vlevel = 106,
				set = 18,
				attack = new int[2] { 207, 253 },
				type = 0
			};
			array48[231] = new Equipment
			{
				id = 231,
				name = "R.Dinosaur Armor",
				image = Resources.dinosaurarmor,
				level = 101,
				vlevel = 107,
				set = 18,
				defense = 407,
				type = 5
			};
			array48[232] = new Equipment
			{
				id = 232,
				name = "R.Dinosaur Helm",
				image = Resources.dinosaurhelm,
				level = 101,
				vlevel = 103,
				set = 18,
				defense = 127,
				type = 4
			};
			array48[233] = new Equipment
			{
				id = 233,
				name = "R.Dinosaur Boots",
				image = Resources.dinosaurboots,
				level = 101,
				vlevel = 105,
				set = 18,
				defense = 100,
				type = 7
			};
			array48[234] = new Equipment
			{
				id = 234,
				name = "R.Dinosaur Talisman",
				image = Resources.dinosauramulet,
				level = 101,
				vlevel = 104,
				set = 18,
				type = 3
			};
			array48[235] = new Equipment
			{
				id = 235,
				name = "R.Dinosaur Glove",
				image = Resources.dinosaurgloves,
				level = 101,
				vlevel = 108,
				set = 18,
				defense = 102,
				type = 1
			};
			array48[236] = new Equipment
			{
				id = 236,
				name = "R.Dinosaur Belt",
				image = Resources.dinosaurbelt,
				level = 101,
				vlevel = 109,
				set = 18,
				defense = 84,
				type = 6
			};
			array48[237] = new Equipment
			{
				id = 237,
				name = "R.Dinosaur Ring",
				image = Resources.dinosaurring,
				level = 101,
				vlevel = 110,
				set = 18,
				type = 2
			};
			array48[238] = new Equipment
			{
				id = 238,
				name = "R.Hidden Dragon Weapon",
				image = Resources.hiddenweapon,
				level = 101,
				vlevel = 106,
				set = 19,
				attack = new int[2] { 207, 253 },
				type = 0
			};
			array48[239] = new Equipment
			{
				id = 239,
				name = "R.Hidden Dragon Armor",
				image = Resources.hiddenarmor,
				level = 101,
				vlevel = 107,
				set = 19,
				defense = 407,
				type = 5
			};
			array48[240] = new Equipment
			{
				id = 240,
				name = "R.Hidden Dragon Helm",
				image = Resources.hiddenhelm,
				level = 101,
				vlevel = 103,
				set = 19,
				defense = 127,
				type = 4
			};
			array48[241] = new Equipment
			{
				id = 241,
				name = "R.Hidden Dragon Boots",
				image = Resources.hiddenboots,
				level = 101,
				vlevel = 105,
				set = 19,
				defense = 100,
				type = 7
			};
			array48[242] = new Equipment
			{
				id = 242,
				name = "R.Hidden Dragon Talisman",
				image = Resources.hiddenamulet,
				level = 101,
				vlevel = 104,
				set = 19,
				type = 3
			};
			array48[243] = new Equipment
			{
				id = 243,
				name = "R.Hidden Dragon Glove",
				image = Resources.hiddengloves,
				level = 101,
				vlevel = 108,
				set = 19,
				defense = 102,
				type = 1
			};
			array48[244] = new Equipment
			{
				id = 244,
				name = "R.Hidden Dragon Belt",
				image = Resources.hiddenbelt,
				level = 101,
				vlevel = 109,
				set = 19,
				defense = 84,
				type = 6
			};
			array48[245] = new Equipment
			{
				id = 245,
				name = "R.Hidden Dragon Ring",
				image = Resources.hiddenring,
				level = 101,
				vlevel = 110,
				set = 19,
				type = 2
			};
			array48[246] = new Equipment
			{
				id = 246,
				name = "R.Blood Dragon Weapon",
				image = Resources.blooddragonweapon,
				level = 101,
				vlevel = 106,
				set = 20,
				attack = new int[2] { 207, 253 },
				type = 0
			};
			array48[247] = new Equipment
			{
				id = 247,
				name = "R.Blood Dragon Armor",
				image = Resources.blooddragonarmor,
				level = 101,
				vlevel = 107,
				set = 20,
				defense = 407,
				type = 5
			};
			array48[248] = new Equipment
			{
				id = 248,
				name = "R.Blood Dragon Helm",
				image = Resources.blooddragonhelm,
				level = 101,
				vlevel = 103,
				set = 20,
				defense = 127,
				type = 4
			};
			array48[249] = new Equipment
			{
				id = 249,
				name = "R.Blood Dragon Boots",
				image = Resources.blooddragonboots,
				level = 101,
				vlevel = 105,
				set = 20,
				defense = 100,
				type = 7
			};
			array48[250] = new Equipment
			{
				id = 250,
				name = "R.Blood Dragon Talisman",
				image = Resources.blooddragonamulet,
				level = 101,
				vlevel = 104,
				set = 20,
				type = 3
			};
			array48[251] = new Equipment
			{
				id = 251,
				name = "R.Blood Dragon Glove",
				image = Resources.blooddragongloves,
				level = 101,
				vlevel = 108,
				set = 20,
				defense = 102,
				type = 1
			};
			array48[252] = new Equipment
			{
				id = 252,
				name = "R.Blood Dragon Belt",
				image = Resources.blooddragonbelt,
				level = 101,
				vlevel = 109,
				set = 20,
				defense = 84,
				type = 6
			};
			array48[253] = new Equipment
			{
				id = 253,
				name = "R.Blood Dragon Ring",
				image = Resources.blooddragonring,
				level = 101,
				vlevel = 110,
				set = 20,
				type = 2
			};
			Equipment equipment11 = new Equipment
			{
				id = 254,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21
			};
			array3 = new int[2];
			equipment11.attack = array3;
			equipment11.type = 0;
			array48[254] = equipment11;
			array48[255] = new Equipment
			{
				id = 255,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21,
				defense = 0,
				type = 5
			};
			array48[256] = new Equipment
			{
				id = 256,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21,
				defense = 0,
				type = 4
			};
			array48[257] = new Equipment
			{
				id = 257,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21,
				defense = 0,
				type = 7
			};
			array48[258] = new Equipment
			{
				id = 258,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21,
				type = 3
			};
			array48[259] = new Equipment
			{
				id = 259,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21,
				defense = 0,
				type = 1
			};
			array48[260] = new Equipment
			{
				id = 260,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21,
				defense = 0,
				type = 6
			};
			array48[261] = new Equipment
			{
				id = 261,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 21,
				type = 2
			};
			Equipment equipment12 = new Equipment
			{
				id = 262,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22
			};
			array3 = new int[2];
			equipment12.attack = array3;
			equipment12.type = 0;
			array48[262] = equipment12;
			array48[263] = new Equipment
			{
				id = 263,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22,
				defense = 0,
				type = 5
			};
			array48[264] = new Equipment
			{
				id = 264,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22,
				defense = 0,
				type = 4
			};
			array48[265] = new Equipment
			{
				id = 265,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22,
				defense = 0,
				type = 7
			};
			array48[266] = new Equipment
			{
				id = 266,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22,
				type = 3
			};
			array48[267] = new Equipment
			{
				id = 267,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22,
				defense = 0,
				type = 1
			};
			array48[268] = new Equipment
			{
				id = 268,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22,
				defense = 0,
				type = 6
			};
			array48[269] = new Equipment
			{
				id = 269,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 22,
				type = 2
			};
			Equipment equipment13 = new Equipment
			{
				id = 270,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23
			};
			array3 = new int[2];
			equipment13.attack = array3;
			equipment13.type = 0;
			array48[270] = equipment13;
			array48[271] = new Equipment
			{
				id = 271,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23,
				defense = 0,
				type = 5
			};
			array48[272] = new Equipment
			{
				id = 272,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23,
				defense = 0,
				type = 4
			};
			array48[273] = new Equipment
			{
				id = 273,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23,
				defense = 0,
				type = 7
			};
			array48[274] = new Equipment
			{
				id = 274,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23,
				type = 3
			};
			array48[275] = new Equipment
			{
				id = 275,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23,
				defense = 0,
				type = 1
			};
			array48[276] = new Equipment
			{
				id = 276,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23,
				defense = 0,
				type = 6
			};
			array48[277] = new Equipment
			{
				id = 277,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 23,
				type = 2
			};
			Equipment equipment14 = new Equipment
			{
				id = 278,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24
			};
			array3 = new int[2];
			equipment14.attack = array3;
			equipment14.type = 0;
			array48[278] = equipment14;
			array48[279] = new Equipment
			{
				id = 279,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24,
				defense = 0,
				type = 5
			};
			array48[280] = new Equipment
			{
				id = 280,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24,
				defense = 0,
				type = 4
			};
			array48[281] = new Equipment
			{
				id = 281,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24,
				defense = 0,
				type = 7
			};
			array48[282] = new Equipment
			{
				id = 282,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24,
				type = 3
			};
			array48[283] = new Equipment
			{
				id = 283,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24,
				defense = 0,
				type = 1
			};
			array48[284] = new Equipment
			{
				id = 284,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24,
				defense = 0,
				type = 6
			};
			array48[285] = new Equipment
			{
				id = 285,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 24,
				type = 2
			};
			Equipment equipment15 = new Equipment
			{
				id = 286,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25
			};
			array3 = new int[2];
			equipment15.attack = array3;
			equipment15.type = 0;
			array48[286] = equipment15;
			array48[287] = new Equipment
			{
				id = 287,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25,
				defense = 0,
				type = 5
			};
			array48[288] = new Equipment
			{
				id = 288,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25,
				defense = 0,
				type = 4
			};
			array48[289] = new Equipment
			{
				id = 289,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25,
				defense = 0,
				type = 7
			};
			array48[290] = new Equipment
			{
				id = 290,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25,
				type = 3
			};
			array48[291] = new Equipment
			{
				id = 291,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25,
				defense = 0,
				type = 1
			};
			array48[292] = new Equipment
			{
				id = 292,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25,
				defense = 0,
				type = 6
			};
			array48[293] = new Equipment
			{
				id = 293,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 25,
				type = 2
			};
			Equipment equipment16 = new Equipment
			{
				id = 294,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26
			};
			array3 = new int[2];
			equipment16.attack = array3;
			equipment16.type = 0;
			array48[294] = equipment16;
			array48[295] = new Equipment
			{
				id = 295,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26,
				defense = 0,
				type = 5
			};
			array48[296] = new Equipment
			{
				id = 296,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26,
				defense = 0,
				type = 4
			};
			array48[297] = new Equipment
			{
				id = 297,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26,
				defense = 0,
				type = 7
			};
			array48[298] = new Equipment
			{
				id = 298,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26,
				type = 3
			};
			array48[299] = new Equipment
			{
				id = 299,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26,
				defense = 0,
				type = 1
			};
			array48[300] = new Equipment
			{
				id = 300,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26,
				defense = 0,
				type = 6
			};
			array48[301] = new Equipment
			{
				id = 301,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 26,
				type = 2
			};
			array48[302] = new Equipment
			{
				id = 302,
				name = "Kage Weapon",
				image = Resources.kageweapon,
				bonus = new Values[1]
				{
					new PAtk(60)
				},
				level = 81,
				vlevel = 96,
				set = 27,
				attack = new int[2] { 189, 226 },
				type = 0
			};
			array48[303] = new Equipment
			{
				id = 303,
				name = "Kage Armor",
				image = Resources.kagearmor,
				bonus = new Values[1]
				{
					new PHP(60)
				},
				level = 81,
				vlevel = 97,
				set = 27,
				defense = 359,
				type = 5
			};
			array48[304] = new Equipment
			{
				id = 304,
				name = "Kage Helm",
				image = Resources.kagehelm,
				bonus = new Values[1]
				{
					new Hit(75)
				},
				level = 81,
				vlevel = 93,
				set = 27,
				defense = 116,
				type = 4
			};
			array48[305] = new Equipment
			{
				id = 305,
				name = "Kage Boots",
				image = Resources.kageboots,
				bonus = new Values[1]
				{
					new Speed(60)
				},
				level = 81,
				vlevel = 95,
				set = 27,
				defense = 92,
				type = 7
			};
			array48[306] = new Equipment
			{
				id = 306,
				name = "Kage Gloves",
				image = Resources.kagegloves,
				bonus = new Values[1]
				{
					new Counterattack(60)
				},
				level = 81,
				vlevel = 98,
				set = 27,
				defense = 94,
				type = 1
			};
			array48[307] = new Equipment
			{
				id = 307,
				name = "Kage Belt",
				image = Resources.kagebelt,
				bonus = new Values[1]
				{
					new Defense(79)
				},
				level = 81,
				vlevel = 99,
				set = 27,
				defense = 79,
				type = 6
			};
			array48[308] = new Equipment
			{
				id = 308,
				name = "Kage Talisman",
				image = Resources.kageamulet,
				bonus = new Values[1]
				{
					new DmgReduction(40)
				},
				level = 81,
				vlevel = 94,
				set = 27,
				type = 3
			};
			array48[309] = new Equipment
			{
				id = 309,
				name = "Kage Ring",
				image = Resources.kagering,
				bonus = new Values[1]
				{
					new HPAbsorb(40)
				},
				level = 81,
				vlevel = 100,
				set = 27,
				type = 2
			};
			array48[310] = new Equipment
			{
				id = 310,
				name = "Advanced Kage Weapon",
				image = Resources.kageweapon,
				bonus = new Values[1]
				{
					new PAtk(75)
				},
				level = 91,
				vlevel = 106,
				set = 28,
				attack = new int[2] { 215, 258 },
				type = 0
			};
			array48[311] = new Equipment
			{
				id = 311,
				name = "Advanced Kage Armor",
				image = Resources.kagearmor,
				bonus = new Values[1]
				{
					new PHP(75)
				},
				level = 91,
				vlevel = 107,
				set = 28,
				defense = 385,
				type = 5
			};
			array48[312] = new Equipment
			{
				id = 312,
				name = "Advanced Kage Helm",
				image = Resources.kagehelm,
				bonus = new Values[1]
				{
					new Hit(94)
				},
				level = 91,
				vlevel = 109,
				set = 28,
				defense = 125,
				type = 4
			};
			array48[313] = new Equipment
			{
				id = 313,
				name = "Advanced Kage Boots",
				image = Resources.kageboots,
				bonus = new Values[1]
				{
					new Speed(75)
				},
				level = 91,
				vlevel = 105,
				set = 28,
				defense = 100,
				type = 7
			};
			array48[314] = new Equipment
			{
				id = 314,
				name = "Advanced Kage Gloves",
				image = Resources.kagegloves,
				bonus = new Values[1]
				{
					new Counterattack(80)
				},
				level = 91,
				vlevel = 108,
				set = 28,
				defense = 102,
				type = 1
			};
			array48[315] = new Equipment
			{
				id = 315,
				name = "Advanced Kage Belt",
				image = Resources.kagebelt,
				bonus = new Values[1]
				{
					new Defense(99)
				},
				level = 91,
				vlevel = 109,
				set = 28,
				defense = 85,
				type = 6
			};
			array48[316] = new Equipment
			{
				id = 316,
				name = "Advanced Kage Talisman",
				image = Resources.kageamulet,
				bonus = new Values[1]
				{
					new DmgReduction(50)
				},
				level = 91,
				vlevel = 104,
				set = 28,
				type = 3
			};
			array48[317] = new Equipment
			{
				id = 317,
				name = "Advanced Kage Ring",
				image = Resources.kagering,
				bonus = new Values[1]
				{
					new HPAbsorb(50)
				},
				level = 91,
				vlevel = 110,
				set = 28,
				type = 2
			};
			array48[318] = new Equipment
			{
				id = 318,
				name = "Kages Unearthed Weapon",
				image = Resources.kageweapon,
				bonus = new Values[1]
				{
					new PAtk(90)
				},
				level = 101,
				vlevel = 116,
				set = 29,
				attack = new int[2] { 241, 288 },
				type = 0
			};
			array48[319] = new Equipment
			{
				id = 319,
				name = "Kages Unearthed Armor",
				image = Resources.kagearmor,
				bonus = new Values[1]
				{
					new PHP(90)
				},
				level = 101,
				vlevel = 117,
				set = 29,
				defense = 401,
				type = 5
			};
			array48[320] = new Equipment
			{
				id = 320,
				name = "Kages Unearthed Helm",
				image = Resources.kagehelm,
				bonus = new Values[1]
				{
					new Hit(113)
				},
				level = 101,
				vlevel = 119,
				set = 29,
				defense = 134,
				type = 4
			};
			array48[321] = new Equipment
			{
				id = 321,
				name = "Kages Unearthed Boots",
				image = Resources.kageboots,
				bonus = new Values[1]
				{
					new Speed(90)
				},
				level = 101,
				vlevel = 115,
				set = 29,
				defense = 108,
				type = 7
			};
			array48[322] = new Equipment
			{
				id = 322,
				name = "Kages Unearthed Gloves",
				image = Resources.kagegloves,
				bonus = new Values[1]
				{
					new Counterattack(80)
				},
				level = 101,
				vlevel = 118,
				set = 29,
				defense = 110,
				type = 1
			};
			array48[323] = new Equipment
			{
				id = 323,
				name = "Kages Unearthed Belt",
				image = Resources.kagebelt,
				bonus = new Values[1]
				{
					new Defense(119)
				},
				level = 101,
				vlevel = 119,
				set = 29,
				defense = 91,
				type = 6
			};
			array48[324] = new Equipment
			{
				id = 324,
				name = "Kages Unearthed Talisman",
				image = Resources.kageamulet,
				bonus = new Values[1]
				{
					new DmgReduction(60)
				},
				level = 101,
				vlevel = 114,
				set = 29,
				type = 3
			};
			array48[325] = new Equipment
			{
				id = 325,
				name = "Kages Unearthed Ring",
				image = Resources.kagering,
				bonus = new Values[1]
				{
					new HPAbsorb(50)
				},
				level = 101,
				vlevel = 120,
				set = 29,
				type = 2
			};
			array48[326] = new Equipment
			{
				id = 326,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				attack = new int[0],
				type = 0
			};
			array48[327] = new Equipment
			{
				id = 327,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				defense = 0,
				type = 5
			};
			array48[328] = new Equipment
			{
				id = 328,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				defense = 0,
				type = 4
			};
			array48[329] = new Equipment
			{
				id = 329,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				defense = 0,
				type = 7
			};
			array48[330] = new Equipment
			{
				id = 330,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				defense = 0,
				type = 1
			};
			array48[331] = new Equipment
			{
				id = 331,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				defense = 0,
				type = 6
			};
			array48[332] = new Equipment
			{
				id = 332,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				type = 3
			};
			array48[333] = new Equipment
			{
				id = 333,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 30,
				type = 2
			};
			array48[334] = new Equipment
			{
				id = 334,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				attack = new int[0],
				type = 0
			};
			array48[335] = new Equipment
			{
				id = 335,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				defense = 0,
				type = 5
			};
			array48[336] = new Equipment
			{
				id = 336,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				defense = 0,
				type = 4
			};
			array48[337] = new Equipment
			{
				id = 337,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				defense = 0,
				type = 7
			};
			array48[338] = new Equipment
			{
				id = 338,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				defense = 0,
				type = 1
			};
			array48[339] = new Equipment
			{
				id = 339,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				defense = 0,
				type = 6
			};
			array48[340] = new Equipment
			{
				id = 340,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				type = 3
			};
			array48[341] = new Equipment
			{
				id = 341,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 31,
				type = 2
			};
			array48[342] = new Equipment
			{
				id = 342,
				name = "Lament Helm",
				image = Resources.lamenthelm,
				level = 83,
				set = 32,
				defense = 106,
				type = 4
			};
			array48[343] = new Equipment
			{
				id = 343,
				name = "Requiem Amulet",
				image = Resources.lamentamulet,
				level = 84,
				set = 32,
				type = 3
			};
			array48[344] = new Equipment
			{
				id = 344,
				name = "Lament Boots",
				image = Resources.lamentboots,
				level = 85,
				set = 32,
				defense = 84,
				type = 7
			};
			array48[345] = new Equipment
			{
				id = 345,
				name = "Lament Armor",
				image = Resources.lamentarmor,
				level = 87,
				set = 32,
				defense = 343,
				type = 5
			};
			array48[346] = new Equipment
			{
				id = 346,
				name = "Lament Gloves",
				image = Resources.lamentgloves,
				level = 88,
				set = 32,
				defense = 86,
				type = 1
			};
			array48[347] = new Equipment
			{
				id = 347,
				name = "Lament Belt",
				image = Resources.lamentbelt,
				level = 89,
				set = 32,
				defense = 71,
				type = 6
			};
			array48[348] = new Equipment
			{
				id = 348,
				name = "Lament Ring",
				image = Resources.lamentring,
				level = 90,
				set = 32,
				type = 2
			};
			array48[349] = new Equipment
			{
				id = 349,
				name = "Radiant Battle Helm",
				image = Resources.radianthelm,
				level = 53,
				set = 33,
				defense = 75,
				type = 4
			};
			array48[350] = new Equipment
			{
				id = 350,
				name = "Cross of Purity",
				image = Resources.radiantamulet,
				level = 54,
				set = 3,
				type = 3
			};
			array48[351] = new Equipment
			{
				id = 351,
				name = "Radiant Warboots",
				image = Resources.radiantarmor,
				level = 55,
				set = 33,
				defense = 60,
				type = 7
			};
			array48[352] = new Equipment
			{
				id = 352,
				name = "Radiant Warchest",
				image = Resources.radiantarmor,
				level = 57,
				set = 33,
				defense = 247,
				type = 5
			};
			array48[353] = new Equipment
			{
				id = 353,
				name = "Radiant Gloves",
				image = Resources.radiantgloves,
				level = 58,
				set = 33,
				defense = 62,
				type = 1
			};
			array48[354] = new Equipment
			{
				id = 354,
				name = "Radiant Steel Belt",
				image = Resources.radiantbelt,
				level = 59,
				set = 33,
				defense = 52,
				type = 6
			};
			array48[355] = new Equipment
			{
				id = 355,
				name = "Band of Purity",
				image = Resources.radiantring,
				level = 60,
				set = 33,
				type = 2
			};
			array48[356] = new Equipment
			{
				id = 356,
				name = "Frigid Battle Helm",
				image = Resources.frigidhelm,
				level = 53,
				set = 34,
				defense = 75,
				type = 4
			};
			array48[357] = new Equipment
			{
				id = 357,
				name = "Cross of Devotion",
				image = Resources.frigidamulet,
				level = 54,
				set = 34,
				type = 3
			};
			array48[358] = new Equipment
			{
				id = 358,
				name = "Frigid Battle Helm",
				image = Resources.frigidhelm,
				level = 55,
				set = 34,
				defense = 60,
				type = 7
			};
			array48[359] = new Equipment
			{
				id = 359,
				name = "Frigid Warchest",
				image = Resources.frigidarmor,
				level = 57,
				set = 34,
				defense = 247,
				type = 5
			};
			array48[360] = new Equipment
			{
				id = 360,
				name = "Frigid Gloves",
				image = Resources.frigidgloves,
				level = 58,
				set = 34,
				defense = 62,
				type = 1
			};
			array48[361] = new Equipment
			{
				id = 361,
				name = "Frigid Belt",
				image = Resources.frigidbelt,
				level = 59,
				set = 34,
				defense = 52,
				type = 6
			};
			array48[362] = new Equipment
			{
				id = 362,
				name = "Band of Devotion",
				image = Resources.frigidring,
				level = 60,
				set = 34,
				type = 2
			};
			array48[363] = new Equipment
			{
				id = 363,
				name = "Streamray Faceguard",
				image = Resources.streamrayhelm,
				level = 73,
				set = 35,
				defense = 96,
				type = 4
			};
			array48[364] = new Equipment
			{
				id = 364,
				name = "Gilt Talisman",
				image = Resources.streamrayamulet,
				level = 74,
				set = 35,
				type = 3
			};
			array48[365] = new Equipment
			{
				id = 365,
				name = "Streamray Boot",
				image = Resources.streamrayboots,
				level = 75,
				set = 35,
				defense = 76,
				type = 7
			};
			array48[366] = new Equipment
			{
				id = 366,
				name = "Streamray Coat",
				image = Resources.streamrayarmor,
				level = 77,
				set = 35,
				defense = 311,
				type = 5
			};
			array48[367] = new Equipment
			{
				id = 367,
				name = "Streamray Gloves",
				image = Resources.streamraygloves,
				level = 78,
				set = 35,
				defense = 78,
				type = 1
			};
			array48[368] = new Equipment
			{
				id = 368,
				name = "Streamray Belt",
				image = Resources.streamraybelt,
				level = 79,
				set = 35,
				defense = 65,
				type = 6
			};
			array48[369] = new Equipment
			{
				id = 369,
				name = "Gilt Ring",
				image = Resources.streamrayring,
				level = 80,
				set = 35,
				type = 2
			};
			array48[370] = new Equipment
			{
				id = 370,
				name = "Prajna's Visage",
				image = Resources.prajnahelm,
				level = 23,
				set = 36,
				defense = 44,
				type = 4
			};
			array48[371] = new Equipment
			{
				id = 371,
				name = "Hiroki Pendant",
				image = Resources.prajnaamulet,
				level = 24,
				set = 36,
				type = 3
			};
			array48[372] = new Equipment
			{
				id = 372,
				name = "Prajna's Boots",
				image = Resources.prajnaboots,
				level = 25,
				set = 36,
				defense = 36,
				type = 7
			};
			array48[373] = new Equipment
			{
				id = 373,
				name = "Prajna's Robes",
				image = Resources.prajnaarmor,
				level = 27,
				set = 36,
				defense = 151,
				type = 5
			};
			array48[374] = new Equipment
			{
				id = 374,
				name = "Prajna's Gloves",
				image = Resources.prajnagloves,
				level = 28,
				set = 36,
				defense = 38,
				type = 1
			};
			array48[375] = new Equipment
			{
				id = 375,
				name = "Prajna's Girdle",
				image = Resources.prajnabelt,
				level = 29,
				set = 36,
				defense = 32,
				type = 6
			};
			array48[376] = new Equipment
			{
				id = 376,
				name = "Springwater Ring",
				image = Resources.prajnaring,
				level = 30,
				set = 36,
				type = 2
			};
			array48[377] = new Equipment
			{
				id = 377,
				name = "Nightmare Helm",
				image = Resources.nightmarehelm,
				level = 33,
				set = 37,
				defense = 55,
				type = 4
			};
			array48[378] = new Equipment
			{
				id = 378,
				name = "Ivory Phoenix Jade",
				image = Resources.nightmareamulet,
				level = 34,
				set = 37,
				type = 3
			};
			array48[379] = new Equipment
			{
				id = 379,
				name = "Nightmare Boots",
				image = Resources.nightmareboots,
				level = 35,
				set = 37,
				defense = 44,
				type = 7
			};
			array48[380] = new Equipment
			{
				id = 380,
				name = "Nightmare Armor",
				image = Resources.nightmarearmor,
				level = 37,
				set = 37,
				defense = 183,
				type = 5
			};
			array48[381] = new Equipment
			{
				id = 381,
				name = "Nightmare Gloves",
				image = Resources.nightmareglove,
				level = 38,
				set = 37,
				defense = 46,
				type = 1
			};
			array48[382] = new Equipment
			{
				id = 382,
				name = "Nightmare Belt",
				image = Resources.nightmarebelt,
				level = 39,
				set = 37,
				defense = 39,
				type = 6
			};
			array48[383] = new Equipment
			{
				id = 383,
				name = "Ivory Phoenix Ring",
				image = Resources.nightmarering,
				level = 40,
				set = 37,
				type = 2
			};
			array48[384] = new Equipment
			{
				id = 384,
				name = "Sunset Battle Helm",
				image = Resources.sunsethelm,
				level = 73,
				set = 38,
				defense = 96,
				type = 4
			};
			array48[385] = new Equipment
			{
				id = 385,
				name = "Skeletal Necklace",
				image = Resources.sunsetamulet,
				level = 74,
				set = 38,
				type = 3
			};
			array48[386] = new Equipment
			{
				id = 386,
				name = "Sunset Warboots",
				image = Resources.sunsetboots,
				level = 75,
				set = 38,
				defense = 76,
				type = 7
			};
			array48[387] = new Equipment
			{
				id = 387,
				name = "Sunset Warchest",
				image = Resources.sunsetarmor,
				level = 77,
				set = 38,
				defense = 311,
				type = 5
			};
			array48[388] = new Equipment
			{
				id = 388,
				name = "Sunset Gloves",
				image = Resources.sunsetgloves,
				level = 78,
				set = 38,
				defense = 78,
				type = 1
			};
			array48[389] = new Equipment
			{
				id = 389,
				name = "Sunset Steel Belt",
				image = Resources.sunsetbelt,
				level = 79,
				set = 38,
				defense = 65,
				type = 6
			};
			array48[390] = new Equipment
			{
				id = 390,
				name = "Skeletal Ring",
				image = Resources.sunsetring,
				level = 80,
				set = 38,
				type = 2
			};
			array48[391] = new Equipment
			{
				id = 391,
				name = "Glorious Battle Helm",
				image = Resources.glorioushelm,
				level = 63,
				set = 39,
				defense = 86,
				type = 4
			};
			array48[392] = new Equipment
			{
				id = 392,
				name = "Beastbone Necklace",
				image = Resources.gloriousamulet,
				level = 64,
				set = 39,
				type = 3
			};
			array48[393] = new Equipment
			{
				id = 393,
				name = "Glorious Warboots",
				image = Resources.gloriousboots,
				level = 65,
				set = 39,
				defense = 68,
				type = 7
			};
			array48[394] = new Equipment
			{
				id = 394,
				name = "Glorious Warchest",
				image = Resources.gloriousarmor,
				level = 67,
				set = 39,
				defense = 279,
				type = 5
			};
			array48[395] = new Equipment
			{
				id = 395,
				name = "Glorious Gloves",
				image = Resources.gloriousgloves,
				level = 68,
				set = 39,
				defense = 70,
				type = 1
			};
			array48[396] = new Equipment
			{
				id = 396,
				name = "Glorious Steel Belt",
				image = Resources.gloriousbelt,
				level = 69,
				set = 39,
				defense = 58,
				type = 6
			};
			array48[397] = new Equipment
			{
				id = 397,
				name = "Beastbone Ring",
				image = Resources.gloriousring,
				level = 70,
				set = 39,
				type = 2
			};
			array48[398] = new Equipment
			{
				id = 398,
				name = "Kagura Band",
				image = Resources.kagurahelm,
				level = 33,
				set = 40,
				defense = 55,
				type = 4
			};
			array48[399] = new Equipment
			{
				id = 399,
				name = "Austere Talisman",
				image = Resources.kaguraamulet,
				level = 34,
				set = 40,
				type = 3
			};
			array48[400] = new Equipment
			{
				id = 400,
				name = "Kagura Boots",
				image = Resources.kaguraboots,
				level = 35,
				set = 40,
				defense = 44,
				type = 7
			};
			array48[401] = new Equipment
			{
				id = 401,
				name = "Kagura Robes",
				image = Resources.kaguraarmor,
				level = 37,
				set = 40,
				defense = 183,
				type = 5
			};
			array48[402] = new Equipment
			{
				id = 402,
				name = "Kagura Gloves",
				image = Resources.kaguragloves,
				level = 38,
				set = 40,
				defense = 46,
				type = 1
			};
			array48[403] = new Equipment
			{
				id = 403,
				name = "Kagura Girdle",
				image = Resources.kagurabelt,
				level = 39,
				set = 40,
				defense = 39,
				type = 6
			};
			array48[404] = new Equipment
			{
				id = 404,
				name = "Austere Ring",
				image = Resources.kaguraring,
				level = 40,
				set = 40,
				type = 2
			};
			array48[405] = new Equipment
			{
				id = 405,
				name = "Empty Soul Helm",
				image = Resources.emptysoulhelm,
				level = 73,
				set = 41,
				defense = 96,
				type = 4
			};
			array48[406] = new Equipment
			{
				id = 406,
				name = "Cero Talisman",
				image = Resources.emptysoulamulet,
				level = 74,
				set = 41,
				type = 3
			};
			array48[407] = new Equipment
			{
				id = 407,
				name = "Empty Soul Ankle Boot",
				image = Resources.emptysoulboots,
				level = 75,
				set = 41,
				defense = 76,
				type = 7
			};
			array48[408] = new Equipment
			{
				id = 408,
				name = "Empty Soul Warchest",
				image = Resources.emptysoularmor,
				level = 77,
				set = 41,
				defense = 311,
				type = 5
			};
			array48[409] = new Equipment
			{
				id = 409,
				name = "Empty Soul Gloves",
				image = Resources.emptysoulgloves,
				level = 78,
				set = 41,
				defense = 78,
				type = 1
			};
			array48[410] = new Equipment
			{
				id = 410,
				name = "Empty Soul Belt",
				image = Resources.emptysoulbelt,
				level = 79,
				set = 41,
				defense = 65,
				type = 6
			};
			array48[411] = new Equipment
			{
				id = 411,
				name = "Nihility Ring",
				image = Resources.emptysoulring,
				level = 80,
				set = 41,
				type = 2
			};
			array48[412] = new Equipment
			{
				id = 412,
				name = "Exorcism Mask",
				image = Resources.exorcismhelm,
				level = 73,
				set = 42,
				defense = 96,
				type = 4
			};
			array48[413] = new Equipment
			{
				id = 413,
				name = "Protective Talisman",
				image = Resources.exorcismamulet,
				level = 74,
				set = 42,
				type = 3
			};
			array48[414] = new Equipment
			{
				id = 414,
				name = "Exorcism Thign Boot",
				image = Resources.exorcismboots,
				level = 75,
				set = 42,
				defense = 76,
				type = 7
			};
			array48[415] = new Equipment
			{
				id = 415,
				name = "Exorcism Robe",
				image = Resources.exorcismarmor,
				level = 77,
				set = 42,
				defense = 311,
				type = 5
			};
			array48[416] = new Equipment
			{
				id = 416,
				name = "Exorcism Gloves",
				image = Resources.exorcismgloves,
				level = 78,
				set = 42,
				defense = 78,
				type = 1
			};
			array48[417] = new Equipment
			{
				id = 417,
				name = "Exorcism Belt",
				image = Resources.exorcismbelt,
				level = 79,
				set = 42,
				defense = 65,
				type = 6
			};
			array48[418] = new Equipment
			{
				id = 418,
				name = "Protective Ring",
				image = Resources.exorcismring,
				level = 80,
				set = 42,
				type = 2
			};
			array48[419] = new Equipment
			{
				id = 419,
				name = "Tigerfury Helm",
				image = Resources.tigerlordhelm,
				level = 13,
				set = 43,
				defense = 34,
				type = 4
			};
			array48[420] = new Equipment
			{
				id = 420,
				name = "Tsukuyomi Order",
				image = Resources.tigerlordamulet,
				level = 14,
				set = 43,
				type = 3
			};
			array48[421] = new Equipment
			{
				id = 421,
				name = "Tigerlord Boots",
				image = Resources.tigerlordboots,
				level = 15,
				set = 43,
				defense = 28,
				type = 7
			};
			array48[422] = new Equipment
			{
				id = 422,
				name = "Tigerfury Armor",
				image = Resources.tigerlordarmor,
				level = 17,
				set = 43,
				defense = 119,
				type = 5
			};
			array48[423] = new Equipment
			{
				id = 423,
				name = "Tigerlord Gloves",
				image = Resources.tigerlordgloves,
				level = 18,
				set = 43,
				defense = 30,
				type = 1
			};
			array48[424] = new Equipment
			{
				id = 424,
				name = "Tigerlord Belt",
				image = Resources.tigerlordbelt,
				level = 19,
				set = 43,
				defense = 25,
				type = 6
			};
			array48[425] = new Equipment
			{
				id = 425,
				name = "Tsukuyomi Ring",
				image = Resources.tigerlordring,
				level = 20,
				set = 43,
				type = 2
			};
			array48[426] = new Equipment
			{
				id = 426,
				name = "Black Oracle Hat",
				image = Resources.oraclehelm,
				level = 13,
				set = 44,
				defense = 34,
				type = 4
			};
			array48[427] = new Equipment
			{
				id = 427,
				name = "Susano Order",
				image = Resources.oracleamulet,
				level = 14,
				set = 44,
				type = 3
			};
			array48[428] = new Equipment
			{
				id = 428,
				name = "Oracle Boots",
				image = Resources.oracleboots,
				level = 15,
				set = 44,
				defense = 28,
				type = 7
			};
			array48[429] = new Equipment
			{
				id = 429,
				name = "Oracle Robes",
				image = Resources.oraclearmor,
				level = 17,
				set = 44,
				defense = 119,
				type = 5
			};
			array48[430] = new Equipment
			{
				id = 430,
				name = "Oracle Gloves",
				image = Resources.oraclegloves,
				level = 18,
				set = 44,
				defense = 30,
				type = 1
			};
			array48[431] = new Equipment
			{
				id = 431,
				name = "Oracle Girdle",
				image = Resources.oraclebelt,
				level = 19,
				set = 44,
				defense = 25,
				type = 6
			};
			array48[432] = new Equipment
			{
				id = 432,
				name = "Susano Ring",
				image = Resources.oraclering,
				level = 20,
				set = 44,
				type = 2
			};
			array48[433] = new Equipment
			{
				id = 433,
				name = "Berserker Helm",
				image = Resources.berserkerhelm,
				level = 33,
				set = 45,
				defense = 55,
				type = 4
			};
			array48[434] = new Equipment
			{
				id = 434,
				name = "Lucid Jade",
				image = Resources.berserkeramulet,
				level = 34,
				set = 45,
				type = 3
			};
			array48[435] = new Equipment
			{
				id = 435,
				name = "Berserker Warboots",
				image = Resources.berserkerboots,
				level = 35,
				set = 45,
				defense = 44,
				type = 7
			};
			array48[436] = new Equipment
			{
				id = 436,
				name = "Berserker Warchest",
				image = Resources.berserkerarmor,
				level = 37,
				set = 45,
				defense = 183,
				type = 5
			};
			array48[437] = new Equipment
			{
				id = 437,
				name = "Berserker Gloves",
				image = Resources.berserkergloves,
				level = 38,
				set = 45,
				defense = 46,
				type = 1
			};
			array48[438] = new Equipment
			{
				id = 438,
				name = "Berserker Belt",
				image = Resources.berserkerbelt,
				level = 39,
				set = 45,
				defense = 39,
				type = 6
			};
			array48[439] = new Equipment
			{
				id = 439,
				name = "Lucid Ring",
				image = Resources.berserkerring,
				level = 40,
				set = 45,
				type = 2
			};
			array48[440] = new Equipment
			{
				id = 440,
				name = "Beryl Helm",
				image = Resources.berylhelm,
				level = 43,
				set = 46,
				defense = 65,
				type = 4
			};
			array48[441] = new Equipment
			{
				id = 441,
				name = "Harmony Pendant",
				image = Resources.berylamulet,
				level = 44,
				set = 46,
				type = 3
			};
			array48[442] = new Equipment
			{
				id = 442,
				name = "Beryl Boots",
				image = Resources.berylboots,
				level = 45,
				set = 46,
				defense = 52,
				type = 7
			};
			array48[443] = new Equipment
			{
				id = 443,
				name = "Beryl Armor",
				image = Resources.berylarmor,
				level = 47,
				set = 46,
				defense = 215,
				type = 5
			};
			array48[444] = new Equipment
			{
				id = 444,
				name = "Beryl Gloves",
				image = Resources.berylgloves,
				level = 48,
				set = 46,
				defense = 54,
				type = 1
			};
			array48[445] = new Equipment
			{
				id = 445,
				name = "Beryl Belt",
				image = Resources.berylbelt,
				level = 49,
				set = 46,
				defense = 45,
				type = 6
			};
			array48[446] = new Equipment
			{
				id = 446,
				name = "Harmony Ring",
				image = Resources.berylring,
				level = 50,
				set = 46,
				type = 2
			};
			array48[447] = new Equipment
			{
				id = 447,
				name = "Bloody Battle Helm",
				image = Resources.bloodyhelm,
				level = 83,
				set = 47,
				defense = 106,
				type = 4
			};
			array48[448] = new Equipment
			{
				id = 448,
				name = "Dragonfang Necklace",
				image = Resources.bloodyamulet,
				level = 84,
				set = 47,
				type = 3
			};
			array48[449] = new Equipment
			{
				id = 449,
				name = "Bloody Warboots",
				image = Resources.bloodyboots,
				level = 85,
				set = 47,
				defense = 84,
				type = 7
			};
			array48[450] = new Equipment
			{
				id = 450,
				name = "Bloody Warchest",
				image = Resources.bloodyarmor,
				level = 87,
				set = 47,
				defense = 343,
				type = 5
			};
			array48[451] = new Equipment
			{
				id = 451,
				name = "Bloody Gloves",
				image = Resources.bloodygloves,
				level = 88,
				set = 47,
				defense = 86,
				type = 1
			};
			array48[452] = new Equipment
			{
				id = 452,
				name = "Bloody Steel Belt",
				image = Resources.bloodybelt,
				level = 89,
				set = 47,
				defense = 71,
				type = 6
			};
			array48[453] = new Equipment
			{
				id = 453,
				name = "Dragonfang Ring",
				image = Resources.bloodyring,
				level = 90,
				set = 47,
				type = 2
			};
			array48[454] = new Equipment
			{
				id = 454,
				name = "Bugle Helm",
				image = Resources.harvesthelm,
				level = 83,
				set = 48,
				defense = 106,
				type = 4
			};
			array48[455] = new Equipment
			{
				id = 455,
				name = "Harvest Amulet",
				image = Resources.harvestamulet,
				level = 84,
				set = 48,
				type = 3
			};
			array48[456] = new Equipment
			{
				id = 456,
				name = "Bugle Boots",
				image = Resources.harvestboots,
				level = 85,
				set = 48,
				defense = 84,
				type = 7
			};
			array48[457] = new Equipment
			{
				id = 457,
				name = "Bugle Armor",
				image = Resources.harvestarmor,
				level = 87,
				set = 48,
				defense = 343,
				type = 5
			};
			array48[458] = new Equipment
			{
				id = 458,
				name = "Bugle Gloves",
				image = Resources.harvestgloves,
				level = 88,
				set = 48,
				defense = 86,
				type = 1
			};
			array48[459] = new Equipment
			{
				id = 459,
				name = "Bugle Belt",
				image = Resources.harvestbelt,
				level = 89,
				set = 48,
				defense = 71,
				type = 6
			};
			array48[460] = new Equipment
			{
				id = 460,
				name = "Harvest Ring",
				image = Resources.harvestring,
				level = 90,
				set = 48,
				type = 2
			};
			array48[461] = new Equipment
			{
				id = 461,
				name = "Visor of Destruction",
				image = Resources.destructionhelm,
				level = 43,
				set = 49,
				defense = 65,
				type = 4
			};
			array48[462] = new Equipment
			{
				id = 462,
				name = "Frostwyrm Bell",
				image = Resources.destructionamulet,
				level = 44,
				set = 49,
				type = 3
			};
			array48[463] = new Equipment
			{
				id = 463,
				name = "Boots of Destruction",
				image = Resources.destructionboots,
				level = 45,
				set = 49,
				defense = 52,
				type = 7
			};
			array48[464] = new Equipment
			{
				id = 464,
				name = "Battle Suit of Destruction",
				image = Resources.destructionarmor,
				level = 47,
				set = 49,
				defense = 215,
				type = 5
			};
			array48[465] = new Equipment
			{
				id = 465,
				name = "Gloves of Destruction",
				image = Resources.destructiongloves,
				level = 48,
				set = 49,
				defense = 54,
				type = 1
			};
			array48[466] = new Equipment
			{
				id = 466,
				name = "Girdle of Destruction",
				image = Resources.destructionbelt,
				level = 49,
				set = 49,
				defense = 45,
				type = 6
			};
			array48[467] = new Equipment
			{
				id = 467,
				name = "Frostwyrm Ring",
				image = Resources.destructionring,
				level = 50,
				set = 49,
				type = 2
			};
			array48[468] = new Equipment
			{
				id = 468,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 50,
				defense = 0,
				type = 4
			};
			array48[469] = new Equipment
			{
				id = 469,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 50,
				type = 3
			};
			array48[470] = new Equipment
			{
				id = 470,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 50,
				defense = 0,
				type = 7
			};
			array48[471] = new Equipment
			{
				id = 471,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 50,
				defense = 0,
				type = 5
			};
			array48[472] = new Equipment
			{
				id = 472,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 50,
				defense = 0,
				type = 1
			};
			array48[473] = new Equipment
			{
				id = 473,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 50,
				defense = 0,
				type = 6
			};
			array48[474] = new Equipment
			{
				id = 474,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 50,
				type = 2
			};
			array48[475] = new Equipment
			{
				id = 475,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 51,
				defense = 0,
				type = 4
			};
			array48[476] = new Equipment
			{
				id = 476,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 51,
				type = 3
			};
			array48[477] = new Equipment
			{
				id = 477,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 51,
				defense = 0,
				type = 7
			};
			array48[478] = new Equipment
			{
				id = 478,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 51,
				defense = 0,
				type = 5
			};
			array48[479] = new Equipment
			{
				id = 479,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 51,
				defense = 0,
				type = 1
			};
			array48[480] = new Equipment
			{
				id = 480,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 51,
				defense = 0,
				type = 6
			};
			array48[481] = new Equipment
			{
				id = 481,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 51,
				type = 2
			};
			array48[482] = new Equipment
			{
				id = 482,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 52,
				defense = 0,
				type = 4
			};
			array48[483] = new Equipment
			{
				id = 483,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 52,
				type = 3
			};
			array48[484] = new Equipment
			{
				id = 484,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 52,
				defense = 0,
				type = 7
			};
			array48[485] = new Equipment
			{
				id = 485,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 52,
				defense = 0,
				type = 5
			};
			array48[486] = new Equipment
			{
				id = 486,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 52,
				defense = 0,
				type = 1
			};
			array48[487] = new Equipment
			{
				id = 487,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 52,
				defense = 0,
				type = 6
			};
			array48[488] = new Equipment
			{
				id = 488,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 52,
				type = 2
			};
			array48[489] = new Equipment
			{
				id = 489,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 53,
				defense = 0,
				type = 4
			};
			array48[490] = new Equipment
			{
				id = 490,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 53,
				type = 3
			};
			array48[491] = new Equipment
			{
				id = 491,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 53,
				defense = 0,
				type = 7
			};
			array48[492] = new Equipment
			{
				id = 492,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 53,
				defense = 0,
				type = 5
			};
			array48[493] = new Equipment
			{
				id = 493,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 53,
				defense = 0,
				type = 1
			};
			array48[494] = new Equipment
			{
				id = 494,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 53,
				defense = 0,
				type = 6
			};
			array48[495] = new Equipment
			{
				id = 495,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 53,
				type = 2
			};
			array48[496] = new Equipment
			{
				id = 496,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 54,
				defense = 0,
				type = 4
			};
			array48[497] = new Equipment
			{
				id = 497,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 54,
				type = 3
			};
			array48[498] = new Equipment
			{
				id = 498,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 54,
				defense = 0,
				type = 7
			};
			array48[499] = new Equipment
			{
				id = 499,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 54,
				defense = 0,
				type = 5
			};
			array48[500] = new Equipment
			{
				id = 500,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 54,
				defense = 0,
				type = 1
			};
			array48[501] = new Equipment
			{
				id = 501,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 54,
				defense = 0,
				type = 6
			};
			array48[502] = new Equipment
			{
				id = 502,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 54,
				type = 2
			};
			array48[503] = new Equipment
			{
				id = 503,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 55,
				defense = 0,
				type = 4
			};
			array48[504] = new Equipment
			{
				id = 504,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 55,
				type = 3
			};
			array48[505] = new Equipment
			{
				id = 505,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 55,
				defense = 0,
				type = 7
			};
			array48[506] = new Equipment
			{
				id = 506,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 55,
				defense = 0,
				type = 5
			};
			array48[507] = new Equipment
			{
				id = 507,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 55,
				defense = 0,
				type = 1
			};
			array48[508] = new Equipment
			{
				id = 508,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 55,
				defense = 0,
				type = 6
			};
			array48[509] = new Equipment
			{
				id = 509,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 55,
				type = 2
			};
			array48[510] = new Equipment
			{
				id = 510,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 56,
				defense = 0,
				type = 4
			};
			array48[511] = new Equipment
			{
				id = 511,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 56,
				type = 3
			};
			array48[512] = new Equipment
			{
				id = 512,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 56,
				defense = 0,
				type = 7
			};
			array48[513] = new Equipment
			{
				id = 513,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 56,
				defense = 0,
				type = 5
			};
			array48[514] = new Equipment
			{
				id = 514,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 56,
				defense = 0,
				type = 1
			};
			array48[515] = new Equipment
			{
				id = 515,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 56,
				defense = 0,
				type = 6
			};
			array48[516] = new Equipment
			{
				id = 516,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 56,
				type = 2
			};
			array48[517] = new Equipment
			{
				id = 517,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[518] = new Equipment
			{
				id = 518,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[519] = new Equipment
			{
				id = 519,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[520] = new Equipment
			{
				id = 520,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[521] = new Equipment
			{
				id = 521,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[522] = new Equipment
			{
				id = 522,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[523] = new Equipment
			{
				id = 523,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[524] = new Equipment
			{
				id = 524,
				name = "Angelic Helm",
				image = Resources.AngelicHelm,
				level = 73,
				set = 58,
				defense = 96,
				type = 4
			};
			array48[525] = new Equipment
			{
				id = 525,
				name = "Angelic Boots",
				image = Resources.AngelicBoots,
				level = 75,
				set = 58,
				defense = 76,
				type = 7
			};
			array48[526] = new Equipment
			{
				id = 526,
				name = "Angelic Armor",
				image = Resources.AngelicArmor,
				level = 77,
				set = 58,
				defense = 311,
				type = 5
			};
			array48[527] = new Equipment
			{
				id = 527,
				name = "Angelic Gloves",
				image = Resources.AngelicGloves,
				level = 78,
				set = 58,
				defense = 78,
				type = 1
			};
			array48[528] = new Equipment
			{
				id = 528,
				name = "Angelic Belt",
				image = Resources.AngelicBelt,
				level = 79,
				set = 58,
				defense = 65,
				type = 6
			};
			array48[529] = new Equipment
			{
				id = 529,
				name = "Dragon Lord Helm",
				image = Resources.DragonLordHelm,
				level = 73,
				set = 59,
				defense = 96,
				type = 4
			};
			array48[530] = new Equipment
			{
				id = 530,
				name = "Dragon Lord Boots",
				image = Resources.DragonLordBoots,
				level = 75,
				set = 59,
				defense = 76,
				type = 7
			};
			array48[531] = new Equipment
			{
				id = 531,
				name = "Dragon Lord Armor",
				image = Resources.DragonLordArmor,
				level = 77,
				set = 59,
				defense = 311,
				type = 5
			};
			array48[532] = new Equipment
			{
				id = 532,
				name = "Dragon Lord Gloves",
				image = Resources.DragonLordGloves,
				level = 78,
				set = 59,
				defense = 78,
				type = 1
			};
			array48[533] = new Equipment
			{
				id = 533,
				name = "Dragon Lord Belt",
				image = Resources.DragonLordBelt,
				level = 79,
				set = 59,
				defense = 65,
				type = 6
			};
			array48[534] = new Equipment
			{
				id = 534,
				name = "Sacred Helm",
				image = Resources.SacredHelm,
				level = 73,
				set = 60,
				defense = 96,
				type = 4
			};
			array48[535] = new Equipment
			{
				id = 535,
				name = "Sacred Boots",
				image = Resources.SacredBoots,
				level = 75,
				set = 60,
				defense = 76,
				type = 7
			};
			array48[536] = new Equipment
			{
				id = 536,
				name = "Sacred Armor",
				image = Resources.SacredArmor,
				level = 77,
				set = 60,
				defense = 311,
				type = 5
			};
			array48[537] = new Equipment
			{
				id = 537,
				name = "Sacred Gloves",
				image = Resources.SacredGloves,
				level = 78,
				set = 60,
				defense = 78,
				type = 1
			};
			array48[538] = new Equipment
			{
				id = 538,
				name = "Sacred Belt",
				image = Resources.SacredBelt,
				level = 79,
				set = 60,
				defense = 65,
				type = 6
			};
			array48[539] = new Equipment
			{
				id = 539,
				name = "Archangel Helm",
				image = Resources.AngelicHelm,
				level = 83,
				set = 61,
				defense = 106,
				type = 4
			};
			array48[540] = new Equipment
			{
				id = 540,
				name = "Archangel Boots",
				image = Resources.AngelicBoots,
				level = 85,
				set = 61,
				defense = 84,
				type = 7
			};
			array48[541] = new Equipment
			{
				id = 541,
				name = "Archangel Armor",
				image = Resources.AngelicArmor,
				level = 87,
				set = 61,
				defense = 327,
				type = 5
			};
			array48[542] = new Equipment
			{
				id = 542,
				name = "Archangel Gloves",
				image = Resources.AngelicGloves,
				level = 88,
				set = 61,
				defense = 86,
				type = 1
			};
			array48[543] = new Equipment
			{
				id = 543,
				name = "Archangel Belt",
				image = Resources.AngelicBelt,
				level = 89,
				set = 61,
				defense = 71,
				type = 6
			};
			array48[544] = new Equipment
			{
				id = 544,
				name = "Mighty Dragon Lord Helm",
				image = Resources.DragonLordHelm,
				level = 83,
				set = 62,
				defense = 106,
				type = 4
			};
			array48[545] = new Equipment
			{
				id = 545,
				name = "Mighty Dragon Lord Boots",
				image = Resources.DragonLordBoots,
				level = 85,
				set = 62,
				defense = 84,
				type = 7
			};
			array48[546] = new Equipment
			{
				id = 546,
				name = "Mighty Dragon Lord Armor",
				image = Resources.DragonLordArmor,
				level = 87,
				set = 62,
				defense = 327,
				type = 5
			};
			array48[547] = new Equipment
			{
				id = 547,
				name = "Mighty Dragon Lord Gloves",
				image = Resources.DragonLordGloves,
				level = 88,
				set = 62,
				defense = 86,
				type = 1
			};
			array48[548] = new Equipment
			{
				id = 548,
				name = "Mighty Dragon Lord Belt",
				image = Resources.DragonLordBelt,
				level = 89,
				set = 62,
				defense = 71,
				type = 6
			};
			array48[549] = new Equipment
			{
				id = 549,
				name = "Super Sacred Helm",
				image = Resources.SacredHelm,
				level = 83,
				set = 63,
				defense = 106,
				type = 4
			};
			array48[550] = new Equipment
			{
				id = 550,
				name = "Super Sacred Boots",
				image = Resources.SacredBoots,
				level = 85,
				set = 63,
				defense = 84,
				type = 7
			};
			array48[551] = new Equipment
			{
				id = 551,
				name = "Super Sacred Armor",
				image = Resources.SacredArmor,
				level = 87,
				set = 63,
				defense = 327,
				type = 5
			};
			array48[552] = new Equipment
			{
				id = 552,
				name = "Super Sacred Gloves",
				image = Resources.SacredGloves,
				level = 88,
				set = 63,
				defense = 86,
				type = 1
			};
			array48[553] = new Equipment
			{
				id = 553,
				name = "Super Sacred Belt",
				image = Resources.SacredBelt,
				level = 89,
				set = 63,
				defense = 71,
				type = 6
			};
			array48[554] = new Equipment
			{
				id = 554,
				name = "Judicator Helm",
				image = Resources.AngelicHelm,
				bonus = new Values[1]
				{
					new Hit(82)
				},
				level = 93,
				set = 64,
				defense = 122,
				type = 4
			};
			array48[555] = new Equipment
			{
				id = 555,
				name = "Judicator Boots",
				image = Resources.AngelicBoots,
				bonus = new Values[1]
				{
					new Speed(68)
				},
				level = 95,
				set = 64,
				defense = 96,
				type = 7
			};
			array48[556] = new Equipment
			{
				id = 556,
				name = "Judicator Armor",
				image = Resources.AngelicArmor,
				bonus = new Values[1]
				{
					new PHP(65)
				},
				level = 97,
				set = 64,
				defense = 380,
				type = 5
			};
			array48[557] = new Equipment
			{
				id = 557,
				name = "Judicator Gloves",
				image = Resources.AngelicGloves,
				bonus = new Values[1]
				{
					new Counterattack(70)
				},
				level = 98,
				set = 64,
				defense = 100,
				type = 1
			};
			array48[558] = new Equipment
			{
				id = 558,
				name = "Judicator Belt",
				image = Resources.AngelicBelt,
				bonus = new Values[1]
				{
					new Defense(89)
				},
				level = 99,
				set = 64,
				defense = 82,
				type = 6
			};
			array48[559] = new Equipment
			{
				id = 559,
				name = "Dark Dragon King Helm",
				image = Resources.DragonLordHelm,
				bonus = new Values[1]
				{
					new Hit(82)
				},
				level = 93,
				set = 65,
				defense = 122,
				type = 4
			};
			array48[560] = new Equipment
			{
				id = 560,
				name = "Dark Dragon King Boots",
				image = Resources.DragonLordBoots,
				bonus = new Values[1]
				{
					new Speed(68)
				},
				level = 95,
				set = 65,
				defense = 96,
				type = 7
			};
			array48[561] = new Equipment
			{
				id = 561,
				name = "Dark Dragon King Armor",
				image = Resources.DragonLordArmor,
				bonus = new Values[1]
				{
					new PHP(65)
				},
				level = 97,
				set = 65,
				defense = 380,
				type = 5
			};
			array48[562] = new Equipment
			{
				id = 562,
				name = "Dark Dragon King Gloves",
				image = Resources.DragonLordGloves,
				bonus = new Values[1]
				{
					new Counterattack(70)
				},
				level = 98,
				set = 65,
				defense = 100,
				type = 1
			};
			array48[563] = new Equipment
			{
				id = 563,
				name = "Dark Dragon King Belt",
				image = Resources.DragonLordBelt,
				bonus = new Values[1]
				{
					new Defense(89)
				},
				level = 99,
				set = 65,
				defense = 82,
				type = 6
			};
			array48[564] = new Equipment
			{
				id = 564,
				name = "Templar Helm",
				image = Resources.SacredHelm,
				bonus = new Values[1]
				{
					new Hit(82)
				},
				level = 93,
				set = 66,
				defense = 122,
				type = 4
			};
			array48[565] = new Equipment
			{
				id = 565,
				name = "Templar Boots",
				image = Resources.SacredBoots,
				bonus = new Values[1]
				{
					new Speed(68)
				},
				level = 95,
				set = 66,
				defense = 96,
				type = 7
			};
			array48[566] = new Equipment
			{
				id = 566,
				name = "Templar Armor",
				image = Resources.SacredArmor,
				bonus = new Values[1]
				{
					new PHP(65)
				},
				level = 97,
				set = 66,
				defense = 380,
				type = 5
			};
			array48[567] = new Equipment
			{
				id = 567,
				name = "Templar Gloves",
				image = Resources.SacredGloves,
				bonus = new Values[1]
				{
					new Counterattack(70)
				},
				level = 98,
				set = 66,
				defense = 100,
				type = 1
			};
			array48[568] = new Equipment
			{
				id = 568,
				name = "Templar Belt",
				image = Resources.SacredBelt,
				bonus = new Values[1]
				{
					new Defense(89)
				},
				level = 99,
				set = 66,
				defense = 82,
				type = 6
			};
			array48[569] = new Equipment
			{
				id = 569,
				name = "Dragon Soul Weapon",
				image = Resources.DragonSoulWeapon,
				bonus = new Values[1]
				{
					new PAtk(50)
				},
				level = 71,
				vlevel = 76,
				set = 67,
				attack = new int[2] { 163, 198 },
				type = 0
			};
			array48[570] = new Equipment
			{
				id = 570,
				name = "Dragon Soul Armor",
				image = Resources.DragonSoulArmor,
				bonus = new Values[1]
				{
					new PHP(50)
				},
				level = 71,
				vlevel = 77,
				set = 67,
				defense = 327,
				type = 5
			};
			array48[571] = new Equipment
			{
				id = 571,
				name = "Dragon Soul Helm",
				image = Resources.DragonSoulHelm,
				bonus = new Values[1]
				{
					new Hit(66)
				},
				level = 71,
				vlevel = 73,
				set = 67,
				defense = 106,
				type = 4
			};
			array48[572] = new Equipment
			{
				id = 572,
				name = "Dragon Soul Boots",
				image = Resources.DragonSoulBoots,
				bonus = new Values[1]
				{
					new Speed(50)
				},
				level = 71,
				vlevel = 75,
				set = 67,
				defense = 84,
				type = 7
			};
			array48[573] = new Equipment
			{
				id = 573,
				name = "Dragon Soul Gloves",
				image = Resources.DragonSoulGloves,
				bonus = new Values[1]
				{
					new Counterattack(50)
				},
				level = 71,
				vlevel = 78,
				set = 67,
				defense = 86,
				type = 1
			};
			array48[574] = new Equipment
			{
				id = 574,
				name = "Dragon Soul Belt",
				image = Resources.DragonSoulBelt,
				bonus = new Values[1]
				{
					new Defense(71)
				},
				level = 71,
				vlevel = 79,
				set = 67,
				defense = 71,
				type = 6
			};
			array48[575] = new Equipment
			{
				id = 575,
				name = "Dragon Soul Talisman",
				image = Resources.DragonSoulAmulet,
				bonus = new Values[1]
				{
					new DmgReduction(30)
				},
				level = 71,
				vlevel = 74,
				set = 67,
				type = 3
			};
			array48[576] = new Equipment
			{
				id = 576,
				name = "Dragon Soul Ring",
				image = Resources.DragonSoulRing,
				bonus = new Values[1]
				{
					new HPAbsorb(30)
				},
				level = 71,
				vlevel = 80,
				set = 67,
				type = 2
			};
			array48[577] = new Equipment
			{
				id = 577,
				name = "Fire Talisman",
				image = Resources.FireTalisman,
				level = 81,
				vlevel = 94,
				set = 68,
				type = 3
			};
			array48[578] = new Equipment
			{
				id = 578,
				name = "Fire Ring",
				image = Resources.FireRing,
				level = 81,
				vlevel = 100,
				set = 68,
				type = 2
			};
			array48[579] = new Equipment
			{
				id = 579,
				name = "Water Talisman",
				image = Resources.WaterTalisman,
				level = 81,
				vlevel = 94,
				set = 69,
				type = 3
			};
			array48[580] = new Equipment
			{
				id = 580,
				name = "Water Ring",
				image = Resources.WaterRing,
				level = 81,
				vlevel = 100,
				set = 69,
				type = 2
			};
			array48[581] = new Equipment
			{
				id = 581,
				name = "Lightning Talisman",
				image = Resources.LightningTalisman,
				level = 81,
				vlevel = 94,
				set = 70,
				type = 3
			};
			array48[582] = new Equipment
			{
				id = 582,
				name = "Lightning Ring",
				image = Resources.LightningRing,
				level = 81,
				vlevel = 100,
				set = 70,
				type = 2
			};
			array48[583] = new Equipment
			{
				id = 583,
				name = "Wind Talisman",
				image = Resources.WindTalisman,
				level = 81,
				vlevel = 94,
				set = 71,
				type = 3
			};
			array48[584] = new Equipment
			{
				id = 584,
				name = "Wind Ring",
				image = Resources.WindRing,
				level = 81,
				vlevel = 100,
				set = 71,
				type = 2
			};
			array48[585] = new Equipment
			{
				id = 585,
				name = "Earth Talisman",
				image = Resources.EarthTalisman,
				level = 81,
				vlevel = 94,
				set = 72,
				type = 3
			};
			array48[586] = new Equipment
			{
				id = 586,
				name = "Earth Ring",
				image = Resources.EarthRing,
				level = 81,
				vlevel = 100,
				set = 72,
				type = 2
			};
			array48[587] = new Equipment
			{
				id = 587,
				name = "Fire Talisman",
				image = Resources.FireTalisman,
				bonus = new Values[1]
				{
					new DmgReduction(40)
				},
				level = 91,
				vlevel = 104,
				set = 73,
				type = 3
			};
			array48[588] = new Equipment
			{
				id = 588,
				name = "Fire Ring",
				image = Resources.FireRing,
				bonus = new Values[1]
				{
					new HPAbsorb(40)
				},
				level = 91,
				vlevel = 110,
				set = 73,
				type = 2
			};
			array48[589] = new Equipment
			{
				id = 589,
				name = "Water Talisman",
				image = Resources.WaterTalisman,
				bonus = new Values[1]
				{
					new DmgReduction(40)
				},
				level = 91,
				vlevel = 104,
				set = 74,
				type = 3
			};
			array48[590] = new Equipment
			{
				id = 590,
				name = "Water Ring",
				image = Resources.WaterRing,
				bonus = new Values[1]
				{
					new HPAbsorb(40)
				},
				level = 91,
				vlevel = 110,
				set = 74,
				type = 2
			};
			array48[591] = new Equipment
			{
				id = 591,
				name = "Lightning Talisman",
				image = Resources.LightningTalisman,
				bonus = new Values[1]
				{
					new DmgReduction(40)
				},
				level = 91,
				vlevel = 104,
				set = 75,
				type = 3
			};
			array48[592] = new Equipment
			{
				id = 592,
				name = "Lightning Ring",
				image = Resources.LightningRing,
				bonus = new Values[1]
				{
					new HPAbsorb(40)
				},
				level = 91,
				vlevel = 110,
				set = 75,
				type = 2
			};
			array48[593] = new Equipment
			{
				id = 593,
				name = "Wind Talisman",
				image = Resources.WindTalisman,
				bonus = new Values[1]
				{
					new DmgReduction(40)
				},
				level = 91,
				vlevel = 104,
				set = 76,
				type = 3
			};
			array48[594] = new Equipment
			{
				id = 594,
				name = "Wind Ring",
				image = Resources.WindRing,
				bonus = new Values[1]
				{
					new HPAbsorb(40)
				},
				level = 91,
				vlevel = 110,
				set = 76,
				type = 2
			};
			array48[595] = new Equipment
			{
				id = 595,
				name = "Earth Talisman",
				image = Resources.EarthTalisman,
				bonus = new Values[1]
				{
					new DmgReduction(40)
				},
				level = 91,
				vlevel = 104,
				set = 77,
				type = 3
			};
			array48[596] = new Equipment
			{
				id = 596,
				name = "Earth Ring",
				image = Resources.EarthRing,
				bonus = new Values[1]
				{
					new HPAbsorb(40)
				},
				level = 91,
				vlevel = 110,
				set = 77,
				type = 2
			};
			array48[597] = new Equipment
			{
				id = 597,
				name = "Azure Dragon Talisman",
				image = Resources.AzureDragonTalisman,
				level = 81,
				vlevel = 94,
				set = 78,
				type = 3
			};
			array48[598] = new Equipment
			{
				id = 598,
				name = "Azure Dragon Ring",
				image = Resources.AzureDragonRing,
				level = 81,
				vlevel = 100,
				set = 78,
				type = 2
			};
			array48[599] = new Equipment
			{
				id = 599,
				name = "Vermilion Bird Talisman",
				image = Resources.VermilionBirdTalisman,
				level = 81,
				vlevel = 94,
				set = 79,
				type = 3
			};
			array48[600] = new Equipment
			{
				id = 600,
				name = "Vermilion Bird Ring",
				image = Resources.VermilionBirdRing,
				level = 81,
				vlevel = 100,
				set = 79,
				type = 2
			};
			array48[601] = new Equipment
			{
				id = 601,
				name = "Black Tortoise Talisman",
				image = Resources.BlackTortoiseTalisman,
				level = 81,
				vlevel = 94,
				set = 80,
				type = 3
			};
			array48[602] = new Equipment
			{
				id = 602,
				name = "Black Tortoise Ring",
				image = Resources.BlackTortoiseRing,
				level = 81,
				vlevel = 100,
				set = 80,
				type = 2
			};
			array48[603] = new Equipment
			{
				id = 603,
				name = "Judicator Helm",
				image = Resources.AngelicHelm,
				bonus = new Values[1]
				{
					new Hit(86)
				},
				level = 103,
				set = 81,
				defense = 127,
				type = 4
			};
			array48[604] = new Equipment
			{
				id = 604,
				name = "Judicator Boots",
				image = Resources.AngelicBoots,
				bonus = new Values[1]
				{
					new Speed(71)
				},
				level = 105,
				set = 81,
				defense = 100,
				type = 7
			};
			array48[605] = new Equipment
			{
				id = 605,
				name = "Judicator Armor",
				image = Resources.AngelicArmor,
				bonus = new Values[1]
				{
					new PHP(68)
				},
				level = 107,
				set = 81,
				defense = 407,
				type = 5
			};
			array48[606] = new Equipment
			{
				id = 606,
				name = "Judicator Gloves",
				image = Resources.AngelicGloves,
				bonus = new Values[1]
				{
					new Counterattack(70)
				},
				level = 108,
				set = 81,
				defense = 102,
				type = 1
			};
			array48[607] = new Equipment
			{
				id = 607,
				name = "Judicator Belt",
				image = Resources.AngelicBelt,
				bonus = new Values[1]
				{
					new Defense(93)
				},
				level = 109,
				set = 81,
				defense = 85,
				type = 6
			};
			array48[608] = new Equipment
			{
				id = 608,
				name = "Dark Dragon King Helm",
				image = Resources.DragonLordHelm,
				bonus = new Values[1]
				{
					new Hit(86)
				},
				level = 103,
				set = 82,
				defense = 127,
				type = 4
			};
			array48[609] = new Equipment
			{
				id = 609,
				name = "Dark Dragon King Boots",
				image = Resources.DragonLordBoots,
				bonus = new Values[1]
				{
					new Speed(71)
				},
				level = 105,
				set = 82,
				defense = 100,
				type = 7
			};
			array48[610] = new Equipment
			{
				id = 610,
				name = "Dark Dragon King Armor",
				image = Resources.DragonLordArmor,
				bonus = new Values[1]
				{
					new PHP(68)
				},
				level = 107,
				set = 82,
				defense = 407,
				type = 5
			};
			array48[611] = new Equipment
			{
				id = 611,
				name = "Dark Dragon King Gloves",
				image = Resources.DragonLordGloves,
				bonus = new Values[1]
				{
					new Counterattack(70)
				},
				level = 108,
				set = 82,
				defense = 102,
				type = 1
			};
			array48[612] = new Equipment
			{
				id = 612,
				name = "Dark Dragon King Belt",
				image = Resources.DragonLordBelt,
				bonus = new Values[1]
				{
					new Defense(93)
				},
				level = 109,
				set = 85,
				defense = 82,
				type = 6
			};
			array48[613] = new Equipment
			{
				id = 613,
				name = "Templar Helm",
				image = Resources.SacredHelm,
				bonus = new Values[1]
				{
					new Hit(86)
				},
				level = 103,
				set = 83,
				defense = 127,
				type = 4
			};
			array48[614] = new Equipment
			{
				id = 614,
				name = "Templar Boots",
				image = Resources.SacredBoots,
				bonus = new Values[1]
				{
					new Speed(71)
				},
				level = 105,
				set = 83,
				defense = 100,
				type = 7
			};
			array48[615] = new Equipment
			{
				id = 615,
				name = "Templar Armor",
				image = Resources.SacredArmor,
				bonus = new Values[1]
				{
					new PHP(68)
				},
				level = 107,
				set = 83,
				defense = 407,
				type = 5
			};
			array48[616] = new Equipment
			{
				id = 616,
				name = "Templar Gloves",
				image = Resources.SacredGloves,
				bonus = new Values[1]
				{
					new Counterattack(70)
				},
				level = 108,
				set = 83,
				defense = 102,
				type = 1
			};
			array48[617] = new Equipment
			{
				id = 617,
				name = "Templar Belt",
				image = Resources.SacredBelt,
				bonus = new Values[1]
				{
					new Defense(93)
				},
				level = 109,
				set = 83,
				defense = 85,
				type = 6
			};
			array48[618] = new Equipment
			{
				id = 618,
				name = "Captain's Helmet",
				image = Resources.CaptainHelm,
				bonus = new Values[2]
				{
					new Block(140),
					new Stamina(69)
				},
				level = 91,
				vlevel = 93,
				set = 84,
				defense = 140,
				type = 4
			};
			array48[619] = new Equipment
			{
				id = 619,
				name = "Captain's Boots",
				image = Resources.CaptainBoots,
				bonus = new Values[2]
				{
					new Speed(50),
					new DmgReduction(50)
				},
				level = 91,
				vlevel = 95,
				set = 84,
				defense = 108,
				type = 7
			};
			array48[620] = new Equipment
			{
				id = 620,
				name = "Captain's Armor",
				image = Resources.CaptainArmor,
				bonus = new Values[2]
				{
					new HP(75),
					new Healing(60)
				},
				level = 91,
				vlevel = 97,
				set = 84,
				defense = 400,
				type = 5
			};
			array48[621] = new Equipment
			{
				id = 621,
				name = "Captain's Gloves",
				image = Resources.CaptainGloves,
				bonus = new Values[2]
				{
					new Hit(73),
					new Counterattack(50)
				},
				level = 91,
				vlevel = 98,
				set = 84,
				defense = 108,
				type = 1
			};
			array48[622] = new Equipment
			{
				id = 622,
				name = "Captain's Waistbelt",
				image = Resources.CaptainBelt,
				bonus = new Values[2]
				{
					new PChakra(50),
					new EConstitution(50)
				},
				level = 91,
				vlevel = 99,
				set = 84,
				defense = 90,
				type = 6
			};
			array48[623] = new Equipment
			{
				id = 623,
				name = "Sage Headscarf",
				image = Resources.SageHelm,
				bonus = new Values[2]
				{
					new Hit(73),
					new Lightning(60)
				},
				level = 91,
				vlevel = 93,
				set = 85,
				defense = 140,
				type = 4
			};
			array48[624] = new Equipment
			{
				id = 624,
				name = "Sage Shoes",
				image = Resources.SageBoots,
				bonus = new Values[2]
				{
					new MinAtk(21),
					new EDodge(5)
				},
				level = 91,
				vlevel = 95,
				set = 85,
				defense = 108,
				type = 7
			};
			array48[625] = new Equipment
			{
				id = 625,
				name = "Sage Suits",
				image = Resources.SageArmor,
				bonus = new Values[2]
				{
					new Defense(80),
					new Critical(45)
				},
				level = 91,
				vlevel = 97,
				set = 85,
				defense = 400,
				type = 5
			};
			array48[626] = new Equipment
			{
				id = 626,
				name = "Sage Glove",
				image = Resources.SageGloves,
				bonus = new Values[2]
				{
					new Pierce(73),
					new EPierce(5)
				},
				level = 91,
				vlevel = 98,
				set = 85,
				defense = 108,
				type = 1
			};
			array48[627] = new Equipment
			{
				id = 627,
				name = "Sage Belt",
				image = Resources.SageBelt,
				bonus = new Values[2]
				{
					new Agility(69),
					new HPAbsorb(30)
				},
				level = 91,
				vlevel = 99,
				set = 85,
				defense = 90,
				type = 6
			};
			array48[628] = new Equipment
			{
				id = 628,
				name = "Soul Reaper's Headband",
				image = Resources.SoulReaperHelm,
				bonus = new Values[2]
				{
					new Defense(80),
					new Strength(69)
				},
				level = 91,
				vlevel = 93,
				set = 86,
				defense = 140,
				type = 4
			};
			array48[629] = new Equipment
			{
				id = 629,
				name = "Soul Reaper's Clog",
				image = Resources.SoulReaperBoots,
				bonus = new Values[2]
				{
					new Speed(50),
					new Constitution(68)
				},
				level = 91,
				vlevel = 95,
				set = 86,
				defense = 108,
				type = 7
			};
			array48[630] = new Equipment
			{
				id = 630,
				name = "Soul Reaper's Clothes",
				image = Resources.SoulReaperArmor,
				bonus = new Values[2]
				{
					new PHP(50),
					new Fire(60)
				},
				level = 91,
				vlevel = 97,
				set = 86,
				defense = 400,
				type = 5
			};
			array48[631] = new Equipment
			{
				id = 631,
				name = "Soul Reaper's Glove",
				image = Resources.SoulReaperGloves,
				bonus = new Values[2]
				{
					new MaxAtk(21),
					new ECritical(5)
				},
				level = 91,
				vlevel = 98,
				set = 86,
				defense = 108,
				type = 1
			};
			array48[632] = new Equipment
			{
				id = 632,
				name = "Soul Reaper's Belt",
				image = Resources.SoulReaperBelt,
				bonus = new Values[2]
				{
					new Block(48),
					new Pierce(73)
				},
				level = 91,
				vlevel = 99,
				set = 86,
				defense = 90,
				type = 6
			};
			array48[633] = new Equipment
			{
				id = 633,
				name = "R.Captain's Helmet",
				image = Resources.CaptainHelm,
				bonus = new Values[2]
				{
					new Block(51),
					new Stamina(74)
				},
				level = 101,
				vlevel = 103,
				set = 87,
				defense = 151,
				type = 4
			};
			array48[634] = new Equipment
			{
				id = 634,
				name = "R.Captain's Boots",
				image = Resources.CaptainBoots,
				bonus = new Values[2]
				{
					new Speed(55),
					new DmgReduction(60)
				},
				level = 101,
				vlevel = 105,
				set = 87,
				defense = 118,
				type = 7
			};
			array48[635] = new Equipment
			{
				id = 635,
				name = "R.Captain's Armor",
				image = Resources.CaptainArmor,
				bonus = new Values[2]
				{
					new HP(81),
					new Healing(65)
				},
				level = 101,
				vlevel = 107,
				set = 87,
				defense = 426,
				type = 5
			};
			array48[636] = new Equipment
			{
				id = 636,
				name = "R.Captain's Gloves",
				image = Resources.CaptainGloves,
				bonus = new Values[2]
				{
					new Hit(80),
					new Counterattack(60)
				},
				level = 101,
				vlevel = 108,
				set = 87,
				defense = 116,
				type = 1
			};
			array48[637] = new Equipment
			{
				id = 637,
				name = "R.Captain's Waistbelt",
				image = Resources.CaptainBelt,
				bonus = new Values[2]
				{
					new PChakra(55),
					new EConstitution(6)
				},
				level = 101,
				vlevel = 109,
				set = 87,
				defense = 98,
				type = 6
			};
			array48[638] = new Equipment
			{
				id = 638,
				name = "R.Sage Headscarf",
				image = Resources.SageHelm,
				bonus = new Values[2]
				{
					new Hit(73),
					new Lightning(60)
				},
				level = 101,
				vlevel = 103,
				set = 88,
				defense = 151,
				type = 4
			};
			array48[639] = new Equipment
			{
				id = 639,
				name = "R.Sage Shoes",
				image = Resources.SageBoots,
				bonus = new Values[2]
				{
					new MinAtk(24),
					new EDodge(6)
				},
				level = 101,
				vlevel = 105,
				set = 88,
				defense = 118,
				type = 7
			};
			array48[640] = new Equipment
			{
				id = 640,
				name = "R.Sage Suits",
				image = Resources.SageArmor,
				bonus = new Values[2]
				{
					new Defense(80),
					new Critical(45)
				},
				level = 101,
				vlevel = 107,
				set = 88,
				defense = 426,
				type = 5
			};
			array48[641] = new Equipment
			{
				id = 641,
				name = "R.Sage Glove",
				image = Resources.SageGloves,
				bonus = new Values[2]
				{
					new Pierce(73),
					new EPierce(5)
				},
				level = 101,
				vlevel = 108,
				set = 88,
				defense = 116,
				type = 1
			};
			array48[642] = new Equipment
			{
				id = 642,
				name = "R.Sage Belt",
				image = Resources.SageBelt,
				bonus = new Values[2]
				{
					new Agility(74),
					new HPAbsorb(40)
				},
				level = 101,
				vlevel = 109,
				set = 88,
				defense = 98,
				type = 6
			};
			array48[643] = new Equipment
			{
				id = 643,
				name = "R.Soul Reaper's Headband",
				image = Resources.SoulReaperHelm,
				bonus = new Values[2]
				{
					new Defense(80),
					new Strength(69)
				},
				level = 101,
				vlevel = 103,
				set = 89,
				defense = 151,
				type = 4
			};
			array48[644] = new Equipment
			{
				id = 644,
				name = "R.Soul Reaper's Clog",
				image = Resources.SoulReaperBoots,
				bonus = new Values[2]
				{
					new Speed(50),
					new Constitution(68)
				},
				level = 101,
				vlevel = 105,
				set = 89,
				defense = 118,
				type = 7
			};
			array48[645] = new Equipment
			{
				id = 645,
				name = "R.Soul Reaper's Clothes",
				image = Resources.SoulReaperArmor,
				bonus = new Values[2]
				{
					new PHP(50),
					new Fire(60)
				},
				level = 101,
				vlevel = 107,
				set = 89,
				defense = 426,
				type = 5
			};
			array48[646] = new Equipment
			{
				id = 646,
				name = "R.Soul Reaper's Glove",
				image = Resources.SoulReaperGloves,
				bonus = new Values[2]
				{
					new MaxAtk(21),
					new ECritical(5)
				},
				level = 101,
				vlevel = 108,
				set = 89,
				defense = 116,
				type = 1
			};
			array48[647] = new Equipment
			{
				id = 647,
				name = "R.Soul Reaper's Belt",
				image = Resources.SoulReaperBelt,
				bonus = new Values[2]
				{
					new Block(48),
					new Pierce(73)
				},
				level = 101,
				vlevel = 109,
				set = 89,
				defense = 98,
				type = 6
			};
			array48[648] = new Equipment
			{
				id = 648,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[649] = new Equipment
			{
				id = 649,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[650] = new Equipment
			{
				id = 650,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[651] = new Equipment
			{
				id = 651,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[652] = new Equipment
			{
				id = 652,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[653] = new Equipment
			{
				id = 653,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[654] = new Equipment
			{
				id = 654,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[655] = new Equipment
			{
				id = 655,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[656] = new Equipment
			{
				id = 656,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[657] = new Equipment
			{
				id = 657,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[658] = new Equipment
			{
				id = 658,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[659] = new Equipment
			{
				id = 659,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[660] = new Equipment
			{
				id = 660,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[661] = new Equipment
			{
				id = 661,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[662] = new Equipment
			{
				id = 662,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[663] = new Equipment
			{
				id = 663,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[664] = new Equipment
			{
				id = 664,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[665] = new Equipment
			{
				id = 665,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[666] = new Equipment
			{
				id = 666,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[667] = new Equipment
			{
				id = 667,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[668] = new Equipment
			{
				id = 668,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[669] = new Equipment
			{
				id = 669,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[670] = new Equipment
			{
				id = 670,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[671] = new Equipment
			{
				id = 671,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[672] = new Equipment
			{
				id = 672,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[673] = new Equipment
			{
				id = 673,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[674] = new Equipment
			{
				id = 674,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[675] = new Equipment
			{
				id = 675,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[676] = new Equipment
			{
				id = 676,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[677] = new Equipment
			{
				id = 677,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[678] = new Equipment
			{
				id = 678,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[679] = new Equipment
			{
				id = 679,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[680] = new Equipment
			{
				id = 680,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[681] = new Equipment
			{
				id = 681,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[682] = new Equipment
			{
				id = 682,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[683] = new Equipment
			{
				id = 683,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[684] = new Equipment
			{
				id = 684,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[685] = new Equipment
			{
				id = 685,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[686] = new Equipment
			{
				id = 686,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[687] = new Equipment
			{
				id = 687,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[688] = new Equipment
			{
				id = 688,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[689] = new Equipment
			{
				id = 689,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[690] = new Equipment
			{
				id = 690,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 4
			};
			array48[691] = new Equipment
			{
				id = 691,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 3
			};
			array48[692] = new Equipment
			{
				id = 692,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 7
			};
			array48[693] = new Equipment
			{
				id = 693,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 5
			};
			array48[694] = new Equipment
			{
				id = 694,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 1
			};
			array48[695] = new Equipment
			{
				id = 695,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				defense = 0,
				type = 6
			};
			array48[696] = new Equipment
			{
				id = 696,
				name = "",
				image = Resources.empty,
				level = 0,
				set = 57,
				type = 2
			};
			array48[697] = new Equipment
			{
				id = 697,
				forge = 1,
				name = "Flame Helm",
				image = Resources.forge33,
				level = 33,
				defense = 55,
				type = 4
			};
			array48[698] = new Equipment
			{
				id = 698,
				forge = 1,
				name = "Flame Necklace",
				image = Resources.forge34,
				level = 34,
				type = 3
			};
			array48[699] = new Equipment
			{
				id = 699,
				forge = 1,
				name = "Flame Boots",
				image = Resources.forge35,
				level = 35,
				defense = 44,
				type = 7
			};
			array48[700] = new Equipment
			{
				id = 700,
				forge = 1,
				name = "Flame Weapon",
				image = Resources.forge36,
				level = 36,
				attack = new int[2] { 67, 82 },
				type = 0
			};
			array48[701] = new Equipment
			{
				id = 701,
				forge = 1,
				name = "Flame Armor",
				image = Resources.forge37,
				level = 37,
				defense = 183,
				type = 5
			};
			array48[702] = new Equipment
			{
				id = 702,
				forge = 1,
				name = "Flame Gloves",
				image = Resources.forge38,
				level = 38,
				defense = 46,
				type = 1
			};
			array48[703] = new Equipment
			{
				id = 703,
				forge = 1,
				name = "Flame Belt",
				image = Resources.forge39,
				level = 39,
				defense = 39,
				type = 6
			};
			array48[704] = new Equipment
			{
				id = 704,
				forge = 1,
				name = "Flame Ring",
				image = Resources.forge40,
				level = 40,
				type = 2
			};
			array48[705] = new Equipment
			{
				id = 705,
				forge = 1,
				name = "Thunderbolt Helm",
				image = Resources.forge43,
				level = 43,
				defense = 65,
				type = 4
			};
			array48[706] = new Equipment
			{
				id = 706,
				forge = 1,
				name = "Thunderbolt Necklace",
				image = Resources.forge44,
				level = 44,
				type = 3
			};
			array48[707] = new Equipment
			{
				id = 707,
				forge = 1,
				name = "Thunderbolt Boots",
				image = Resources.forge45,
				level = 45,
				defense = 52,
				type = 7
			};
			array48[708] = new Equipment
			{
				id = 708,
				forge = 1,
				name = "Thunderbolt Weapon",
				image = Resources.forge46,
				level = 46,
				attack = new int[2] { 86, 105 },
				type = 0
			};
			array48[709] = new Equipment
			{
				id = 709,
				forge = 1,
				name = "Thunderbolt Armor",
				image = Resources.forge47,
				level = 47,
				defense = 215,
				type = 5
			};
			array48[710] = new Equipment
			{
				id = 710,
				forge = 1,
				name = "Thunderbolt Gloves",
				image = Resources.forge48,
				level = 48,
				defense = 54,
				type = 1
			};
			array48[711] = new Equipment
			{
				id = 711,
				forge = 1,
				name = "Thunderbolt Belt",
				image = Resources.forge49,
				level = 49,
				defense = 45,
				type = 6
			};
			array48[712] = new Equipment
			{
				id = 712,
				forge = 1,
				name = "Thunderbolt Ring",
				image = Resources.forge50,
				level = 50,
				type = 2
			};
			array48[713] = new Equipment
			{
				id = 713,
				forge = 1,
				name = "Rainbow Helm",
				image = Resources.forge53,
				level = 53,
				defense = 75,
				type = 4
			};
			array48[714] = new Equipment
			{
				id = 714,
				forge = 1,
				name = "Rainbow Necklace",
				image = Resources.forge54,
				level = 54,
				type = 3
			};
			array48[715] = new Equipment
			{
				id = 715,
				forge = 1,
				name = "Rainbow Boots",
				image = Resources.forge55,
				level = 55,
				defense = 60,
				type = 7
			};
			array48[716] = new Equipment
			{
				id = 716,
				forge = 1,
				name = "Rainbow Weapon",
				image = Resources.forge56,
				level = 56,
				attack = new int[2] { 106, 130 },
				type = 0
			};
			array48[717] = new Equipment
			{
				id = 717,
				forge = 1,
				name = "Rainbow Armor",
				image = Resources.forge57,
				level = 57,
				defense = 247,
				type = 5
			};
			array48[718] = new Equipment
			{
				id = 718,
				forge = 1,
				name = "Rainbow Gloves",
				image = Resources.forge58,
				level = 58,
				defense = 62,
				type = 1
			};
			array48[719] = new Equipment
			{
				id = 719,
				forge = 1,
				name = "Rainbow Belt",
				image = Resources.forge59,
				level = 59,
				defense = 52,
				type = 6
			};
			array48[720] = new Equipment
			{
				id = 720,
				forge = 1,
				name = "Rainbow Ring",
				image = Resources.forge60,
				level = 60,
				type = 2
			};
			array48[721] = new Equipment
			{
				id = 721,
				forge = 1,
				name = "Heavenly Tone Helm",
				image = Resources.forge63,
				level = 63,
				defense = 86,
				type = 4
			};
			array48[722] = new Equipment
			{
				id = 722,
				forge = 1,
				name = "Heavenly Tone Necklace",
				image = Resources.forge64,
				level = 64,
				type = 3
			};
			array48[723] = new Equipment
			{
				id = 723,
				forge = 1,
				name = "Heavenly Tone Boots",
				image = Resources.forge65,
				level = 65,
				defense = 68,
				type = 7
			};
			array48[724] = new Equipment
			{
				id = 724,
				forge = 1,
				name = "Heavenly Tone Weapon",
				image = Resources.forge66,
				level = 66,
				attack = new int[2] { 129, 156 },
				type = 0
			};
			array48[725] = new Equipment
			{
				id = 725,
				forge = 1,
				name = "Heavenly Tone Armor",
				image = Resources.forge67,
				level = 67,
				defense = 279,
				type = 5
			};
			array48[726] = new Equipment
			{
				id = 726,
				forge = 1,
				name = "Heavenly Tone Gloves",
				image = Resources.forge68,
				level = 68,
				defense = 70,
				type = 1
			};
			array48[727] = new Equipment
			{
				id = 727,
				forge = 1,
				name = "Heavenly Tone Belt",
				image = Resources.forge69,
				level = 69,
				defense = 58,
				type = 6
			};
			array48[728] = new Equipment
			{
				id = 728,
				forge = 1,
				name = "Heavenly Tone Ring",
				image = Resources.forge70,
				level = 70,
				type = 2
			};
			array48[729] = new Equipment
			{
				id = 729,
				forge = 2,
				name = "Crystal Helm",
				image = Resources.forge73,
				level = 73,
				defense = 96,
				type = 4
			};
			array48[730] = new Equipment
			{
				id = 730,
				forge = 2,
				name = "Crystal Necklace",
				image = Resources.forge74,
				level = 74,
				type = 3
			};
			array48[731] = new Equipment
			{
				id = 731,
				forge = 2,
				name = "Crystal Boots",
				image = Resources.forge75,
				level = 75,
				defense = 76,
				type = 7
			};
			array48[732] = new Equipment
			{
				id = 732,
				forge = 2,
				name = "Crystal Weapon",
				image = Resources.forge76,
				level = 76,
				attack = new int[2] { 151, 184 },
				type = 0
			};
			array48[733] = new Equipment
			{
				id = 733,
				forge = 2,
				name = "Crystal Armor",
				image = Resources.forge77,
				level = 77,
				defense = 311,
				type = 5
			};
			array48[734] = new Equipment
			{
				id = 734,
				forge = 2,
				name = "Crystal Gloves",
				image = Resources.forge78,
				level = 78,
				defense = 78,
				type = 1
			};
			array48[735] = new Equipment
			{
				id = 735,
				forge = 2,
				name = "Crystal Belt",
				image = Resources.forge79,
				level = 79,
				defense = 65,
				type = 6
			};
			array48[736] = new Equipment
			{
				id = 736,
				forge = 2,
				name = "Crystal Ring",
				image = Resources.forge80,
				level = 80,
				type = 2
			};
			array48[737] = new Equipment
			{
				id = 737,
				forge = 2,
				name = "Crane Feather Helm",
				image = Resources.forge83,
				level = 83,
				defense = 106,
				type = 4
			};
			array48[738] = new Equipment
			{
				id = 738,
				forge = 2,
				name = "Crane Feather Necklace",
				image = Resources.forge84,
				level = 84,
				type = 3
			};
			array48[739] = new Equipment
			{
				id = 739,
				forge = 2,
				name = "Crane Feather Boots",
				image = Resources.forge85,
				level = 85,
				defense = 84,
				type = 7
			};
			array48[740] = new Equipment
			{
				id = 740,
				forge = 2,
				name = "Crane Feather Weapon",
				image = Resources.forge86,
				level = 86,
				attack = new int[2] { 176, 213 },
				type = 0
			};
			array48[741] = new Equipment
			{
				id = 741,
				forge = 2,
				name = "Crane Feather Armor",
				image = Resources.forge87,
				level = 87,
				defense = 343,
				type = 5
			};
			array48[742] = new Equipment
			{
				id = 742,
				forge = 2,
				name = "Crane Feather Gloves",
				image = Resources.forge88,
				level = 88,
				defense = 86,
				type = 1
			};
			array48[743] = new Equipment
			{
				id = 743,
				forge = 2,
				name = "Crane Feather Belt",
				image = Resources.forge89,
				level = 89,
				defense = 71,
				type = 6
			};
			array48[744] = new Equipment
			{
				id = 744,
				forge = 2,
				name = "Crane Feather Ring",
				image = Resources.forge90,
				level = 90,
				type = 2
			};
			array48[745] = new Equipment
			{
				id = 745,
				forge = 2,
				name = "Shining Helm",
				image = Resources.forge93,
				level = 93,
				defense = 117,
				type = 4
			};
			array48[746] = new Equipment
			{
				id = 746,
				forge = 2,
				name = "Shining Necklace",
				image = Resources.forge94,
				level = 94,
				type = 3
			};
			array48[747] = new Equipment
			{
				id = 747,
				forge = 2,
				name = "Shining Boots",
				image = Resources.forge95,
				level = 95,
				defense = 92,
				type = 7
			};
			array48[748] = new Equipment
			{
				id = 748,
				forge = 2,
				name = "Shining Weapon",
				image = Resources.forge96,
				level = 96,
				attack = new int[2] { 198, 238 },
				type = 0
			};
			array48[749] = new Equipment
			{
				id = 749,
				forge = 2,
				name = "Shining Armor",
				image = Resources.forge97,
				level = 97,
				defense = 375,
				type = 5
			};
			array48[750] = new Equipment
			{
				id = 750,
				forge = 2,
				name = "Shining Gloves",
				image = Resources.forge98,
				level = 98,
				defense = 94,
				type = 1
			};
			array48[751] = new Equipment
			{
				id = 751,
				forge = 2,
				name = "Shining Belt",
				image = Resources.forge99,
				level = 99,
				defense = 77,
				type = 6
			};
			array48[752] = new Equipment
			{
				id = 752,
				forge = 2,
				name = "Shining Ring",
				image = Resources.forge100,
				level = 100,
				type = 2
			};
			array48[753] = new Equipment
			{
				id = 753,
				forge = 2,
				name = "Hidden Bore Helm",
				image = Resources.forge103,
				level = 103,
				defense = 127,
				type = 4
			};
			array48[754] = new Equipment
			{
				id = 754,
				forge = 2,
				name = "Hidden Bore Necklace",
				image = Resources.forge104,
				level = 104,
				type = 3
			};
			array48[755] = new Equipment
			{
				id = 755,
				forge = 2,
				name = "Hidden Bore Boots",
				image = Resources.forge105,
				level = 105,
				defense = 100,
				type = 7
			};
			array48[756] = new Equipment
			{
				id = 756,
				forge = 2,
				name = "Hidden Bore Weapon",
				image = Resources.forge106,
				level = 106,
				attack = new int[2] { 223, 272 },
				type = 0
			};
			array48[757] = new Equipment
			{
				id = 757,
				forge = 2,
				name = "Hidden Bore Armor",
				image = Resources.forge107,
				level = 107,
				defense = 407,
				type = 5
			};
			array48[758] = new Equipment
			{
				id = 758,
				forge = 2,
				name = "Hidden Bore Gloves",
				image = Resources.forge108,
				level = 108,
				defense = 78,
				type = 1
			};
			array48[759] = new Equipment
			{
				id = 759,
				forge = 2,
				name = "Hidden Bore Belt",
				image = Resources.forge109,
				level = 109,
				defense = 85,
				type = 6
			};
			array48[760] = new Equipment
			{
				id = 760,
				forge = 2,
				name = "Hidden Bore Ring",
				image = Resources.forge110,
				level = 110,
				type = 2
			};
			array48[761] = new Equipment
			{
				id = 761,
				forge = 2,
				name = "Demented Helm",
				image = Resources.demented93,
				set = 111,
				level = 93,
				defense = 117,
				type = 4
			};
			array48[762] = new Equipment
			{
				id = 762,
				forge = 2,
				name = "Demented Necklace",
				image = Resources.demented94,
				set = 111,
				level = 94,
				type = 3
			};
			array48[763] = new Equipment
			{
				id = 763,
				forge = 2,
				name = "Demented Boots",
				image = Resources.demented95,
				set = 111,
				level = 95,
				defense = 92,
				type = 7
			};
			array48[764] = new Equipment
			{
				id = 764,
				forge = 2,
				name = "Demented Weapon",
				image = Resources.demented106,
				set = 111,
				level = 96,
				attack = new int[2] { 198, 238 },
				type = 0
			};
			array48[765] = new Equipment
			{
				id = 765,
				forge = 2,
				name = "Demented Armor",
				image = Resources.demented97,
				set = 111,
				level = 97,
				defense = 375,
				type = 5
			};
			array48[766] = new Equipment
			{
				id = 766,
				forge = 2,
				name = "Demented Gloves",
				image = Resources.demented98,
				set = 111,
				level = 98,
				defense = 94,
				type = 1
			};
			array48[767] = new Equipment
			{
				id = 767,
				forge = 2,
				name = "Demented Belt",
				image = Resources.demented99,
				set = 111,
				level = 99,
				defense = 77,
				type = 6
			};
			array48[768] = new Equipment
			{
				id = 768,
				forge = 2,
				name = "Demented Ring",
				image = Resources.demented100,
				set = 111,
				level = 100,
				type = 2
			};
			array48[769] = new Equipment
			{
				id = 769,
				forge = 2,
				name = "Worship Helm",
				image = Resources.worship93,
				set = 112,
				level = 93,
				defense = 117,
				type = 4
			};
			array48[770] = new Equipment
			{
				id = 770,
				forge = 2,
				name = "Worship Necklace",
				image = Resources.worship94,
				set = 112,
				level = 94,
				type = 3
			};
			array48[771] = new Equipment
			{
				id = 771,
				forge = 2,
				name = "Worship Boots",
				image = Resources.worship95,
				set = 112,
				level = 95,
				defense = 92,
				type = 7
			};
			array48[772] = new Equipment
			{
				id = 772,
				forge = 2,
				name = "Worship Weapon",
				image = Resources.worship106,
				set = 112,
				level = 96,
				attack = new int[2] { 198, 238 },
				type = 0
			};
			array48[773] = new Equipment
			{
				id = 773,
				forge = 2,
				name = "Worship Armor",
				image = Resources.worship97,
				set = 112,
				level = 97,
				defense = 375,
				type = 5
			};
			array48[774] = new Equipment
			{
				id = 774,
				forge = 2,
				name = "Worship Gloves",
				image = Resources.worship98,
				set = 112,
				level = 98,
				defense = 94,
				type = 1
			};
			array48[775] = new Equipment
			{
				id = 775,
				forge = 2,
				name = "Worship Belt",
				image = Resources.worship99,
				set = 112,
				level = 99,
				defense = 77,
				type = 6
			};
			array48[776] = new Equipment
			{
				id = 776,
				forge = 2,
				name = "Worship Ring",
				image = Resources.worship100,
				set = 112,
				level = 100,
				type = 2
			};
			array48[777] = new Equipment
			{
				id = 777,
				forge = 2,
				name = "Emperor Helm",
				image = Resources.emperor93,
				set = 113,
				level = 93,
				defense = 117,
				type = 4
			};
			array48[778] = new Equipment
			{
				id = 778,
				forge = 2,
				name = "Emperor Necklace",
				image = Resources.emperor94,
				set = 113,
				level = 94,
				type = 3
			};
			array48[779] = new Equipment
			{
				id = 779,
				forge = 2,
				name = "Emperor Boots",
				image = Resources.emperor95,
				set = 113,
				level = 95,
				defense = 92,
				type = 7
			};
			array48[780] = new Equipment
			{
				id = 780,
				forge = 2,
				name = "Emperor Weapon",
				image = Resources.emperor106,
				set = 113,
				level = 96,
				attack = new int[2] { 198, 238 },
				type = 0
			};
			array48[781] = new Equipment
			{
				id = 781,
				forge = 2,
				name = "Emperor Armor",
				image = Resources.emperor97,
				set = 113,
				level = 97,
				defense = 375,
				type = 5
			};
			array48[782] = new Equipment
			{
				id = 782,
				forge = 2,
				name = "Emperor Gloves",
				image = Resources.emperor98,
				set = 113,
				level = 98,
				defense = 94,
				type = 1
			};
			array48[783] = new Equipment
			{
				id = 783,
				forge = 2,
				name = "Emperor Belt",
				image = Resources.emperor99,
				set = 113,
				level = 99,
				defense = 77,
				type = 6
			};
			array48[784] = new Equipment
			{
				id = 784,
				forge = 2,
				name = "Emperor Ring",
				image = Resources.emperor100,
				set = 113,
				level = 100,
				type = 2
			};
			array48[785] = new Equipment
			{
				id = 785,
				forge = 2,
				name = "Demented Helm",
				image = Resources.demented103,
				set = 114,
				level = 103,
				defense = 127,
				type = 4
			};
			array48[786] = new Equipment
			{
				id = 786,
				forge = 2,
				name = "Demented Necklace",
				image = Resources.demented104,
				set = 114,
				level = 104,
				type = 3
			};
			array48[787] = new Equipment
			{
				id = 787,
				forge = 2,
				name = "Demented Boots",
				image = Resources.demented105,
				set = 114,
				level = 105,
				defense = 100,
				type = 7
			};
			array48[788] = new Equipment
			{
				id = 788,
				forge = 2,
				name = "Demented Weapon",
				image = Resources.demented106,
				set = 114,
				level = 106,
				attack = new int[2] { 223, 272 },
				type = 0
			};
			array48[789] = new Equipment
			{
				id = 789,
				forge = 2,
				name = "Demented Armor",
				image = Resources.demented107,
				set = 114,
				level = 107,
				defense = 407,
				type = 5
			};
			array48[790] = new Equipment
			{
				id = 790,
				forge = 2,
				name = "Demented Gloves",
				image = Resources.demented108,
				set = 114,
				level = 108,
				defense = 78,
				type = 1
			};
			array48[791] = new Equipment
			{
				id = 791,
				forge = 2,
				name = "Demented Belt",
				image = Resources.demented109,
				set = 114,
				level = 109,
				defense = 85,
				type = 6
			};
			array48[792] = new Equipment
			{
				id = 792,
				forge = 2,
				name = "Demented Ring",
				image = Resources.demented110,
				set = 114,
				level = 110,
				type = 2
			};
			array48[793] = new Equipment
			{
				id = 793,
				forge = 2,
				name = "Worship Helm",
				image = Resources.worship103,
				set = 115,
				level = 103,
				defense = 127,
				type = 4
			};
			array48[794] = new Equipment
			{
				id = 794,
				forge = 2,
				name = "Worship Necklace",
				image = Resources.worship104,
				set = 115,
				level = 104,
				type = 3
			};
			array48[795] = new Equipment
			{
				id = 795,
				forge = 2,
				name = "Worship Boots",
				image = Resources.worship105,
				set = 115,
				level = 105,
				defense = 100,
				type = 7
			};
			array48[796] = new Equipment
			{
				id = 796,
				forge = 2,
				name = "Worship Weapon",
				image = Resources.worship106,
				set = 115,
				level = 106,
				attack = new int[2] { 223, 272 },
				type = 0
			};
			array48[797] = new Equipment
			{
				id = 797,
				forge = 2,
				name = "Worship Armor",
				image = Resources.worship107,
				set = 115,
				level = 107,
				defense = 407,
				type = 5
			};
			array48[798] = new Equipment
			{
				id = 798,
				forge = 2,
				name = "Worship Gloves",
				image = Resources.worship108,
				set = 115,
				level = 108,
				defense = 78,
				type = 1
			};
			array48[799] = new Equipment
			{
				id = 799,
				forge = 2,
				name = "Worship Belt",
				image = Resources.worship109,
				set = 115,
				level = 109,
				defense = 85,
				type = 6
			};
			array48[800] = new Equipment
			{
				id = 800,
				forge = 2,
				name = "Worship Ring",
				image = Resources.worship110,
				set = 115,
				level = 110,
				type = 2
			};
			array48[801] = new Equipment
			{
				id = 801,
				forge = 2,
				name = "Emperor Helm",
				image = Resources.emperor103,
				set = 116,
				level = 103,
				defense = 127,
				type = 4
			};
			array48[802] = new Equipment
			{
				id = 802,
				forge = 2,
				name = "Emperor Necklace",
				image = Resources.emperor104,
				set = 116,
				level = 104,
				type = 3
			};
			array48[803] = new Equipment
			{
				id = 803,
				forge = 2,
				name = "Emperor Boots",
				image = Resources.emperor105,
				set = 116,
				level = 105,
				defense = 100,
				type = 7
			};
			array48[804] = new Equipment
			{
				id = 804,
				forge = 2,
				name = "Emperor Weapon",
				image = Resources.emperor106,
				set = 116,
				level = 106,
				attack = new int[2] { 223, 272 },
				type = 0
			};
			array48[805] = new Equipment
			{
				id = 805,
				forge = 2,
				name = "Emperor Armor",
				image = Resources.emperor107,
				set = 116,
				level = 107,
				defense = 407,
				type = 5
			};
			array48[806] = new Equipment
			{
				id = 806,
				forge = 2,
				name = "Emperor Gloves",
				image = Resources.emperor108,
				set = 116,
				level = 108,
				defense = 78,
				type = 1
			};
			array48[807] = new Equipment
			{
				id = 807,
				forge = 2,
				name = "Emperor Belt",
				image = Resources.emperor109,
				set = 116,
				level = 109,
				defense = 85,
				type = 6
			};
			array48[808] = new Equipment
			{
				id = 808,
				forge = 2,
				name = "Emperor Ring",
				image = Resources.emperor110,
				set = 116,
				level = 110,
				type = 2
			};
			DataLibrary.equipment = array48;
			Set[] array49 = new Set[117];
			Set set = new Set
			{
				id = 0,
				name = "dummy"
			};
			Values[] bonus = new Values[8];
			set.bonus = bonus;
			array49[0] = set;
			array49[1] = new Set
			{
				id = 1,
				name = "Beastlord",
				bonus = new Values[8]
				{
					null,
					new Chakra(13),
					new Dodge(40),
					new Block(40),
					null,
					null,
					null,
					null
				}
			};
			array49[2] = new Set
			{
				id = 2,
				name = "Gilded",
				bonus = new Values[8]
				{
					null,
					new Chakra(24),
					new Dodge(44),
					new Block(44),
					null,
					null,
					null,
					null
				}
			};
			array49[3] = new Set
			{
				id = 3,
				name = "Tengu Bamboo",
				bonus = new Values[8]
				{
					null,
					new Constitution(32),
					new Speed(20),
					new Defense(34),
					null,
					null,
					null,
					null
				}
			};
			array49[4] = new Set
			{
				id = 4,
				name = "Quicksilver",
				bonus = new Values[8]
				{
					null,
					new Chakra(33),
					new Dodge(47),
					new Block(47),
					null,
					null,
					null,
					null
				}
			};
			array49[5] = new Set
			{
				id = 5,
				name = "Ferocious",
				bonus = new Values[8]
				{
					null,
					new Constitution(35),
					new Speed(25),
					new Defense(43),
					null,
					null,
					null,
					null
				}
			};
			array49[6] = new Set
			{
				id = 6,
				name = "Deity's",
				bonus = new Values[8]
				{
					null,
					new Stamina(38),
					new Strength(38),
					new Agility(38),
					null,
					null,
					null,
					null
				}
			};
			array49[7] = new Set
			{
				id = 7,
				name = "Oni",
				bonus = new Values[8]
				{
					null,
					new Constitution(42),
					new Speed(30),
					new Defense(53),
					null,
					null,
					null,
					null
				}
			};
			array49[8] = new Set
			{
				id = 8,
				name = "Balanced",
				bonus = new Values[8]
				{
					null,
					new Stamina(44),
					new Strength(44),
					new Agility(44),
					null,
					null,
					null,
					null
				}
			};
			array49[9] = new Set
			{
				id = 9,
				name = "Cosmic",
				bonus = new Values[8]
				{
					null,
					new Chakra(45),
					new Dodge(51),
					new Block(51),
					null,
					null,
					null,
					null
				}
			};
			Set set2 = new Set
			{
				id = 10,
				name = ""
			};
			bonus = new Values[8];
			set2.bonus = bonus;
			array49[10] = set2;
			Set set3 = new Set
			{
				id = 11,
				name = ""
			};
			bonus = new Values[8];
			set3.bonus = bonus;
			array49[11] = set3;
			Set set4 = new Set
			{
				id = 12,
				name = ""
			};
			bonus = new Values[8];
			set4.bonus = bonus;
			array49[12] = set4;
			Set set5 = new Set
			{
				id = 13,
				name = ""
			};
			bonus = new Values[8];
			set5.bonus = bonus;
			array49[13] = set5;
			Set set6 = new Set
			{
				id = 14,
				name = ""
			};
			bonus = new Values[8];
			set6.bonus = bonus;
			array49[14] = set6;
			array49[15] = new Set
			{
				id = 15,
				name = "Dinosaur",
				bonus = new Values[8]
				{
					null,
					new Hit(127),
					null,
					new Strength(80),
					null,
					new Critical(80),
					null,
					new PAtk(100)
				}
			};
			array49[16] = new Set
			{
				id = 16,
				name = "Hidden Dragon",
				bonus = new Values[8]
				{
					null,
					new Hit(127),
					null,
					new Agility(80),
					null,
					new Dodge(80),
					null,
					new Speed(100)
				}
			};
			array49[17] = new Set
			{
				id = 17,
				name = "Blood Dragon",
				bonus = new Values[8]
				{
					null,
					new Hit(127),
					null,
					new Stamina(80),
					null,
					new Defense(142),
					null,
					new PHP(100)
				}
			};
			array49[18] = new Set
			{
				id = 18,
				name = "R.Dinosaur",
				bonus = new Values[8]
				{
					null,
					new Hit(139),
					null,
					new Strength(88),
					null,
					new Critical(88),
					null,
					new PAtk(120)
				}
			};
			array49[19] = new Set
			{
				id = 19,
				name = "R.Hidden Dragon",
				bonus = new Values[8]
				{
					null,
					new Hit(139),
					null,
					new Agility(88),
					null,
					new Dodge(88),
					null,
					new Speed(120)
				}
			};
			array49[20] = new Set
			{
				id = 20,
				name = "R.Blood Dragon",
				bonus = new Values[8]
				{
					null,
					new Hit(139),
					null,
					new Stamina(88),
					null,
					new Defense(156),
					null,
					new PHP(120)
				}
			};
			Set set7 = new Set
			{
				id = 21,
				name = ""
			};
			bonus = new Values[8];
			set7.bonus = bonus;
			array49[21] = set7;
			Set set8 = new Set
			{
				id = 22,
				name = ""
			};
			bonus = new Values[8];
			set8.bonus = bonus;
			array49[22] = set8;
			Set set9 = new Set
			{
				id = 23,
				name = ""
			};
			bonus = new Values[8];
			set9.bonus = bonus;
			array49[23] = set9;
			Set set10 = new Set
			{
				id = 24,
				name = ""
			};
			bonus = new Values[8];
			set10.bonus = bonus;
			array49[24] = set10;
			Set set11 = new Set
			{
				id = 25,
				name = ""
			};
			bonus = new Values[8];
			set11.bonus = bonus;
			array49[25] = set11;
			Set set12 = new Set
			{
				id = 26,
				name = ""
			};
			bonus = new Values[8];
			set12.bonus = bonus;
			array49[26] = set12;
			array49[27] = new Set
			{
				id = 27,
				name = "Kage",
				bonus = new Values[8]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					new FiveElement(200)
				}
			};
			array49[28] = new Set
			{
				id = 28,
				name = "Advanced Kage",
				bonus = new Values[8]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					new FiveElement(250)
				}
			};
			array49[29] = new Set
			{
				id = 29,
				name = "Kages Unearthed",
				bonus = new Values[8]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					new FiveElement(300)
				}
			};
			Set set13 = new Set
			{
				id = 30,
				name = ""
			};
			bonus = new Values[8];
			set13.bonus = bonus;
			array49[30] = set13;
			Set set14 = new Set
			{
				id = 31,
				name = ""
			};
			bonus = new Values[8];
			set14.bonus = bonus;
			array49[31] = set14;
			array49[32] = new Set
			{
				id = 32,
				name = "Lament Melody",
				bonus = new Values[8]
				{
					null,
					new MaxAtk(25),
					null,
					new HP(91),
					null,
					null,
					new Strength(130),
					null
				}
			};
			array49[33] = new Set
			{
				id = 33,
				name = "Radiant",
				bonus = new Values[8]
				{
					null,
					new HP(38),
					null,
					new Stamina(44),
					null,
					null,
					new Defense(56),
					null
				}
			};
			array49[34] = new Set
			{
				id = 34,
				name = "Frigid",
				bonus = new Values[8]
				{
					null,
					new MinAtk(4),
					null,
					new Strength(49),
					null,
					null,
					new Critical(35),
					null
				}
			};
			array49[35] = new Set
			{
				id = 35,
				name = "Streamray",
				bonus = new Values[8]
				{
					null,
					new MaxAtk(19),
					null,
					new HP(83),
					null,
					null,
					new Strength(122),
					null
				}
			};
			array49[36] = new Set
			{
				id = 36,
				name = "Prajna's",
				bonus = new Values[8]
				{
					null,
					new Stamina(32),
					null,
					new Strength(32),
					null,
					null,
					new Agility(32),
					null
				}
			};
			array49[37] = new Set
			{
				id = 37,
				name = "Nightmare",
				bonus = new Values[8]
				{
					null,
					new Stamina(39),
					null,
					new Strength(39),
					null,
					null,
					new Agility(39),
					null
				}
			};
			array49[38] = new Set
			{
				id = 38,
				name = "Sunset",
				bonus = new Values[8]
				{
					null,
					new PHP(43),
					null,
					new Constitution(33),
					null,
					null,
					new Dodge(54),
					null
				}
			};
			array49[39] = new Set
			{
				id = 39,
				name = "Glorious",
				bonus = new Values[8]
				{
					null,
					new Agility(56),
					null,
					new MinAtk(8),
					null,
					null,
					new MaxAtk(15),
					null
				}
			};
			array49[40] = new Set
			{
				id = 40,
				name = "Kagura",
				bonus = new Values[8]
				{
					null,
					new HP(19),
					null,
					new Block(28),
					null,
					null,
					new Fire(300),
					null
				}
			};
			array49[41] = new Set
			{
				id = 41,
				name = "Empty Soul",
				bonus = new Values[8]
				{
					null,
					new MaxAtk(19),
					null,
					new HP(83),
					null,
					null,
					new Agility(122),
					null
				}
			};
			array49[42] = new Set
			{
				id = 42,
				name = "Exorcism",
				bonus = new Values[8]
				{
					null,
					new MaxAtk(19),
					null,
					new HP(83),
					null,
					null,
					new Stamina(122),
					null
				}
			};
			array49[43] = new Set
			{
				id = 43,
				name = "Tigerlord",
				bonus = new Values[8]
				{
					null,
					new Critical(25),
					null,
					new Hit(43),
					null,
					null,
					new Pierce(43),
					null
				}
			};
			array49[44] = new Set
			{
				id = 44,
				name = "Oracle",
				bonus = new Values[8]
				{
					null,
					new Stamina(28),
					null,
					new Strength(28),
					null,
					null,
					new Agility(28),
					null
				}
			};
			array49[45] = new Set
			{
				id = 45,
				name = "Berserker",
				bonus = new Values[8]
				{
					null,
					new Critical(30),
					null,
					new Hit(51),
					null,
					null,
					new Pierce(51),
					null
				}
			};
			array49[46] = new Set
			{
				id = 46,
				name = "Beryl",
				bonus = new Values[8]
				{
					null,
					new Stamina(43),
					null,
					new Strength(43),
					null,
					null,
					null,
					null
				}
			};
			array49[47] = new Set
			{
				id = 47,
				name = "Bloody",
				bonus = new Values[8]
				{
					null,
					new ArmorBreak(45),
					null,
					new Critical(27),
					null,
					null,
					new Fire(300),
					null
				}
			};
			array49[48] = new Set
			{
				id = 48,
				name = "Harvest Bugle",
				bonus = new Values[8]
				{
					null,
					new MaxAtk(25),
					null,
					new HP(91),
					null,
					null,
					new Agility(130),
					null
				}
			};
			array49[49] = new Set
			{
				id = 49,
				name = "Destruction",
				bonus = new Values[8]
				{
					null,
					new ArmorBreak(36),
					null,
					new Critical(24),
					null,
					null,
					new Fire(300),
					null
				}
			};
			Set set15 = new Set
			{
				id = 50,
				name = ""
			};
			bonus = new Values[8];
			set15.bonus = bonus;
			array49[50] = set15;
			Set set16 = new Set
			{
				id = 51,
				name = ""
			};
			bonus = new Values[8];
			set16.bonus = bonus;
			array49[51] = set16;
			Set set17 = new Set
			{
				id = 52,
				name = ""
			};
			bonus = new Values[8];
			set17.bonus = bonus;
			array49[52] = set17;
			Set set18 = new Set
			{
				id = 53,
				name = ""
			};
			bonus = new Values[8];
			set18.bonus = bonus;
			array49[53] = set18;
			Set set19 = new Set
			{
				id = 54,
				name = ""
			};
			bonus = new Values[8];
			set19.bonus = bonus;
			array49[54] = set19;
			Set set20 = new Set
			{
				id = 55,
				name = ""
			};
			bonus = new Values[8];
			set20.bonus = bonus;
			array49[55] = set20;
			Set set21 = new Set
			{
				id = 56,
				name = ""
			};
			bonus = new Values[8];
			set21.bonus = bonus;
			array49[56] = set21;
			Set set22 = new Set
			{
				id = 57,
				name = ""
			};
			bonus = new Values[8];
			set22.bonus = bonus;
			array49[57] = set22;
			array49[58] = new Set
			{
				id = 58,
				name = "Angelic Union",
				bonus = new Values[8]
				{
					null,
					null,
					new Dodge(64),
					null,
					new Speed(55),
					null,
					null,
					null
				}
			};
			array49[59] = new Set
			{
				id = 59,
				name = "Dragon Lord",
				bonus = new Values[8]
				{
					null,
					null,
					new MinAtk(22),
					null,
					new ArmorBreak(55),
					null,
					null,
					null
				}
			};
			array49[60] = new Set
			{
				id = 60,
				name = "Sacred Army",
				bonus = new Values[8]
				{
					null,
					null,
					new Block(65),
					null,
					new Defense(69),
					null,
					null,
					null
				}
			};
			array49[61] = new Set
			{
				id = 61,
				name = "Angelic Union",
				bonus = new Values[8]
				{
					null,
					null,
					new Dodge(86),
					null,
					new Speed(70),
					null,
					null,
					null
				}
			};
			array49[62] = new Set
			{
				id = 62,
				name = "Dragon Lord",
				bonus = new Values[8]
				{
					null,
					null,
					new MinAtk(30),
					null,
					new ArmorBreak(74),
					null,
					null,
					null
				}
			};
			array49[63] = new Set
			{
				id = 63,
				name = "Sacred Army",
				bonus = new Values[8]
				{
					null,
					null,
					new Block(88),
					null,
					new Defense(93),
					null,
					null,
					null
				}
			};
			array49[64] = new Set
			{
				id = 64,
				name = "Angelic Union",
				bonus = new Values[8]
				{
					null,
					null,
					new Dodge(108),
					null,
					new Speed(85),
					null,
					null,
					null
				}
			};
			array49[65] = new Set
			{
				id = 65,
				name = "Dark Dragon King",
				bonus = new Values[8]
				{
					null,
					null,
					new MinAtk(38),
					null,
					new ArmorBreak(93),
					null,
					null,
					null
				}
			};
			array49[66] = new Set
			{
				id = 66,
				name = "Templar",
				bonus = new Values[8]
				{
					null,
					null,
					new Block(111),
					null,
					new Defense(117),
					null,
					null,
					null
				}
			};
			array49[67] = new Set
			{
				id = 67,
				name = "Dragon Soul",
				bonus = new Values[8]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					new FiveElement(150)
				}
			};
			array49[68] = new Set
			{
				id = 68,
				name = "Fire Release",
				bonus = new Values[8]
				{
					null,
					new Fire(200),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[69] = new Set
			{
				id = 69,
				name = "Water Release",
				bonus = new Values[8]
				{
					null,
					new Water(200),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[70] = new Set
			{
				id = 70,
				name = "Lightning Release",
				bonus = new Values[8]
				{
					null,
					new Lightning(200),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[71] = new Set
			{
				id = 71,
				name = "Wind Release",
				bonus = new Values[8]
				{
					null,
					new Wind(200),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[72] = new Set
			{
				id = 72,
				name = "Earth Release",
				bonus = new Values[8]
				{
					null,
					new Earth(200),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[73] = new Set
			{
				id = 73,
				name = "Fire Release",
				bonus = new Values[8]
				{
					null,
					new Fire(250),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[74] = new Set
			{
				id = 74,
				name = "Water Release",
				bonus = new Values[8]
				{
					null,
					new Water(250),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[75] = new Set
			{
				id = 75,
				name = "Lightning Release",
				bonus = new Values[8]
				{
					null,
					new Lightning(250),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[76] = new Set
			{
				id = 76,
				name = "Wind Release",
				bonus = new Values[8]
				{
					null,
					new Wind(250),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[77] = new Set
			{
				id = 77,
				name = "Earth Release",
				bonus = new Values[8]
				{
					null,
					new Earth(250),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[78] = new Set
			{
				id = 78,
				name = "Azure Dragon",
				bonus = new Values[8]
				{
					null,
					new Strength(72),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[79] = new Set
			{
				id = 79,
				name = "Vermilion Bird",
				bonus = new Values[8]
				{
					null,
					new Agility(72),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[80] = new Set
			{
				id = 80,
				name = "Black Tortoise",
				bonus = new Values[8]
				{
					null,
					new Stamina(72),
					null,
					null,
					null,
					null,
					null,
					null
				}
			};
			array49[81] = new Set
			{
				id = 81,
				name = "Angelic Union",
				bonus = new Values[8]
				{
					null,
					null,
					new Dodge(130),
					null,
					new Speed(100),
					null,
					null,
					null
				}
			};
			array49[82] = new Set
			{
				id = 82,
				name = "Dark Dragon King",
				bonus = new Values[8]
				{
					null,
					null,
					new MinAtk(46),
					null,
					new ArmorBreak(112),
					null,
					null,
					null
				}
			};
			array49[83] = new Set
			{
				id = 83,
				name = "Templar",
				bonus = new Values[8]
				{
					null,
					null,
					new Block(134),
					null,
					new Defense(141),
					null,
					null,
					null
				}
			};
			array49[84] = new Set
			{
				id = 84,
				name = "Captain's",
				bonus = new Values[8]
				{
					null,
					null,
					new Constitution(98),
					null,
					new Defense(144),
					null,
					null,
					null
				}
			};
			array49[85] = new Set
			{
				id = 85,
				name = "Sage",
				bonus = new Values[8]
				{
					null,
					null,
					new MaxAtk(30),
					null,
					new Dodge(90),
					null,
					null,
					null
				}
			};
			array49[86] = new Set
			{
				id = 86,
				name = "Soul Reaper",
				bonus = new Values[8]
				{
					null,
					null,
					new ArmorBreak(68),
					null,
					new Critical(90),
					null,
					null,
					null
				}
			};
			array49[87] = new Set
			{
				id = 87,
				name = "R.Captain's",
				bonus = new Values[8]
				{
					null,
					null,
					new Constitution(108),
					null,
					new Defense(158),
					null,
					null,
					null
				}
			};
			array49[88] = new Set
			{
				id = 88,
				name = "R.Sage",
				bonus = new Values[8]
				{
					null,
					null,
					new MaxAtk(33),
					null,
					new Dodge(99),
					null,
					null,
					null
				}
			};
			array49[89] = new Set
			{
				id = 89,
				name = "R.Soul Reaper",
				bonus = new Values[8]
				{
					null,
					null,
					new ArmorBreak(75),
					null,
					new Critical(99),
					null,
					null,
					null
				}
			};
			Set set23 = new Set
			{
				id = 90,
				name = ""
			};
			bonus = new Values[8];
			set23.bonus = bonus;
			array49[90] = set23;
			Set set24 = new Set
			{
				id = 91,
				name = ""
			};
			bonus = new Values[8];
			set24.bonus = bonus;
			array49[91] = set24;
			Set set25 = new Set
			{
				id = 92,
				name = ""
			};
			bonus = new Values[8];
			set25.bonus = bonus;
			array49[92] = set25;
			Set set26 = new Set
			{
				id = 93,
				name = ""
			};
			bonus = new Values[8];
			set26.bonus = bonus;
			array49[93] = set26;
			Set set27 = new Set
			{
				id = 94,
				name = ""
			};
			bonus = new Values[8];
			set27.bonus = bonus;
			array49[94] = set27;
			Set set28 = new Set
			{
				id = 95,
				name = ""
			};
			bonus = new Values[8];
			set28.bonus = bonus;
			array49[95] = set28;
			Set set29 = new Set
			{
				id = 96,
				name = ""
			};
			bonus = new Values[8];
			set29.bonus = bonus;
			array49[96] = set29;
			Set set30 = new Set
			{
				id = 97,
				name = ""
			};
			bonus = new Values[8];
			set30.bonus = bonus;
			array49[97] = set30;
			Set set31 = new Set
			{
				id = 98,
				name = ""
			};
			bonus = new Values[8];
			set31.bonus = bonus;
			array49[98] = set31;
			Set set32 = new Set
			{
				id = 99,
				name = ""
			};
			bonus = new Values[8];
			set32.bonus = bonus;
			array49[99] = set32;
			Set set33 = new Set
			{
				id = 100,
				name = ""
			};
			bonus = new Values[8];
			set33.bonus = bonus;
			array49[100] = set33;
			Set set34 = new Set
			{
				id = 101,
				name = ""
			};
			bonus = new Values[8];
			set34.bonus = bonus;
			array49[101] = set34;
			Set set35 = new Set
			{
				id = 102,
				name = ""
			};
			bonus = new Values[8];
			set35.bonus = bonus;
			array49[102] = set35;
			Set set36 = new Set
			{
				id = 103,
				name = ""
			};
			bonus = new Values[8];
			set36.bonus = bonus;
			array49[103] = set36;
			Set set37 = new Set
			{
				id = 104,
				name = ""
			};
			bonus = new Values[8];
			set37.bonus = bonus;
			array49[104] = set37;
			Set set38 = new Set
			{
				id = 105,
				name = ""
			};
			bonus = new Values[8];
			set38.bonus = bonus;
			array49[105] = set38;
			Set set39 = new Set
			{
				id = 106,
				name = ""
			};
			bonus = new Values[8];
			set39.bonus = bonus;
			array49[106] = set39;
			Set set40 = new Set
			{
				id = 107,
				name = ""
			};
			bonus = new Values[8];
			set40.bonus = bonus;
			array49[107] = set40;
			Set set41 = new Set
			{
				id = 108,
				name = ""
			};
			bonus = new Values[8];
			set41.bonus = bonus;
			array49[108] = set41;
			Set set42 = new Set
			{
				id = 109,
				name = ""
			};
			bonus = new Values[8];
			set42.bonus = bonus;
			array49[109] = set42;
			Set set43 = new Set
			{
				id = 110,
				name = ""
			};
			bonus = new Values[8];
			set43.bonus = bonus;
			array49[110] = set43;
			array49[111] = new Set
			{
				id = 111,
				name = "Demented",
				bonus = new Values[8]
				{
					null,
					new Constitution(127),
					null,
					new Stamina(135),
					null,
					new Defense(190),
					null,
					new EDefense(12)
				}
			};
			array49[112] = new Set
			{
				id = 112,
				name = "Worship",
				bonus = new Values[8]
				{
					null,
					new MaxAtk(55),
					null,
					new Strength(135),
					null,
					new ArmorBreak(167),
					null,
					new EHit(14)
				}
			};
			array49[113] = new Set
			{
				id = 113,
				name = "Emperor",
				bonus = new Values[8]
				{
					null,
					new Hit(139),
					null,
					new Agility(135),
					null,
					new Dodge(103),
					null,
					new EDodge(10)
				}
			};
			array49[114] = new Set
			{
				id = 114,
				name = "R.Demented",
				bonus = new Values[8]
				{
					null,
					new Constitution(127),
					null,
					new Stamina(135),
					null,
					new Defense(190),
					null,
					new EDefense(12)
				}
			};
			array49[115] = new Set
			{
				id = 115,
				name = "R.Worship",
				bonus = new Values[8]
				{
					null,
					new MaxAtk(55),
					null,
					new Strength(135),
					null,
					new ArmorBreak(167),
					null,
					new EHit(14)
				}
			};
			array49[116] = new Set
			{
				id = 116,
				name = "R.Emperor",
				bonus = new Values[8]
				{
					null,
					new Hit(139),
					null,
					new Agility(135),
					null,
					new Dodge(103),
					null,
					new EDodge(10)
				}
			};
			sets = array49;
			bloodsouls = new Bloodsoul[13][]
			{
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Armor Break I",
						level = 25,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(11)
					},
					new Bloodsoul
					{
						name = "Armor Break II",
						level = 25,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(18)
					},
					new Bloodsoul
					{
						name = "Armor Break III",
						level = 25,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(30)
					},
					new Bloodsoul
					{
						name = "Armor Break IV",
						level = 36,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(47)
					},
					new Bloodsoul
					{
						name = "Armor Break V",
						level = 36,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(69)
					},
					new Bloodsoul
					{
						name = "Armor Break VI",
						level = 51,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(96)
					},
					new Bloodsoul
					{
						name = "Armor Break VII",
						level = 71,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(127)
					},
					new Bloodsoul
					{
						name = "Armor Break VIII",
						level = 71,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(159)
					},
					new Bloodsoul
					{
						name = "Armor Break IX",
						level = 71,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(192)
					},
					new Bloodsoul
					{
						name = "Armor Break X",
						level = 71,
						image = Resources.BSArmorBreak,
						value = new ArmorBreak(240)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Block I",
						level = 25,
						image = Resources.BSBlock,
						value = new Block(7)
					},
					new Bloodsoul
					{
						name = "Block II",
						level = 25,
						image = Resources.BSBlock,
						value = new Block(12)
					},
					new Bloodsoul
					{
						name = "Block III",
						level = 25,
						image = Resources.BSBlock,
						value = new Block(19)
					},
					new Bloodsoul
					{
						name = "Block IV",
						level = 36,
						image = Resources.BSBlock,
						value = new Block(30)
					},
					new Bloodsoul
					{
						name = "Block V",
						level = 36,
						image = Resources.BSBlock,
						value = new Block(44)
					},
					new Bloodsoul
					{
						name = "Block VI",
						level = 51,
						image = Resources.BSBlock,
						value = new Block(60)
					},
					new Bloodsoul
					{
						name = "Block VII",
						level = 71,
						image = Resources.BSBlock,
						value = new Block(80)
					},
					new Bloodsoul
					{
						name = "Block VIII",
						level = 71,
						image = Resources.BSBlock,
						value = new Block(101)
					},
					new Bloodsoul
					{
						name = "Block IX",
						level = 71,
						image = Resources.BSBlock,
						value = new Block(123)
					},
					new Bloodsoul
					{
						name = "Block X",
						level = 71,
						image = Resources.BSBlock,
						value = new Block(153)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Chakra I",
						level = 25,
						image = Resources.BSChakra,
						value = new Chakra(12)
					},
					new Bloodsoul
					{
						name = "Chakra II",
						level = 25,
						image = Resources.BSChakra,
						value = new Chakra(20)
					},
					new Bloodsoul
					{
						name = "Chakra III",
						level = 25,
						image = Resources.BSChakra,
						value = new Chakra(34)
					},
					new Bloodsoul
					{
						name = "Chakra IV",
						level = 36,
						image = Resources.BSChakra,
						value = new Chakra(53)
					},
					new Bloodsoul
					{
						name = "Chakra V",
						level = 36,
						image = Resources.BSChakra,
						value = new Chakra(77)
					},
					new Bloodsoul
					{
						name = "Chakra VI",
						level = 51,
						image = Resources.BSChakra,
						value = new Chakra(107)
					},
					new Bloodsoul
					{
						name = "Chakra VII",
						level = 71,
						image = Resources.BSChakra,
						value = new Chakra(142)
					},
					new Bloodsoul
					{
						name = "Chakra VIII",
						level = 71,
						image = Resources.BSChakra,
						value = new Chakra(178)
					},
					new Bloodsoul
					{
						name = "Chakra IX",
						level = 71,
						image = Resources.BSChakra,
						value = new Chakra(215)
					},
					new Bloodsoul
					{
						name = "Chakra X",
						level = 71,
						image = Resources.BSChakra,
						value = new Chakra(268)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Constitution I",
						level = 25,
						image = Resources.BSConstitution,
						value = new Constitution(10)
					},
					new Bloodsoul
					{
						name = "Constitution II",
						level = 25,
						image = Resources.BSConstitution,
						value = new Constitution(17)
					},
					new Bloodsoul
					{
						name = "Constitution III",
						level = 25,
						image = Resources.BSConstitution,
						value = new Constitution(28)
					},
					new Bloodsoul
					{
						name = "Constitution IV",
						level = 36,
						image = Resources.BSConstitution,
						value = new Constitution(43)
					},
					new Bloodsoul
					{
						name = "Constitution V",
						level = 36,
						image = Resources.BSConstitution,
						value = new Constitution(63)
					},
					new Bloodsoul
					{
						name = "Constitution VI",
						level = 51,
						image = Resources.BSConstitution,
						value = new Constitution(87)
					},
					new Bloodsoul
					{
						name = "Constitution VII",
						level = 71,
						image = Resources.BSConstitution,
						value = new Constitution(115)
					},
					new Bloodsoul
					{
						name = "Constitution VIII",
						level = 71,
						image = Resources.BSConstitution,
						value = new Constitution(144)
					},
					new Bloodsoul
					{
						name = "Constitution IX",
						level = 71,
						image = Resources.BSConstitution,
						value = new Constitution(174)
					},
					new Bloodsoul
					{
						name = "Constitution X",
						level = 71,
						image = Resources.BSConstitution,
						value = new Constitution(217)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Critical I",
						level = 25,
						image = Resources.BSCritical,
						value = new Critical(7)
					},
					new Bloodsoul
					{
						name = "Critical II",
						level = 25,
						image = Resources.BSCritical,
						value = new Critical(12)
					},
					new Bloodsoul
					{
						name = "Critical III",
						level = 25,
						image = Resources.BSCritical,
						value = new Critical(19)
					},
					new Bloodsoul
					{
						name = "Critical IV",
						level = 36,
						image = Resources.BSCritical,
						value = new Critical(30)
					},
					new Bloodsoul
					{
						name = "Critical V",
						level = 36,
						image = Resources.BSCritical,
						value = new Critical(44)
					},
					new Bloodsoul
					{
						name = "Critical VI",
						level = 51,
						image = Resources.BSCritical,
						value = new Critical(60)
					},
					new Bloodsoul
					{
						name = "Critical VII",
						level = 71,
						image = Resources.BSCritical,
						value = new Critical(80)
					},
					new Bloodsoul
					{
						name = "Critical VIII",
						level = 71,
						image = Resources.BSCritical,
						value = new Critical(101)
					},
					new Bloodsoul
					{
						name = "Critical IX",
						level = 71,
						image = Resources.BSCritical,
						value = new Critical(123)
					},
					new Bloodsoul
					{
						name = "Critical X",
						level = 71,
						image = Resources.BSCritical,
						value = new Critical(153)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Defense I",
						level = 25,
						image = Resources.BSDefense,
						value = new Defense(12)
					},
					new Bloodsoul
					{
						name = "Defense II",
						level = 25,
						image = Resources.BSDefense,
						value = new Defense(20)
					},
					new Bloodsoul
					{
						name = "Defense III",
						level = 25,
						image = Resources.BSDefense,
						value = new Defense(34)
					},
					new Bloodsoul
					{
						name = "Defense IV",
						level = 36,
						image = Resources.BSDefense,
						value = new Defense(53)
					},
					new Bloodsoul
					{
						name = "Defense V",
						level = 36,
						image = Resources.BSDefense,
						value = new Defense(77)
					},
					new Bloodsoul
					{
						name = "Defense VI",
						level = 51,
						image = Resources.BSDefense,
						value = new Defense(107)
					},
					new Bloodsoul
					{
						name = "Defense VII",
						level = 71,
						image = Resources.BSDefense,
						value = new Defense(142)
					},
					new Bloodsoul
					{
						name = "Defense VIII",
						level = 71,
						image = Resources.BSDefense,
						value = new Defense(178)
					},
					new Bloodsoul
					{
						name = "Defense IX",
						level = 71,
						image = Resources.BSDefense,
						value = new Defense(215)
					},
					new Bloodsoul
					{
						name = "Defense X",
						level = 71,
						image = Resources.BSDefense,
						value = new Defense(253)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Dodge I",
						level = 25,
						image = Resources.BSDodge,
						value = new Dodge(7)
					},
					new Bloodsoul
					{
						name = "Dodge II",
						level = 25,
						image = Resources.BSDodge,
						value = new Dodge(12)
					},
					new Bloodsoul
					{
						name = "Dodge III",
						level = 25,
						image = Resources.BSDodge,
						value = new Dodge(19)
					},
					new Bloodsoul
					{
						name = "Dodge IV",
						level = 36,
						image = Resources.BSDodge,
						value = new Dodge(30)
					},
					new Bloodsoul
					{
						name = "Dodge V",
						level = 36,
						image = Resources.BSDodge,
						value = new Dodge(44)
					},
					new Bloodsoul
					{
						name = "Dodge VI",
						level = 51,
						image = Resources.BSDodge,
						value = new Dodge(60)
					},
					new Bloodsoul
					{
						name = "Dodge VII",
						level = 71,
						image = Resources.BSDodge,
						value = new Dodge(80)
					},
					new Bloodsoul
					{
						name = "Dodge VIII",
						level = 71,
						image = Resources.BSDodge,
						value = new Dodge(101)
					},
					new Bloodsoul
					{
						name = "Dodge IX",
						level = 71,
						image = Resources.BSDodge,
						value = new Dodge(123)
					},
					new Bloodsoul
					{
						name = "Dodge X",
						level = 71,
						image = Resources.BSDodge,
						value = new Dodge(153)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Hit I",
						level = 25,
						image = Resources.BSHit,
						value = new Hit(11)
					},
					new Bloodsoul
					{
						name = "Hit II",
						level = 25,
						image = Resources.BSHit,
						value = new Hit(18)
					},
					new Bloodsoul
					{
						name = "Hit III",
						level = 25,
						image = Resources.BSHit,
						value = new Hit(30)
					},
					new Bloodsoul
					{
						name = "Hit IV",
						level = 36,
						image = Resources.BSHit,
						value = new Hit(47)
					},
					new Bloodsoul
					{
						name = "Hit V",
						level = 36,
						image = Resources.BSHit,
						value = new Hit(69)
					},
					new Bloodsoul
					{
						name = "Hit VI",
						level = 51,
						image = Resources.BSHit,
						value = new Hit(96)
					},
					new Bloodsoul
					{
						name = "Hit VII",
						level = 71,
						image = Resources.BSHit,
						value = new Hit(127)
					},
					new Bloodsoul
					{
						name = "Hit VIII",
						level = 71,
						image = Resources.BSHit,
						value = new Hit(159)
					},
					new Bloodsoul
					{
						name = "Hit IX",
						level = 71,
						image = Resources.BSHit,
						value = new Hit(192)
					},
					new Bloodsoul
					{
						name = "Hit X",
						level = 71,
						image = Resources.BSHit,
						value = new Hit(240)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "HP I",
						level = 25,
						image = Resources.BSHP,
						value = new HP(12)
					},
					new Bloodsoul
					{
						name = "HP II",
						level = 25,
						image = Resources.BSHP,
						value = new HP(20)
					},
					new Bloodsoul
					{
						name = "HP III",
						level = 25,
						image = Resources.BSHP,
						value = new HP(34)
					},
					new Bloodsoul
					{
						name = "HP IV",
						level = 36,
						image = Resources.BSHP,
						value = new HP(53)
					},
					new Bloodsoul
					{
						name = "HP V",
						level = 36,
						image = Resources.BSHP,
						value = new HP(77)
					},
					new Bloodsoul
					{
						name = "HP VI",
						level = 51,
						image = Resources.BSHP,
						value = new HP(107)
					},
					new Bloodsoul
					{
						name = "HP VII",
						level = 71,
						image = Resources.BSHP,
						value = new HP(142)
					},
					new Bloodsoul
					{
						name = "HP VIII",
						level = 71,
						image = Resources.BSHP,
						value = new HP(178)
					},
					new Bloodsoul
					{
						name = "HP IX",
						level = 71,
						image = Resources.BSHP,
						value = new HP(215)
					},
					new Bloodsoul
					{
						name = "HP X",
						level = 71,
						image = Resources.BSHP,
						value = new HP(268)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Max Atk I",
						level = 25,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(4)
					},
					new Bloodsoul
					{
						name = "Max Atk II",
						level = 25,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(6)
					},
					new Bloodsoul
					{
						name = "Max Atk III",
						level = 25,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(10)
					},
					new Bloodsoul
					{
						name = "Max Atk IV",
						level = 36,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(16)
					},
					new Bloodsoul
					{
						name = "Max Atk V",
						level = 36,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(23)
					},
					new Bloodsoul
					{
						name = "Max Atk VI",
						level = 51,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(32)
					},
					new Bloodsoul
					{
						name = "Max Atk VII",
						level = 71,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(42)
					},
					new Bloodsoul
					{
						name = "Max Atk VIII",
						level = 71,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(53)
					},
					new Bloodsoul
					{
						name = "Max Atk IX",
						level = 71,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(65)
					},
					new Bloodsoul
					{
						name = "Max Atk X",
						level = 71,
						image = Resources.BSMaxAtk,
						value = new MaxAtk(81)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Min Atk I",
						level = 25,
						image = Resources.BSMinAtk,
						value = new MinAtk(4)
					},
					new Bloodsoul
					{
						name = "Min Atk II",
						level = 25,
						image = Resources.BSMinAtk,
						value = new MinAtk(6)
					},
					new Bloodsoul
					{
						name = "Min Atk III",
						level = 25,
						image = Resources.BSMinAtk,
						value = new MinAtk(10)
					},
					new Bloodsoul
					{
						name = "Min Atk IV",
						level = 36,
						image = Resources.BSMinAtk,
						value = new MinAtk(16)
					},
					new Bloodsoul
					{
						name = "Min Atk V",
						level = 36,
						image = Resources.BSMinAtk,
						value = new MinAtk(23)
					},
					new Bloodsoul
					{
						name = "Min Atk VI",
						level = 51,
						image = Resources.BSMinAtk,
						value = new MinAtk(32)
					},
					new Bloodsoul
					{
						name = "Min Atk VII",
						level = 71,
						image = Resources.BSMinAtk,
						value = new MinAtk(42)
					},
					new Bloodsoul
					{
						name = "Min Atk VIII",
						level = 71,
						image = Resources.BSMinAtk,
						value = new MinAtk(53)
					},
					new Bloodsoul
					{
						name = "Min Atk IX",
						level = 71,
						image = Resources.BSMinAtk,
						value = new MinAtk(65)
					},
					new Bloodsoul
					{
						name = "Min Atk X",
						level = 71,
						image = Resources.BSMinAtk,
						value = new MinAtk(81)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Pierce I",
						level = 25,
						image = Resources.BSPierce,
						value = new Pierce(11)
					},
					new Bloodsoul
					{
						name = "Pierce II",
						level = 25,
						image = Resources.BSPierce,
						value = new Pierce(18)
					},
					new Bloodsoul
					{
						name = "Pierce III",
						level = 25,
						image = Resources.BSPierce,
						value = new Pierce(30)
					},
					new Bloodsoul
					{
						name = "Pierce IV",
						level = 36,
						image = Resources.BSPierce,
						value = new Pierce(47)
					},
					new Bloodsoul
					{
						name = "Pierce V",
						level = 36,
						image = Resources.BSPierce,
						value = new Pierce(69)
					},
					new Bloodsoul
					{
						name = "Pierce VI",
						level = 51,
						image = Resources.BSPierce,
						value = new Pierce(96)
					},
					new Bloodsoul
					{
						name = "Pierce VII",
						level = 71,
						image = Resources.BSPierce,
						value = new Pierce(127)
					},
					new Bloodsoul
					{
						name = "Pierce VIII",
						level = 71,
						image = Resources.BSPierce,
						value = new Pierce(159)
					},
					new Bloodsoul
					{
						name = "Pierce IX",
						level = 71,
						image = Resources.BSPierce,
						value = new Pierce(192)
					},
					new Bloodsoul
					{
						name = "Pierce X",
						level = 71,
						image = Resources.BSPierce,
						value = new Pierce(240)
					}
				},
				new Bloodsoul[10]
				{
					new Bloodsoul
					{
						name = "Speed I",
						level = 25,
						image = Resources.BSSpeed,
						value = new Speed(9)
					},
					new Bloodsoul
					{
						name = "Speed II",
						level = 25,
						image = Resources.BSSpeed,
						value = new Speed(15)
					},
					new Bloodsoul
					{
						name = "Speed III",
						level = 25,
						image = Resources.BSSpeed,
						value = new Speed(24)
					},
					new Bloodsoul
					{
						name = "Speed IV",
						level = 36,
						image = Resources.BSSpeed,
						value = new Speed(37)
					},
					new Bloodsoul
					{
						name = "Speed V",
						level = 36,
						image = Resources.BSSpeed,
						value = new Speed(55)
					},
					new Bloodsoul
					{
						name = "Speed VI",
						level = 51,
						image = Resources.BSSpeed,
						value = new Speed(75)
					},
					new Bloodsoul
					{
						name = "Speed VII",
						level = 71,
						image = Resources.BSSpeed,
						value = new Speed(100)
					},
					new Bloodsoul
					{
						name = "Speed VIII",
						level = 71,
						image = Resources.BSSpeed,
						value = new Speed(126)
					},
					new Bloodsoul
					{
						name = "Speed IX",
						level = 71,
						image = Resources.BSSpeed,
						value = new Speed(153)
					},
					new Bloodsoul
					{
						name = "Speed X",
						level = 71,
						image = Resources.BSSpeed,
						value = new Speed(191)
					}
				}
			};
			ninjarank = new int[21]
			{
				0, 50, 70, 93, 120, 150, 184, 221, 262, 306,
				354, 405, 460, 518, 580, 645, 714, 786, 862, 941,
				1024
			};
			records = new Values[21][]
			{
				new Values[3]
				{
					new Speed(0),
					new PHP(0),
					new PAtk(0)
				},
				new Values[3]
				{
					new Speed(32),
					new PHP(32),
					new PAtk(32)
				},
				new Values[3]
				{
					new Speed(49),
					new PHP(49),
					new PAtk(49)
				},
				new Values[3]
				{
					new Speed(61),
					new PHP(61),
					new PAtk(61)
				},
				new Values[3]
				{
					new Speed(71),
					new PHP(71),
					new PAtk(71)
				},
				new Values[3]
				{
					new Speed(80),
					new PHP(80),
					new PAtk(80)
				},
				new Values[3]
				{
					new Speed(90),
					new PHP(90),
					new PAtk(90)
				},
				new Values[3]
				{
					new Speed(100),
					new PHP(100),
					new PAtk(100)
				},
				new Values[3]
				{
					new Speed(110),
					new PHP(110),
					new PAtk(110)
				},
				new Values[3]
				{
					new Speed(120),
					new PHP(120),
					new PAtk(120)
				},
				new Values[3]
				{
					new Speed(130),
					new PHP(130),
					new PAtk(130)
				},
				new Values[3]
				{
					new Speed(140),
					new PHP(140),
					new PAtk(140)
				},
				new Values[3]
				{
					new Speed(150),
					new PHP(150),
					new PAtk(150)
				},
				new Values[3]
				{
					new Speed(160),
					new PHP(160),
					new PAtk(160)
				},
				new Values[3]
				{
					new Speed(170),
					new PHP(170),
					new PAtk(170)
				},
				new Values[3]
				{
					new Speed(190),
					new PHP(190),
					new PAtk(190)
				},
				new Values[3]
				{
					new Speed(220),
					new PHP(220),
					new PAtk(220)
				},
				new Values[3]
				{
					new Speed(250),
					new PHP(250),
					new PAtk(250)
				},
				new Values[3]
				{
					new Speed(280),
					new PHP(280),
					new PAtk(280)
				},
				new Values[3]
				{
					new Speed(310),
					new PHP(310),
					new PAtk(310)
				},
				new Values[3]
				{
					new Speed(340),
					new PHP(340),
					new PAtk(340)
				}
			};
			outfits = new Outfit[154]
			{
				new Outfit
				{
					id = 0,
					record = new int[3] { 1, 2, 1 },
					name = "Ggio Vega",
					image = Resources.GgioVega,
					pimage = Resources.PGgioVega,
					type = "Grey",
					release = "Wind",
					str_init = 13,
					agi_init = 22,
					sta_init = 13,
					str_mul_init = 0.65,
					agi_mul_init = 1.1,
					sta_mul_init = 0.65,
					bmv_str = 17,
					bmv_agi = 10,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 1,
					record = new int[3] { 3, 0, 1 },
					name = "Love Aikawa",
					image = Resources.LoveAikawa,
					pimage = Resources.PLoveAikawa,
					type = "Grey",
					release = "Fire",
					str_init = 24,
					agi_init = 8,
					sta_init = 16,
					str_mul_init = 1.2,
					agi_mul_init = 0.4,
					sta_mul_init = 0.8,
					bmv_str = 11,
					bmv_agi = 22,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 2,
					record = new int[3] { 1, 2, 1 },
					name = "Hirako Shinji",
					image = Resources.HirakoShinji,
					pimage = Resources.PHirakoShinji,
					type = "Grey",
					release = "Earth",
					str_init = 16,
					agi_init = 16,
					sta_init = 16,
					str_mul_init = 0.8,
					agi_mul_init = 0.8,
					sta_mul_init = 0.8,
					bmv_str = 14,
					bmv_agi = 14,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 3,
					record = new int[3] { 3, 0, 1 },
					name = "Renji",
					image = Resources.Renji,
					pimage = Resources.PRenji,
					type = "Grey",
					release = "Lightning",
					str_init = 26,
					agi_init = 6,
					sta_init = 16,
					str_mul_init = 1.3,
					agi_mul_init = 0.3,
					sta_mul_init = 0.8,
					bmv_str = 10,
					bmv_agi = 21,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 4,
					record = new int[3] { 2, 0, 2 },
					name = "Akimichi Choji",
					image = Resources.AkimichiChoji,
					pimage = Resources.PAkimichiChoji,
					type = "Grey",
					release = "Taijutsu",
					str_init = 23,
					agi_init = 4,
					sta_init = 23,
					str_mul_init = 1.15,
					agi_mul_init = 0.2,
					sta_mul_init = 1.15,
					bmv_str = 9,
					bmv_agi = 121,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 5,
					record = new int[3] { 1, 3, 0 },
					name = "Inuzuka Kiba",
					image = Resources.KibaInuzuka,
					pimage = Resources.PKibaInuzuka,
					type = "Grey",
					release = "Taijutsu",
					str_init = 17,
					agi_init = 23,
					sta_init = 8,
					str_mul_init = 0.85,
					agi_mul_init = 1.15,
					sta_mul_init = 0.4,
					bmv_str = 12,
					bmv_agi = 11,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 6,
					record = new int[3] { 1, 2, 1 },
					name = "Aburame Shino",
					image = Resources.ShinoAburame,
					pimage = Resources.PShinoAburame,
					type = "Grey",
					release = "Tool",
					str_init = 18,
					agi_init = 20,
					sta_init = 18,
					str_mul_init = 0.9,
					agi_mul_init = 1.0,
					sta_mul_init = 0.9,
					bmv_str = 18,
					bmv_agi = 11,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 7,
					record = new int[3] { 1, 1, 2 },
					name = "Nara Shikamaru",
					image = Resources.ShikamaruNara,
					pimage = Resources.PShikamaruNara,
					type = "Grey",
					release = "Illusion",
					str_init = 16,
					agi_init = 16,
					sta_init = 16,
					str_mul_init = 0.8,
					agi_mul_init = 0.8,
					sta_mul_init = 0.8,
					bmv_str = 14,
					bmv_agi = 14,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 8,
					record = new int[3] { 2, 0, 2 },
					name = "Asuma",
					image = Resources.Asuma,
					pimage = Resources.PAsuma,
					type = "Grey",
					release = "Fire",
					str_init = 18,
					agi_init = 16,
					sta_init = 18,
					str_mul_init = 0.9,
					agi_mul_init = 0.8,
					sta_mul_init = 0.9,
					bmv_str = 13,
					bmv_agi = 14,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 9,
					record = new int[3] { 2, 0, 2 },
					name = "Sarugaki Hiyori",
					image = Resources.HiyoriSarugaki,
					pimage = Resources.PSarugakiHiyori,
					type = "Grey",
					release = "Taijutsu",
					str_init = 18,
					agi_init = 14,
					sta_init = 18,
					str_mul_init = 0.9,
					agi_mul_init = 0.7,
					sta_mul_init = 0.9,
					bmv_str = 13,
					bmv_agi = 16,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 10,
					record = new int[3] { 1, 1, 2 },
					name = "Nanao Ise",
					image = Resources.NanaoIse,
					pimage = Resources.PNanaoIse,
					type = "Grey",
					release = "Water",
					str_init = 14,
					agi_init = 16,
					sta_init = 20,
					str_mul_init = 0.7,
					agi_mul_init = 0.8,
					sta_mul_init = 1.0,
					bmv_str = 11,
					bmv_agi = 26,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 11,
					record = new int[3] { 2, 1, 1 },
					name = "Momo Hinamori",
					image = Resources.MomoHinamori,
					pimage = Resources.PMomoHinamori,
					type = "Grey",
					release = "Fire",
					str_init = 18,
					agi_init = 17,
					sta_init = 16,
					str_mul_init = 0.9,
					agi_mul_init = 0.85,
					sta_mul_init = 0.8,
					bmv_str = 13,
					bmv_agi = 13,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 12,
					record = new int[3] { 3, 0, 1 },
					name = "Rangiku Matsumoto",
					image = Resources.RangikuMatsumoto,
					pimage = Resources.PRangikuMatsumoto,
					type = "Grey",
					release = "Tool",
					str_init = 23,
					agi_init = 7,
					sta_init = 18,
					str_mul_init = 1.15,
					agi_mul_init = 0.35,
					sta_mul_init = 0.9,
					bmv_str = 10,
					bmv_agi = 21,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 13,
					record = new int[3] { 1, 2, 1 },
					name = "Kurenai Yuuhi",
					image = Resources.KurenaiYuhi,
					pimage = Resources.PKurenaiYuhi,
					type = "Grey",
					release = "Illusion",
					str_init = 12,
					agi_init = 18,
					sta_init = 12,
					str_mul_init = 0.6,
					agi_mul_init = 0.9,
					sta_mul_init = 0.6,
					bmv_str = 20,
					bmv_agi = 11,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 14,
					record = new int[3] { 0, 1, 3 },
					name = "Shizune",
					image = Resources.Shizune,
					pimage = Resources.PShizune,
					type = "Grey",
					release = "Healing",
					str_init = 10,
					agi_init = 14,
					sta_init = 24,
					str_mul_init = 0.5,
					agi_mul_init = 0.7,
					sta_mul_init = 1.2,
					bmv_str = 19,
					bmv_agi = 16,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 15,
					record = new int[3] { 1, 2, 1 },
					name = "Mitarashi Anko",
					image = Resources.MitarashiAnko,
					pimage = Resources.PMitarashiAnko,
					type = "Grey",
					release = "Sealing",
					str_init = 14,
					agi_init = 18,
					sta_init = 14,
					str_mul_init = 0.7,
					agi_mul_init = 0.9,
					sta_mul_init = 0.7,
					bmv_str = 14,
					bmv_agi = 11,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 16,
					record = new int[3] { 0, 4, 0 },
					name = "Tenten",
					image = Resources.Tenten,
					pimage = Resources.PTenten,
					type = "Grey",
					release = "Tool",
					str_init = 10,
					agi_init = 20,
					sta_init = 14,
					str_mul_init = 0.5,
					agi_mul_init = 1.0,
					sta_mul_init = 0.7,
					bmv_str = 17,
					bmv_agi = 11,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 17,
					record = new int[3] { 0, 0, 4 },
					name = "Kurotsuchi Nemu",
					image = Resources.KurotsuchiNemu,
					pimage = Resources.PKurotsuchiNemu,
					type = "Grey",
					release = "Healing",
					str_init = 12,
					agi_init = 10,
					sta_init = 26,
					str_mul_init = 0.6,
					agi_mul_init = 0.5,
					sta_mul_init = 1.3,
					bmv_str = 19,
					bmv_agi = 29,
					bmv_sta = 6
				},
				new Outfit
				{
					id = 18,
					record = new int[3] { 1, 1, 3 },
					name = "Ulquiorra",
					image = Resources.Ulquiorra,
					pimage = Resources.PUlquiorra,
					type = "Blue",
					release = "Healing",
					str_init = 18,
					agi_init = 21,
					sta_init = 26,
					str_mul_init = 0.9,
					agi_mul_init = 1.05,
					sta_mul_init = 1.3,
					bmv_str = 13,
					bmv_agi = 22,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 19,
					record = new int[3] { 1, 1, 3 },
					name = "White Ulquiorra",
					image = Resources.WhiteUlquiorra,
					pimage = Resources.PWhiteUlquiorra,
					type = "Blue",
					release = "Healing",
					str_init = 20,
					agi_init = 22,
					sta_init = 27,
					str_mul_init = 1.0,
					agi_mul_init = 1.1,
					sta_mul_init = 1.35,
					bmv_str = 13,
					bmv_agi = 21,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 20,
					record = new int[3] { 3, 2, 0 },
					name = "Grimmjow",
					image = Resources.Grimmjow,
					pimage = Resources.PGrimmjow,
					type = "Blue",
					release = "Taijutsu",
					str_init = 24,
					agi_init = 22,
					sta_init = 14,
					str_mul_init = 1.2,
					agi_mul_init = 1.1,
					sta_mul_init = 0.7,
					bmv_str = 13,
					bmv_agi = 13,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 21,
					record = new int[3] { 0, 3, 2 },
					name = "Hitsugaya Toushiro",
					image = Resources.ToshiroHitsugaya,
					pimage = Resources.PToshiroHitsugaya,
					type = "Blue",
					release = "Water",
					str_init = 12,
					agi_init = 28,
					sta_init = 24,
					str_mul_init = 0.6,
					agi_mul_init = 1.4,
					sta_mul_init = 1.2,
					bmv_str = 22,
					bmv_agi = 12,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 22,
					record = new int[3] { 1, 2, 2 },
					name = "Hollowfied Hirako",
					image = Resources.HollowfiedHirako,
					pimage = Resources.PHollowfiedHirako,
					type = "Blue",
					release = "Earth",
					str_init = 20,
					agi_init = 20,
					sta_init = 20,
					str_mul_init = 1.0,
					agi_mul_init = 1.0,
					sta_mul_init = 1.0,
					bmv_str = 14,
					bmv_agi = 14,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 23,
					record = new int[3] { 0, 1, 4 },
					name = "Gin Ichimaru",
					image = Resources.GinIchimaru,
					pimage = Resources.PGinIchimaru,
					type = "Blue",
					release = "Tool",
					str_init = 16,
					agi_init = 22,
					sta_init = 24,
					str_mul_init = 0.8,
					agi_mul_init = 1.1,
					sta_mul_init = 1.2,
					bmv_str = 18,
					bmv_agi = 12,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 24,
					record = new int[3] { 2, 2, 1 },
					name = "Rock Lee",
					image = Resources.RockLee,
					pimage = Resources.PRockLee,
					type = "Blue",
					release = "Taijutsu",
					str_init = 22,
					agi_init = 22,
					sta_init = 16,
					str_mul_init = 1.1,
					agi_mul_init = 1.1,
					sta_mul_init = 0.8,
					bmv_str = 12,
					bmv_agi = 13,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 25,
					record = new int[3] { 2, 2, 1 },
					name = "Hyuga Neji",
					image = Resources.NejiHyuga,
					pimage = Resources.PNejiNyuga,
					type = "Blue",
					release = "Taijutsu",
					str_init = 22,
					agi_init = 22,
					sta_init = 16,
					str_mul_init = 1.1,
					agi_mul_init = 1.1,
					sta_mul_init = 0.8,
					bmv_str = 13,
					bmv_agi = 13,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 26,
					record = new int[3] { 2, 0, 3 },
					name = "Sasori",
					image = Resources.Sasori,
					pimage = Resources.PSasori,
					type = "Blue",
					release = "Tool",
					str_init = 26,
					agi_init = 12,
					sta_init = 26,
					str_mul_init = 1.3,
					agi_mul_init = 0.6,
					sta_mul_init = 1.3,
					bmv_str = 10,
					bmv_agi = 29,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 27,
					record = new int[3] { 1, 4, 0 },
					name = "Soifon",
					image = Resources.Soifon,
					pimage = Resources.PSoifon,
					type = "Blue",
					release = "Wind",
					str_init = 22,
					agi_init = 26,
					sta_init = 16,
					str_mul_init = 1.1,
					agi_mul_init = 1.3,
					sta_mul_init = 0.8,
					bmv_str = 13,
					bmv_agi = 11,
					bmv_sta = 17
				},
				new Outfit
				{
					id = 28,
					record = new int[3] { 3, 0, 2 },
					name = "Zangetsu",
					image = Resources.Zangetsu,
					pimage = Resources.PZangetsu,
					type = "Blue",
					release = "Tool",
					str_init = 24,
					agi_init = 18,
					sta_init = 23,
					str_mul_init = 1.2,
					agi_mul_init = 0.9,
					sta_mul_init = 1.15,
					bmv_str = 12,
					bmv_agi = 19,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 29,
					record = new int[3] { 2, 2, 1 },
					name = "Hollowfied Grimmjow",
					image = Resources.HollowfiedGrimmjow,
					pimage = Resources.PHollowfiedGrimmjow,
					type = "Blue",
					release = "Taijutsu",
					str_init = 21,
					agi_init = 21,
					sta_init = 19,
					str_mul_init = 1.05,
					agi_mul_init = 1.05,
					sta_mul_init = 0.95,
					bmv_str = 13,
					bmv_agi = 13,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 30,
					record = new int[3] { 2, 1, 2 },
					name = "Yamanaka Ino",
					image = Resources.YamanakaIno,
					pimage = Resources.PYamanakaIno,
					type = "Blue",
					release = "Illusion",
					str_init = 22,
					agi_init = 16,
					sta_init = 20,
					str_mul_init = 1.1,
					agi_mul_init = 0.8,
					sta_mul_init = 1.0,
					bmv_str = 11,
					bmv_agi = 17,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 31,
					record = new int[3] { 2, 2, 1 },
					name = "Temari",
					image = Resources.Temari,
					pimage = Resources.PTemari,
					type = "Blue",
					release = "Wind",
					str_init = 23,
					agi_init = 23,
					sta_init = 20,
					str_mul_init = 1.15,
					agi_mul_init = 1.15,
					sta_mul_init = 1.0,
					bmv_str = 13,
					bmv_agi = 13,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 32,
					record = new int[3] { 0, 4, 1 },
					name = "Haku",
					image = Resources.Haku,
					pimage = Resources.PHaku,
					type = "Blue",
					release = "Water",
					str_init = 6,
					agi_init = 28,
					sta_init = 20,
					str_mul_init = 0.3,
					agi_mul_init = 1.4,
					sta_mul_init = 1.0,
					bmv_str = 37,
					bmv_agi = 8,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 33,
					record = new int[3] { 3, 0, 2 },
					name = "Kusajishi Yachiru",
					image = Resources.KusajishiYachiru,
					pimage = Resources.PKusajishiYachiru,
					type = "Blue",
					release = "Lightning",
					str_init = 24,
					agi_init = 12,
					sta_init = 24,
					str_mul_init = 1.2,
					agi_mul_init = 0.6,
					sta_mul_init = 1.2,
					bmv_str = 11,
					bmv_agi = 19,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 34,
					record = new int[3] { 1, 2, 2 },
					name = "Yadomaru Lisa",
					image = Resources.YadomaruLisa,
					pimage = Resources.PYadomaruLisa,
					type = "Blue",
					release = "Fire",
					str_init = 20,
					agi_init = 20,
					sta_init = 20,
					str_mul_init = 1.0,
					agi_mul_init = 1.0,
					sta_mul_init = 1.0,
					bmv_str = 13,
					bmv_agi = 12,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 35,
					record = new int[3] { 3, 2, 0 },
					name = "Momochi Zabuza",
					image = Resources.MomochiZabuza,
					pimage = Resources.PMomochiZabuza,
					type = "Blue",
					release = "Water",
					str_init = 24,
					agi_init = 20,
					sta_init = 18,
					str_mul_init = 1.2,
					agi_mul_init = 1.0,
					sta_mul_init = 0.9,
					bmv_str = 12,
					bmv_agi = 15,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 36,
					record = new int[3] { 3, 0, 2 },
					name = "Christmas Boy",
					image = Resources.ChristmasBoy,
					pimage = Resources.PChristmasBoy,
					type = "Blue",
					release = "",
					str_init = 26,
					agi_init = 16,
					sta_init = 20,
					str_mul_init = 1.3,
					agi_mul_init = 0.8,
					sta_mul_init = 1.0,
					bmv_str = 11,
					bmv_agi = 21,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 37,
					record = new int[3] { 2, 3, 0 },
					name = "Christmas Girl",
					image = Resources.ChristmasGirl,
					pimage = Resources.PChristmasGirl,
					type = "Blue",
					release = "",
					str_init = 23,
					agi_init = 25,
					sta_init = 14,
					str_mul_init = 1.15,
					agi_mul_init = 1.25,
					sta_mul_init = 0.7,
					bmv_str = 12,
					bmv_agi = 13,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 38,
					record = new int[3] { 2, 2, 2 },
					name = "Kurosaki Ichigo",
					image = Resources.KurosakiIchigo,
					pimage = Resources.PKurosakiIchigo,
					type = "Orange",
					release = "Fire",
					str_init = 24,
					agi_init = 24,
					sta_init = 24,
					str_mul_init = 1.2,
					agi_mul_init = 1.2,
					sta_mul_init = 1.2,
					bmv_str = 13,
					bmv_agi = 15,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 39,
					record = new int[3] { 2, 2, 2 },
					name = "White Ichigo",
					image = Resources.WhiteIchigo,
					pimage = Resources.PWhiteIchigo,
					type = "Orange",
					release = "Fire",
					str_init = 25,
					agi_init = 25,
					sta_init = 25,
					str_mul_init = 1.25,
					agi_mul_init = 1.25,
					sta_mul_init = 1.25,
					bmv_str = 12,
					bmv_agi = 14,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 40,
					record = new int[3] { 2, 2, 2 },
					name = "Hollowfied Ichigo",
					image = Resources.HollowfiedIchigo,
					pimage = Resources.PHollowfiedIchigo,
					type = "Orange",
					release = "Fire",
					str_init = 26,
					agi_init = 26,
					sta_init = 26,
					str_mul_init = 1.4,
					agi_mul_init = 1.35,
					sta_mul_init = 1.3,
					bmv_str = 12,
					bmv_agi = 13,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 41,
					record = new int[3] { 1, 1, 4 },
					name = "Hollowfied Ulquiorra",
					image = Resources.HollowfiedUlquiorra,
					pimage = Resources.PHollowfiedUlquiorra,
					type = "Orange",
					release = "Healing",
					str_init = 24,
					agi_init = 22,
					sta_init = 28,
					str_mul_init = 1.2,
					agi_mul_init = 1.1,
					sta_mul_init = 1.4,
					bmv_str = 13,
					bmv_agi = 21,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 42,
					record = new int[3] { 2, 4, 0 },
					name = "Shihouin Yoruichi",
					image = Resources.ShihouinYoruichi,
					pimage = Resources.PShihouinYoruichi,
					type = "Orange",
					release = "Wind",
					str_init = 22,
					agi_init = 30,
					sta_init = 18,
					str_mul_init = 1.1,
					agi_mul_init = 1.5,
					sta_mul_init = 0.9,
					bmv_str = 13,
					bmv_agi = 10,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 43,
					record = new int[3] { 3, 0, 3 },
					name = "Halibel",
					image = Resources.Halibel,
					pimage = Resources.PHalibel,
					type = "Orange",
					release = "Water",
					str_init = 26,
					agi_init = 22,
					sta_init = 26,
					str_mul_init = 1.3,
					agi_mul_init = 1.1,
					sta_mul_init = 1.3,
					bmv_str = 12,
					bmv_agi = 20,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 44,
					record = new int[3] { 1, 1, 4 },
					name = "Inoue Orihime",
					image = Resources.InoueOrihime,
					pimage = Resources.PInoueOrihime,
					type = "Orange",
					release = "Healing",
					str_init = 20,
					agi_init = 22,
					sta_init = 30,
					str_mul_init = 1.0,
					agi_mul_init = 1.1,
					sta_mul_init = 1.5,
					bmv_str = 20,
					bmv_agi = 15,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 45,
					record = new int[3] { 2, 2, 2 },
					name = "Hyuga Hinata",
					image = Resources.HyugaHinata,
					pimage = Resources.PHyugaHinata,
					type = "Orange",
					release = "Taijutsu",
					str_init = 24,
					agi_init = 26,
					sta_init = 28,
					str_mul_init = 1.2,
					agi_mul_init = 1.3,
					sta_mul_init = 1.45,
					bmv_str = 12,
					bmv_agi = 10,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 46,
					record = new int[3] { 3, 2, 1 },
					name = "Uzumaki Naruto",
					image = Resources.UzumakiNaruto,
					pimage = Resources.PUzumakiNaruto,
					type = "Orange",
					release = "Wind",
					str_init = 28,
					agi_init = 24,
					sta_init = 24,
					str_mul_init = 1.4,
					agi_mul_init = 1.2,
					sta_mul_init = 1.2,
					bmv_str = 12,
					bmv_agi = 15,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 47,
					record = new int[3] { 3, 0, 3 },
					name = "Gaara",
					image = Resources.Gaara,
					pimage = Resources.PGaara,
					type = "Orange",
					release = "Earth",
					str_init = 25,
					agi_init = 18,
					sta_init = 39,
					str_mul_init = 1.25,
					agi_mul_init = 0.9,
					sta_mul_init = 1.5,
					bmv_str = 11,
					bmv_agi = 26,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 48,
					record = new int[3] { 2, 4, 0 },
					name = "Hatake Kakashi",
					image = Resources.KakashiHatake,
					pimage = Resources.PKakashiHatake,
					type = "Orange",
					release = "Lightning",
					str_init = 26,
					agi_init = 26,
					sta_init = 24,
					str_mul_init = 1.35,
					agi_mul_init = 1.35,
					sta_mul_init = 1.4,
					bmv_str = 12,
					bmv_agi = 12,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 49,
					record = new int[3] { 2, 4, 0 },
					name = "Uchiha Sasuke",
					image = Resources.SasukeUchiha,
					pimage = Resources.PSasukeUchiha,
					type = "Orange",
					release = "Lightning",
					str_init = 25,
					agi_init = 27,
					sta_init = 24,
					str_mul_init = 1.25,
					agi_mul_init = 1.35,
					sta_mul_init = 1.2,
					bmv_str = 13,
					bmv_agi = 11,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 50,
					record = new int[3] { 1, 4, 1 },
					name = "Uchiha Itachi",
					image = Resources.ItachiUchiha,
					pimage = Resources.PUchihaItachi,
					type = "Orange",
					release = "Illusion",
					str_init = 23,
					agi_init = 27,
					sta_init = 20,
					str_mul_init = 1.15,
					agi_mul_init = 1.45,
					sta_mul_init = 1.1,
					bmv_str = 12,
					bmv_agi = 10,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 51,
					record = new int[3] { 3, 0, 3 },
					name = "Orochimaru",
					image = Resources.Orochimaru,
					pimage = Resources.POrochimaru,
					type = "Orange",
					release = "Sealing",
					str_init = 25,
					agi_init = 26,
					sta_init = 26,
					str_mul_init = 1.25,
					agi_mul_init = 1.3,
					sta_mul_init = 1.3,
					bmv_str = 13,
					bmv_agi = 12,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 52,
					record = new int[3] { 2, 2, 2 },
					name = "Aizen",
					image = Resources.Aizen,
					pimage = Resources.PAizen,
					type = "Orange",
					release = "Illusion",
					str_init = 27,
					agi_init = 27,
					sta_init = 28,
					str_mul_init = 1.35,
					agi_mul_init = 1.35,
					sta_mul_init = 1.4,
					bmv_str = 12,
					bmv_agi = 12,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 53,
					record = new int[3] { 1, 4, 1 },
					name = "4th Hokage",
					image = Resources.forthHokage,
					pimage = Resources.PforthHokage,
					type = "Orange",
					release = "Wind",
					str_init = 22,
					agi_init = 30,
					sta_init = 22,
					str_mul_init = 1.1,
					agi_mul_init = 1.5,
					sta_mul_init = 1.1,
					bmv_str = 13,
					bmv_agi = 10,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 54,
					record = new int[3] { 4, 0, 2 },
					name = "Sakura Haruno",
					image = Resources.SakuraHaruno,
					pimage = Resources.PSakuraHaruno,
					type = "Orange",
					release = "Taijutsu",
					str_init = 30,
					agi_init = 17,
					sta_init = 26,
					str_mul_init = 1.5,
					agi_mul_init = 0.85,
					sta_mul_init = 1.3,
					bmv_str = 10,
					bmv_agi = 16,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 55,
					record = new int[3] { 4, 0, 2 },
					name = "Tsunade",
					image = Resources.Tsunade,
					pimage = Resources.PTsunade,
					type = "Orange",
					release = "Healing",
					str_init = 30,
					agi_init = 14,
					sta_init = 28,
					str_mul_init = 1.5,
					agi_mul_init = 0.7,
					sta_mul_init = 1.4,
					bmv_str = 10,
					bmv_agi = 17,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 56,
					record = new int[3] { 2, 2, 2 },
					name = "Kuchiki Rukia",
					image = Resources.KuchikiRukia,
					pimage = Resources.PKuchikiRukia,
					type = "Orange",
					release = "Water",
					str_init = 24,
					agi_init = 24,
					sta_init = 24,
					str_mul_init = 1.3,
					agi_mul_init = 1.25,
					sta_mul_init = 1.3,
					bmv_str = 12,
					bmv_agi = 13,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 57,
					record = new int[3] { 2, 2, 2 },
					name = "Kuchiki Byakuya",
					image = Resources.KuchikiByakuya,
					pimage = Resources.PKuchikiByakuya,
					type = "Orange",
					release = "Tool",
					str_init = 25,
					agi_init = 25,
					sta_init = 24,
					str_mul_init = 1.25,
					agi_mul_init = 1.25,
					sta_mul_init = 1.2,
					bmv_str = 13,
					bmv_agi = 14,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 58,
					record = new int[3] { 0, 4, 2 },
					name = "Nelliel",
					image = Resources.Nelliel,
					pimage = Resources.PNelliel,
					type = "Orange",
					release = "Sealing",
					str_init = 26,
					agi_init = 30,
					sta_init = 26,
					str_mul_init = 1.2,
					agi_mul_init = 1.5,
					sta_mul_init = 1.4,
					bmv_str = 13,
					bmv_agi = 12,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 59,
					record = new int[3] { 1, 2, 3 },
					name = "Little Meng",
					image = Resources.LittleMeng,
					pimage = Resources.PLittleMeng,
					type = "Maskot",
					release = "Illusion",
					str_init = 25,
					agi_init = 29,
					sta_init = 34,
					str_mul_init = 1.2,
					agi_mul_init = 1.35,
					sta_mul_init = 1.5,
					bmv_str = 13,
					bmv_agi = 11,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 60,
					record = new int[3] { 3, 2, 1 },
					name = "Little Jun",
					image = Resources.LittleJun,
					pimage = Resources.PLittleJun,
					type = "Maskot",
					release = "Taijutsu",
					str_init = 34,
					agi_init = 29,
					sta_init = 25,
					str_mul_init = 1.5,
					agi_mul_init = 1.35,
					sta_mul_init = 1.2,
					bmv_str = 10,
					bmv_agi = 13,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 61,
					record = new int[3] { 3, 3, 0 },
					name = "Jiraiya",
					image = Resources.Jiraiya,
					pimage = Resources.PJiraiya,
					type = "Orange",
					release = "Fire",
					str_init = 27,
					agi_init = 27,
					sta_init = 23,
					str_mul_init = 1.35,
					agi_mul_init = 1.35,
					sta_mul_init = 1.15,
					bmv_str = 12,
					bmv_agi = 12,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 62,
					record = new int[3] { 3, 0, 3 },
					name = "Unohana Retsu",
					image = Resources.UnohanaRetsu,
					pimage = Resources.PUnohanaRetsu,
					type = "Orange",
					release = "Healing",
					str_init = 28,
					agi_init = 15,
					sta_init = 29,
					str_mul_init = 1.4,
					agi_mul_init = 0.75,
					sta_mul_init = 1.45,
					bmv_str = 12,
					bmv_agi = 17,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 63,
					record = new int[3] { 1, 2, 3 },
					name = "Kyuubi Naruto",
					image = Resources.KyuubiNaruto,
					pimage = Resources.PKyuubiNaruto,
					type = "Special",
					release = "Fire",
					str_init = 30,
					agi_init = 35,
					sta_init = 40,
					str_mul_init = 1.3,
					agi_mul_init = 1.4,
					sta_mul_init = 1.5,
					bmv_str = 15,
					bmv_agi = 11,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 64,
					record = new int[3] { 3, 1, 2 },
					name = "Kakuzu",
					image = Resources.Kakuzu,
					pimage = Resources.PKakuzu,
					type = "Shippuuden",
					release = "Taijutsu",
					str_init = 34,
					agi_init = 24,
					sta_init = 30,
					str_mul_init = 1.45,
					agi_mul_init = 1.15,
					sta_mul_init = 1.4,
					bmv_str = 8,
					bmv_agi = 17,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 65,
					record = new int[3] { 2, 1, 3 },
					name = "Hidan",
					image = Resources.Hidan,
					pimage = Resources.PHidan,
					type = "Shippuuden",
					release = "Taijutsu",
					str_init = 33,
					agi_init = 19,
					sta_init = 36,
					str_mul_init = 1.4,
					agi_mul_init = 1.0,
					sta_mul_init = 1.5,
					bmv_str = 13,
					bmv_agi = 16,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 66,
					record = new int[3] { 3, 2, 1 },
					name = "Deidara",
					image = Resources.Deidara,
					pimage = Resources.PDeidara,
					type = "Shippuuden",
					release = "Earth",
					str_init = 33,
					agi_init = 29,
					sta_init = 26,
					str_mul_init = 1.5,
					agi_mul_init = 1.4,
					sta_mul_init = 1.1,
					bmv_str = 8,
					bmv_agi = 12,
					bmv_sta = 17
				},
				new Outfit
				{
					id = 67,
					record = new int[3] { 2, 2, 2 },
					name = "Pain",
					image = Resources.Pain,
					pimage = Resources.PPain,
					type = "S-Rank",
					release = "Illusion",
					str_init = 40,
					agi_init = 40,
					sta_init = 40,
					str_mul_init = 1.5,
					agi_mul_init = 1.5,
					sta_mul_init = 1.5,
					bmv_str = 11,
					bmv_agi = 11,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 68,
					record = new int[3] { 3, 1, 2 },
					name = "Kisame Hoshigaki",
					image = Resources.KisameHoshigaki,
					pimage = Resources.PKisameHoshigaki,
					type = "Shippuuden",
					release = "Water",
					str_init = 32,
					agi_init = 26,
					sta_init = 30,
					str_mul_init = 1.45,
					agi_mul_init = 1.1,
					sta_mul_init = 1.45,
					bmv_str = 8,
					bmv_agi = 18,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 69,
					record = new int[3] { 2, 3, 1 },
					name = "Konan",
					image = Resources.Konan,
					pimage = Resources.PKonan,
					type = "S-Rank",
					release = "Fire",
					str_init = 38,
					agi_init = 40,
					sta_init = 30,
					str_mul_init = 1.5,
					agi_mul_init = 1.6,
					sta_mul_init = 1.3,
					bmv_str = 10,
					bmv_agi = 8,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 70,
					record = new int[3] { 2, 2, 2 },
					name = "Sage Naruto",
					image = Resources.SageNaruto,
					pimage = Resources.PSageNaruto,
					type = "S-Rank",
					release = "Wind",
					str_init = 37,
					agi_init = 37,
					sta_init = 37,
					str_mul_init = 1.45,
					agi_mul_init = 1.45,
					sta_mul_init = 1.45,
					bmv_str = 10,
					bmv_agi = 11,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 71,
					record = new int[3] { 2, 3, 1 },
					name = "Hebi Sasuke",
					image = Resources.HebiSasuke,
					pimage = Resources.PHebiSasuke,
					type = "S-Rank",
					release = "Lightning",
					str_init = 37,
					agi_init = 42,
					sta_init = 28,
					str_mul_init = 1.55,
					agi_mul_init = 1.75,
					sta_mul_init = 1.2,
					bmv_str = 10,
					bmv_agi = 9,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 72,
					record = new int[3] { 3, 2, 1 },
					name = "Suigetsu",
					image = Resources.Suigetsu,
					pimage = Resources.PSuigetsu,
					type = "Shippuuden",
					release = "Water",
					str_init = 35,
					agi_init = 30,
					sta_init = 23,
					str_mul_init = 1.45,
					agi_mul_init = 1.45,
					sta_mul_init = 1.1,
					bmv_str = 8,
					bmv_agi = 12,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 73,
					record = new int[3] { 1, 2, 3 },
					name = "Karin",
					image = Resources.Karin,
					pimage = Resources.PKarin,
					type = "Shippuuden",
					release = "Healing",
					str_init = 24,
					agi_init = 32,
					sta_init = 32,
					str_mul_init = 1.05,
					agi_mul_init = 1.45,
					sta_mul_init = 1.45,
					bmv_str = 19,
					bmv_agi = 11,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 74,
					record = new int[3] { 1, 1, 4 },
					name = "Shiba Kuukaku",
					image = Resources.ShibaKuukaku,
					pimage = Resources.PShibaKuukaku,
					type = "Shippuuden",
					release = "Illusion",
					str_init = 32,
					agi_init = 21,
					sta_init = 35,
					str_mul_init = 1.35,
					agi_mul_init = 1.0,
					sta_mul_init = 1.55,
					bmv_str = 12,
					bmv_agi = 17,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 75,
					record = new int[3] { 1, 2, 3 },
					name = "3rd Hokage",
					image = Resources.thirdHokage,
					pimage = Resources.PthirdHokage,
					type = "S-Rank",
					release = "Healing",
					str_init = 33,
					agi_init = 39,
					sta_init = 39,
					str_mul_init = 1.3,
					agi_mul_init = 1.6,
					sta_mul_init = 1.6,
					bmv_str = 14,
					bmv_agi = 10,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 76,
					record = new int[3] { 1, 3, 2 },
					name = "Kotetsu Isane",
					image = Resources.KotetsuIsane,
					pimage = Resources.PKotetsuIsane,
					type = "Shippuuden",
					release = "Lightning",
					str_init = 37,
					agi_init = 21,
					sta_init = 30,
					str_mul_init = 1.55,
					agi_mul_init = 1.1,
					sta_mul_init = 1.35,
					bmv_str = 8,
					bmv_agi = 17,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 77,
					record = new int[3] { 2, 2, 2 },
					name = "Mizukage",
					image = Resources.Mizukage,
					pimage = Resources.PMizukage,
					type = "S-Rank",
					release = "Water",
					str_init = 40,
					agi_init = 40,
					sta_init = 40,
					str_mul_init = 1.5,
					agi_mul_init = 1.5,
					sta_mul_init = 1.5,
					bmv_str = 10,
					bmv_agi = 11,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 78,
					record = new int[3] { 2, 2, 2 },
					name = "Yamato",
					image = Resources.Yamato,
					pimage = Resources.PYamato,
					type = "Shippuuden",
					release = "Earth",
					str_init = 29,
					agi_init = 29,
					sta_init = 30,
					str_mul_init = 1.35,
					agi_mul_init = 1.35,
					sta_mul_init = 1.35,
					bmv_str = 11,
					bmv_agi = 12,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 79,
					record = new int[3] { 3, 1, 2 },
					name = "Mashiro Kuna",
					image = Resources.MashiroKuna,
					pimage = Resources.PMashiroKuna,
					type = "S-Rank",
					release = "Wind",
					str_init = 41,
					agi_init = 31,
					sta_init = 38,
					str_mul_init = 1.7,
					agi_mul_init = 1.3,
					sta_mul_init = 1.5,
					bmv_str = 8,
					bmv_agi = 14,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 80,
					record = new int[3] { 1, 3, 2 },
					name = "2nd Hokage",
					image = Resources.secondHokage,
					pimage = Resources.PsecondHokage,
					type = "S-Rank",
					release = "Water",
					str_init = 45,
					agi_init = 30,
					sta_init = 35,
					str_mul_init = 1.75,
					agi_mul_init = 1.3,
					sta_mul_init = 1.45,
					bmv_str = 8,
					bmv_agi = 15,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 81,
					record = new int[3] { 2, 3, 1 },
					name = "Arisawa Tatsuki",
					image = Resources.ArisawaTatsuki,
					pimage = Resources.PArisawaTatsuki,
					type = "Shippuuden",
					release = "Taijutsu",
					str_init = 29,
					agi_init = 37,
					sta_init = 22,
					str_mul_init = 1.35,
					agi_mul_init = 1.55,
					sta_mul_init = 1.15,
					bmv_str = 11,
					bmv_agi = 9,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 82,
					record = new int[3] { 2, 3, 1 },
					name = "Hime-Cut Hinata",
					image = Resources.HimeCutHinata,
					pimage = Resources.PHimeCutHinata,
					type = "Anniversary",
					release = "Taijutsu",
					str_init = 38,
					agi_init = 42,
					sta_init = 30,
					str_mul_init = 1.55,
					agi_mul_init = 1.65,
					sta_mul_init = 1.3,
					bmv_str = 11,
					bmv_agi = 9,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 83,
					record = new int[3] { 1, 3, 2 },
					name = "Shunsui Kyoraku",
					image = Resources.ShunsuiKyoraku,
					pimage = Resources.PShunsuiKyoraku,
					type = "Anniversary",
					release = "Lightning",
					str_init = 25,
					agi_init = 35,
					sta_init = 28,
					str_mul_init = 1.15,
					agi_mul_init = 1.55,
					sta_mul_init = 1.35,
					bmv_str = 18,
					bmv_agi = 8,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 84,
					record = new int[3] { 2, 2, 2 },
					name = "Kabuto",
					image = Resources.Kabuto,
					pimage = Resources.PKabuto,
					type = "Limited",
					release = "Healing",
					str_init = 30,
					agi_init = 50,
					sta_init = 45,
					str_mul_init = 1.35,
					agi_mul_init = 1.7,
					sta_mul_init = 1.6,
					bmv_str = 14,
					bmv_agi = 9,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 85,
					record = new int[3] { 2, 2, 2 },
					name = "Kisuke Urahara",
					image = Resources.KisukeUrahara,
					pimage = Resources.PKisukeUrahana,
					type = "Anniversary",
					release = "Wind",
					str_init = 38,
					agi_init = 38,
					sta_init = 40,
					str_mul_init = 1.5,
					agi_mul_init = 1.5,
					sta_mul_init = 1.5,
					bmv_str = 11,
					bmv_agi = 10,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 86,
					record = new int[3] { 1, 2, 3 },
					name = "Guren",
					image = Resources.Guren,
					pimage = Resources.PGuren,
					type = "Anniversary",
					release = "Fire",
					str_init = 20,
					agi_init = 28,
					sta_init = 40,
					str_mul_init = 1.1,
					agi_mul_init = 1.3,
					sta_mul_init = 1.65,
					bmv_str = 18,
					bmv_agi = 13,
					bmv_sta = 7
				},
				new Outfit
				{
					id = 87,
					record = new int[3] { 3, 2, 1 },
					name = "Kenpachi Zaraki",
					image = Resources.KenpachiZaraki,
					pimage = Resources.PKenpachiZaraki,
					type = "",
					release = "Lightning",
					str_init = 40,
					agi_init = 36,
					sta_init = 34,
					str_mul_init = 1.7,
					agi_mul_init = 1.6,
					sta_mul_init = 1.2,
					bmv_str = 8,
					bmv_agi = 10,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 88,
					record = new int[3] { 1, 3, 2 },
					name = "Kujou Nozomi",
					image = Resources.KujouNozomi,
					pimage = Resources.PKujouNozomi,
					type = "Anniversary",
					release = "Taijutsu",
					str_init = 20,
					agi_init = 38,
					sta_init = 30,
					str_mul_init = 1.2,
					agi_mul_init = 1.55,
					sta_mul_init = 1.3,
					bmv_str = 14,
					bmv_agi = 9,
					bmv_sta = 11
				},
				new Outfit
				{
					id = 89,
					record = new int[3] { 3, 1, 2 },
					name = "Kenpachi Limited",
					image = Resources.KenpachiLimited,
					pimage = Resources.PKenpachiLimited,
					type = "Super",
					release = "Lightning",
					str_init = 40,
					agi_init = 32,
					sta_init = 38,
					str_mul_init = 1.7,
					agi_mul_init = 1.2,
					sta_mul_init = 1.6,
					bmv_str = 8,
					bmv_agi = 18,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 90,
					record = new int[3] { 2, 2, 2 },
					name = "Hollowfied Aizen",
					image = Resources.HollowfiedAizen,
					pimage = Resources.PHollowfiedAizen,
					type = "Super",
					release = "Illusion",
					str_init = 38,
					agi_init = 42,
					sta_init = 35,
					str_mul_init = 1.6,
					agi_mul_init = 1.7,
					sta_mul_init = 1.2,
					bmv_str = 9,
					bmv_agi = 8,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 91,
					record = new int[3] { 1, 3, 2 },
					name = "Kushina Uzumaki",
					image = Resources.KushinaUzumaki,
					pimage = Resources.PKushinaUzumaki,
					type = "Limited",
					release = "Wind",
					str_init = 38,
					agi_init = 20,
					sta_init = 30,
					str_mul_init = 1.55,
					agi_mul_init = 1.2,
					sta_mul_init = 1.3,
					bmv_str = 8,
					bmv_agi = 20,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 92,
					record = new int[3] { 2, 1, 3 },
					name = "Uryu Ishida",
					image = Resources.UryuIshida,
					pimage = Resources.PUryuIshida,
					type = "Limited",
					release = "Wind",
					str_init = 40,
					agi_init = 30,
					sta_init = 55,
					str_mul_init = 1.65,
					agi_mul_init = 1.3,
					sta_mul_init = 1.7,
					bmv_str = 9,
					bmv_agi = 15,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 93,
					record = new int[3] { 2, 1, 3 },
					name = "Kimimaro",
					image = Resources.Kimimaro,
					pimage = Resources.PKimimaro,
					type = "Super",
					release = "Taijutsu",
					str_init = 35,
					agi_init = 33,
					sta_init = 42,
					str_mul_init = 1.6,
					agi_mul_init = 1.15,
					sta_mul_init = 1.8,
					bmv_str = 9,
					bmv_agi = 17,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 94,
					record = new int[3] { 3, 1, 2 },
					name = "Sanji",
					image = Resources.Sanji,
					pimage = Resources.PSanji,
					type = "Super",
					release = "Fire",
					str_init = 40,
					agi_init = 40,
					sta_init = 30,
					str_mul_init = 1.7,
					agi_mul_init = 1.7,
					sta_mul_init = 1.1,
					bmv_str = 8,
					bmv_agi = 9,
					bmv_sta = 17
				},
				new Outfit
				{
					id = 95,
					record = new int[3] { 3, 1, 2 },
					name = "Fire Fist Ace",
					image = Resources.FireFistAce,
					pimage = Resources.PFireFistAce,
					type = "Limited",
					release = "Fire",
					str_init = 45,
					agi_init = 32,
					sta_init = 38,
					str_mul_init = 1.75,
					agi_mul_init = 1.2,
					sta_mul_init = 1.65,
					bmv_str = 9,
					bmv_agi = 12,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 96,
					record = new int[3] { 2, 3, 1 },
					name = "Empress Hancock",
					image = Resources.EmpressHancock,
					pimage = Resources.PEmpressHancock,
					type = "Limited",
					release = "Illusion",
					str_init = 40,
					agi_init = 42,
					sta_init = 33,
					str_mul_init = 1.6,
					agi_mul_init = 1.7,
					sta_mul_init = 1.3,
					bmv_str = 9,
					bmv_agi = 8,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 97,
					record = new int[3] { 3, 1, 2 },
					name = "Whitebeard",
					image = Resources.Whitebeard,
					pimage = Resources.PWhitebeard,
					type = "Limited",
					release = "Taijutsu",
					str_init = 42,
					agi_init = 35,
					sta_init = 38,
					str_mul_init = 1.75,
					agi_mul_init = 1.25,
					sta_mul_init = 1.6,
					bmv_str = 8,
					bmv_agi = 14,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 98,
					record = new int[3] { 1, 3, 2 },
					name = "Nami",
					image = Resources.Nami,
					pimage = Resources.PNami,
					type = "Limited",
					release = "Wind",
					str_init = 33,
					agi_init = 42,
					sta_init = 40,
					str_mul_init = 1.3,
					agi_mul_init = 1.75,
					sta_mul_init = 1.55,
					bmv_str = 12,
					bmv_agi = 8,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 99,
					record = new int[3] { 3, 2, 1 },
					name = "Limited Aizen",
					image = Resources.LimitedAizen,
					pimage = Resources.PLimitedAizen,
					type = "Limited",
					release = "Illusion",
					str_init = 42,
					agi_init = 42,
					sta_init = 32,
					str_mul_init = 1.7,
					agi_mul_init = 1.7,
					sta_mul_init = 1.2,
					bmv_str = 8,
					bmv_agi = 9,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 100,
					record = new int[3] { 2, 2, 2 },
					name = "Third Form Aizen",
					image = Resources.thirdFormAizen,
					pimage = Resources.PthirdFormAizen,
					type = "Limited",
					release = "Illusion",
					str_init = 45,
					agi_init = 40,
					sta_init = 36,
					str_mul_init = 2.05,
					agi_mul_init = 1.95,
					sta_mul_init = 1.6,
					bmv_str = 10,
					bmv_agi = 9,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 101,
					record = new int[3] { 3, 1, 2 },
					name = "Ukitake Jushiro",
					image = Resources.UkitakeJushiro,
					pimage = Resources.PUkitakeJushiro,
					type = "Limited",
					release = "Fire",
					str_init = 55,
					agi_init = 30,
					sta_init = 40,
					str_mul_init = 1.7,
					agi_mul_init = 1.3,
					sta_mul_init = 1.65,
					bmv_str = 8,
					bmv_agi = 15,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 102,
					record = new int[3] { 3, 2, 1 },
					name = "Zoro",
					image = Resources.Zoro,
					pimage = Resources.PZoro,
					type = "Eternal",
					release = "Taijutsu",
					str_init = 45,
					agi_init = 38,
					sta_init = 32,
					str_mul_init = 1.8,
					agi_mul_init = 1.65,
					sta_mul_init = 1.15,
					bmv_str = 8,
					bmv_agi = 9,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 103,
					record = new int[3] { 2, 2, 2 },
					name = "Danzo Shimura",
					image = Resources.DanzoShimura,
					pimage = Resources.PDanzoShimura,
					type = "Limited",
					release = "Illusion",
					str_init = 42,
					agi_init = 42,
					sta_init = 42,
					str_mul_init = 1.55,
					agi_mul_init = 1.55,
					sta_mul_init = 1.6,
					bmv_str = 10,
					bmv_agi = 10,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 104,
					record = new int[3] { 2, 2, 2 },
					name = "R. 4th Hokage",
					image = Resources.RforthHokage,
					pimage = Resources.PRforthHokage,
					type = "Ressurection",
					release = "Wind",
					str_init = 35,
					agi_init = 42,
					sta_init = 33,
					str_mul_init = 1.5,
					agi_mul_init = 1.75,
					sta_mul_init = 1.25,
					bmv_str = 10,
					bmv_agi = 9,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 105,
					record = new int[3] { 2, 1, 3 },
					name = "R. Little Jun",
					image = Resources.RLittleJun,
					pimage = Resources.PRLittleJun,
					type = "Ressurection",
					release = "Taijutsu",
					str_init = 36,
					agi_init = 34,
					sta_init = 40,
					str_mul_init = 1.5,
					agi_mul_init = 1.35,
					sta_mul_init = 1.65,
					bmv_str = 10,
					bmv_agi = 12,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 106,
					record = new int[3] { 1, 2, 3 },
					name = "R. Little Meng",
					image = Resources.RLittleMeng,
					pimage = Resources.PRLittleMeng,
					type = "Ressurection",
					release = "Illusion",
					str_init = 34,
					agi_init = 36,
					sta_init = 40,
					str_mul_init = 1.35,
					agi_mul_init = 1.5,
					sta_mul_init = 1.65,
					bmv_str = 12,
					bmv_agi = 10,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 107,
					record = new int[3] { 2, 1, 3 },
					name = "R. Gaara",
					image = Resources.RGaara,
					pimage = Resources.PRGaara,
					type = "Ressurection",
					release = "Earth",
					str_init = 39,
					agi_init = 28,
					sta_init = 43,
					str_mul_init = 1.55,
					agi_mul_init = 1.1,
					sta_mul_init = 1.85,
					bmv_str = 10,
					bmv_agi = 18,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 108,
					record = new int[3] { 2, 3, 1 },
					name = "R. Uchiha Itachi",
					image = Resources.RItachiUchiha,
					pimage = Resources.PRItachiUchiha,
					type = "Ressurection",
					release = "Illusion",
					str_init = 36,
					agi_init = 43,
					sta_init = 31,
					str_mul_init = 1.45,
					agi_mul_init = 1.85,
					sta_mul_init = 1.2,
					bmv_str = 11,
					bmv_agi = 8,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 109,
					record = new int[3] { 3, 2, 1 },
					name = "R. Shihouin Yoruichi",
					image = Resources.RShihouinYoruichi,
					pimage = Resources.PRShihouinYoruichi,
					type = "Ressurection",
					release = "Wind",
					str_init = 40,
					agi_init = 40,
					sta_init = 30,
					str_mul_init = 1.65,
					agi_mul_init = 1.65,
					sta_mul_init = 1.2,
					bmv_str = 9,
					bmv_agi = 9,
					bmv_sta = 16
				},
				new Outfit
				{
					id = 110,
					record = new int[3] { 2, 3, 1 },
					name = "Limited Hatake Kakashi",
					image = Resources.LimitedHatakeKakashi,
					pimage = Resources.PLimitedHatakeKakashi,
					type = "Ressurection",
					release = "Lightning",
					str_init = 39,
					agi_init = 39,
					sta_init = 32,
					str_mul_init = 1.6,
					agi_mul_init = 1.6,
					sta_mul_init = 1.3,
					bmv_str = 10,
					bmv_agi = 10,
					bmv_sta = 12
				},
				new Outfit
				{
					id = 111,
					record = new int[3] { 1, 4, 1 },
					name = "Sai",
					image = Resources.Sai,
					pimage = Resources.PSai,
					type = "Limited",
					release = "Water",
					str_init = 30,
					agi_init = 50,
					sta_init = 30,
					str_mul_init = 1.35,
					agi_mul_init = 1.9,
					sta_mul_init = 1.35,
					bmv_str = 15,
					bmv_agi = 7,
					bmv_sta = 13
				},
				new Outfit
				{
					id = 112,
					record = new int[3] { 2, 1, 3 },
					name = "Bankai Ulquiorra",
					image = Resources.Ulquiorra,
					pimage = Resources.PUlquiorra,
					type = "Bankai",
					release = "Healing",
					str_init = 36,
					agi_init = 32,
					sta_init = 42,
					str_mul_init = 1.45,
					agi_mul_init = 1.35,
					sta_mul_init = 1.7,
					bmv_str = 11,
					bmv_agi = 14,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 113,
					record = new int[3] { 2, 2, 2 },
					name = "Bankai Nelliel",
					image = Resources.Nelliel,
					pimage = Resources.PNelliel,
					type = "Bankai",
					release = "Sealing",
					str_init = 32,
					agi_init = 39,
					sta_init = 39,
					str_mul_init = 1.3,
					agi_mul_init = 1.6,
					sta_mul_init = 1.6,
					bmv_str = 12,
					bmv_agi = 10,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 114,
					record = new int[3] { 2, 1, 3 },
					name = "Bankai Halibel",
					image = Resources.Halibel,
					pimage = Resources.PHalibel,
					type = "Bankai",
					release = "Water",
					str_init = 37,
					agi_init = 34,
					sta_init = 39,
					str_mul_init = 1.5,
					agi_mul_init = 1.4,
					sta_mul_init = 1.6,
					bmv_str = 10,
					bmv_agi = 13,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 115,
					record = new int[3] { 1, 1, 4 },
					name = "Bankai Inoue Orihime",
					image = Resources.InoueOrihime,
					pimage = Resources.PInoueOrihime,
					type = "Bankai",
					release = "Healing",
					str_init = 33,
					agi_init = 37,
					sta_init = 40,
					str_mul_init = 1.3,
					agi_mul_init = 1.5,
					sta_mul_init = 1.7,
					bmv_str = 14,
					bmv_agi = 11,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 116,
					record = new int[3] { 1, 2, 3 },
					name = "Bankai Hollowfied",
					image = Resources.HollowfiedIchigo,
					pimage = Resources.PHollowfiedIchigo,
					type = "Bankai",
					release = "Fire",
					str_init = 35,
					agi_init = 37,
					sta_init = 38,
					str_mul_init = 1.4,
					agi_mul_init = 1.5,
					sta_mul_init = 1.6,
					bmv_str = 12,
					bmv_agi = 11,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 117,
					record = new int[3] { 2, 1, 3 },
					name = "Bankai Kuchiki Rukia",
					image = Resources.KuchikiRukia,
					pimage = Resources.PKuchikiRukia,
					type = "Bankai",
					release = "Water",
					str_init = 37,
					agi_init = 35,
					sta_init = 38,
					str_mul_init = 1.5,
					agi_mul_init = 1.4,
					sta_mul_init = 1.6,
					bmv_str = 11,
					bmv_agi = 12,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 118,
					record = new int[3] { 2, 3, 1 },
					name = "Res. Neliel",
					image = Resources.RessNel,
					pimage = Resources.PRessNel,
					type = "Limited",
					release = "Taijutsu",
					str_init = 35,
					agi_init = 45,
					sta_init = 30,
					str_mul_init = 1.5,
					agi_mul_init = 1.9,
					sta_mul_init = 1.2,
					bmv_str = 10,
					bmv_agi = 7,
					bmv_sta = 22
				},
				new Outfit
				{
					id = 119,
					record = new int[3] { 3, 1, 2 },
					name = "Luffy",
					image = Resources.Luffy,
					pimage = Resources.PLuffy,
					type = "Limited",
					release = "Taijutsu",
					str_init = 45,
					agi_init = 30,
					sta_init = 40,
					str_mul_init = 1.9,
					agi_mul_init = 0.9,
					sta_mul_init = 1.5,
					bmv_str = 7,
					bmv_agi = 20,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 120,
					record = new int[3] { 2, 3, 1 },
					name = "Hawk-Eyes",
					image = Resources.HawkEyes,
					pimage = Resources.PHawkEyes,
					type = "Limited",
					release = "Illusion",
					str_init = 44,
					agi_init = 46,
					sta_init = 36,
					str_mul_init = 1.8,
					agi_mul_init = 2.0,
					sta_mul_init = 1.35,
					bmv_str = 8,
					bmv_agi = 7,
					bmv_sta = 16
				},
				new Outfit
				{
					id = 121,
					record = new int[3] { 2, 1, 3 },
					name = "Robin",
					image = Resources.Robin,
					pimage = Resources.PRobin,
					type = "Limited",
					release = "Illusion",
					str_init = 40,
					agi_init = 30,
					sta_init = 43,
					str_mul_init = 1.5,
					agi_mul_init = 1.0,
					sta_mul_init = 1.9,
					bmv_str = 11,
					bmv_agi = 20,
					bmv_sta = 7
				},
				new Outfit
				{
					id = 122,
					record = new int[3] { 3, 2, 1 },
					name = "Shanks",
					image = Resources.Shanks,
					pimage = Resources.PShanks,
					type = "Limited",
					release = "Taijutsu",
					str_init = 45,
					agi_init = 39,
					sta_init = 35,
					str_mul_init = 1.9,
					agi_mul_init = 1.6,
					sta_mul_init = 1.2,
					bmv_str = 7,
					bmv_agi = 10,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 123,
					record = new int[3] { 1, 3, 2 },
					name = "Sage 6-paths",
					image = Resources.SageSixPaths,
					pimage = Resources.PSageSixPaths,
					type = "Limited",
					release = "Illusion",
					str_init = 32,
					agi_init = 38,
					sta_init = 35,
					str_mul_init = 1.2,
					agi_mul_init = 2.0,
					sta_mul_init = 1.4,
					bmv_str = 18,
					bmv_agi = 7,
					bmv_sta = 10
				},
				new Outfit
				{
					id = 124,
					record = new int[3] { 2, 1, 3 },
					name = "R. Sage 6-paths",
					image = Resources.SageSixPaths,
					pimage = Resources.PSageSixPaths,
					type = "Limited",
					release = "Fire",
					str_init = 46,
					agi_init = 38,
					sta_init = 45,
					str_mul_init = 2.0,
					agi_mul_init = 1.4,
					sta_mul_init = 1.75,
					bmv_str = 7,
					bmv_agi = 15,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 125,
					record = new int[3] { 2, 1, 3 },
					name = "Blackbeard",
					image = Resources.Blackbeard,
					pimage = Resources.PBlackbeard,
					type = "Limited",
					release = "Taijutsu",
					str_init = 38,
					agi_init = 34,
					sta_init = 43,
					str_mul_init = 1.6,
					agi_mul_init = 1.2,
					sta_mul_init = 1.75,
					bmv_str = 9,
					bmv_agi = 17,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 126,
					record = new int[3] { 3, 1, 2 },
					name = "Golden Lion Luffy",
					image = Resources.LionLuffy,
					pimage = Resources.PLionLuffy,
					type = "Limited",
					release = "Taijutsu",
					str_init = 45,
					agi_init = 32,
					sta_init = 42,
					str_mul_init = 2.0,
					agi_mul_init = 1.0,
					sta_mul_init = 1.6,
					bmv_str = 7,
					bmv_agi = 16,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 127,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "Butler Little Jun",
					image = Resources.ButlerLittleJun,
					pimage = Resources.PButlerLittleJun,
					type = "Limited",
					release = "Taijutsu",
					str_init = 40,
					agi_init = 32,
					sta_init = 45,
					str_mul_init = 1.6,
					agi_mul_init = 1.2,
					sta_mul_init = 1.9,
					bmv_str = 11,
					bmv_agi = 18,
					bmv_sta = 7
				},
				new Outfit
				{
					id = 128,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "Maid Little Meng",
					image = Resources.MaidLittleMeng,
					pimage = Resources.PMaidLittleMeng,
					type = "Limited",
					release = "Taijutsu",
					str_init = 39,
					agi_init = 42,
					sta_init = 34,
					str_mul_init = 1.45,
					agi_mul_init = 1.9,
					sta_mul_init = 1.4,
					bmv_str = 12,
					bmv_agi = 7,
					bmv_sta = 18
				},
				new Outfit
				{
					id = 129,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "Sage Kabuto",
					image = Resources.SageKabuto,
					pimage = Resources.PSageKabuto,
					type = "Limited",
					release = "Taijutsu",
					str_init = 42,
					agi_init = 35,
					sta_init = 45,
					str_mul_init = 1.8,
					agi_mul_init = 1.5,
					sta_mul_init = 2.0,
					bmv_str = 9,
					bmv_agi = 13,
					bmv_sta = 7
				},
				new Outfit
				{
					id = 130,
					chinese = true,
					record = new int[3] { 1, 3, 2 },
					name = "Madara Uchiha",
					image = Resources.MadaraUchiha,
					pimage = Resources.PMadaraUchiha,
					type = "Limited",
					release = "Taijutsu",
					str_init = 38,
					agi_init = 45,
					sta_init = 42,
					str_mul_init = 1.5,
					agi_mul_init = 2.0,
					sta_mul_init = 1.85,
					bmv_str = 13,
					bmv_agi = 7,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 131,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "Rob Lucci",
					image = Resources.RobLucci,
					pimage = Resources.PRobLucci,
					type = "Limited",
					release = "Wind",
					str_init = 42,
					agi_init = 45,
					sta_init = 38,
					str_mul_init = 1.6,
					agi_mul_init = 1.9,
					sta_mul_init = 1.4,
					bmv_str = 11,
					bmv_agi = 7,
					bmv_sta = 16
				},
				new Outfit
				{
					id = 132,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "Chakra Naruto",
					image = Resources.ChakraNaruto,
					pimage = Resources.PChakraNaruto,
					type = "Limited",
					release = "Wind",
					str_init = 45,
					agi_init = 42,
					sta_init = 34,
					str_mul_init = 2.0,
					agi_mul_init = 1.8,
					sta_mul_init = 1.6,
					bmv_str = 7,
					bmv_agi = 8,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 133,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "R. Blackbeard",
					image = Resources.Blackbeard,
					pimage = Resources.PBlackbeard,
					type = "Limited",
					release = "Illusion",
					str_init = 43,
					agi_init = 34,
					sta_init = 45,
					str_mul_init = 1.8,
					agi_mul_init = 1.35,
					sta_mul_init = 1.8,
					bmv_str = 8,
					bmv_agi = 16,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 134,
					chinese = true,
					record = new int[3] { 3, 1, 2 },
					name = "Festival Hawk-Eyes",
					image = Resources.HawkEyes,
					pimage = Resources.PHawkEyes,
					type = "Limited",
					release = "Taijutsu",
					str_init = 42,
					agi_init = 43,
					sta_init = 32,
					str_mul_init = 1.75,
					agi_mul_init = 1.9,
					sta_mul_init = 1.3,
					bmv_str = 9,
					bmv_agi = 7,
					bmv_sta = 17
				},
				new Outfit
				{
					id = 135,
					chinese = true,
					record = new int[3] { 3, 2, 1 },
					name = "R. Madara Uchiha",
					image = Resources.MadaraUchiha,
					pimage = Resources.PMadaraUchiha,
					type = "Limited",
					release = "Illusion",
					str_init = 45,
					agi_init = 38,
					sta_init = 42,
					str_mul_init = 2.0,
					agi_mul_init = 1.1,
					sta_mul_init = 1.6,
					bmv_str = 7,
					bmv_agi = 15,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 136,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "Getsuga Ichigo",
					image = Resources.GetsugaIchigo,
					pimage = Resources.PGetsugaIchigo,
					type = "Limited",
					release = "Water",
					str_init = 42,
					agi_init = 46,
					sta_init = 35,
					str_mul_init = 1.8,
					agi_mul_init = 2.0,
					sta_mul_init = 1.3,
					bmv_str = 8,
					bmv_agi = 7,
					bmv_sta = 17
				},
				new Outfit
				{
					id = 137,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "R. Boa Hancock",
					image = Resources.EmpressHancock,
					pimage = Resources.PEmpressHancock,
					type = "Limited",
					release = "Illusion",
					str_init = 40,
					agi_init = 45,
					sta_init = 33,
					str_mul_init = 1.8,
					agi_mul_init = 1.95,
					sta_mul_init = 1.3,
					bmv_str = 9,
					bmv_agi = 7,
					bmv_sta = 16
				},
				new Outfit
				{
					id = 138,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "R. Kisuke Urahara",
					image = Resources.KisukeUrahara,
					pimage = Resources.PKisukeUrahana,
					type = "Limited",
					release = "Wind",
					str_init = 43,
					agi_init = 34,
					sta_init = 45,
					str_mul_init = 1.9,
					agi_mul_init = 1.35,
					sta_mul_init = 1.8,
					bmv_str = 8,
					bmv_agi = 15,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 139,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "Shigekuni Yamamoto-Genryūsai",
					image = Resources.Shigekuni,
					pimage = Resources.PShigekuni,
					type = "Limited",
					release = "Fire",
					str_init = 42,
					agi_init = 35,
					sta_init = 45,
					str_mul_init = 1.85,
					agi_mul_init = 1.4,
					sta_mul_init = 2.0,
					bmv_str = 9,
					bmv_agi = 16,
					bmv_sta = 7
				},
				new Outfit
				{
					id = 140,
					chinese = true,
					record = new int[3] { 2, 2, 2 },
					name = "Franky",
					image = Resources.Franky,
					pimage = Resources.PFranky,
					type = "Limited",
					release = "Tool",
					str_init = 42,
					agi_init = 40,
					sta_init = 42,
					str_mul_init = 1.85,
					agi_mul_init = 1.6,
					sta_mul_init = 1.85,
					bmv_str = 8,
					bmv_agi = 14,
					bmv_sta = 8
				},
				new Outfit
				{
					id = 141,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "Bikini Boa Hancock",
					image = Resources.BikiniBoa,
					pimage = Resources.PBikiniBoa,
					type = "Limited",
					release = "Illusion",
					str_init = 47,
					agi_init = 43,
					sta_init = 38,
					str_mul_init = 2.0,
					agi_mul_init = 1.85,
					sta_mul_init = 1.5,
					bmv_str = 7,
					bmv_agi = 8,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 142,
					chinese = true,
					record = new int[3] { 3, 1, 2 },
					name = "Bikini Tsunade",
					image = Resources.BikiniTsunade,
					pimage = Resources.PBikiniTsunade,
					type = "Limited",
					release = "Taijutsu",
					str_init = 45,
					agi_init = 40,
					sta_init = 42,
					str_mul_init = 2.0,
					agi_mul_init = 1.65,
					sta_mul_init = 1.9,
					bmv_str = 7,
					bmv_agi = 15,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 143,
					chinese = true,
					record = new int[3] { 3, 1, 2 },
					name = "Trafalgar Law",
					image = Resources.Trafalgar,
					pimage = Resources.PTrafalgar,
					type = "Limited",
					release = "Illusion",
					str_init = 48,
					agi_init = 39,
					sta_init = 43,
					str_mul_init = 2.3,
					agi_mul_init = 1.55,
					sta_mul_init = 1.95,
					bmv_str = 7,
					bmv_agi = 15,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 144,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "Swimsuit Yachiru",
					image = Resources.SwimsuitYachiru,
					pimage = Resources.PSwimsuitYachiru,
					type = "Limited",
					release = "Taijutsu",
					str_init = 42,
					agi_init = 39,
					sta_init = 48,
					str_mul_init = 1.95,
					agi_mul_init = 1.5,
					sta_mul_init = 2.3,
					bmv_str = 9,
					bmv_agi = 13,
					bmv_sta = 7
				},
				new Outfit
				{
					id = 145,
					chinese = true,
					record = new int[3] { 3, 2, 1 },
					name = "Swimsuit Yachiru",
					image = Resources.SwimsuitYachiru,
					pimage = Resources.PSwimsuitYachiru,
					type = "Limited",
					release = "Taijutsu",
					str_init = 47,
					agi_init = 43,
					sta_init = 38,
					str_mul_init = 2.3,
					agi_mul_init = 1.75,
					sta_mul_init = 1.5,
					bmv_str = 7,
					bmv_agi = 9,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 146,
					chinese = true,
					record = new int[3] { 1, 2, 3 },
					name = "Swimsuit Yachiru",
					image = Resources.SwimsuitYachiru,
					pimage = Resources.PSwimsuitYachiru,
					type = "Limited",
					release = "Illusion",
					str_init = 38,
					agi_init = 42,
					sta_init = 48,
					str_mul_init = 1.5,
					agi_mul_init = 1.8,
					sta_mul_init = 2.3,
					bmv_str = 13,
					bmv_agi = 9,
					bmv_sta = 7
				},
				new Outfit
				{
					id = 147,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "Swimsuit Yachiru",
					image = Resources.SwimsuitYachiru,
					pimage = Resources.PSwimsuitYachiru,
					type = "Limited",
					release = "Taijutsu",
					str_init = 43,
					agi_init = 47,
					sta_init = 38,
					str_mul_init = 1.75,
					agi_mul_init = 2.3,
					sta_mul_init = 1.5,
					bmv_str = 9,
					bmv_agi = 7,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 148,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "Enel",
					image = Resources.Enel,
					pimage = Resources.PEnel,
					type = "Limited",
					release = "Lightning",
					str_init = 40,
					agi_init = 49,
					sta_init = 30,
					str_mul_init = 1.85,
					agi_mul_init = 2.3,
					sta_mul_init = 1.3,
					bmv_str = 8,
					bmv_agi = 7,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 149,
					chinese = true,
					record = new int[3] { 2, 3, 1 },
					name = "Dark Rukia",
					image = Resources.DarkRukia,
					pimage = Resources.PDarkRukia,
					type = "Limited",
					release = "Lightning",
					str_init = 40,
					agi_init = 45,
					sta_init = 30,
					str_mul_init = 1.6,
					agi_mul_init = 2.0,
					sta_mul_init = 1.3,
					bmv_str = 10,
					bmv_agi = 7,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 150,
					chinese = true,
					record = new int[3] { 2, 1, 3 },
					name = "Mr.2",
					image = Resources.Mr2,
					pimage = Resources.PMr2,
					type = "Limited",
					release = "Wind",
					str_init = 40,
					agi_init = 45,
					sta_init = 35,
					str_mul_init = 1.6,
					agi_mul_init = 1.9,
					sta_mul_init = 1.4,
					bmv_str = 9,
					bmv_agi = 8,
					bmv_sta = 14
				},
				new Outfit
				{
					id = 151,
					chinese = true,
					record = new int[3] { 3, 2, 1 },
					name = "Edo Tensei Itachi",
					image = Resources.EdoTenseiItachi,
					pimage = Resources.PEdoTenseiItachi,
					type = "Limited",
					release = "Lightning",
					str_init = 45,
					agi_init = 40,
					sta_init = 30,
					str_mul_init = 2.0,
					agi_mul_init = 1.75,
					sta_mul_init = 1.55,
					bmv_str = 7,
					bmv_agi = 9,
					bmv_sta = 15
				},
				new Outfit
				{
					id = 152,
					chinese = true,
					record = new int[3] { 3, 2, 1 },
					name = "Bartholomew Kuma",
					image = Resources.Kuma,
					pimage = Resources.PKuma,
					type = "Limited",
					release = "Taijutsu",
					str_init = 48,
					agi_init = 42,
					sta_init = 40,
					str_mul_init = 2.3,
					agi_mul_init = 1.55,
					sta_mul_init = 1.6,
					bmv_str = 7,
					bmv_agi = 14,
					bmv_sta = 9
				},
				new Outfit
				{
					id = 153,
					chinese = true,
					record = new int[3] { 3, 2, 1 },
					name = "Brook",
					image = Resources.Brook,
					pimage = Resources.PBrook,
					type = "Limited",
					release = "Wind",
					str_init = 49,
					agi_init = 42,
					sta_init = 35,
					str_mul_init = 2.3,
					agi_mul_init = 1.85,
					sta_mul_init = 1.3,
					bmv_str = 7,
					bmv_agi = 8,
					bmv_sta = 15
				}
			};
			bloodlines = new Bloodline[68]
			{
				new Bloodline
				{
					id = 0,
					name = "Tenten",
					level = 25,
					image = Resources.BLTenten,
					release = new Tool(20),
					str = new Strength(18),
					agi = new Agility(13),
					sta = new Stamina(24),
					values = new Values[2]
					{
						new Defense(53),
						new ArmorBreak(47)
					}
				},
				new Bloodline
				{
					id = 1,
					name = "Inuzuka Kiba",
					level = 25,
					image = Resources.BLInuzukaKiba,
					release = new Taijutsu(20),
					str = new Strength(18),
					agi = new Agility(25),
					sta = new Stamina(12),
					values = new Values[2]
					{
						new Pierce(47),
						new Dodge(30)
					}
				},
				new Bloodline
				{
					id = 2,
					name = "Hyuga Hinata",
					level = 26,
					image = Resources.BLHyugaHinata,
					release = new Taijutsu(20),
					str = new Strength(23),
					agi = new Agility(20),
					sta = new Stamina(13),
					values = new Values[2]
					{
						new Agility(30),
						new Critical(30)
					}
				},
				new Bloodline
				{
					id = 3,
					name = "Shizune",
					level = 26,
					image = Resources.BLShizune,
					release = new Healing(20),
					str = new Strength(12),
					agi = new Agility(14),
					sta = new Stamina(30),
					values = new Values[2]
					{
						new Stamina(30),
						new PHP(37)
					}
				},
				new Bloodline
				{
					id = 4,
					name = "AkimichiChoji",
					level = 27,
					image = Resources.BLAkimichiChoji,
					release = new Taijutsu(20),
					str = new Strength(23),
					agi = new Agility(11),
					sta = new Stamina(23),
					values = new Values[2]
					{
						new Constitution(43),
						new Strength(30)
					}
				},
				new Bloodline
				{
					id = 5,
					name = "Aburame Shino",
					level = 28,
					image = Resources.BLAburameShino,
					release = new Tool(20),
					str = new Strength(12),
					agi = new Agility(23),
					sta = new Stamina(23),
					values = new Values[2]
					{
						new Defense(53),
						new Speed(37)
					}
				},
				new Bloodline
				{
					id = 6,
					name = "Hyuga Neji",
					level = 31,
					image = Resources.BLHyugaNeji,
					release = new Taijutsu(20),
					str = new Strength(20),
					agi = new Agility(20),
					sta = new Stamina(20),
					values = new Values[2]
					{
						new Hit(47),
						new Stamina(30)
					}
				},
				new Bloodline
				{
					id = 7,
					name = "Mitarashi Anko",
					level = 31,
					image = Resources.BLMitarashiAnko,
					release = new Sealing(20),
					str = new Strength(13),
					agi = new Agility(25),
					sta = new Stamina(22),
					values = new Values[2]
					{
						new PHP(47),
						new Hit(47)
					}
				},
				new Bloodline
				{
					id = 8,
					name = "Nara Shikamaru",
					level = 36,
					image = Resources.BLNaraShikamaru,
					release = new Illusion(30),
					str = new Strength(18),
					agi = new Agility(24),
					sta = new Stamina(50),
					values = new Values[2]
					{
						new Block(44),
						new Defense(77)
					}
				},
				new Bloodline
				{
					id = 9,
					name = "Yamanaka Ino",
					level = 37,
					image = Resources.BLYamanakaIno,
					release = new Illusion(30),
					str = new Strength(31),
					agi = new Agility(24),
					sta = new Stamina(38),
					values = new Values[2]
					{
						new Stamina(44),
						new Pierce(69)
					}
				},
				new Bloodline
				{
					id = 10,
					name = "Haku",
					level = 37,
					image = Resources.BLHaku,
					release = new Water(30),
					str = new Strength(22),
					agi = new Agility(38),
					sta = new Stamina(33),
					values = new Values[2]
					{
						new Hit(69),
						new Agility(44)
					}
				},
				new Bloodline
				{
					id = 11,
					name = "Temari",
					level = 38,
					image = Resources.BLTemari,
					release = new Wind(30),
					str = new Strength(32),
					agi = new Agility(32),
					sta = new Stamina(30),
					values = new Values[2]
					{
						new Hit(69),
						new PAtk(55)
					}
				},
				new Bloodline
				{
					id = 12,
					name = "Yamato",
					level = 39,
					image = Resources.BLYamato,
					release = new Earth(30),
					str = new Strength(33),
					agi = new Agility(29),
					sta = new Stamina(33),
					values = new Values[2]
					{
						new Hit(69),
						new Dodge(44)
					}
				},
				new Bloodline
				{
					id = 13,
					name = "Karin",
					level = 41,
					image = Resources.BLKarin,
					release = new Healing(30),
					str = new Strength(16),
					agi = new Agility(45),
					sta = new Stamina(35),
					values = new Values[2]
					{
						new Dodge(44),
						new Constitution(63)
					}
				},
				new Bloodline
				{
					id = 14,
					name = "Kurenai Yuuhi",
					level = 41,
					image = Resources.BLKurenaiYuuhi,
					release = new Illusion(30),
					str = new Strength(16),
					agi = new Agility(35),
					sta = new Stamina(45),
					values = new Values[2]
					{
						new Defense(77),
						new Speed(55)
					}
				},
				new Bloodline
				{
					id = 15,
					name = "Kakuzu",
					level = 42,
					image = Resources.BLKakuzu,
					release = new Taijutsu(30),
					str = new Strength(42),
					agi = new Agility(20),
					sta = new Stamina(35),
					values = new Values[2]
					{
						new Strength(44),
						new Block(44)
					}
				},
				new Bloodline
				{
					id = 16,
					name = "Asuma Sarutobi",
					level = 43,
					image = Resources.BLAsumaSarutobi,
					release = new Fire(30),
					str = new Strength(38),
					agi = new Agility(35),
					sta = new Stamina(25),
					values = new Values[2]
					{
						new Speed(55),
						new ArmorBreak(69)
					}
				},
				new Bloodline
				{
					id = 17,
					name = "Sakura Haruno",
					level = 46,
					image = Resources.BLSakuraHaruno,
					release = new Taijutsu(30),
					str = new Strength(24),
					agi = new Agility(20),
					sta = new Stamina(55),
					values = new Values[2]
					{
						new Constitution(63),
						new PHP(55)
					}
				},
				new Bloodline
				{
					id = 18,
					name = "Uzumaki Naruto",
					level = 46,
					image = Resources.BLUzumakiNaruto,
					release = new Wind(30),
					str = new Strength(45),
					agi = new Agility(32),
					sta = new Stamina(23),
					values = new Values[2]
					{
						new ArmorBreak(69),
						new Hit(69)
					}
				},
				new Bloodline
				{
					id = 19,
					name = "Sasori",
					level = 46,
					image = Resources.BLSasori,
					release = new Tool(30),
					str = new Strength(32),
					agi = new Agility(23),
					sta = new Stamina(45),
					values = new Values[2]
					{
						new Stamina(44),
						new Critical(44)
					}
				},
				new Bloodline
				{
					id = 20,
					name = "Sai",
					level = 51,
					image = Resources.BLSai,
					release = new Illusion(40),
					str = new Strength(58),
					agi = new Agility(32),
					sta = new Stamina(65),
					values = new Values[2]
					{
						new ArmorBreak(96),
						new Defense(107)
					}
				},
				new Bloodline
				{
					id = 21,
					name = "Rock Lee",
					level = 51,
					image = Resources.BLRockLee,
					release = new Taijutsu(40),
					str = new Strength(52),
					agi = new Agility(51),
					sta = new Stamina(52),
					values = new Values[2]
					{
						new Hit(96),
						new Agility(60)
					}
				},
				new Bloodline
				{
					id = 22,
					name = "Hidan",
					level = 52,
					image = Resources.BLHidan,
					release = new Taijutsu(40),
					str = new Strength(68),
					agi = new Agility(32),
					sta = new Stamina(56),
					values = new Values[2]
					{
						new PHP(75),
						new Strength(60)
					}
				},
				new Bloodline
				{
					id = 23,
					name = "Second Hokage",
					level = 54,
					image = Resources.BLSecondHokage,
					release = new Water(40),
					str = new Strength(40),
					agi = new Agility(63),
					sta = new Stamina(55),
					values = new Values[2]
					{
						new Speed(75),
						new Block(60)
					}
				},
				new Bloodline
				{
					id = 24,
					name = "Konan",
					level = 54,
					image = Resources.BLKonan,
					release = new Fire(40),
					str = new Strength(58),
					agi = new Agility(60),
					sta = new Stamina(40),
					values = new Values[2]
					{
						new Dodge(60),
						new Pierce(96)
					}
				},
				new Bloodline
				{
					id = 25,
					name = "Suigetsu",
					level = 56,
					image = Resources.BLSuigetsu,
					release = new Water(40),
					str = new Strength(68),
					agi = new Agility(52),
					sta = new Stamina(40),
					values = new Values[2]
					{
						new Critical(60),
						new Dodge(60)
					}
				},
				new Bloodline
				{
					id = 26,
					name = "Deidara",
					level = 56,
					image = Resources.BLDeidara,
					release = new Earth(40),
					str = new Strength(50),
					agi = new Agility(70),
					sta = new Stamina(40),
					values = new Values[2]
					{
						new Hit(96),
						new PAtk(75)
					}
				},
				new Bloodline
				{
					id = 27,
					name = "Kyuubi Naruto",
					level = 58,
					image = Resources.BLKyuubiNaruto,
					release = new Fire(40),
					str = new Strength(38),
					agi = new Agility(59),
					sta = new Stamina(65),
					values = new Values[2]
					{
						new Dodge(60),
						new Stamina(60)
					}
				},
				new Bloodline
				{
					id = 28,
					name = "Mizukage",
					level = 58,
					image = Resources.BLMizukage,
					release = new Water(40),
					str = new Strength(54),
					agi = new Agility(54),
					sta = new Stamina(54),
					values = new Values[2]
					{
						new Hit(96),
						new Hit(96)
					}
				},
				new Bloodline
				{
					id = 29,
					name = "Jugo",
					level = 60,
					image = Resources.BLJugo,
					release = new Taijutsu(40),
					str = new Strength(35),
					agi = new Agility(65),
					sta = new Stamina(65),
					values = new Values[2]
					{
						new Agility(60),
						new Constitution(87)
					}
				},
				new Bloodline
				{
					id = 30,
					name = "Kisame Hoshigaki",
					level = 60,
					image = Resources.BLKisameHoshigaki,
					release = new Water(40),
					str = new Strength(65),
					agi = new Agility(35),
					sta = new Stamina(65),
					values = new Values[2]
					{
						new PHP(75),
						new ArmorBreak(96)
					}
				},
				new Bloodline
				{
					id = 31,
					name = "Uchiha Sasuke",
					level = 60,
					image = Resources.BLUchihaSasuke,
					release = new Lightning(40),
					str = new Strength(65),
					agi = new Agility(65),
					sta = new Stamina(35),
					values = new Values[2]
					{
						new ArmorBreak(96),
						new Speed(75)
					}
				},
				new Bloodline
				{
					id = 32,
					name = "Fourth Hokage",
					level = 71,
					image = Resources.BLFourthHokage,
					release = new Wind(50),
					str = new Strength(92),
					agi = new Agility(84),
					sta = new Stamina(52),
					values = new Values[2]
					{
						new Hit(127),
						new Critical(80)
					}
				},
				new Bloodline
				{
					id = 33,
					name = "Gaara",
					level = 72,
					image = Resources.BLGaara,
					release = new Earth(50),
					str = new Strength(84),
					agi = new Agility(48),
					sta = new Stamina(98),
					values = new Values[2]
					{
						new Strength(80),
						new Defense(142)
					}
				},
				new Bloodline
				{
					id = 34,
					name = "Hatake Kakashi",
					level = 73,
					image = Resources.BLHatakeKakashi,
					release = new Lightning(50),
					str = new Strength(78),
					agi = new Agility(77),
					sta = new Stamina(77),
					values = new Values[2]
					{
						new Block(80),
						new Dodge(80)
					}
				},
				new Bloodline
				{
					id = 35,
					name = "Third Hokage",
					level = 74,
					image = Resources.BLThirdHokage,
					release = new Healing(50),
					str = new Strength(60),
					agi = new Agility(88),
					sta = new Stamina(86),
					values = new Values[2]
					{
						new Stamina(80),
						new Speed(100)
					}
				},
				new Bloodline
				{
					id = 36,
					name = "Tsunade",
					level = 75,
					image = Resources.BLTsunade,
					release = new Healing(50),
					str = new Strength(51),
					agi = new Agility(90),
					sta = new Stamina(95),
					values = new Values[2]
					{
						new Critical(80),
						new PHP(100)
					}
				},
				new Bloodline
				{
					id = 37,
					name = "Jiraiya",
					level = 75,
					image = Resources.BLJiraiya,
					release = new Fire(50),
					str = new Strength(88),
					agi = new Agility(98),
					sta = new Stamina(50),
					values = new Values[2]
					{
						new Agility(80),
						new PAtk(100)
					}
				},
				new Bloodline
				{
					id = 38,
					name = "Uchiha Itachi",
					level = 81,
					image = Resources.BLUchihaItachi,
					release = new Illusion(60),
					str = new Strength(90),
					agi = new Agility(120),
					sta = new Stamina(70),
					values = new Values[2]
					{
						new ArmorBreak(158),
						new Dodge(100)
					}
				},
				new Bloodline
				{
					id = 39,
					name = "Orochimaru",
					level = 81,
					image = Resources.BLOrochimaru,
					release = new Sealing(60),
					str = new Strength(70),
					agi = new Agility(90),
					sta = new Stamina(120),
					values = new Values[2]
					{
						new Defense(177),
						new PHP(125)
					}
				},
				new Bloodline
				{
					id = 40,
					name = "Sage Jiraiya",
					level = 82,
					image = Resources.BLSageJiraiya,
					release = new Fire(60),
					str = new Strength(90),
					agi = new Agility(70),
					sta = new Stamina(120),
					values = new Values[2]
					{
						new Defense(177),
						new Critical(100)
					}
				},
				new Bloodline
				{
					id = 41,
					name = "Pain",
					level = 82,
					image = Resources.BLPain,
					release = new Illusion(60),
					str = new Strength(70),
					agi = new Agility(120),
					sta = new Stamina(90),
					values = new Values[2]
					{
						new Dodge(100),
						new Stamina(100)
					}
				},
				new Bloodline
				{
					id = 42,
					name = "Hebi Sasuke",
					level = 84,
					image = Resources.BLHebiSasuke,
					release = new Lightning(60),
					str = new Strength(120),
					agi = new Agility(90),
					sta = new Stamina(70),
					values = new Values[2]
					{
						new Hit(158),
						new ArmorBreak(158)
					}
				},
				new Bloodline
				{
					id = 43,
					name = "Sage Naruto",
					level = 84,
					image = Resources.BLSageNaruto,
					release = new Wind(60),
					str = new Strength(120),
					agi = new Agility(70),
					sta = new Stamina(90),
					values = new Values[2]
					{
						new Strength(100),
						new Block(100)
					}
				},
				new Bloodline
				{
					id = 44,
					name = "Kabuto Yakushi",
					level = 86,
					image = Resources.BLKabutoYakushi,
					release = new Healing(60),
					str = new Strength(90),
					agi = new Agility(120),
					sta = new Stamina(70),
					values = new Values[2]
					{
						new Hit(158),
						new Speed(125)
					}
				},
				new Bloodline
				{
					id = 45,
					name = "Guren",
					level = 86,
					image = Resources.BLGuren,
					release = new Fire(60),
					str = new Strength(120),
					agi = new Agility(90),
					sta = new Stamina(70),
					values = new Values[2]
					{
						new Strength(100),
						new Critical(100)
					}
				},
				new Bloodline
				{
					id = 46,
					name = "Deva Pain",
					level = 86,
					image = Resources.BLDevaPain,
					release = new Healing(60),
					str = new Strength(60),
					agi = new Agility(90),
					sta = new Stamina(130),
					values = new Values[2]
					{
						new PHP(125),
						new Block(100)
					}
				},
				new Bloodline
				{
					id = 47,
					name = "Human Pain",
					level = 86,
					image = Resources.BLHumanPain,
					release = new Water(60),
					str = new Strength(100),
					agi = new Agility(90),
					sta = new Stamina(90),
					values = new Values[2]
					{
						new Dodge(100),
						new Stamina(100)
					}
				},
				new Bloodline
				{
					id = 48,
					name = "Asura Pain",
					level = 86,
					image = Resources.BLAsuraPain,
					release = new Fire(60),
					str = new Strength(130),
					agi = new Agility(90),
					sta = new Stamina(60),
					values = new Values[2]
					{
						new ArmorBreak(158),
						new Critical(100)
					}
				},
				new Bloodline
				{
					id = 49,
					name = "4th Raikage",
					level = 86,
					image = Resources.BLFourthRaikage,
					release = new Lightning(60),
					str = new Strength(80),
					agi = new Agility(130),
					sta = new Stamina(70),
					values = new Values[2]
					{
						new Agility(100),
						new Speed(125)
					}
				},
				new Bloodline
				{
					id = 50,
					name = "Preta Pain",
					level = 91,
					image = Resources.BLPretaPain,
					release = new Wind(70),
					str = new Strength(120),
					agi = new Agility(90),
					sta = new Stamina(150),
					values = new Values[2]
					{
						new PHP(150),
						new Block(120)
					}
				},
				new Bloodline
				{
					id = 51,
					name = "Naraka Pain",
					level = 91,
					image = Resources.BLNarakaPain,
					release = new Fire(70),
					str = new Strength(100),
					agi = new Agility(140),
					sta = new Stamina(120),
					values = new Values[2]
					{
						new Dodge(120),
						new Critical(120)
					}
				},
				new Bloodline
				{
					id = 52,
					name = "Animal Pain",
					level = 91,
					image = Resources.BLAnimalPain,
					release = new Lightning(70),
					str = new Strength(130),
					agi = new Agility(110),
					sta = new Stamina(120),
					values = new Values[2]
					{
						new Hit(189),
						new Defense(212)
					}
				},
				new Bloodline
				{
					id = 53,
					name = "Uzumaki Nagato",
					level = 91,
					image = Resources.BLUzumakiNagato,
					release = new Wind(70),
					str = new Strength(150),
					agi = new Agility(90),
					sta = new Stamina(120),
					values = new Values[2]
					{
						new ArmorBreak(189),
						new Hit(189)
					}
				},
				new Bloodline
				{
					id = 54,
					name = "Chiyo",
					level = 91,
					image = Resources.BLChiyo,
					release = new Healing(70),
					str = new Strength(120),
					agi = new Agility(80),
					sta = new Stamina(160),
					values = new Values[2]
					{
						new PHP(150),
						new Defense(212)
					}
				},
				new Bloodline
				{
					id = 55,
					name = "Kazekage Gaara",
					level = 91,
					image = Resources.BLKazekageGaara,
					release = new Earth(70),
					str = new Strength(140),
					agi = new Agility(80),
					sta = new Stamina(140),
					values = new Values[2]
					{
						new Stamina(120),
						new Block(120)
					}
				},
				new Bloodline
				{
					id = 56,
					name = "Black Zetsu",
					level = 91,
					image = Resources.BLBlackZetsu,
					release = new Taijutsu(70),
					str = new Strength(80),
					agi = new Agility(150),
					sta = new Stamina(130),
					values = new Values[2]
					{
						new Agility(120),
						new PHP(150)
					}
				},
				new Bloodline
				{
					id = 57,
					name = "White Zetsu",
					level = 91,
					image = Resources.BLWhiteZetsu,
					release = new Healing(70),
					str = new Strength(90),
					agi = new Agility(140),
					sta = new Stamina(130),
					values = new Values[2]
					{
						new Constitution(171),
						new Stamina(120)
					}
				},
				new Bloodline
				{
					id = 58,
					name = "Guy",
					level = 91,
					image = Resources.BLGuy,
					release = new Taijutsu(70),
					str = new Strength(110),
					agi = new Agility(160),
					sta = new Stamina(90),
					values = new Values[2]
					{
						new Agility(120),
						new Speed(150)
					}
				},
				new Bloodline
				{
					id = 59,
					name = "Uchiha Shisui",
					level = 91,
					image = Resources.BLUchihaShisui,
					release = new Illusion(70),
					str = new Strength(80),
					agi = new Agility(150),
					sta = new Stamina(130),
					values = new Values[2]
					{
						new PAtk(150),
						new Dodge(120)
					}
				},
				new Bloodline
				{
					id = 60,
					name = "Killer B",
					level = 91,
					image = Resources.BLKillerB,
					release = new Lightning(70),
					str = new Strength(150),
					agi = new Agility(120),
					sta = new Stamina(90),
					values = new Values[2]
					{
						new Hit(189),
						new PAtk(150)
					}
				},
				new Bloodline
				{
					id = 61,
					name = "Hatake Sakumo",
					level = 91,
					image = Resources.BLHatakeSakumo,
					release = new Lightning(70),
					str = new Strength(160),
					agi = new Agility(100),
					sta = new Stamina(100),
					values = new Values[2]
					{
						new Strength(120),
						new Critical(120)
					}
				},
				new Bloodline
				{
					id = 62,
					name = "Danzō",
					level = 101,
					image = Resources.BLDanzo,
					release = new Fire(80),
					str = new Strength(200),
					agi = new Agility(150),
					sta = new Stamina(100),
					values = new Values[2]
					{
						new Speed(175),
						new ArmorBreak(220)
					}
				},
				new Bloodline
				{
					id = 63,
					name = "Immortal Jiraiya",
					level = 101,
					image = Resources.BLImmortalJiraiya,
					release = new Earth(80),
					str = new Strength(150),
					agi = new Agility(200),
					sta = new Stamina(100),
					values = new Values[2]
					{
						new Stamina(140),
						new Defense(247)
					}
				},
				new Bloodline
				{
					id = 64,
					name = "Ōnoki",
					level = 101,
					image = Resources.BLOnoki,
					release = new Taijutsu(80),
					str = new Strength(150),
					agi = new Agility(100),
					sta = new Stamina(200),
					values = new Values[2]
					{
						new PAtk(175),
						new Critical(140)
					}
				},
				new Bloodline
				{
					id = 65,
					name = "Hanzo",
					level = 101,
					image = Resources.BLHanzo,
					release = new Healing(80),
					str = new Strength(200),
					agi = new Agility(100),
					sta = new Stamina(150),
					values = new Values[2]
					{
						new Agility(140),
						new Dodge(140)
					}
				},
				new Bloodline
				{
					id = 66,
					name = "Uchiha Madara",
					level = 101,
					image = Resources.BLUchihaMadara,
					release = new Illusion(80),
					str = new Strength(100),
					agi = new Agility(150),
					sta = new Stamina(200),
					values = new Values[2]
					{
						new PHP(175),
						new Strength(140)
					}
				},
				new Bloodline
				{
					id = 67,
					name = "1st Hokage",
					level = 101,
					image = Resources.BLShodaiHokage,
					release = new Lightning(80),
					str = new Strength(100),
					agi = new Agility(200),
					sta = new Stamina(150),
					values = new Values[2]
					{
						new Hit(220),
						new Block(140)
					}
				}
			};
		}
	}
}
