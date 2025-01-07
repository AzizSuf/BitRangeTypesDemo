using BitRangeTypes;

namespace BitRangeTypesTest
{
    [TestClass]
    public sealed class UnsingTest
    {
        [TestMethod]
        public void TestMethod_1bit()
        {
            UBit<BitCount1> data1 = new();
            Assert.ThrowsException<OverflowException>(() => data1 = 2);
            Assert.ThrowsException<OverflowException>(() => data1 = 3);
            data1 = 0;
            Assert.AreEqual(0, (byte)data1);
            data1 = 1;
            Assert.AreEqual(1, (byte)data1);
        }

        [TestMethod]
        public void TestMethod_2bits()
        {
            UBit<BitCount2> data2 = new();
            Assert.ThrowsException<OverflowException>(() => data2 = 4);
            Assert.ThrowsException<OverflowException>(() => data2 = 10);
            data2 = 0;
            Assert.AreEqual(0, (byte)data2);
            data2 = 3;
            Assert.AreEqual(3, (byte)data2);
        }

        [TestMethod]
        public void TestMethod_3bits()
        {
            UBit<BitCount3> data3 = new();
            Assert.ThrowsException<OverflowException>(() => data3 = 8);
            Assert.ThrowsException<OverflowException>(() => data3 = 9);
            data3 = 7;
            Assert.AreEqual(7, (byte)data3);
            data3 = 0;
            Assert.AreEqual(0, (byte)data3);
        }

        [TestMethod]
        public void TestMethod_4bits()
        {
            UBit<BitCount4> data4 = new();
            Assert.ThrowsException<OverflowException>(() => data4 = 16);
            Assert.ThrowsException<OverflowException>(() => data4 = 17);
            data4 = 15;
            Assert.AreEqual(15, (byte)data4);
            data4 = 0;
            Assert.AreEqual(0, (byte)data4);
        }

        [TestMethod]
        public void TestMethod_5bits()
        {
            UBit<BitCount5> data5 = new();
            Assert.ThrowsException<OverflowException>(() => data5 = 32);
            Assert.ThrowsException<OverflowException>(() => data5 = 33);
            data5 = 31;
            Assert.AreEqual(31, (byte)data5);
            data5 = 0;
            Assert.AreEqual(0, (byte)data5);
        }

        [TestMethod]
        public void TestMethod_6bits()
        {
            UBit<BitCount6> data6 = new();
            Assert.ThrowsException<OverflowException>(() => data6 = 64);
            Assert.ThrowsException<OverflowException>(() => data6 = 65);
            data6 = 63;
            Assert.AreEqual(63, (byte)data6);
            data6 = 0;
            Assert.AreEqual(0, (byte)data6);
        }

        [TestMethod]
        public void TestMethod_7bits()
        {
            UBit<BitCount7> data7 = new();
            Assert.ThrowsException<OverflowException>(() => data7 = 128);
            Assert.ThrowsException<OverflowException>(() => data7 = 129);
            data7 = 127;
            Assert.AreEqual(127, (byte)data7);
            data7 = 0;
            Assert.AreEqual(0, (byte)data7);
        }

        [TestMethod]
        public void TestMethod_8bits()
        {
            UBit<BitCount8> data8 = new();

            // Can't assign
            //Assert.ThrowsException<OverflowException>(() => data8 = 256);  // 256 is out of range for 8 bits
            //Assert.ThrowsException<OverflowException>(() => data8 = 257);  // 257 is out of range for 8 bits

            data8 = 255;
            Assert.AreEqual(255, (byte)data8);
            data8 = 0;
            Assert.AreEqual(0, (byte)data8);
        }
    }
}
