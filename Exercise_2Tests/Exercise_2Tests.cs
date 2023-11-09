using FactoryMethodExercise;

namespace Exercise_2Tests
{
    public class Tests
    {
        [TestFixture]
        public class FirstTestSuite
        {
            [Test]
            public void Test()
            {
                var pf = new PersonFactory();

                var p1 = pf.CreatePerson("Chris");
                Assert.That(p1.Name, Is.EqualTo("Chris"));
                Assert.That(p1.Id, Is.EqualTo(0));

                var p2 = pf.CreatePerson("Sarah");
                Assert.That(p2.Id, Is.EqualTo(1));
            }
        }
    }
}