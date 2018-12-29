/***********************************************************************
 * Module:  Cyddczjl.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cyddczjl
 ***********************************************************************/

// <summary>
// ��������������¼
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������������¼
    public class R_OrderRecord
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ������
        ///</summary>
        public int CreateUser { get; set; }


        ///<summary>
        /// ����ʱ��
        ///</summary>
        public Nullable<DateTime> CreateDate { get; set; }


        ///<summary>
        /// ��������(1:Ԥ��,2:��̨,3:���,4:�ͳ�,5:�ò���,6:����,7:ȡ��,8:������Ʒ�޸� 9.��̨ 10.����/��̨)
        ///</summary>
        public CyddStatus CyddCzjlStatus { get; set; }


        ///<summary>
        /// �û�����(1:����Ա��,2:��Ա)
        ///</summary>
        public CyddCzjlUserType CyddCzjlUserType { get; set; }


        ///<summary>
        /// ��ע��Ϣ
        ///</summary>
        public string Remark { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Order_Id { get; set; }
        /// <summary>
        /// ��������̨��
        /// </summary>
        public int R_OrderTable_Id { get; set; }
    }
}