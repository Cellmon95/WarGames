using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.objects.data.gameinterface
{
	class MoveButton : Button
	{
		public MoveButton() 
			: base(new Vector2f(400, 525), new Vector2f(120, 20), "Move")
		{

		}
	}
}
