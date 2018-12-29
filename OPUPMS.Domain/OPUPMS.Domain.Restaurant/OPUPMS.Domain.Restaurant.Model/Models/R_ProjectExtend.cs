/***********************************************************************
 * Module:  CyxmKz.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyxmKz
 ***********************************************************************/

// <summary>
// ������Ŀ��չ
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������Ŀ��չ
    public class R_ProjectExtend
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
        /// ����
        ///</summary>
        public decimal Price { get; set; }


        ///<summary>
        /// ����(1:����,2:Ҫ��,3.���)
        ///</summary>
        public CyxmKzType CyxmKzType { get; set; }


        ///<summary>
        /// ��λ
        ///</summary>
        public string Unit { get; set; }
        public int R_Company_Id { get; set; }
        public int R_ProjectExtendType_Id { get; set; }
        public bool IsDelete { get; set; }
    }
}