using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.objects.data;

namespace WarGames.objects.data.units
{
	class UnitRenderer:Drawable, IDisposable
	{
		private Unit data;
		private RectangleShape rectangleShape;

		public UnitRenderer(Unit data)
		{
			this.data = data;
			rectangleShape = new RectangleShape(data.Size);
			rectangleShape.Scale = data.Scale;
			rectangleShape.FillColor = data.FillColor;
			rectangleShape.Position = data.Position;
		}

		public virtual void Draw(RenderTarget target, RenderStates states)
		{
			rectangleShape.Position = data.Position;
			target.Draw(rectangleShape);
		}

		public void Dispose()
		{
			rectangleShape.Dispose();
		}
	}
}
