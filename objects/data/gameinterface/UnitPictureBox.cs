using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarGames.core;

namespace WarGames.objects.data
{
	class UnitPictureBox : Transformable
	{
		private Unit selectedUnit;
		private Sprite picture;

		public UnitPictureBox()
		{
			//frame = new RectangleShape(new SFML.Window.Vector2f(122, 122));
			Scale = new SFML.Window.Vector2f(122, 122);
			Position = new SFML.Window.Vector2f(32, 640 - 124);
			FillColor = Color.Black;
		}

		public Unit SelectedUnit
		{
			get
			{
				return selectedUnit;
			}

			set
			{
				selectedUnit = value;

				PictureInt = (int)selectedUnit.Stats.UnitPicture;
			}
		}

		public Sprite PictureSprite
		{
			get
			{
				return picture;
			}
		}

		private int PictureInt
		{
			set
			{
				switch (value)
				{
					case (int)Stats.Picture.INFANTERI:
						picture = new Sprite(Assets.InfantryText);
						picture.TextureRect = new IntRect(0, 0, 115, 115);
						picture.Position = new SFML.Window.Vector2f(Position.X + 3, Position.Y + 3);
						
						break;
					case (int)Stats.Picture.SHERMAN_TANK:
						picture = new Sprite(Assets.ShermanTankText);
						picture.TextureRect = new IntRect(50, 5, 115, 115);
						picture.Position = new SFML.Window.Vector2f(Position.X + 3, Position.Y + 3);
						break;
					default:
						break;
				}
			}
		}

		public Color FillColor { get; private set; }
	}
}
