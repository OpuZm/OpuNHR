/***********************************************************************
 * Module:  CyctQy.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyctQy
 ***********************************************************************/

// <summary>
// ������������
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������������
    public class R_Area
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
        /// ��������
        ///</summary>
        public int R_Restaurant_Id { get; set; }


        ///<summary>
        /// �������
        ///</summary>
        public Nullable<decimal> ServerRate { get; set; }
        public bool IsDelete { get; set; }
    }
}