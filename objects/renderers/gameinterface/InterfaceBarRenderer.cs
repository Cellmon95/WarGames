using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WarGames.objects.data;
using WarGames.objects.renderers.gameinterface;
namespace WarGames.objects.data
{
	class InterfaceBarRenderer: Drawable, IDisposable
	{
		private InterfaceBar data;
		private RectangleShape rectangleShape;
		private UnitPictureBoxRenderer unitPictureBoxRenderer;
		private HealthBarRenderer healthBarRenderer; 

		public InterfaceBarRenderer(InterfaceBar data)
		{
			this.data = data;
			rectangleShape = new RectangleShape();
			rectangleShape.Position = data.Position;
			rectangleShape.Size = data.Size;
			rectangleShape.FillColor = data.FillColor;

			unitPictureBoxRenderer = new UnitPictureBoxRenderer(data.UnitPictureBox);
			healthBarRenderer = new HealthBarRenderer(data.HealthBar);
			MoveButtonRenderer = new MoveButtonRenderer(data.MoveButton);
			AttackButtonRenderer = new AttackButtonRenderer(data.AttackButton);
		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			target.Draw(rectangleShape);
			target.Draw(unitPictureBoxRenderer);
			target.Draw(healthBarRenderer);
			target.Draw(MoveButtonRenderer);
			target.Draw(AttackButtonRenderer);
		}

		public void Dispose()
		{
			rectangleShape.Dispose();
		}

		public MoveButtonRenderer MoveButtonRenderer { get; set; }

		public AttackButtonRenderer AttackButtonRenderer { get; set; }
	}
}
