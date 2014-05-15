using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.core;
using WarGames.objects.data;
using WarGames.objects.data.units;
using WarGames.screens;

namespace WarGames.handlers
{
	struct Vector3
	{
		private int x;
		private int y;
		private int z;

		public Vector3(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public int X { set { x = value; } get { return x; } }

		public int Y { set { y = value; } get { return y; } }

		public int Z { set { z = value; } get { return z; } }
	}
	class UnitHandler
	{
		private Game game;
		private Unit[] units;
		private Random rand;
		private CombatScreen screen;
		private objects.data.Unit selectedUnit;
		private Pathfinder pathfinder;

		private const int TILE_SIZE = 32;

		public UnitHandler(Game game, CombatScreen screen)
		{
			this.game = game;
			this.screen = screen;

			units = new Unit[6];
			rand = new Random();

			pathfinder = new Pathfinder(screen.DataMaster.map);

			//Fill units with infantery.
			//TODO:: make this better by able it to be filed with other units to
			for (int i = 0; i < units.Length; i++)
			{
				units[i] = new Infantery();
				units[i].Position = new SFML.Window.Vector2f(
					(float)Math.Round((double)rand.Next(0, 800/32)) * 32,
					(float)Math.Round((double)rand.Next(0, 640 / 32)) * 32);
			}

			units[units.Length - 1] = new Tank();
			units[units.Length - 1].Position = new SFML.Window.Vector2f(
	(float)Math.Round((double)rand.Next(0, 800 / 32)) * 32,
	(float)Math.Round((double)rand.Next(0, 640 / 32)) * 32);

			screen.DataMaster.Units = units;	
		}

		public void update()
		{
			for (int i = 0; i < units.Length; i++)
			{
				if (Input.checkIfClicked(units[i].Position, units[i].Size))
				{
					selectedUnit = units[i];
					screen.DataMaster.InterfaceBar.SelectedUnit = units[i];
				}
			}

			if (selectedUnit != null)
			{
				switch (CurrentUnitStatus)
				{
					case UnitStatus.MOVE:
						moveSelectedUnit();
						break;

					case UnitStatus.ATTACK:
						Console.WriteLine("bom bom");
						break;
					default:
						break;
				}
			}
		}

		private void moveSelectedUnit()
		{
			/*if (Input.hoverAtPosition())
			{
			}*/

			if (Input.checkIfPressed(screen.DataMaster.map.Position, screen.DataMaster.map.Size))
			{
				int smallesPath = pathfinder.calculateSmallestPath(
					screen.DataMaster.map.getTileByPosition(selectedUnit.Position),
					screen.DataMaster.map.getTileByPosition(Input.ClickedPos));

				if ( smallesPath <= selectedUnit.Stats.APValue)
				{
					//subtrakt move points from the ap value
					selectedUnit.Stats.APValue -= smallesPath;
					Console.WriteLine(selectedUnit.Stats.APValue);
					
					//move the unit
					selectedUnit.Position = new Vector2f(
						(float)((int)Input.ClickedPos.X / 32) * 32,
						(float)((int)Input.ClickedPos.Y / 32) * 32);
				}
			}
		}

		/// <summary>
		/// Change unit status. Status represent what the unit can do. If a unit can shoot it is in shooting status.
		/// </summary>
		public UnitStatus CurrentUnitStatus { get; set; }

		public enum UnitStatus
		{
			NONE,
			MOVE,
			ATTACK
		}
	}
}
