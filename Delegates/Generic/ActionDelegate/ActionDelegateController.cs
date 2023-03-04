namespace Delegate.Generic.ActionDelegate
{
    internal class ActionDelegateController
    {
        public static void RunExercise01()
        {
            PrintActionDelegate printActionDel1 = ClassObj.ConsolePrint;
            printActionDel1(6745);

            //Instead of Creating the above delegate, you can
            Action<int> printActionDel2 = ClassObj.ConsolePrint;
            printActionDel2(2515616);

            //Can also...
            Action<int> printActionDel3 = new Action<int>(ClassObj.ConsolePrint);
            printActionDel3(342515);
        }
    }
}
