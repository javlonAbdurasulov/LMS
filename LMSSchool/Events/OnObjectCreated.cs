using LMSSchool.Services.Classes;

namespace LMSSchool.Events;

internal class OnObjectCreated
{
    //public static string path = @"../../../myfile.txt";
    public static Action<object> OnObjectCreat = (obj) => {
        Console.WriteLine(obj.GetType().Name+" is create");
    };
}
