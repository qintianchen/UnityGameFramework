using System;
using TrueSync;
using UnityEngine;

namespace QTC.FixedPointScaleVersion
{
    // 定点数实现
    public struct FixedPoint
    {
        // 示例给了 0.2 * 0.3 通过先乘1000再除1000的方式来规避小数操作
        // 但是如果是 0.0002 * 0.0003怎么办呢？
        // 老师说先暂定1000，后面小数的影响也不是很大，定一个1000基本是够用的

        private long m_scaledValue;

        public long scaledValue
        {
            get { return m_scaledValue; }
            set { m_scaledValue = value; }
        }

        public int rawInt // 序列化数值，仅在显示的时候会用到，其余的操作全部都是对放大后的数值进行操作
        {
            get
            {
                // 因为计算机内部正数和负数的表示方法不一样（原码和补码），我们需要对位操作做特殊处理
                return (int) RBitOperate(scaledValue, BIT_MOVE_COUNT);
            }
        }

        public float rawFloat // 序列化数值，仅在显示的时候会用到，其余的操作全部都是对放大后的数值进行操作
        {
            get { return RBitOperate(scaledValue, BIT_MOVE_COUNT); }
        }

        private const int BIT_MOVE_COUNT = 10; // scale 通过位操作实现，该变量规定了位操作的位数
        private const long MULTIPLIED_FACTOR = 1 << BIT_MOVE_COUNT; // 放大的系数

        private static long LBitOperate(long val, int bitCount)
        {
            if (val >= 0) return val << bitCount;

            return -(-val << bitCount);
        }

        private static int LBitOperate(int val, int bitCount)
        {
            if (val >= 0) return val << bitCount;

            return -(-val << bitCount);
        }

        private static long RBitOperate(long val, int bitCount)
        {
            if (val >= 0) return val >> bitCount;

            return -(-val >> bitCount);
        }

        private static int RBitOperate(int val, int bitCount)
        {
            if (val >= 0) return val >> bitCount;

            return -(-val >> bitCount);
        }


        #region 构造函数（广义）

        public FixedPoint(int val)
        {
            m_scaledValue = val * MULTIPLIED_FACTOR;
        }

        public FixedPoint(long val)
        {
            m_scaledValue = val * MULTIPLIED_FACTOR;
        }

        public FixedPoint(float val)
        {
            m_scaledValue = (long) Math.Round(val * MULTIPLIED_FACTOR); // 所有的浮点乘以倍数之后，抛弃剩余的所有的小数部分
        }

        public FixedPoint(double val)
        {
            m_scaledValue = (long) Math.Round(val * MULTIPLIED_FACTOR); // 所有的浮点乘以倍数之后，抛弃剩余的所有的小数部分
        }

        private static FixedPoint FromScaledValue(long scaledValue)
        {
            var fp = new FixedPoint {m_scaledValue = scaledValue};
            return fp;
        }

        #endregion

        #region 隐式/显式转换

        public static explicit operator FixedPoint(double val)
        {
            return new FixedPoint(val);
        }

        public static implicit operator FixedPoint(float val)
        {
            return new FixedPoint(val);
        }

        public static implicit operator FixedPoint(int val)
        {
            return new FixedPoint(val);
        }

        public static implicit operator double(FixedPoint val)
        {
            return val.rawInt;
        }

        public static implicit operator float(FixedPoint val)
        {
            return val.rawInt;
        }

        public static implicit operator int(FixedPoint val)
        {
            return (int) val.rawInt;
        }

        #endregion

        #region 赋值运算符（广义）

        public static FixedPoint operator -(FixedPoint val)
        {
            return FromScaledValue(-val.m_scaledValue);
        }

        public static FixedPoint operator -(FixedPoint a, FixedPoint b)
        {
            return FromScaledValue(a.scaledValue - b.scaledValue);
        }

        public static FixedPoint operator +(FixedPoint a, FixedPoint b)
        {
            return FromScaledValue(a.scaledValue + b.scaledValue);
        }

        public static FixedPoint operator *(FixedPoint a, FixedPoint b)
        {
            long value = a.scaledValue * b.scaledValue;
            value = RBitOperate(value, BIT_MOVE_COUNT);
            return FromScaledValue(value);
        }

        public static FixedPoint operator /(FixedPoint a, FixedPoint b)
        {
            if (b.scaledValue == 0)
            {
                throw new Exception("Divisor should not be zero");
            }

            long value = (long) ((double) a.scaledValue / b.scaledValue);
            value = LBitOperate(value, BIT_MOVE_COUNT);
            return FromScaledValue(value);
        }

        public static bool operator ==(FixedPoint a, FixedPoint b)
        {
            return a.scaledValue == b.scaledValue;
        }

        public override bool Equals(object obj)
        {
            return obj switch
            {
                null => false,
                FixedPoint val => val == this,
                _ => false
            };
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator !=(FixedPoint a, FixedPoint b)
        {
            return !(a == b);
        }

        public static bool operator <(FixedPoint a, FixedPoint b)
        {
            return a.scaledValue < b.scaledValue;
        }

        public static bool operator <=(FixedPoint a, FixedPoint b)
        {
            return a.scaledValue <= b.scaledValue;
        }

        public static bool operator >(FixedPoint a, FixedPoint b)
        {
            return a.scaledValue > b.scaledValue;
        }

        public static bool operator >=(FixedPoint a, FixedPoint b)
        {
            return a.scaledValue >= b.scaledValue;
        }

        public static FixedPoint operator >>(FixedPoint val, int bitCount)
        {
            return FromScaledValue(RBitOperate(val.scaledValue, bitCount));
        }

        public static FixedPoint operator <<(FixedPoint val, int bitCount)
        {
            return FromScaledValue(LBitOperate(val.scaledValue, bitCount));
        }

        #endregion

        public override string ToString()
        {
            return rawInt.ToString();
        }
    }
}