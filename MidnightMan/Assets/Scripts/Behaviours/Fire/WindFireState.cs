using Helpers;
using UnityEngine;

namespace Behaviours
{
    class WindFireState : BaseFireState
    {
        private float _timeToExtinguish = 5f;

        private float _timesLeft;

        public WindFireState(FireStateController stateController) : base(stateController)
        {
            _timesLeft = _timeToExtinguish;
        }

        public override void EnterState()
        {
            base.EnterState();
        }
        public override void ExitState()
        {
            base.ExitState();
            _timesLeft = _timeToExtinguish;
        }
        public override void LogicUpdate()
        {
            base.LogicUpdate();
            WindExtinguishedFire();
        }
        protected override void HandleInput()
        {
            base.HandleInput();
            var isFiring = _stateController.InputController.InputActions.
                PlayerActionList[InputActionManagerPlayer.RELOAD].IsPressed();
            if (isFiring)
            {
                IgniteOnWind();
            }
            var isInspecting = _stateController.InputController.InputActions.
                PlayerActionList[InputActionManagerPlayer.INSPECT].IsPressed();
            if (isInspecting)
            {
                _timesLeft = _timeToExtinguish;
            }
        }

        private void WindExtinguishedFire()
        {
            Debug.Log(_timesLeft);
            if (_timesLeft > 0)
            {
                _timesLeft -= Time.deltaTime;
            }
            else
            {
                _stateController.StateObject.Extinguish();
            }
        }
        private void IgniteOnWind()
        {
            _timesLeft = _timeToExtinguish;
            _stateController.StateObject.Ignite();
        }
    }
}
