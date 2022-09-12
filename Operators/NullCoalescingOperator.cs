namespace Operators.NullCoalescing
{
    public class NullCoalescingOperator
    {
        public class Person
        {
            private string name;
            public string Name 
            { 
                get => name; 
                set{
                    name = value ?? throw new ArgumentNullException(nameof(Name));
                }
            }
        }
        public static void RunExercise01()
        {
            Person person = new Person 
            { 
                Name = "Original Gerald"
            };
            
            //person.Name = null;
            //When .Name is null, it will take the "Gerald" string
            string name = person.Name ?? "Second Gerald";
            person.Name ??= "Third Gerald";

            
        }
    }
}
