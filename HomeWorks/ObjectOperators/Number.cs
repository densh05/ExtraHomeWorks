using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ObjectOperators
{
    struct Number
    {
        public int Value { get; }
        public string Description { get; }
        public bool IsPositive => Value > 0;

        public Number(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            if (IsPositive)
                return Value.ToString();
            else
                return "Negative: " + Value.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Number other)
            {
                return this == other;
            }

            return false;
        }

        public static implicit operator int(Number number)
        {
            return number.Value;
        }

        public static explicit operator Number(int value)
        {
            return new Number(value);
        }

        public static Number operator +(Number a, Number b)
        {
            return new Number (a.Value + b.Value);
        }
        public static Number operator -(Number a, Number b)
        {
            return new Number(a.Value - b.Value);
        }
        public static Number operator *(Number a, Number b)
        {
            return new Number(a.Value * b.Value);
        }
        public static Number operator /(Number a, Number b)
        {
            return new Number(a.Value / b.Value);
        }
        public static Number operator %(Number a, Number b)
        {
            return new Number(a.Value % b.Value);
        }
        public static Number operator ++(Number a)
        {
            return new Number(a.Value + 1);
        }
        public static Number operator --(Number a)
        {
            return new Number(a.Value - 1);
        }
        public static bool operator ==(Number a, Number b)
        {
            return a.Value == b.Value;
        }
        public static bool operator !=(Number a, Number b)
        {
            return a.Value != b.Value;
        }
        public static bool operator >(Number a, Number b)
        {
            return a.Value > b.Value;
        }
        public static bool operator <(Number a, Number b)
        {
            return a.Value < b.Value;
        }
        public static bool operator >=(Number a, Number b)
        {
            return a.Value >= b.Value;
        }
        public static bool operator <=(Number a, Number b)
        {
            return a.Value <= b.Value;
        }
    }
}