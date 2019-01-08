using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUPMS.Domain.Restaurant.Model.Dtos
{
    public class CompanyUserDTO
    {
    }

    public class CompanyUserSearchDTO : BaseSearch
    {
        public int CompanyId { get; set; }
        public string UserName { get; set; }
    }
}
