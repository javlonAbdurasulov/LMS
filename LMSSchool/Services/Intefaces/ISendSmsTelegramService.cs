﻿namespace LMSSchool.Services.Intefaces;

internal interface ISendSmsTelegramService
{
    void SendSmsTelegram(string phoneNumber, string message);
}
