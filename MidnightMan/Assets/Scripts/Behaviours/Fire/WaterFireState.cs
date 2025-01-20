namespace Behaviours
{
    class WaterFireState : BaseFireState
    {
        public WaterFireState(FireStateController stateController) : base(stateController)
        {
        }
        public override void EnterState()
        {
            base.EnterState();
            _stateController.StateObject.Extinguish();
        }
    }
}
