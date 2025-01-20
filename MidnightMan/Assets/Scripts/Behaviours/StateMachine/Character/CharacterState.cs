using Helpers;


namespace Behaviours.States
{
    abstract class CharacterState : BaseState<CharacterStateController>
    {
        protected CharacterState(CharacterStateController stateController) : base(stateController)
        {
        }
        public override void LogicUpdate()
        {
            base.LogicUpdate();
            MakeRotation();
            InputHandle();
        }
        public override void LogicLateUpdate()
        {
            base.LogicLateUpdate();
        }
        protected virtual void InputHandle()
        {
            Interact();
            Inspect();
        }

        private void Interact()
        {
            var isInteracting = _stateController.InputController.InputActions.
                PlayerActionList[InputActionManagerPlayer.INTERACT].IsPressed();
            if (isInteracting)
            {
                _stateController.StateObject.Interacter.CheckInteraction();
            }
        }
        private void Inspect()
        {
            var isInspecting = _stateController.InputController.InputActions.
                PlayerActionList[InputActionManagerPlayer.INSPECT].IsPressed();
        }
        private void MakeRotation()
        {
            _stateController.StateObject.Rotation.RotateTowardCamera();
        }
    }
}