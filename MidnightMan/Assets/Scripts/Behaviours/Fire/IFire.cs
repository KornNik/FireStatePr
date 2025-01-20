using UnityEngine;

namespace Behaviours
{
    interface IFire
    {
        FireStateController StateController { get; }
        ParticleSystem FireParticle { get; }
        void Ignite();
        void Extinguish();
    }
}
