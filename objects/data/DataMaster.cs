using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data
{
	class DataMaster
	{
		public Map map { get; set; }
		private WarGames.core.Game game;
		public DataMaster(WarGames.core.Game game)
		{
			this.game = game;

			//make sure the map is as big as the screen is
			map = new Map(new Vector2i(
				(int)Math.Round((float)(game.stage.Size.X / 32)),
				(int)Math.Round((float)(game.stage.Size.Y / 32) - 4)
				));
			InterfaceBar = new InterfaceBar();
		}

		internal void update()
		{
			foreach (Unit unit in Units)
			{
				unit.update();
			}
			InterfaceBar.update();
		}

		public Unit[] Units { set; get; }
		public InterfaceBar InterfaceBar { get; set; }
	}
}
