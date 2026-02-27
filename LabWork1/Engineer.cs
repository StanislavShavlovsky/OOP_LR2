using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    public class Engineer : Person
    {
        public Engineer(int id, string fullName, int age)
            : base(id, fullName, age) { }

        public override string GetRole() => "Инженер";
    }
}

