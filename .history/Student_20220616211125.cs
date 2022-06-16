public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, string address, int age, string email, string phoneNumber)
    {
        Id = id;
        Name = name;
        Address = address;
        Age = age;
        Email = email;
        PhoneNumber = phoneNumber;
    }

}