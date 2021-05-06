﻿using UnityEngine;

namespace Language.Variables {
    public class X : SpecialVariable<float> {
        Size _size;

        void SetSize() {
            _size = BoundGameObject.GetComponent<Size>();
        }

        readonly System.Action _setSizeOnce;
        
        protected override float InternalGet() {
            _setSizeOnce();

            return EngineAPI.GetSizePosConverter().PositionU2M(BoundGameObject.transform.position, _size.Height).x;
        }

        public override void Set(float value) {
            _setSizeOnce();

            var x = EngineAPI.GetSizePosConverter().PositionM2U(new Vector2(value, 0), _size.Height).x;
            var pos = BoundGameObject.transform.position;
            BoundGameObject.transform.position = new Vector3(x, pos.y, pos.z);
        }

        public X(GameObject gameObject, LogicEngine.LogicEngineAPI engineAPI) : base(gameObject, engineAPI) {
            _setSizeOnce = ((System.Action) SetSize).Once();
        }
    }
}