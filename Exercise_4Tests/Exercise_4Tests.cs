using SingletonPatternExercise;

namespace Exercise_4Tests
{
    [TestFixture]
    public class FirstTestSuite
    {
        [Test]
        public void Test()
        {
            var obj = new object();
            Assert.IsTrue(SingletonTester.IsSingleton(() => obj));
            Assert.IsFalse(SingletonTester.IsSingleton(() => new object()));
        }
    }
}