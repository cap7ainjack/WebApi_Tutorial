using BookShopSystem.Services.Contracts;
using BookShopSytem.Models.VmModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSystem.Services
{
    public class AuthorsService : Service, IAuthorsService
    {
        public bool ContainsAuthor(int id)
        {
            return this.Context.Authors.Find(id) != null;
        }

        public DetailedAuthorVM GetDetailedAuthor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
