using PrototypePatternExercise;
using System.Drawing;

namespace Exercise_3Tests
{
    public class Tests
    {
        [TestFixture]
        public class FirstTestSuite
        {
            [Test]
            public void Test()
            {
                var line1 = new Line
                {
                    Start = new PrototypePatternExercise.Point { X = 3, Y = 3 },
                    End = new PrototypePatternExercise.Point { X = 10, Y = 10 }
                };

                var line2 = line1.DeepCopy();
                line1.Start.X = line1.End.X = line1.Start.Y = line1.End.Y = 0;

                Assert.That(line2.Start.X, Is.EqualTo(3));
                Assert.That(line2.Start.Y, Is.EqualTo(3));
                Assert.That(line2.End.X, Is.EqualTo(10));
                Assert.That(line2.End.Y, Is.EqualTo(10));
            }
        }
    }
}