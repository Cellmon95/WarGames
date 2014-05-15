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
<<<<<<< HEAD
		{
			InfantryText = new Texture("resources\\Infantry.jpg");
			ShermanTankText = new Texture("resources\\Tank_Sherman.jpg");
			ArialFont = new Font("resources\\fonts\\arial.ttf");
=======
		{	
			InfantryText = new Texture("resources\\Infantry.jpg");
			ShermanTankText = new Texture("resources\\Tank_Sherman.jpg");
			ArialFont = new Font("resources\\fonts\\arial.ttf");
			
>>>>>>> c1409df34427d235b016516688328254a131965f
		}

		public static Font ArialFont { get; private set; }
		public static Texture InfantryText { get; private set; }
		public static Texture ShermanTankText { get; private set; }
	}
}
