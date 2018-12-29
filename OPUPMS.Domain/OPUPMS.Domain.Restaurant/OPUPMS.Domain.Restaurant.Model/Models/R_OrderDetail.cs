/***********************************************************************
 * Module:  CyddMx.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyddMx
 ***********************************************************************/

// <summary>
// ����������ϸ
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ����������ϸ
    public class R_OrderDetail
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ��������̨��
        ///</summary>
        public int R_OrderTable_Id { get; set; }


        ///<summary>
        /// ������ϸ��Ŀ����(1:������Ŀ,2:�����ײ�)
        ///</summary>
        public CyddMxType CyddMxType { get; set; }


        ///<summary>
        /// ������ĿID(��������)
        ///</summary>
        public int CyddMxId { get; set; }


        ///<summary>
        /// ���۳ɱ���
        ///</summary>
        public decimal CostPrice { get; set; }


        ///<summary>
        /// ���ۼ�
        ///</summary>
        public decimal Price { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public decimal Num { get; set; }


        ///<summary>
        /// ������(��ʦ)
        ///</summary>
        public string MakeUser { get; set; }


        ///<summary>
        /// ״̬(1:δ��,2:�ѳ�)
        ///</summary>
        public CyddMxStatus CyddMxStatus { get; set; }


        ///<summary>
        /// ˳��
        ///</summary>
        public int SortNum { get; set; }

        ///<summary>
        /// �ߴٴ���
        ///</summary>
        public int RemindNum { get; set; }


        ///<summary>
        /// ��ע��Ϣ
        ///</summary>
        public string Remark { get; set; }


        ///<summary>
        /// �ۿ���
        ///</summary>
        public decimal DiscountRate { get; set; }

        public Nullable<DateTime> CreateDate { get; set; }
        public int CreateUser { get; set; }
        public int HookNum { get; set; }
        public string ExtendName { get; set; }
        public string CyddMxName { get; set; }
        public DishesStatus DishesStatus { get; set; }
        public string Unit { get; set; }
        /// <summary>
        /// ��ǰ��Ʒ���ѽ��
        /// </summary>
        public decimal OriginalTotalPrice { get; set; }
        /// <summary>
        /// ��ǰ��Ʒʵ�����ۺ��
        /// </summary>
        public decimal PayableTotalPrice { get; set; }
        /// <summary>
        /// ��ǰ��Ʒ���ͽ��
        /// </summary>
        public decimal GiveTotalPrice { get; set; }
        public bool IsListPrint { get; set; }
        public decimal ExtractPrice { get; set; }
    }
}