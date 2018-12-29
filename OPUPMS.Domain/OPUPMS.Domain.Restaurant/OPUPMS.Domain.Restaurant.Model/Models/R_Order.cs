/***********************************************************************
 * Module:  Cydd.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cydd
 ***********************************************************************/

// <summary>
// ��������// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������
    public class R_Order
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// �������
        ///</summary>
        public string OrderNo { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Restaurant_Id { get; set; }


        ///<summary>
        /// ������Դ(1:������,2:Ӫ���ƹ�,3:Э��ͻ�,4:΢��)
        ///</summary>
        public int CyddOrderSource { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public int PersonNum { get; set; }


        ///<summary>
        /// ������
        ///</summary>
        public int BillingUser { get; set; }


        ///<summary>
        /// ����״̬(1:Ԥ��,2:��̨,3:�ͳ�,4:�ò���,5:����,6:ȡ��,7:������Ʒ�޸�,8:��̨)
        ///</summary>
        public CyddStatus CyddStatus { get; set; }


        ///<summary>
        /// ��ע��Ϣ
        ///</summary>
        public string Remark { get; set; }


        ///<summary>
        /// Ԥ���ò�ʱ��
        ///</summary>
        public Nullable<DateTime> ReserveDate { get; set; }


        ///<summary>
        /// ���ѽ��
        ///</summary>
        public decimal ConAmount { get; set; }


        ///<summary>
        /// ������
        ///</summary>
        public decimal ServiceAmount { get; set; }


        ///<summary>
        /// Ӧ�ս��
        ///</summary>
        public decimal OriginalAmount { get; set; }


        ///<summary>
        /// ʵ�ս��
        ///</summary>
        public decimal RealAmount { get; set; }


        ///<summary>
        /// �ۿ���
        ///</summary>
        public decimal DiscountRate { get; set; }


        ///<summary>
        /// �ۿ۽��
        ///</summary>
        public decimal DiscountAmount { get; set; }


        ///<summary>
        /// ���ͽ��
        ///</summary>
        public decimal GiveAmount { get; set; }


        ///<summary>
        /// ����Ҫ��
        ///</summary>
        public string SpecialPopc { get; set; }


        ///<summary>
        /// ��˷�ʽ(1:����,2:����)
        ///</summary>
        public CyddCallType CyddCallType { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public decimal DepositAmount { get; set; }


        ///<summary>
        /// ����ʱ��
        ///</summary>
        public Nullable<DateTime> CreateDate { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Market_Id { get; set; }
        /// <summary>
        /// ����Ա
        /// </summary>
        public int CreateUser { get; set; }
        public string ContactPerson { get; set; }
        public string ContactTel { get; set; }
        public decimal ClearAmount { get; set; }
        public int TableNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public int OrderType { get; set; }

        /// <summary>
        /// �ͻ�Id
        /// </summary>
        public int CustomerId { get; set; }
        public bool IsDelete { get; set; }
        public string BillDepartMent { get; set; }
        public int MemberCardId { get; set; }
        public Nullable<DateTime> OpenDate { get; set; }
    }
}