/***********************************************************************
 * Module:  CytcMx.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CytcMx
 ***********************************************************************/

// <summary>
// �����ײ���ϸ
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// �����ײ���ϸ
    public class R_PackageDetail
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// �����ײ�
        ///</summary>
        public int R_Package_Id { get; set; }


        ///<summary>
        /// ������Ŀ��ϸ
        ///</summary>
        public int R_ProjectDetail_Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public decimal Num { get; set; }

        public bool IsDelete { get; set; }

    }
}