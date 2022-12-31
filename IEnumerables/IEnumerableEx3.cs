using System.Collections;

namespace IEnumerables
{
    public class PhoneBook : IEnumerable<Contact>
    {
        public List<Contact> Contacts;

        public PhoneBook()
        {
            Contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }

        public IEnumerator<Contact> GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }

        public void Call()
        {
            Console.WriteLine($"Calling to {Name}. Phone number is {Number}");
        }

    }

    public class PhonebookTest
    {
        public static void Run()
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
    }

   
}
