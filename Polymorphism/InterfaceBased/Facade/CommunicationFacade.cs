namespace Polymorphism.InterfaceBased
{ 
    class CommunicationFacade
    {
        //Method
        public void StartCommunication(ICommunicationType communication)
        {
            communication.Communicate();
        }
    }
}
