namespace generics.Entities
{
    public class Student:Person
    {
        public Student(int id, string name) : base(id, name)
        {

        }
        public Student() : base(0, "None") 
        { 

        }
        public void SubmitWork()
        {
            Console.WriteLine($"Sumbited {Name}'s work");
        }
        public void SayName()
        {
            Console.WriteLine($"Name {Name}");
        }
    }
}