/***********************************************************************
 * Module:  CyxmMx.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyxmMx
 ***********************************************************************/

// <summary>
// ������Ŀ��ϸ
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������Ŀ��ϸ
    public class R_ProjectDetail
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ������ĿID
        ///</summary>
        public int R_Project_Id { get; set; }


        ///<summary>
        /// ��λ
        ///</summary>
        public string Unit { get; set; }


        ///<summary>
        /// �۸�
        ///</summary>
        public decimal Price { get; set; }


        ///<summary>
        /// �ɱ���
        ///</summary>
        public decimal CostPrice { get; set; }


        ///<summary>
        /// ������Ϣ
        ///</summary>
        public string Description { get; set; }


        ///<summary>
        /// ��λ���� [1,1.5,2��]
        ///</summary>
        public decimal UnitRate { get; set; }

        public bool IsDelete { get; set; }

    }
}