namespace Polymorphism.InterfaceBased
{
    class CommunicationFactory
    {
        public static ICommunication Create(int mode)
        {
            if (mode == 1)
            {
                return new VoiceMode();
            }
            else
            {
                return new TextMode();
            }
        }

    }
}
