using System.Data.Common;

namespace generics.Entities
{
    public class Person
    {
        public int Id;
        public string Name;

        public Person()
        {
            
        }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

}