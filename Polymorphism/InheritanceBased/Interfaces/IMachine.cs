namespace Polymorphism.InheritanceBased
{
    public class IMachine 
    {
        public void StartMachine(Machine machine)
        {
            machine.Start();
        }
        public void ShutdownMachine(Machine machine)
        {
            machine.Stop();
        }

    }
}
