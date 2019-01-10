using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUPMS.Domain.Base.Dtos
{
    public class MemberResultDTO
    {
        public int TotalCount { get; set; }
        public List<MemberDTO> ListDto { get; set; }
    }
    public class MemberDTO
    {
        public int Id { get; set; }
        public string MemberCardNo { get; set; }
        public string IdTypeNo { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public string Telephone { get; set; }
        public string ChineseName { get; set; }
        //Id = item.Id,
        //                        MemberCardNo = item.MemberCardNo,
        //                        MemberIdentityNo = item.IdTypeNo,
        //                        MemberPwbByte = item.Password,
        //                        CardBalance = item.Balance,
        //                        MemberPhoneNo = item.Telephone,
        //                        MemberName = item.ChineseName
    }
}
