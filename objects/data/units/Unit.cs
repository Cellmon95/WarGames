using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data
{
	class Unit : Transformable
	{
		protected Stats stats;
		//protected bool selected;

		public Unit()
		{
		}

		internal virtual void update()
		{
		}

		public enum Types
		{
			INFANTERI
		}

		public Types Type { get; private set; }
		public Color FillColor { get; protected set; }
		public Boolean Selected { get; set; }
		public Vector2f Size { get; set; }
		public Stats Stats { get; set; }
	}
}
