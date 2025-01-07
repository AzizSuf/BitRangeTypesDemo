using BitRangeTypes;

namespace BitRangeTypesTest;

[TestClass]
public sealed class SignedTest
{
    [TestMethod]
    public void TestMethod_1bit()
    {
        SBit<BitCount1> data1 = new();
        Assert.ThrowsException<OverflowException>(() => data1 = 1);
        Assert.ThrowsException<OverflowException>(() => data1 = -2);
        data1 = 0;
        Assert.AreEqual(0, (sbyte)data1);
        data1 = -1;
        Assert.AreEqual(-1, (sbyte)data1);
    }

    [TestMethod]
    public void TestMethod_2bits()
    {
        SBit<BitCount2> data2 = new();
        Assert.ThrowsException<OverflowException>(() => data2 = 2);
        Assert.ThrowsException<OverflowException>(() => data2 = -3);
        data2 = 1;
        Assert.AreEqual(1, (sbyte)data2);
        data2 = 0;
        Assert.AreEqual(0, (sbyte)data2);
        data2 = -1;
        Assert.AreEqual(-1, (sbyte)data2);
        data2 = -2;
        Assert.AreEqual(-2, (sbyte)data2);
    }

    [TestMethod]
    public void TestMethod_3bits()
    {
        SBit<BitCount3> data3 = new();
        Assert.ThrowsException<OverflowException>(() => data3 = 4);
        Assert.ThrowsException<OverflowException>(() => data3 = -5);
        data3 = 3;
        Assert.AreEqual(3, (sbyte)data3);
        data3 = -4;
        Assert.AreEqual(-4, (sbyte)data3);
    }

    [TestMethod]
    public void TestMethod_4bits()
    {
        SBit<BitCount4> data4 = new();
        Assert.ThrowsException<OverflowException>(() => data4 = 8);
        Assert.ThrowsException<OverflowException>(() => data4 = -9);
        data4 = 7;
        Assert.AreEqual(7, (sbyte)data4);
        data4 = -8;
        Assert.AreEqual(-8, (sbyte)data4);
    }

    [TestMethod]
    public void TestMethod_5bits()
    {
        SBit<BitCount5> data5 = new();
        Assert.ThrowsException<OverflowException>(() => data5 = 16);
        Assert.ThrowsException<OverflowException>(() => data5 = -17);
        data5 = 15;
        Assert.AreEqual(15, (sbyte)data5);
        data5 = -16;
        Assert.AreEqual(-16, (sbyte)data5);
    }

    [TestMethod]
    public void TestMethod_6bits()
    {
        SBit<BitCount6> data6 = new();
        Assert.ThrowsException<OverflowException>(() => data6 = 32);
        Assert.ThrowsException<OverflowException>(() => data6 = -33);
        data6 = 31;
        Assert.AreEqual(31, (sbyte)data6);
        data6 = -32;
        Assert.AreEqual(-32, (sbyte)data6);
    }

    [TestMethod]
    public void TestMethod_7bits()
    {
        SBit<BitCount7> data7 = new();
        Assert.ThrowsException<OverflowException>(() => data7 = 64);
        Assert.ThrowsException<OverflowException>(() => data7 = -65);
        data7 = 63;
        Assert.AreEqual(63, (sbyte)data7);
        data7 = -64;
        Assert.AreEqual(-64, (sbyte)data7);
    }

    [TestMethod]
    public void TestMethod_8bits()
    {
        SBit<BitCount8> data8 = new();

        // Can't assign
        //Assert.ThrowsException<OverflowException>(() => data8 = 128);
        //Assert.ThrowsException<OverflowException>(() => data8 = -129);

        data8 = 127;
        Assert.AreEqual(127, (sbyte)data8);
        data8 = -128;
        Assert.AreEqual(-128, (sbyte)data8);
    }
}