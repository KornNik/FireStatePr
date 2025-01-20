using Data;
using Helpers;
using Helpers.Extensions;
using UnityEngine;

namespace Behaviour
{
    class UnitItemHandler
    {
        private Item _itemInHand;
        private Transform _objectGrabTransform;
        private Collider _unitCollider;

        public Item ItemInHand => _itemInHand;

        public UnitItemHandler(Transform objectGrabTransform, Collider unitCollider)
        {
            _objectGrabTransform = objectGrabTransform;
            _unitCollider = unitCollider;
            SetHandleItem(null);
        }

        public void SetHandleItem(Item itemInHand)
        {
            var handleCandleRes = Services.Instance.DatasBundle.ServicesObject.
                GetData<DataResourcePrefabs>().GetHandleCandle();

            _itemInHand = GameObject.Instantiate(handleCandleRes, _objectGrabTransform).
                With(e => e.transform.position = _objectGrabTransform.position).
                With(e => e.transform.rotation = _objectGrabTransform.rotation);
            _itemInHand.SetCollisionStatusWithObject(_unitCollider, false);
        }

        public void IsnpectItemInHand()
        {
            if(!ReferenceEquals(_itemInHand, null))
            {
                _itemInHand.Inspect();
            }
        }
        public void StopInspection()
        {
            if (!ReferenceEquals(_itemInHand, null))
            {
                _itemInHand.StopInspect();
            }
        }
    }
}
