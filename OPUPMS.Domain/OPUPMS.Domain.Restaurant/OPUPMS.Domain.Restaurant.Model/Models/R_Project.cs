/***********************************************************************
 * Module:  Cyxm.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cyxm
 ***********************************************************************/

// <summary>
// ������Ŀ
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������Ŀ
    public class R_Project
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ������Ŀ���
        ///</summary>
        public int R_Category_Id { get; set; }


        ///<summary>
        /// ������Ϣ
        ///</summary>
        public string Description { get; set; }


        ///<summary>
        /// ����ʱ��
        ///</summary>
        public Nullable<DateTime> CreateDate { get; set; }



        ///<summary>
        /// �Ƿ�ɾ��
        ///</summary>
        public bool IsDelete { get; set; }



        ///<summary>
        /// �Ƿ�ʹ�ÿ��
        ///</summary>
        public bool IsStock { get; set; }


        ///<summary>
        /// �����
        ///</summary>
        public decimal Stock { get; set; }

        /// <summary>
        /// ������Ŀ����
        /// </summary>
        public int Property { get; set; }


        ///<summary>
        /// �ɱ���
        ///</summary>
        public decimal CostPrice { get; set; }


        ///<summary>
        /// ���ۼ�
        ///</summary>
        public decimal Price { get; set; }
        public int R_Company_Id { get; set; }
        public string Code { get; set; }
        public int Sorted { get; set; }
        public bool IsEnable { get; set; }
        public int ExtractType { get; set; }
        public decimal ExtractPrice { get; set; }
    }
}