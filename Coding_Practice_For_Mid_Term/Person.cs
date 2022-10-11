using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice_For_Mid_Term
{
    class Person
    {
        string Name;

        public Person(string name)
        {
            this.Name = name;
        }

        public void ToStringName()
        {
            Console.WriteLine ("The name is : "+ Name);
        }

        ~Person()
        {
            Console.WriteLine("Destructor was called");
        }
    }
}
