using PracticeJenkins;

namespace jenkinsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_Print_1()
        {
            Jenkins ob = new Jenkins();
            string result = ob.Print(2);
            Assert.AreEqual("sanjaisanjai", result);
        }


        [Test]
        public void Test_Print_2()
        {
            Jenkins ob = new Jenkins();
            string result = ob.Print(1);
            Assert.AreEqual("sanjai", result);
        }
    }
}