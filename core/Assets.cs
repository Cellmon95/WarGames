using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;
namespace WarGames.core
{
	class Assets
	{

		
		public static void load()
		{	
			InfantryText = new Texture("resources\\Infantry.jpg");
			ShermanTankText = new Texture("resources\\Tank_Sherman.jpg");
			ArialFont = new Font("resources\\fonts\\arial.ttf");
			
		}

		public static Font ArialFont { get; private set; }
		public static Texture InfantryText { get; private set; }
		public static Texture ShermanTankText { get; private set; }
	}
}
