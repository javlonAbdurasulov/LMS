using LMSSchool.Services.Intefaces;

namespace LMSSchool.Services.Classes;

internal class SendSmsTelegramService : ISendSmsTelegramService
{
    public void SendSmsTelegram(string phoneNumber, string message)
    {
        Console.WriteLine($"Send To: {phoneNumber} Message: {message}");
    }
}
