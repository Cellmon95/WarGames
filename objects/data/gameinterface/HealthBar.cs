using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data
{
	class HealthBar : Bar
	{
		private Unit selectedUnit;

		public HealthBar() : base(Color.Red)
		{
			Position = new Vector2f(180, 525);
			Size = new Vector2f(180, 20);
			CurrentValue = 100;
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

				MaxValue = SelectedUnit.Stats.Maxhealth;
				CurrentValue = SelectedUnit.Stats.currentHealth;
			}
		}

		public void update()
		{
			if (SelectedUnit != null)
			{
				CurrentValue = SelectedUnit.Stats.currentHealth;
			}
		}
	}
}
