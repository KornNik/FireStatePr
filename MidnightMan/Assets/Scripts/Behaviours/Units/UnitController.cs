﻿using UI;
using UnityEngine;

namespace Behaviours.Units
{
    [RequireComponent(typeof(UnitModel),typeof(UnitView))]
    class UnitController : MonoBehaviour
    {
        [SerializeField] private UnitModel _model;
        [SerializeField] private UnitView _view;

        public UnitModel Model => _model;
        public UnitView View => _view;

        private void Awake()
        {

        }
        private void Update()
        {
            _model.CharacterStateController.Update();
        }
        private void FixedUpdate()
        {
            _model.CharacterStateController.FixedUpdate();
        }

        private void LateUpdate()
        {
            _model.CharacterStateController.LateUpdate();
        }
    }
}
