/***********************************************************************
 * Module:  Printer.cs
 * Author:  Justin-Administrator
 * Purpose: Definition of the Class Printer
 ***********************************************************************/

// <summary>
// ��ӡ��
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// <summary>
    /// ��ӡ��Model
    /// </summary>
    public class Printer
    {
        ///<summary>
        ///
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ����
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// ��ע��Ϣ
        ///</summary>
        public string Remark { get; set; }

        ///<summary>
        /// �������� 
        ///</summary>
        public string PcName { get; set; }

        ///<summary>
        /// IP��ַ
        ///</summary>
        public string IpAddress { get; set; }

        ///<summary>
        /// ��ӡ���˿�
        ///</summary>
        public string PrintPort { get; set; }

        /// <summary>
        /// �Զ���ӿ�
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// �Ƿ�ɾ��
        /// </summary>
        public bool IsDelete { get; set; }
        public PrintStatus RealStatus { get; set; }
        public string RealStatusRemark { get; set; }
    }
}