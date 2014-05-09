using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data
{
	class Stats
	{
		public int Maxhealth { get; set; }
		public int currentHealth { get; set; }

		public int AttackValue { get; set; }
		public int SpeedValue { get; set; }
		public int APValue { get; set; }
		public int MaxAPValue { get; set; }

		public Item[] Inventory { get; set; }

		public Picture UnitPicture { get; set; }

		public enum Picture
		{
			INFANTERI,
			SHERMAN_TANK
		}
	}
}
