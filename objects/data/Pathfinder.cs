using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data
{
	class Pathfinder
	{
		private List<Tile> openList;
		private List<Tile> closeList;
		private Map map;

		public Pathfinder(Map map)
		{
			this.map = map;
			openList = new List<Tile>();
			closeList = new List<Tile>();
		}

		public int calculateSmallestPath(Tile start, Tile target)
		{
			reset();

			if (target == start)
				return 0;

			StartingTile = start;
			TargetTile = target;
			CheckingTile = StartingTile;

			while (!FoundTarget)
			{
				findPath();
			}

			//Console.WriteLine(TargetTile.FValue);
			return traceBack();
		}

		private void findPath()
		{
			for (int i = 0; i < CheckingTile.Children.Length; i++)
			{
				determenTileValue(CheckingTile, CheckingTile.Children[i]); 
			}

			if (!FoundTarget)
			{
				closeList.Add(CheckingTile);
				openList.Remove(CheckingTile);

				CheckingTile = getSmallestFValueTile();
			}
		}



		private void determenTileValue(Tile currentTile, Tile testingTile)
		{
			if (testingTile == null)
			{
				return;
			}

			if (testingTile == TargetTile)
			{
				testingTile.Parent = currentTile;
				FoundTarget = true;
				return;
			}

			if (!closeList.Contains(testingTile))
			{
				if (openList.Contains(testingTile))
				{
					int newGCost = currentTile.GValue + currentTile.BaseGvalue;

					if (newGCost < testingTile.GValue)
					{
						testingTile.Parent = currentTile;
						testingTile.GValue = newGCost;
						testingTile.calculateFValue();
					}
				}

				else
				{
					testingTile.Parent = currentTile;
					testingTile.GValue = currentTile.GValue + currentTile.BaseGvalue;
					testingTile.calculateFValue();
					openList.Add(testingTile);
				}
			}
		}

		private Tile getSmallestFValueTile()
		{
			int j;
			Tile newValue;

			Console.WriteLine(openList.Count);
			if (openList.Count > 0)
			{
				for (int i = 1; i < openList.Count; i++)
				{
					newValue = openList[i];
					j = i;
					while (j > 0 && openList[j - 1].FValue > newValue.FValue)
					{
						openList[j] = openList[j - 1];
						j--;
					}
					openList[j] = newValue;
				}
				return openList[0];
			}
			return null;
		}


		/// <summary>
		/// Trace back the path and returns the number of steps
		/// </summary>
		/// <returns></returns>
		private int traceBack()
		{
			Tile tile = TargetTile;
			int count = -1;

			do
			{
				tile = tile.Parent;
				count++;
			}
			while (tile != null);

			return count;
		}

		private void reset()
		{
			map.resetTiles();
			openList.Clear();
			closeList.Clear();
			FoundTarget = false;
			TargetTile = null;
		}
		public Tile CheckingTile { get; private set; }
		public Tile StartingTile { get; private set; }
		public Tile TargetTile { get; private set; }
		public bool FoundTarget { get; private set; }
	}
}
