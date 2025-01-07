namespace BitRangeTypes
{
    class BaseBitCount { }
    class BitCount1 : BaseBitCount { }
    class BitCount2 : BaseBitCount { }
    class BitCount3 : BaseBitCount { }
    class BitCount4 : BaseBitCount { }
    class BitCount5 : BaseBitCount { }
    class BitCount6 : BaseBitCount { }
    class BitCount7 : BaseBitCount { }
    class BitCount8 : BaseBitCount { }


    struct UBit<BitCountT> where BitCountT : BaseBitCount
    {
        private byte val;
        public readonly static int MinValue;
        public readonly static int MaxValue;

        public UBit()
        {
            val = 0;
        }

        static UBit()
        {
            if (typeof(BitCountT) == typeof(BitCount1))
            {
                MinValue = 0;
                MaxValue = 1;
            }
            else if (typeof(BitCountT) == typeof(BitCount2))
            {
                MinValue = 0;
                MaxValue = 3;
            }
            else if (typeof(BitCountT) == typeof(BitCount3))
            {
                MinValue = 0;
                MaxValue = 7;
            }
            else if (typeof(BitCountT) == typeof(BitCount4))
            {
                MinValue = 0;
                MaxValue = 15;
            }
            else if (typeof(BitCountT) == typeof(BitCount5))
            {
                MinValue = 0;
                MaxValue = 31;
            }
            else if (typeof(BitCountT) == typeof(BitCount6))
            {
                MinValue = 0;
                MaxValue = 63;
            }
            else if (typeof(BitCountT) == typeof(BitCount7))
            {
                MinValue = 0;
                MaxValue = 127;
            }
            else if (typeof(BitCountT) == typeof(BitCount8))
            {
                MinValue = 0;
                MaxValue = 255;
            }
            else
            {
                throw new Exception();
            }
        }

        private byte Value
        {
            get => val;

            set
            {
                if (value >= MinValue && value <= MaxValue)
                {
                    val = value;
                }
                else
                {
                    throw new OverflowException();
                }
            }
        }

        public static implicit operator UBit<BitCountT>(byte val)
        {
            var res = new UBit<BitCountT>();
            res.Value = val;
            return res;
        }

        public static implicit operator byte(UBit<BitCountT> val)
        {
            return val.Value;
        }
    }


    struct SBit<BitCountT> where BitCountT : BaseBitCount
    {
        private sbyte val;
        public readonly static int MinValue;
        public readonly static int MaxValue;

        public SBit()
        {
            val = 0;
        }

        static SBit()
        {
            if (typeof(BitCountT) == typeof(BitCount1))
            {
                MinValue = -1;
                MaxValue = 0;
            }
            else if (typeof(BitCountT) == typeof(BitCount2))
            {
                MinValue = -2;
                MaxValue = 1;
            }
            else if (typeof(BitCountT) == typeof(BitCount3))
            {
                MinValue = -4;
                MaxValue = 3;
            }
            else if (typeof(BitCountT) == typeof(BitCount4))
            {
                MinValue = -8;
                MaxValue = 7;
            }
            else if (typeof(BitCountT) == typeof(BitCount5))
            {
                MinValue = -16;
                MaxValue = 15;
            }
            else if (typeof(BitCountT) == typeof(BitCount6))
            {
                MinValue = -32;
                MaxValue = 31;
            }
            else if (typeof(BitCountT) == typeof(BitCount7))
            {
                MinValue = -64;
                MaxValue = 63;
            }
            else if (typeof(BitCountT) == typeof(BitCount8))
            {
                MinValue = -128;
                MaxValue = 127;
            }
            else
            {
                throw new Exception();
            }
        }

        private sbyte Value
        {
            get => val;

            set
            {
                if (value >= MinValue && value <= MaxValue)
                {
                    val = value;
                }
                else
                {
                    throw new OverflowException();
                }
            }
        }

        public static implicit operator SBit<BitCountT>(sbyte val)
        {
            var res = new SBit<BitCountT>();
            res.Value = val;
            return res;
        }

        public static implicit operator sbyte(SBit<BitCountT> val)
        {
            return val.Value;
        }
    }
}
