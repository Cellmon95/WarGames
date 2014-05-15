using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace WarGames.core
{
	class Assets
	{


		public static void load()
		{
			/*InfantryText = new Texture("C:\\Users\\Fredrik\\Documents\\GitHub\\GymnasieArbete\\WarGames\\WarGames\\Infantry.jpg");
			*/ShermanTankText = new Texture("Tank_Sherman.jpg");/*
			ArialFont = new Font("C:\\Users\\Fredrik\\Documents\\GitHub\\GymnasieArbete\\WarGames\\WarGames\\arial.ttf");*/

		}

		public static Font ArialFont { get; private set; }
		public static Texture InfantryText { get; private set; }
		public static Texture ShermanTankText { get; private set; }
	}
}
