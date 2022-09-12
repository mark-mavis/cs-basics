namespace Operators.NullConditionals
{
    public class NullConditionalOperator
    {
        public class Person
        {
            public string Name { get; set;}
            public Person Partner { get; set; }
            public string[] Hobbies { get; set; }
        }


        public static void RunExercise01()
        {
            Person person = new Person();

            /* 
            Following code will crash because the Person Object is set to null 
                Person person = null;
                Console.WriteLine(person.Name);

            Typical Check:
                if(person != null){
                    Console.WriteLine(person.Name)
                }
            Inline Check:
                Console.WriteLine(person?.Name);
            */

            Console.WriteLine(person?.Name);
            if (string.IsNullOrEmpty(person?.Name))
            {
                Console.WriteLine("A person has no name");
            }

            person.Name = "Gerald";
            
            Person partner = new Person()
            {
                Name = "Jimmy",
                Hobbies = new[] {"Coding", "Guitar", "Hiking", "Cooking"}
            };
            person.Partner = partner;

            Console.WriteLine(person?.Name);
            Console.WriteLine(person?.Partner?.Name);
            Console.WriteLine(string.Join(",", person?.Partner?.Hobbies));
            Console.WriteLine("Favorite Hobby: " + person?.Partner?.Hobbies?[0]);
        }
    }
}
