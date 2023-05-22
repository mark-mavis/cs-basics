using System.Collections;

namespace StudentHashtableExample
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }

    public class StudentHashtable
    {
        public static void Run()
        {
            Student[] students = new Student[]
            {
                new Student(1, "Jameson Dillings", 16), new Student(2, "Bethany Ellis", 15), new Student(3, "Jack Johnson", 17), new Student(4, "Steven Erikson", 16), new Student(5, "Robby Nelson", 15), new Student(6, "Chase Jones", 16), new Student(2, "Bethany Ellis", 15), new Student(8, "Adam Reisenaur", 17), new Student(4, "Steven Erikson", 16)
            };


            Hashtable studentlist = new Hashtable();

            foreach (Student s in students)
            {
                if (!studentlist.ContainsKey(s.Id))
                {
                    studentlist.Add(s.Id, s);
                }
                else
                {
                    Console.WriteLine("Student Already Exists in Hashtable");
                }
            }

            foreach(DictionaryEntry student in studentlist)
            {
                Student temp = (Student)student.Value;
                Console.WriteLine($"Name: {temp.Name}, Student Id: {temp.Id}, Age: {temp.Age}");
            }
        }
    }
}
