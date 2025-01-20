using Behaviour;
using UnityEngine;

namespace Behaviours
{
    sealed class HandleCandle : Item, IFire
    {
        [SerializeField] private ParticleSystem _particleSystem;

        private FireStateController _stateController;

        public ParticleSystem FireParticle => _particleSystem;
        public FireStateController StateController => _stateController;

        private void Awake()
        {
            _stateController = new FireStateController(this);
        }

        private void Update()
        {
            StateController.Update();
        }

        public override void Inspect()
        {
            base.Inspect();
        }

        public override void StopInspect()
        {
            base.StopInspect();
        }
        public void Extinguish()
        {
            FireParticle.Stop();
        }
        public void Ignite()
        {
            FireParticle.Play();
        }
    }
}
