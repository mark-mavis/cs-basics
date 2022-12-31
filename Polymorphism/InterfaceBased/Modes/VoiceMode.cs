
namespace Polymorphism.InterfaceBased
{
    //Public Class
    public class VoiceMode : ICommunicationType 
    {
        //Public Method
        public void Communicate()
        {
            Console.WriteLine("Voice: Message Transmission via voice started");
        }
    }
}
