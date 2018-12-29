/***********************************************************************
 * Module:  Cytc.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cytc
 ***********************************************************************/

// <summary>
// �����ײ�
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// �����ײ�
    public class R_Package
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// �ײ�����
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// �۸�
        ///</summary>
        public decimal Price { get; set; }


        ///<summary>
        /// �ɱ��۸�
        ///</summary>
        public decimal CostPrice { get; set; }


        ///<summary>
        /// �Ƿ��ϼ�
        ///</summary>
        public bool IsOnSale { get; set; }


        ///<summary>
        /// �ײ�����
        ///</summary>
        public string Describe { get; set; }
        /// <summary>
        /// �Ƿ��Զ���
        /// </summary>
        public bool IsCustomer { get; set; }
        public int R_Company_Id { get; set; }
        public int Property { get; set; }
        public bool IsDelete { get; set; }
        public int R_Category_Id { get; set; }

    }
}