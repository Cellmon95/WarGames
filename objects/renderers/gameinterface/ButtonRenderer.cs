using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.core;
using WarGames.objects.data.gameinterface;

namespace WarGames.objects.renderers.gameinterface
{
	class ButtonRenderer : Drawable, IDisposable
	{
		private RectangleShape body;
		private Text text;
		private Button data;

		public ButtonRenderer(Button data)
		{
			this.data = data;
			body = new RectangleShape();
			body.Position = data.Position;
			body.Size = data.Size;
			body.FillColor = data.FillColor;
			body.OutlineColor = data.OutlineColor;
			body.OutlineThickness = data.OutlineThicknes;

			text = new Text(data.Text, Assets.ArialFont);
			text.Position = new SFML.Window.Vector2f(data.Position.X + data.Size.X / 2 - 20, data.Position.Y - 3);
			text.CharacterSize = 18;
			text.Color = data.TextColor;

		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			body.FillColor = data.FillColor;

			target.Draw(body);
			target.Draw(text);
		}

		public void Dispose()
		{
			body.Dispose();
			text.Dispose();
		}
	}
}
