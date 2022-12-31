namespace Polymorphism.InterfaceBased
{
    public class TextMode : ICommunicationType
    {
        public void Communicate()
        {
            Console.WriteLine("Text: Message Transmission via text started");
        }
    }
}
