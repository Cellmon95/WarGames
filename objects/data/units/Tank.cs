using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data.units
{
	class Tank : Unit
	{
		public Tank()
		{
			Stats = new Stats();
			Size = new SFML.Window.Vector2f(32, 32);
			FillColor = Color.Black;

			initStats();
		}

		private void initStats()
		{
			Stats.Maxhealth = 10;
			Stats.AttackValue = 8;
			Stats.SpeedValue = 5;
			Stats.UnitPicture = Stats.Picture.SHERMAN_TANK;
		}
	}
}
