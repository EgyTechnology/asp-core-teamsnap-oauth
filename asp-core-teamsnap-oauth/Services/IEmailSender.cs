﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_core_teamsnap_oauth.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
