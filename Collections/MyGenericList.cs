
namespace Collections
{
    public class MyGenericList<T>
    {
        private int Count { get; set; }

        //Private Node class for the generic list to use
        private class Node<T>
        {
            //Node Properties
            public Node<T>? Next
            {
                get { return this; }
                set { this.Next = value; }
            }
            public T Data
            {
                get { return Data; }
                set { Data = value; }
            }

            //Node Constructor
            public Node(T t)
            {
                this.Next = null;
                this.Data = t;
            }
        }

        private Node<T>? head;
        public MyGenericList(T data)
        {
            head = new Node<T>(data);
            Count++;
        }
        public void Add(T t)
        {
            if (head == null)
            {

            }
            //Create the new head
            Node<T> n = new Node<T>(t);

            if (head == null)
            {   //Assign new node as head
                head = n;
            }
            else
            {   //Assign new head's next to the prevous head node
                n.Next = head;
                head = n;
            }
        }
        public bool Contains(T t)
        {
            if(head == null){
                return false;
            }
            return Search(t);
        }

        private bool Search(T t)
        {
            Node<T> n = head;
            for(int i = 0; i < Count; i++)
            {
                
            }
            return true;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    class MyGenericListTester
    {
        public static void Initialization()
        {
            MyGenericList<int> genericStringList = new MyGenericList<int>(36);
            
            MyGenericList<int> list = new MyGenericList<int>(11);

            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }

            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");

        }
        
        
    }
}
