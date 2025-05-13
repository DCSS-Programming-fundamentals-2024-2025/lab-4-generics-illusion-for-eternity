using System.Dynamic;
using generics.Entities;

class Program
{
    static void Main(string[] args)
    {
        // Смаль Софія
        var fpm = new Faculty(1, "ФПМ");
        var kp41 = new Group(41, "КП-41");
        var kp42 = new Group(42, "КП-42");
        var kp43 = new Group(43, "КП-43");

        fpm.AddGroup(kp41);
        fpm.AddGroup(kp42);
        fpm.AddGroup(kp43);

        var s1 = new Student(1, "Смаль Софія");
        var s2 = new Student(2, "Кожина Зоряна");
        var s3 = new Student(3, "Рандомний студентт");

        fpm.AddStudentToGroup(41, s1);
        fpm.AddStudentToGroup(41, s2);
        fpm.AddStudentToGroup(42, s3);

        Console.WriteLine("group КП-41:");
        foreach (var student in fpm.GetAllStudentsInGroup(41))
        {
            Console.WriteLine($"{student.Id} -> {student.Name}");
        }

        Console.WriteLine("\ngroup КП-42:");
        foreach (var student in fpm.GetAllStudentsInGroup(42))
        {
            Console.WriteLine($"{student.Id} -> {student.Name}");
        }

        Console.WriteLine("\ngroup КП-43:");
        var studentsKp43 = fpm.GetAllStudentsInGroup(43);
        if (!studentsKp43.Any())
        {
            Console.WriteLine("None.");
        }

        // Read-only інтерфейс (коваріантність)
        IReadOnlyRepository<Student, int> studRepo = new InMemoryRepository<Student, int>();
        IReadOnlyRepository<Person, int> persRepo = studRepo;

        IWriteRepository<Person, int> studWrite = new InMemoryRepository<Person, int>();
        IWriteRepository<Student, int> persWrite = studWrite;
    }

}