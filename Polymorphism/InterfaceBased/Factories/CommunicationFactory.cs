namespace Polymorphism.InterfaceBased
{
    class CommunicationFactory
    {
        public static ICommunicationType Create(int mode)
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
