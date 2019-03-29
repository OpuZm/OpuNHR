using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPUPMS.Domain.Restaurant.Model.Dtos;

namespace OPUPMS.Domain.Restaurant.Repository
{
    public interface ISCompanyRepository
    {
        List<SCompanyDTO> GetGroupCompanys(int groupId = 0);
        string GetApiStr();
    }
}
