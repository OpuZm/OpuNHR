/***********************************************************************
 * Module:  Cyfs.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cyfs
 ***********************************************************************/

// <summary>
// ��������
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������
    public class R_Market
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Restaurant_Id { get; set; }


        ///<summary>
        /// ��ʼʱ��
        ///</summary>
        public string StartTime { get; set; }


        ///<summary>
        /// ����ʱ��
        ///</summary>
        public string EndTime { get; set; }


        ///<summary>
        /// ������Ϣ
        ///</summary>
        public string Description { get; set; }
        public bool IsDelete { get; set; }
    }
}