/***********************************************************************
 * Module:  CybxTh.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CybxTh
 ***********************************************************************/

// <summary>
// ��������̨��
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������̨��
    public class R_BoxTable
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public int R_Box_Id { get; set; }


        ///<summary>
        /// ����̨��
        ///</summary>
        public int R_Table_Id { get; set; }

    }
}