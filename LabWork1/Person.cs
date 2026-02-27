using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
        public class Person
        {
            protected int _id;
            protected string _fullName;
            protected int _age;

            public Person(int id, string fullName, int age)
            {
                _id = id;
                _fullName = fullName;
                _age = age;
            }

            public int GetId() => _id;
            public string GetFullName() => _fullName;
            public int GetAge() => _age;

            public virtual string GetRole() => "Сотрудник";
        }
}
