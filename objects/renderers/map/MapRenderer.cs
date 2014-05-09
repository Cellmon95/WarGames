using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Graphics;
using SFML.Window;
using WarGames.objects.data;

namespace WarGames.objects.data
{
	class MapRenderer : Drawable, IDisposable
	{
		private Map data;
		private TileRenderer[,] tilesRenderers;
		public MapRenderer(Map data)
		{
			this.data = data;
			tilesRenderers = new TileRenderer[data.tiles.GetLength(0), data.tiles.GetLength(1)];
			createTileRenderers();
		}

		private void createTileRenderers()
		{
			for (int x = 0; x < data.tiles.GetLength(0); x++)
			{
				for (int y = 0; y < data.tiles.GetLength(1); y++)
				{
					tilesRenderers[x,y] = new TileRenderer(data.tiles[x, y]);
				}
			}
		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			for (int x = 0; x < tilesRenderers.GetLength(0); x++)
			{
				for (int y = 0; y < tilesRenderers.GetLength(1); y++)
				{
					target.Draw(tilesRenderers[x, y]);
				}
			}
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
