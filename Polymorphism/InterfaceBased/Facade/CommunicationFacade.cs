namespace Polymorphism.InterfaceBased
{ 
    class CommunicationFacade
    {
        //Method
        public void StartCommunication(ICommunication communication)
        {
            communication.Communicate();
        }
    }
}
