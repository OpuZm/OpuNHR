/***********************************************************************
 * Module:  Cybx.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class Cybx
 ***********************************************************************/

// <summary>
// ��������
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
    /// ��������
    public class R_Box
    {


        ///<summary>
        ///</summary>
        public int Id { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// ����
        ///</summary>
        public string Description { get; set; }


        ///<summary>
        /// ������������
        ///</summary>
        public int R_Area_Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public int R_Restaurant_Id { get; set; }
        public bool IsDelete { get; set; }

    }
}