/***********************************************************************
 * Module:  CyxmTp.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyxmTp
 ***********************************************************************/

// <summary>
// ������ĿͼƬ
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ������ĿͼƬ
    public class R_ProjectImage
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ��Դ���(1.������Ŀ;2.�����ײ�)
        ///</summary>
        public int CyxmTpSourceType { get; set; }


        ///<summary>
        /// ͼƬ·��
        ///</summary>
        public string Url { get; set; }


        ///<summary>
        /// ��ԴID
        ///</summary>
        public int Source_Id { get; set; }


        ///<summary>
        /// �Ƿ����
        ///</summary>
        public bool IsCover { get; set; }

        public int Sorted { get; set; }
    }
}