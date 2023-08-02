using LMSSchool.Events;
using LMSSchool.Services.Intefaces;

namespace LMSSchool.Services.Classes;

internal class LogToConsoleService : ILogToConsoleService
{
    public LogToConsoleService()
    {
        OnOutConsole.OnOut += LogToConsole;
        //OnObjectCreated.OnObjectCreat += LogToConsoleCreate;
        //OnObjectUpdatedModel.OnObjectUpdated += LogToConsoleUpdate;
    }
    public void LogToConsole(string message,string s="")
    {
        Console.WriteLine($"Log To Console: {message}");
    }
    //public void LogToConsoleCreate(object obj)
    //{
    //    Console.WriteLine($"Log To Console: {obj.GetType().GetProperty(".Name")} is create");
    //}
    //public void LogToConsoleUpdate(object obj)
    //{
    //    Console.WriteLine($"Log To Console: {obj.GetType().Name} is update");
    //}
}
