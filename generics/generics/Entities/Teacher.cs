using generics.Interfaces;
namespace generics.Entities
{
   public  class Teacher:Person
    {
        public Teacher(int id, string name) : base(id, name)
        {

        }
        public int GradeStudent(string name)
        {
            return 100;
        }
        public string ExpelStudent(string name)
        {
            return $"{name} has been expelled.";
        }
        public void ShowPresentStudents()
        {
            Console.WriteLine("There....");
        }
    }
}