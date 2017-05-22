using BookShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSystem.Services
{
   protected abstract class Service
    {
       protected Service()
       {
           this.Context = new BookShopContext();
       }

       protected BookShopContext Context { get; set; }
    }
}
 