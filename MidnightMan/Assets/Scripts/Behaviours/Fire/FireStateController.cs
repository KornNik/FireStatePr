using Controllers;
using Helpers;

namespace Behaviours
{
    class FireStateController : BaseStateController
    {
        private IFire _stateObject;
        private InputController _inputController;

        private BaseFireState _windState;
        private BaseFireState _waterState;
        private BaseFireState _defaultState;

        public FireStateController(IFire fireObject) : base()
        {
            _stateObject = fireObject;
            _inputController = Services.Instance.InputController.ServicesObject;

            StartState(_defaultState);
        }

        public IFire StateObject => _stateObject;
        public InputController InputController => _inputController;

        public BaseFireState WindState  => _windState; 
        public BaseFireState WaterState => _waterState; 
        public BaseFireState DefaultState  => _defaultState;

        protected override void InitializeStates()
        {
            _windState = new WindFireState(this);
            _waterState = new WaterFireState(this);
            _defaultState = new DefaultFireState(this);
        }
    }
}
