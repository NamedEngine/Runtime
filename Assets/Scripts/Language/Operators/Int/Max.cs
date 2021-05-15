﻿using System;
using UnityEngine;

namespace Language.Operators {
    public class Max : Operator<int> {
        static readonly IValue[][] ArgTypes = {
            new IValue[] {new Value<int>()},
            new IValue[] {new Value<int>()},
        };

        public Max(GameObject gameObject, LogicEngine.LogicEngineAPI engineAPI, IValue[] values,
            bool constraintReference) : base(ArgTypes, gameObject, engineAPI, values, constraintReference) { }

        protected override int InternalGet() {
            return Math.Max((Value<int>) Arguments[0], (Value<int>) Arguments[1]);
        }
    }
}