using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Graphics;
using WarGames.objects.data;
using WarGames.objects.data.units;
using WarGames.objects.data.units;

namespace WarGames.objects.data
{
	class MasterRenderer : Drawable, IDisposable
	{
		private DataMaster dataMaster;
		private InfanteryRenderer infanteriRenderer;
		private MapRenderer mapRenderer;
		private InterfaceBarRenderer interfaceBarRenderer;
		private UnitRenderer[] UnitRenderers;

		public MasterRenderer(DataMaster dataMaster)
		{
			this.dataMaster = dataMaster;

			UnitRenderers = new UnitRenderer[dataMaster.Units.Length];

			mapRenderer = new MapRenderer(dataMaster.map);
			interfaceBarRenderer = new InterfaceBarRenderer(dataMaster.InterfaceBar);
			initUnitsRenderers();
		}

		private void initUnitsRenderers()
		{
			for (int i = 0; i < dataMaster.Units.Length; i++)
			{
				if (dataMaster.Units[i].GetType() == typeof(Infantery))
					UnitRenderers[i] = new InfanteryRenderer(dataMaster.Units[i] as Infantery);

				else if (dataMaster.Units[i].GetType() == typeof(Tank))
					UnitRenderers[i] = new TankRenderer(dataMaster.Units[i] as Tank);
			}
		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			target.Draw(mapRenderer);
			for (int i = 0; i < UnitRenderers.Length; i++)
			{
				target.Draw(UnitRenderers[i]);
			}
			target.Draw(interfaceBarRenderer);
		}

		public void Dispose()
		{
			mapRenderer.Dispose();
		}
	}
}
