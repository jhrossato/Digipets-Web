﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateAsync(string email, string password);
        Task<bool> RegisterVeterinario(string email, string password);
        Task<bool> RegisterTutor(string email, string password);
        Task Logout();

    }
}
