﻿using Ordering.Application.Models;

namespace Ordering.Application.Contracts.Infrastructrue
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
