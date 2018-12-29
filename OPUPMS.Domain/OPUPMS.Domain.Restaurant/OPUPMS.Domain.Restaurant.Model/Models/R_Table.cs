/***********************************************************************
 * Module:  Cyth.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cyth
 ***********************************************************************/

// <summary>
// ����̨��
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ����̨��
    public class R_Table
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Restaurant_Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ��λ��
        ///</summary>
        public int SeatNum { get; set; }


        ///<summary>
        /// ������Ϣ
        ///</summary>
        public string Describe { get; set; }


        ///<summary>
        /// ״̬(1:����,2:����,3:����)
        ///</summary>
        public CythStatus CythStatus { get; set; }


        ///<summary>
        /// �������
        ///</summary>
        public Nullable<decimal> ServerRate { get; set; }


        ///<summary>
        /// ��������
        ///</summary>
        public int R_Area_Id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsVirtual { get; set; }
        public int Sorted { get; set; }
    }
}