namespace Behaviours
{
    abstract class BaseFireState : BaseState<FireStateController>
    {
        public BaseFireState(FireStateController stateController) : base(stateController)
        {

        }
        public override void LogicUpdate()
        {
            base.LogicUpdate();
            HandleInput();
        }
        protected virtual void HandleInput()
        {

        }
    }
}
