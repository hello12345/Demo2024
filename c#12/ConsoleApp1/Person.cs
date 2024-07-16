using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Primary Constructor for a non-record class
    public class Person(string name, int age)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;
    }
}
