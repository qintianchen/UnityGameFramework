using UnityEngine;

namespace QTC.FixedPointScaleVersion
{
    public struct FPVector3
    {
        public FixedPoint x;
        public FixedPoint y;
        public FixedPoint z;

        public FPVector3(FixedPoint x, FixedPoint y, FixedPoint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public FPVector3(Vector3 vec)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = vec.z;
        }
        
        public FixedPoint this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    case 2:
                        return z;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    case 2:
                        z = value;
                        break;
                }
            }
        }
        
        #region 常用向量
        public static FPVector3 zero
        {
            get { return new FPVector3(0, 0, 0); }
        }
        public static FPVector3 one
        {
            get { return new FPVector3(1, 1, 1); }
        }
        public static FPVector3 right
        {
            get { return new FPVector3(1, 0, 0); }
        }
        public static FPVector3 left
        {
            get { return new FPVector3(-1, 0, 0); }
        }
        public static FPVector3 front
        {
            get { return new FPVector3(0, 0, 1); }
        }
        public static FPVector3 back
        {
            get { return new FPVector3(0, 0, -1); }
        }
        public static FPVector3 up
        {
            get { return new FPVector3(0, 1, 0); }
        }
        public static FPVector3 down
        {
            get { return new FPVector3(0, -1, 0); }
        }
        #endregion
    }
}