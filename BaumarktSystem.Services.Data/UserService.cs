using Baumarkt_E_commerce_Platform.Data;
using BaumarktSystem.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data
{
    public class UserService : IUserInterface
    {
        private  readonly BaumarktSystemDbContext dbContext;

        public UserService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string?> GetFullNameByEmail(string email)
        {
            var user = await this.dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null)
            {
                return string.Empty;
            }


            return user?.FullName;
        }



    }
}
