using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using NoticiasDISC.Contexto;

namespace NoticiasDISC.Models
{
    public class CustomUserStore : IUserStore<CustomUser>
    {
        private NoticiasContext database;

        public CustomUserStore()
        {
            this.database = new NoticiasContext();
        }

        public void Dispose()
        {
            this.database.Dispose();
        }

        public Task CreateAsync(CustomUser user)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CustomUser user)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CustomUser user)
        {
            // TODO
            throw new NotImplementedException();
        }

        public async Task<CustomUser> FindByIdAsync(string userId)
        {
            CustomUser user = await this.database.CustomUsers.Where(c => c.Id == userId).FirstOrDefaultAsync();
            return user;
        }

        public async Task<CustomUser> FindByNameAsync(string userName)
        {
            CustomUser user = await this.database.CustomUsers.Where(c => c.UserName == userName).FirstOrDefaultAsync();
            return user;
        }
    }
}
