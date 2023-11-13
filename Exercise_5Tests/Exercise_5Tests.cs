using AdapterPatternExercise;
using NUnit.Framework;

namespace Exercise_5Tests
{
    [TestFixture]
    public class TestSuite
    {
        [Test]
        public void Test()
        {
            var sq = new Square { Side = 11 };
            var adapter = new SquareToRectangleAdapter(sq);
            Assert.That(adapter.Area(), Is.EqualTo(121));
        }
    }
}