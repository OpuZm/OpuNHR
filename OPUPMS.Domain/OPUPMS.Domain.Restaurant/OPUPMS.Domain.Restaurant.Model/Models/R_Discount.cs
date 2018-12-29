/***********************************************************************
 * Module:  CyxmZkSz.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyxmZkSz
 ***********************************************************************/

// <summary>
// ������Ŀ�ۿ�����
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������Ŀ�ۿ�����
    public class R_Discount
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// �ۿ�����
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Market_Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public int R_Restaurant_Id { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Area_Id { get; set; }
        ///<summary>
        /// �Ƿ�����
        ///</summary>
        public bool IsEnable { get; set; }
        public int R_Company_Id { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public bool IsDelete { get; set; }

    }
}