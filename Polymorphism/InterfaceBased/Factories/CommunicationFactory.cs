namespace Polymorphism.InterfaceBased
{

    /*
     * Communication Factory that takes in a user input and returns an ICommunicateType type that has implemented
     * the ICommunicationType Interface.
     * 
     * 
     */
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
