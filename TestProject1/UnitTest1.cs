using hashingEX1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            hashTester testhash = new hashTester();
            testhash.EncodeHash("hej", "per");
            Assert.True(testhash.VerifyHash("hej", "per"));
            Assert.False(testhash.VerifyHash("hej", "per "));
            Assert.Equal(1, testhash.GetCount());
            testhash.EncodeHash(" ", " ");
            Assert.Equal(2, testhash.GetCount());
            Assert.True(testhash.VerifyHash(" ", " "));
            Assert.False(testhash.VerifyHash("", ""));
        }
        [Fact] 
        public void Test2() {
        
            hashTester testhash = new hashTester();
            string hej = "hej";
            Assert.NotEqual(hej, testhash.EncodeHash("he", "j"));
        }

        [Fact]
        public void Test3()
        {
            hashTester testhash = new hashTester();
            testhash.EncodeHash("rune", "rune");
            Assert.Equal(1,testhash.GetCount());
            testhash.DeleteUser("rune", "1");
            Assert.Equal(1,testhash.GetCount());
            testhash.DeleteUser("rune", "rune");
            Assert.Equal(0, testhash.GetCount());
        }
    }
}