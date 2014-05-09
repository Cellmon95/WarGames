using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data.gameinterface
{
    class Button : Transformable
    {
		private Boolean selected;
		public Button(Vector2f position, Vector2f size)
		{
			Position = position;
			Size = size;
			FillColor = Color.Black;
			OutlineColor = Color.Red;
			OutlineThicknes = 3;
		}

		public Button(Vector2f position, Vector2f size, String text)
		{
			Position = position;
			Size = size;
			FillColor = new Color(60, 60, 60);
			OutlineColor = new Color(153, 153, 153);
			OutlineThicknes = 3;
			Text = text;
			TextColor = new Color(204, 204, 204);
		}

		public Vector2f Size { get; private set; }
		public String Text { set; get; }

		public Color FillColor { get; private set; }

		public Color OutlineColor { get; private set; }

		public float OutlineThicknes { get; private set; }

		public Color TextColor { get; private set; }

		public bool Selected 
		{
			get
			{
				return selected;
			}

			set
			{
				selected = value;

				if (selected)
					FillColor = new Color(40, 40, 40);
				else
					FillColor = new Color(60, 60, 60);

			}
		}
	}
}
