using System;

namespace CustomBinders.Models
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(Guid id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public Person()
        {
        }
    }
}
