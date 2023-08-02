using LMSSchool.Services.Intefaces;

namespace LMSSchool.Services.Classes;

internal class WriteToFileService : IWriteToFileService
{
    public void WriteToFile(string filePath, string message)
    {
        using(StreamWriter streamWriter = new StreamWriter(filePath))
        {
            streamWriter.WriteLine(message);
        }
    }
}
