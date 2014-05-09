using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data.gameinterface
{
	class AttackButton : Button
	{
		public AttackButton() : base(new Vector2f(400, 555), new Vector2f(120, 20), "Attack") { }
	}
}
