/***********************************************************************
 * Module:  CyxmLb.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyxmLb
 ***********************************************************************/

// <summary>
// ������Ŀ���
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������Ŀ���
    public class R_Category
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ������Ϣ
        ///</summary>
        public string Description { get; set; }


        ///<summary>
        /// ��ID
        ///</summary>
        public int PId { get; set; }


        ///<summary>
        /// ���۱���
        ///</summary>
        public decimal DiscountRate { get; set; }
        /// <summary>
        /// �Ƿ�ɴ���
        /// </summary>
        public bool IsDiscount { get; set; }
        public int R_Company_Id { get; set; }

        public bool IsDelete { get; set; }
        public int Sorted { get; set; }

    }
}