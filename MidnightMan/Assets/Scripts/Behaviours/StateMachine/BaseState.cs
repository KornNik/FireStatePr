﻿namespace Behaviours
{
    internal class BaseState<TStateController> : IState where TStateController : BaseStateController
    {
        protected TStateController _stateController;

        public BaseState(TStateController stateController)
        {
            _stateController = stateController;
        }

        public virtual void EnterState()
        {
        }

        public virtual void ExitState()
        {
        }

        public virtual void LogicFixedUpdate()
        {
        }
        public virtual void LogicUpdate()
        {
        }
        public virtual void LogicLateUpdate()
        {
        }
    }
}
