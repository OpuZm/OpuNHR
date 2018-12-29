/***********************************************************************
 * Module:  Cyct.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cyct
 ***********************************************************************/

// <summary>
// ��������
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������
    public class R_Restaurant
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ��λ��
        ///</summary>
        public int SeatNum { get; set; }


        ///<summary>
        /// ̨��
        ///</summary>
        public int TableNum { get; set; }


        ///<summary>
        /// �������
        ///</summary>
        public decimal ServiceRate { get; set; }


        ///<summary>
        /// ������Ϣ
        ///</summary>
        public string Description { get; set; }
        public int R_Company_Id { get; set; }
        public bool IsDelete { get; set; }

    }
}