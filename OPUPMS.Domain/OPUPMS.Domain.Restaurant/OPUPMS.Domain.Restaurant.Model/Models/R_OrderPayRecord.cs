/***********************************************************************
 * Module:  CyddJzjl.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyddJzjl
 ***********************************************************************/

// <summary>
// �����������˼�¼
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// �����������˼�¼
    public class R_OrderPayRecord
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Order_Id { get; set; }


        ///<summary>
        /// ���ʽ(1:�ֽ�,2:���п�,3:��Ա��,4:����,5:ת�ͷ�,6:����ȯ,7:�ⵥ)
        ///</summary>
        public int CyddPayType { get; set; }


        ///<summary>
        /// ������
        ///</summary>
        public decimal PayAmount { get; set; }


        ///<summary>
        /// ���ʽ(1:δ��,2:�Ѹ�,3:����)
        ///</summary>
        public CyddJzStatus CyddJzStatus { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public CyddJzType CyddJzType { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
        public int CreateUser { get; set; }

        /// <summary>
        /// ��ԴID�����ݸ���֧����ʽ�ж� ����(1:���� 2:ת�ͷ�) 
        /// </summary>
        public int SourceId { get; set; }

        /// <summary>
        /// ��Դ���� 
        /// </summary>
        public string SourceName { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public Nullable<DateTime> BillDate { get; set; }

        /// <summary>
        /// ����������Id
        /// </summary>
        public int R_OrderMainPay_Id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int R_Market_Id { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }
        public int PId { get; set; }

        public int PrintNum { get; set; }
        public int R_Restaurant_Id { get; set; }
    }
}