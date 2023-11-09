using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    public class PersonFactory
    {
        private int _id = 0;
        public Person CreatePerson(string name)
        {
            return new Person() { Id = _id++, Name = name };
        }
    }
}
