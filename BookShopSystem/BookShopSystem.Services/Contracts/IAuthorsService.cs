using BookShopSytem.Models.VmModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSystem.Services.Contracts
{
   public interface IAuthorsService
    {
       bool ContainsAuthor(int id);

       DetailedAuthorVM GetDetailedAuthor(int id);
    }
}
