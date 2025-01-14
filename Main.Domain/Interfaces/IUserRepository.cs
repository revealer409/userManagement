﻿using Main.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.Interfaces
{
   public interface IUserRepository
    {
        Task<ApplicationUser> GetUserAsync(string username);
    }
}
