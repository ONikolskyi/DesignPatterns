using BuilderMethodExercise;

namespace Exercise_1Tests
{
    public class Tests
    {
        [TestFixture]
        public class FirstTestSuite
        {
            private static string Preprocess(string s)
            {
                return s.Trim().Replace("\r\n", "\n");
            }

            [Test]
            public void EmptyTest()
            {
                var cb = new BuilderMethodExercise.MySolution.CodeBuilder("Foo");
                Assert.That(Preprocess(cb.ToString()), Is.EqualTo("public class Foo\n{\n}"));
            }

            [Test]
            public void PersonTest()
            {
                var cb = new BuilderMethodExercise.MySolution.CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
                Assert.That(Preprocess(cb.ToString()),
                  Is.EqualTo("public class Person\n{\n  public string Name;\n  public int Age;\n}"));
            }
        }
    }
}