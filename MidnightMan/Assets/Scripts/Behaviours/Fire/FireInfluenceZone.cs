using UnityEngine;

namespace Behaviours
{
    [RequireComponent(typeof(Collider))]
    abstract class FireInfluenceZone : MonoBehaviour
    {
        [SerializeField] private Collider _collider;

        private void OnTriggerEnter(Collider other)
        {
            var fireObject = other.GetComponent<MonoBehaviour>();
            if (fireObject)
            {
                var fireHandItem = fireObject as IFire;
                if (fireHandItem != null)
                {
                    OnEnterActions(fireHandItem);
                }
            }
        }
        private void OnTriggerExit(Collider other)
        {
            var fireObject = other.GetComponent<MonoBehaviour>();
            if (fireObject)
            {
                var fireHandItem = fireObject as IFire;
                if (fireHandItem != null)
                {
                    if (fireHandItem.StateController.GetPreviousState() != fireHandItem.StateController.WindState)
                    {
                        OnExitActions(fireHandItem);
                    }
                }
            }
        }
        protected virtual void OnEnterActions(IFire fireHandItem)
        {

        }
        protected virtual void OnExitActions(IFire fireHandItem)
        {

        }
    }
}
