using generics.Interfaces;
namespace generics.Entities
{
    public class Group
    {
        public int Id;
        public string Name;
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Group()
        {
           
        }
        IRepository<Student, int> _students = new InMemoryRepository<Student, int>();
        public void AddStudent(Student s)
        {
            _students.Add(s.Id, s);
        }
        public void RemoveStudent(int studentId)
        {
            _students.Remove(studentId);
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _students.GetAll();
        }
        public Student FindStudent(int studentId)
        {
            return _students.Get(studentId);
        }
    }

}