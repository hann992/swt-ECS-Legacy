using NUnit.Framework;


namespace ECS.Legacy.Test
{
    public class Tests
    {
        private ECS uut;
        [SetUp]
        public void Setup()
        {
            uut = new ECS(23);
        }

        [Test]
        public void Test1()
        {
            uut.Regulate();
            var line1 = uut.Regulate();

        }
    }
}