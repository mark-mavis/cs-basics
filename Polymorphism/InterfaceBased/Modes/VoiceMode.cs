
namespace Polymorphism.InterfaceBased
{
    //Public Class
    public class VoiceMode : ICommunication 
    {
        //Public Method
        public void Communicate()
        {
            Console.WriteLine("Voice: Message Transmission via voice started");
        }
    }
}
