﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data.Interfaces
{
    public  interface IUserInterface
    {

        Task<string?> GetFullNameByEmail(string email);



    }
}
