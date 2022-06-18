public static class Student
{
    public static int Id { get; set; }
    public static string Name { get; set; }
    public static int Age { get; set; }

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