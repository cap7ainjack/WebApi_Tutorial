using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSytem.Models.VmModels
{
   public class DetailedAuthorVM
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<string> BookTitles { get; set; }
    }
}
