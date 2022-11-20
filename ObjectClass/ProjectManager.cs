using ObjectClass.Enum;
using ObjectClass.Static;
using ObjectClass.StaticClass;
using ObjectClass.StaticConstructor;
using ObjectClass.Struct;
using ObjectClass.NestedClasses;
using Classes.Basics;

class ProjectManager
{
    public static void Main(string[] args)
    {
        //ENUM
        //EnumExercise.Run();

        //STATIC FIELDS
        //StaticExercise.Run();

        //STATIC CLASSES
        //StaticClass.RunExercise();

        //STATIC CONSTRUCTORS
        //StaticConstructor.RunExercise();

        //STRUCT
        //StructExercise.Run();

        //NESTED CLASSES
        //TestNestedClasses.Run();

        ObjectClassManager.HumanClassManager();
        ObjectClassManager.CarClassManager();
        ObjectClassManager.BoxClassManager();
    }
}