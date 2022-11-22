using System.Collections;   //Non-Generics Library

namespace Collections
{
    //Can store any type of objects
    class NonGenerics
    {
        /*
         * ArrayList
         * SortedList
         * Stack
         * Queue
         * Hashtable
         * BitArray
         */
        
        public ArrayList arr_list = new (); //Depreicated because of boxing. Slow Performance
        public SortedList sortedList = new ();
        public Stack stack = new ();
        public Queue queue = new ();

        public Hashtable studentsHashtable = new ();
        
        public void AddElementsToHashTable()
        {
            Student mark = new Student("Mark", 3.78f, 325235);
            Student casey = new Student("Casey", 4.0f, 341241);
            Student jake = new Student("Jake", 2.9f, 167435);
            
            studentsHashtable.Add(mark.Id, mark);
            studentsHashtable.Add(casey.Id, casey);
            studentsHashtable.Add(jake.Id, jake);
        }
        public void PrintAllHashtableKeys()
        {
            foreach(Student s in studentsHashtable.Values)
            {
                Console.WriteLine("Student Name: {0} ID: {1} GPA: {2}", s.Name, s.Id, s.GPA);
            }
        }

        public void FindElementsInHashtable(int i)
        {
            if(studentsHashtable.ContainsKey(i)) {
                Console.WriteLine("Key Pair Found");
            }else{
                Console.WriteLine("Key Pair Not Found");
            }
        }


        public void AddObjectsToArrayList(params object[] parameters)
        {
            foreach (object o in parameters)
            {
                arr_list.Add(o);
            }
        }
        public void Sum()
        {
            double sum = 0;
            foreach(object o in arr_list)
            {
                if(o is int) {
                    sum += Convert.ToDouble(o);
                    continue;
                }
                if(o is double) {
                    sum += (double)o;
                    continue;
                }
                if(o is float) {
                    sum += Convert.ToDouble(0);
                    continue;
                }
                if(o is string) continue;
            }
            Console.WriteLine("Sum: " + sum);

        }
    }

    class Student
    {
        public string Name { get; set; }

        public float GPA { get; set;}

        public int Id { get; set; }

        public Student(string name, float gpa, int id)
        {
            this.Name = name;
            this.GPA = gpa;
            this.Id = id;
        }

    }
}
