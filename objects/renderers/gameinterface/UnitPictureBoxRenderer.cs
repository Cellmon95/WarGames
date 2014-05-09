using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.objects.data;

using SFML.Graphics;
using WarGames.core;
namespace WarGames.objects.data
{
	class UnitPictureBoxRenderer : Drawable
	{
		private UnitPictureBox data;
		private RectangleShape frame;
		private Sprite curentPicture;

		public UnitPictureBoxRenderer(UnitPictureBox data)
		{
			this.data = data;
			frame = new RectangleShape(data.Scale);
			frame.Position = data.Position;
			frame.FillColor = data.FillColor;

			curentPicture = new Sprite(new Texture(128, 128));
			
		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			if (data.PictureSprite != null)
				curentPicture = data.PictureSprite;
	
			target.Draw(frame);
			target.Draw(curentPicture);
		}
	}
}
