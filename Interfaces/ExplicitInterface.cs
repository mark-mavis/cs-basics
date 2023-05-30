


namespace MultipleInterfaces;

internal interface IFirstInterface{
    void SomeMethod();
}

internal interface ISecondInterface{
    void SomeMethod();
}

public class DemoClass : IFirstInterface, ISecondInterface{

    /*
        When using Explicit Interface Implementation, the members are forced to
        something more restricted than private in the class itself and when the
        access modifier is forced, you may not add one.
    */
    void IFirstInterface.SomeMethod(){

    }
    void ISecondInterface.SomeMethod(){

    }

    public void SomeMethod(){

    }
}
