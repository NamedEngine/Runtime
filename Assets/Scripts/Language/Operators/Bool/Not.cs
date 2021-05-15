﻿using UnityEngine;

namespace Language.Operators {
    public class Not : Operator<bool> {
        static readonly IValue[][] ArgTypes = {
            new IValue[] {new Value<bool>()},
        };

        public Not(GameObject gameObject, LogicEngine.LogicEngineAPI engineAPI, IValue[] values,
            bool constraintReference) : base(ArgTypes, gameObject, engineAPI, values, constraintReference) { }

        protected override bool InternalGet() {
            return !(Value<bool>) Arguments[0];
        }
    }
}