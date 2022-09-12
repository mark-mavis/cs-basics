namespace Polymorphism.InterfaceBased
{
    public class TextMode : ICommunication
    {
        public void Communicate()
        {
            Console.WriteLine("Text: Message Transmission via text started");
        }
    }
}
