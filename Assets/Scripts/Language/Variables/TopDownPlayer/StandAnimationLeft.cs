﻿using Player;
using UnityEngine;

namespace Language.Variables.TopDownPlayer {
    public class StandAnimationLeft : SpecialVariable<string> {
        PlayerTopDownAnimation _playerAnimation;

        void SetPlayerAnimation() {
            _playerAnimation = BoundGameObject.GetComponent<PlayerTopDownAnimation>();
        }

        readonly System.Action _setPlayerAnimationOnce;
        
        protected override string SpecialGet() {
            _setPlayerAnimationOnce();

            return _playerAnimation.StandAnimationLeft;
        }

        protected override void SpecialSet(string value) {
            _setPlayerAnimationOnce();

            _playerAnimation.StandAnimationLeft.Value = value;
        }

        public StandAnimationLeft(GameObject gameObject, LogicEngine.LogicEngineAPI engineAPI) : base(gameObject, engineAPI) {
            _setPlayerAnimationOnce = ((System.Action) SetPlayerAnimation).Once();
        }
    }
}
