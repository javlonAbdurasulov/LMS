using LMSSchool.Events;
using LMSSchool.Services.Intefaces;

namespace LMSSchool.Services.Classes;


internal class WriteToFileService : IWriteToFileService
{
    static string path = @"../../../Database.txt";
    public WriteToFileService()
    {
        OnOutConsole.OnOut += WriteToFile;
        //OnObjectCreated.OnObjectCreat += WriteToFileCreate;
        //OnObjectUpdatedModel.OnObjectUpdated += WriteToFileUpdate;
    }
    public void WriteToFile( string message, string filePath)
    {
        using(StreamWriter streamWriter = new StreamWriter(filePath,true))
        {
            streamWriter.WriteLine(message);
        }
    }




    //public void WriteToFileCreate( object obj)
    //{
    //    using(StreamWriter streamWriter = new StreamWriter(path,true))
    //    {
    //        streamWriter.WriteLine(obj.GetType().GetProperty("Name")+" is create");
    //    }
    //}
    //public void WriteToFileUpdate( object obj)
    //{
    //    using(StreamWriter streamWriter = new StreamWriter(path,true))
    //    {
    //        streamWriter.WriteLine(obj.GetType().GetProperty("Name")+" is update");
    //    }
    //}
}
