﻿using Helpers;
using UI;

namespace Behaviours
{
    sealed class MenuState : BaseState<GameStateController>
    {
        public MenuState(GameStateController stateController) : base(stateController)
        {
        }
        public override void EnterState()
        {
            ScreenInterface.GetInstance().Execute(ScreenTypes.MainMenu);
        }

        public override void ExitState()
        {
        }

        public override void LogicFixedUpdate()
        {
        }

        public override void LogicUpdate()
        {
        }
    }
}