using Behaviours.Units;
using Controllers;
using Helpers;

namespace Behaviours.States
{
    sealed class CharacterStateController : BaseStateController
    {
        private UnitModel _stateObject;
        private InputController _inputController;

        private CharacterState _idleState;
        private CharacterState _movementState;

        public CharacterState IdleState => _idleState;
        public CharacterState MovementState => _movementState;

        public UnitModel StateObject => _stateObject;
        public InputController InputController => _inputController;

        public CharacterStateController(UnitModel unitModel) : base()
        {
            _stateObject = unitModel;
            _inputController = Services.Instance.InputController.ServicesObject;

            StartState(_idleState);
        }

        protected override void InitializeStates()
        {
            _idleState = new IdleState(this);
            _movementState = new MovementState(this);
        }
    }
}