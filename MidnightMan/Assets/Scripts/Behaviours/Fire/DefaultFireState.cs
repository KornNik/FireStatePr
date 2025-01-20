using Helpers;

namespace Behaviours
{
    class DefaultFireState : BaseFireState
    {
        public DefaultFireState(FireStateController stateController) : base(stateController)
        {
        }
        public override void EnterState()
        {
            base.EnterState();
        }
        public override void LogicUpdate()
        {
            base.LogicUpdate();
            var isInteracting = _stateController.InputController.InputActions.
                PlayerActionList[InputActionManagerPlayer.FIRE].IsPressed();
            if (isInteracting)
            {
                _stateController.StateObject.Ignite();
            }
        }
    }
}
