using LMSSchool.Events;

namespace LMSSchool.ExceptionHandler;

internal class ExceptionHandler
{
    public static string path = @"../../../ExceptionsFile.txt";
    //private readonly Exception _exception; 
    private string _exception; 
    public ExceptionHandler(Exception exception)
    {
        _exception = exception.Message;
    }
    public void Handle()
    {
        OnOutConsole.OnOut.Invoke(" -Problem => "+_exception,path);
    }
}
