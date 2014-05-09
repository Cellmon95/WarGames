using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.core;
using WarGames.handlers;
using WarGames.interfaces;
using WarGames.objects;
using WarGames.objects.data;

namespace WarGames.screens
{
	class CombatScreen : IScreen
	{
		private Game game;
		private DataMaster dataMaster;
		private MasterRenderer masterRenderer;
		private UnitHandler unitHandler;
		private InterfaceHandler interfaceHandler;
		public CombatScreen(Game game)
		{
			this.game = game;

			dataMaster = new DataMaster(game);
			DataMaster = dataMaster;

			unitHandler = new UnitHandler(game, this);
			interfaceHandler = new InterfaceHandler(this);
			masterRenderer = new MasterRenderer(dataMaster);

			//what?
			InterfaceBar = dataMaster.InterfaceBar;

		}

		public void update()
		{
			dataMaster.update();
			unitHandler.update();
			interfaceHandler.update();
		}


		public void draw()
		{
			game.stage.Draw(masterRenderer);
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public DataMaster DataMaster { get; private set; }
		public InterfaceBar InterfaceBar { get; private set; }

		public UnitHandler UnitHandler { get { return unitHandler; } set { unitHandler = value; } }
	}
}
