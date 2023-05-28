using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTesting;

[TestClass] //Test Class Attribute to the UnitTest1 class
public class UnitTest1
{
    [TestMethod]    //Test Method Attribute to define TestMethod1
    public void AddTwoInts()
    {
        string result = Addition.Add("Hello", "World");
        Assert.AreEqual("Hello World", result);
        
    }
}