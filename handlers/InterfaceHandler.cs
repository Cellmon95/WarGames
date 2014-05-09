using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.screens;
using WarGames.core;
using WarGames.objects.data.gameinterface;
namespace WarGames.handlers
{
	class InterfaceHandler
	{
		private CombatScreen screen;
		private objects.data.gameinterface.MoveButton moveButton;
		private Button curentSelectedButton;
 
		public InterfaceHandler(CombatScreen screen)
		{
			this.screen = screen;

			moveButton = screen.DataMaster.InterfaceBar.MoveButton;
			attackButton = screen.DataMaster.InterfaceBar.AttackButton;
		}

		public void update()
		{
			if (Input.checkIfPressed(moveButton.Position, moveButton.Size))
				selectButtonAndStatus(moveButton, UnitHandler.UnitStatus.MOVE);
			else if(Input.checkIfPressed(attackButton.Position, attackButton.Size))
				selectButtonAndStatus(attackButton, UnitHandler.UnitStatus.ATTACK);
		}

		private void selectButtonAndStatus(Button selectedButton, UnitHandler.UnitStatus status)
		{
			if (curentSelectedButton == null)
			{
				curentSelectedButton = selectedButton;
				curentSelectedButton.Selected = true;
				screen.UnitHandler.CurrentUnitStatus = status;
			}
			else if (selectedButton == curentSelectedButton)
			{
				curentSelectedButton.Selected = false;
				curentSelectedButton = null;
				screen.UnitHandler.CurrentUnitStatus = UnitHandler.UnitStatus.NONE;
			}
			else if (curentSelectedButton != null)
			{
				curentSelectedButton.Selected = false;
				curentSelectedButton = selectedButton;
				curentSelectedButton.Selected = true;
				screen.UnitHandler.CurrentUnitStatus = status;
			}

		}

		public AttackButton attackButton { get; set; }
	}
}
