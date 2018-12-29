/***********************************************************************
 * Module:  CyxmDk.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyxmDk
 ***********************************************************************/

// <summary>
// ������Ŀ����
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������Ŀ����
    public class R_ProjectStall
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ������Ŀ
        ///</summary>
        public int R_Project_Id { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Stall_Id { get; set; }

        /// <summary>
        /// ��������(1:�������鵥 2:�����ܵ�)
        /// </summary>
        public int BillType { get; set; }
    }
}