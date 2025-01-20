using Behaviours;
using UnityEngine;

namespace Behaviour
{
    [RequireComponent(typeof(Collider),typeof(Rigidbody))]
    abstract class Item : MonoBehaviour, IInspectable
    {
        [SerializeField] private Collider _collider;
        [SerializeField] private Rigidbody _rigidbody;

        private void Awake()
        {
            if (_collider == null)
            {
                _collider = GetComponent<Collider>();
            }
            if(_rigidbody == null)
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
        }

        public void SetCollisionStatusWithObject(Collider collider, bool status)
        {
            Physics.IgnoreCollision(_collider, collider, status);
        }

        public virtual void Inspect()
        {

        }
        public virtual void StopInspect()
        {

        }
    }
}
