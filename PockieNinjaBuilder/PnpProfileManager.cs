using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PockieNinjaBuilder
{
	public class PnpProfileManager
	{
		public PnpProfile currentProfile;

		public LinkedList<string> recentFiles;

		public PnpProfileManager()
		{
			currentProfile = new PnpProfile();
		}

		private string concat(int[] values)
		{
			string text = "";
			for (int i = 0; i < values.Length; i++)
			{
				text += values[i];
				if (i < values.Length - 1)
				{
					text += ";";
				}
			}
			return text;
		}

		private int[] part(string values)
		{
			string[] array = values.Split(';');
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Convert.ToInt32(array[i]);
			}
			return array2;
		}

		public void saveProfile(string path)
		{
			PnpProfile pnpProfile = currentProfile;
			StreamWriter streamWriter = new StreamWriter(path, false, Encoding.ASCII);
			pnpProfile.filename = Path.GetFileNameWithoutExtension(path);
			streamWriter.WriteLine(pnpProfile.filename);
			streamWriter.WriteLine(pnpProfile.level);
			streamWriter.WriteLine(pnpProfile.village);
			streamWriter.WriteLine(pnpProfile.tsunadebook);
			streamWriter.WriteLine(pnpProfile.title);
			streamWriter.WriteLine(pnpProfile.ninjarank);
			streamWriter.WriteLine(pnpProfile.outfit);
			streamWriter.WriteLine(pnpProfile.outfitlevel);
			streamWriter.WriteLine(pnpProfile.outfitstr);
			streamWriter.WriteLine(pnpProfile.outfitagi);
			streamWriter.WriteLine(pnpProfile.outfitsta);
			streamWriter.WriteLine(concat(pnpProfile.record));
			streamWriter.WriteLine(pnpProfile.bloodline1);
			streamWriter.WriteLine(pnpProfile.prayerstr1);
			streamWriter.WriteLine(pnpProfile.prayeragi1);
			streamWriter.WriteLine(pnpProfile.prayersta1);
			streamWriter.WriteLine(concat(pnpProfile.bloodsoul1));
			streamWriter.WriteLine(concat(pnpProfile.bloodsoullvl1));
			streamWriter.WriteLine(pnpProfile.bloodline2);
			streamWriter.WriteLine(pnpProfile.prayerstr2);
			streamWriter.WriteLine(pnpProfile.prayeragi2);
			streamWriter.WriteLine(pnpProfile.prayersta2);
			streamWriter.WriteLine(concat(pnpProfile.bloodsoul2));
			streamWriter.WriteLine(concat(pnpProfile.bloodsoullvl2));
			streamWriter.WriteLine(pnpProfile.bloodline3);
			streamWriter.WriteLine(pnpProfile.prayerstr3);
			streamWriter.WriteLine(pnpProfile.prayeragi3);
			streamWriter.WriteLine(pnpProfile.prayersta3);
			streamWriter.WriteLine(concat(pnpProfile.bloodsoul3));
			streamWriter.WriteLine(concat(pnpProfile.bloodsoullvl3));
			streamWriter.WriteLine(concat(pnpProfile.weapon));
			streamWriter.WriteLine(concat(pnpProfile.glove));
			streamWriter.WriteLine(concat(pnpProfile.ring));
			streamWriter.WriteLine(concat(pnpProfile.talisman));
			streamWriter.WriteLine(concat(pnpProfile.helm));
			streamWriter.WriteLine(concat(pnpProfile.armor));
			streamWriter.WriteLine(concat(pnpProfile.belt));
			streamWriter.WriteLine(concat(pnpProfile.boots));
			streamWriter.WriteLine(concat(pnpProfile.zantype));
			streamWriter.WriteLine(concat(pnpProfile.zanval));
			streamWriter.WriteLine(pnpProfile.pet);
			streamWriter.WriteLine(concat(pnpProfile.petskills));
			streamWriter.WriteLine(concat(pnpProfile.ban1));
			streamWriter.WriteLine(concat(pnpProfile.ban2));
			streamWriter.WriteLine(concat(pnpProfile.ban3));
			streamWriter.WriteLine(concat(pnpProfile.wings));
			streamWriter.WriteLine(concat(pnpProfile.forge));
			streamWriter.Flush();
			streamWriter.Close();
		}

		public void loadProfile(string path)
		{
			currentProfile = new PnpProfile();
			StreamReader streamReader = new StreamReader(path, Encoding.ASCII);
			currentProfile.filename = streamReader.ReadLine();
			currentProfile.level = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.village = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.tsunadebook = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.title = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.ninjarank = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.outfit = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.outfitlevel = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.outfitstr = Convert.ToDouble(streamReader.ReadLine());
			currentProfile.outfitagi = Convert.ToDouble(streamReader.ReadLine());
			currentProfile.outfitsta = Convert.ToDouble(streamReader.ReadLine());
			currentProfile.record = part(streamReader.ReadLine());
			currentProfile.bloodline1 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayerstr1 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayeragi1 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayersta1 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.bloodsoul1 = part(streamReader.ReadLine());
			currentProfile.bloodsoullvl1 = part(streamReader.ReadLine());
			currentProfile.bloodline2 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayerstr2 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayeragi2 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayersta2 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.bloodsoul2 = part(streamReader.ReadLine());
			currentProfile.bloodsoullvl2 = part(streamReader.ReadLine());
			currentProfile.bloodline3 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayerstr3 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayeragi3 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.prayersta3 = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.bloodsoul3 = part(streamReader.ReadLine());
			currentProfile.bloodsoullvl3 = part(streamReader.ReadLine());
			currentProfile.weapon = part(streamReader.ReadLine());
			currentProfile.glove = part(streamReader.ReadLine());
			currentProfile.ring = part(streamReader.ReadLine());
			currentProfile.talisman = part(streamReader.ReadLine());
			currentProfile.helm = part(streamReader.ReadLine());
			currentProfile.armor = part(streamReader.ReadLine());
			currentProfile.belt = part(streamReader.ReadLine());
			currentProfile.boots = part(streamReader.ReadLine());
			currentProfile.zantype = part(streamReader.ReadLine());
			currentProfile.zanval = part(streamReader.ReadLine());
			currentProfile.pet = Convert.ToInt32(streamReader.ReadLine());
			currentProfile.petskills = part(streamReader.ReadLine());
			if (!streamReader.EndOfStream)
			{
				currentProfile.ban1 = part(streamReader.ReadLine());
				currentProfile.ban2 = part(streamReader.ReadLine());
				currentProfile.ban3 = part(streamReader.ReadLine());
			}
			if (!streamReader.EndOfStream)
			{
				currentProfile.wings = part(streamReader.ReadLine());
			}
			if (!streamReader.EndOfStream)
			{
				currentProfile.forge = part(streamReader.ReadLine());
			}
			streamReader.Close();
		}
	}
}
