using UnityEngine;

namespace Behaviours
{
    [RequireComponent(typeof(Collider))]
    sealed class WindZone : FireInfluenceZone
    {
        protected override void OnEnterActions(IFire fireHandItem)
        {
            base.OnEnterActions(fireHandItem);
            fireHandItem.StateController.ChangeState(fireHandItem.StateController.WindState);
        }
        protected override void OnExitActions(IFire fireHandItem)
        {
            base.OnExitActions(fireHandItem);
            fireHandItem.StateController.ChangeState(fireHandItem.StateController.DefaultState);
        }
    }
}
