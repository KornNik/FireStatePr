using Behaviour;
using Behaviours.States;
using Data;
using System.Collections.Generic;
using UnityEngine;

namespace Behaviours.Units
{
    abstract class UnitModel : MonoBehaviour
    {
        [SerializeField] private UnitData _unitData;
        [SerializeField] private Collider _collider;
        [SerializeField] private Transform _objectGrabTransform;

        protected Movement _movement;
        protected Rotation _rotation;
        protected IInteracter _interacter;
        protected IInspector _inspector;
        protected UnitItemHandler _itemHandler;
        protected UnitAttributesContainer _unitAttributes;
        protected CharacterStateController _characterStateController;


        protected List<IEventSubscription> _subsciptions;

        public Collider Collider => _collider;
        public UnitData UnitData => _unitData;
        public Rotation Rotation => _rotation;
        public Movement Movement => _movement;
        public IInspector Inspector => _inspector;
        public IInteracter Interacter => _interacter;
        public UnitItemHandler ItemHandler => _itemHandler;
        public UnitAttributesContainer UnitAttributes => _unitAttributes;
        public CharacterStateController CharacterStateController => _characterStateController;

        protected virtual void Awake()
        {
            InitializeComponents();
        }
        protected virtual void InitializeComponents()
        {
            _subsciptions = new List<IEventSubscription>(5);
            _unitAttributes = new UnitAttributesContainer(this);
            _characterStateController = new CharacterStateController(this);
            _interacter = new CharacterInteraction(this);
            _inspector = new PlayerInspector(this);
            _itemHandler = new UnitItemHandler(_objectGrabTransform, Collider);
            FillSubscriptions();
        }
        private void OnEnable()
        {
            foreach (var item in _subsciptions)
            {
                item.Subscribe();
            }
        }
        private void OnDisable()
        {
            foreach (var item in _subsciptions)
            {
                item.Unsubscribe();
            }
        }
        private void FillSubscriptions()
        {

        }
    }
}
