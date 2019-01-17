using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUPMS.Domain.Base.Dtos
{
    public class ApiResult
    {
        public int Id { get; set; }
        public int RequestResult { get; set; }
        public string Result { get; set; }
        public string Info { get; set; }
    }
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
    }

    public class ProtocolEntry
    {
        public int ProtocolId { get; set; }
        public string BillNum { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public string BillDate { get; set; }
        public string Reason { get; set; }
        public string SpendPonit { get; set; }
        public string EnterBillSign { get; set; }
    }
}
