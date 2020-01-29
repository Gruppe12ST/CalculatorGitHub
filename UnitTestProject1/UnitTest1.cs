using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        private Calculator uut;

        [SetUp]
        public void setUp()
        {
            //arrange
            uut = new RemovalFilter();

        }

    }
}
