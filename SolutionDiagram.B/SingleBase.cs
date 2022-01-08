﻿using SolutionDiagram.B.Interfaces;

namespace SolutionDiagram.B
{
    public class SingleBase<T> : ISingleBase<T>
    {
        public T Value { get; private set; }

        public SingleBase()
        {

        }

        public SingleBase(T value)
        {
            SetValue(value);
        }

        public virtual void SetValue(T value)
        {
            Value = value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}