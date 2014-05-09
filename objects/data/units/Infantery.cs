using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WarGames.core;

using SFML.Window;
using SFML.Graphics;
namespace WarGames.objects.data
{
	class Infantery : Unit
	{	
		public Infantery()
		{
			Position = new Vector2f(200, 300);
			Size = new Vector2f(32, 32);
			FillColor = Color.Red;

			initStats();
			
		}

		private void initStats()
		{
			Stats = new Stats();
			Stats.Maxhealth = 100;
			Stats.currentHealth = 100;
			Stats.AttackValue = 0;
			Stats.SpeedValue = 3;
			Stats.MaxAPValue = 8;
			Stats.APValue = Stats.MaxAPValue;
			Stats.UnitPicture = data.Stats.Picture.INFANTERI;
		}

		override internal void update()
		{
			//Position = new Vector2f(Position.X, Position.Y);
		}


	}
}
