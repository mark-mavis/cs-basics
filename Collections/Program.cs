using Collections;
class Program
{
    public static void Main()
    {

        //MyArray.TwoDimensionalArray();
        //MyArray.ThreeDimensionalArray();
        //MyArray.FiveFriendsExercise();
        //MyArray.ForeachLoopsSwitchChallenge();
        //JaggedManager.Run();

        //ParamKeyword.RunParamExample("hello", "I", "am", "writing", "as", "many", "params", "as", "I", "want");
        //ParamKeyword.RunParamObjExample(25, 45.3f, "Hello", '$');

        ////The Params keyword allows us to use the same function is
        //// with different signitures....
        //ParamKeyword.RunParamMin(2, 4, 6, 7, 3, 20, 34, 61, 23, 544, 526, 24);
        //ParamKeyword.RunParamMin(634364,13235,51235);

        //Add Any Type to Non-Generic
        NonGenerics nongenerics = new NonGenerics();
        nongenerics.AddObjectsToArrayList(5, 3.14f, "Denis", '$');
        nongenerics.Sum();
        
        nongenerics.AddElementsToHashTable();
        nongenerics.FindElementsInHashtable(325235);
        nongenerics.FindElementsInHashtable(167435);

        nongenerics.PrintAllHashtableKeys();

        //Generics generics = new Generics();
        ////Add Only One Type to Generic
        //generics.AddIntsToList(3, 4, 2, 6, 7, 1, 96, 53);
        //generics.PrintList();

        //MyArrayList.AddAllElementsToArrayList(25, "Hello", "13.37", "13", 128, 25.5, 13);
        //MyArrayList.PrintObjects();

        MyDictionaryTester.ParenthesesGame("(()())");
        MyDictionaryTester.ParenthesesGame("{]");
        MyDictionaryTester.RunEmployeeDirectory();

        
    }
}