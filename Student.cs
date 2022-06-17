public class Student
{
    public int Id { get; init; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        
    }
    public Student(int id, string name,  int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}