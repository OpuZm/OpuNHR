/***********************************************************************
 * Module:  CyddTh.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyddTh
 ***********************************************************************/

// <summary>
// ��������̨��
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������̨��
    public class R_OrderTable
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Order_Id { get; set; }


        ///<summary>
        /// ����̨��
        ///</summary>
        public int R_Table_Id { get; set; }


        ///<summary>
        /// ��̨ʱ��
        ///</summary>
        public Nullable<DateTime> CreateDate { get; set; }


        ///<summary>
        /// ����̨������
        ///</summary>
        public int PersonNum { get; set; }
        public bool IsCheckOut { get; set; }
        public bool IsOpen { get; set; }
        public bool IsLock { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? BillDate { get; set; }

        public int R_Market_Id { get; set; }

        public int R_OrderMainPay_Id { get; set; }
        public bool IsControl { get; set; }
    }
}