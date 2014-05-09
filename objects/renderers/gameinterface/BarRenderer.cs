using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.objects.data;

namespace WarGames.objects.data
{
	class BarRenderer : Drawable
	{
		private Bar data;
		private RectangleShape background;
		private RectangleShape content;

		public BarRenderer(Bar data)
		{
			this.data = data;
			background = new RectangleShape(data.Size);
			background.FillColor = data.BackroundColor;
			background.OutlineThickness = data.OutlineThicknes;
			background.OutlineColor = data.OutlineColor;
			background.Position = data.Position;
			background.Size = data.Size;

			content = new RectangleShape();
			content.FillColor = data.ContentColor;
			content.Position = new SFML.Window.Vector2f(data.Position.X, data.Position.Y);
			content.Size = new SFML.Window.Vector2f(data.Size.X -40, data.Size.Y);
		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			content.Size = data.ContentSize;
			target.Draw(background);
			target.Draw(content);
		}
	}
}
