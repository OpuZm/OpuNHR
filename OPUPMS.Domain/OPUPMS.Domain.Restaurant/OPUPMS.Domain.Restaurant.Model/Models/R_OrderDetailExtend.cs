/***********************************************************************
 * Module:  CyddMxXmKz.cs
 * Author:  ZMAdministrator
 * Purpose: Definition of the Class CyddMxXmKz
 ***********************************************************************/
 
// <summary>
// ����������ϸ��Ŀ��չ
// </summary>

using System;

namespace OPUPMS.Domain.Restaurant.Model
{
/// ����������ϸ��Ŀ��չ
public class R_OrderDetailExtend
    {
   
   
   ///<summary>
   ///</summary>
   public int Id {get;set;}
   
   
   ///<summary>
   /// ����������ϸ
   ///</summary>
   public int R_OrderDetail_Id { get;set;}
   
   
   ///<summary>
   /// ������Ŀ��չ
   ///</summary>
   public int R_ProjectExtend_Id { get;set;}
   public decimal Price { get; set; }
   public string Name { get; set; }
   public string Unit { get; set; }
}
}