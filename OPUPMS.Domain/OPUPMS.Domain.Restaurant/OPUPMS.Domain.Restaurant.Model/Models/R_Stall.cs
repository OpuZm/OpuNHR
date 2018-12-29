/***********************************************************************
 * Module:  Cydk.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cydk
 ***********************************************************************/

// <summary>
// ��������
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������
    public class R_Stall
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ������Ϣ
        ///</summary>
        public string Description { get; set; }
        public int R_Company_Id { get; set; }
        public int Print_Id { get; set; }

        public bool IsDelete { get; set; }
    }
}