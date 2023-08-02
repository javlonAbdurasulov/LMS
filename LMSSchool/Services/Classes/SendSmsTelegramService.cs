using LMSSchool.Events;
using LMSSchool.Services.Intefaces;

namespace LMSSchool.Services.Classes;

internal class SendSmsTelegramService : ISendSmsTelegramService
{
    public SendSmsTelegramService()
    {
        OnOutConsole.OnOut += SendSmsTelegram;
        //OnObjectCreated.OnObjectCreat += SendSmsTelegramCreate;
        //OnObjectUpdatedModel.OnObjectUpdated += SendSmsTelegramupdate;
    }
    public void SendSmsTelegram(string phoneNumber, string message)
    {
        Console.WriteLine($"Send To: {phoneNumber} Message: {message}");
    }
    //public void SendSmsTelegramCreate(object obj)
    //{
    //    Console.WriteLine($"Send To: +99893 557 84 75 Message: {obj.GetType().GetProperty("Name").ToString()} is create");
    //}
    //public void SendSmsTelegramupdate(object obj)
    //{
    //    Console.WriteLine($"Send To: +99893 557 84 75 Message: is update");
    //}
}
