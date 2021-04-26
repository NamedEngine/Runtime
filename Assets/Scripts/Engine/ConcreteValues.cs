﻿public class ConcreteValue<T> : Value<T> {
    readonly T _value;
    
    public ConcreteValue(T value = default) {
        _value = value;
    }
    protected override T InternalGet() {
        return _value;
    }
}

public class NullValue : IValue {
    public bool Cast(IValue value) {
        return value == null;
    }
}