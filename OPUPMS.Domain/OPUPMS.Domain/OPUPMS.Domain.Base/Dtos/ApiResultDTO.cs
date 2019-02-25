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

    public class MemberApiResult
    {
        public int RequestResult { get; set; }
        public string Result { get; set; }
        public string Info { get; set; }
    }

    public class CustomerSearchDTO
    {
        public int CompanyId { get; set; }
    }

    public class CustomerListResultDTO
    {

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
        public string SpendPonit { get; set; }
        public int CompanyId { get; set; }
    }

    public class MemberEntry
    {
        public int CompanyId { get; set; }
        public int MemberId { get; set; }
        public decimal PayAmount { get; set; }
        public int UserId { get; set; }
        public string CateringSpendPoint { get; set; }
        public string BusinessDate { get; set; }
        public string Remark { get; set; }
        public string Password { get; set; }
    }

    public class RoomEntry
    {
        public int GuestNo { get; set; }
        public string ConsumptionPoints { get; set; }
        public string Ticket { get; set; }
        public decimal Total { get; set; }
        public int CompanyId { get; set; }
    }
}
