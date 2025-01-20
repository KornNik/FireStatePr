using System;
using UnityEngine;

namespace Behaviours
{
    sealed class Fire : IFire
    {
        [SerializeField] private ParticleSystem _particleSystem;

        public ParticleSystem FireParticle => _particleSystem;
        public FireStateController StateController { get => StateController; private set => StateController = value; }

        private void Awake()
        {
            StateController = new FireStateController(this);
        }

        public void Extinguish()
        {

        }

        public void Ignite()
        {

        }
    }
}
