
// <summary>
// �������������˼�¼
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// �������������˼�¼
    public class R_OrderMainPay
    {
        ///<summary>
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ��������ID
        ///</summary>
        public int R_Order_Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime BillDate { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int R_Market_Id { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUser { get; set; }

        public int DiscountType { get; set; }

        public int R_Discount_Id { get; set; }
        public string Remark { get; set; }
        public decimal DiscountRate { get; set; }
    }
}