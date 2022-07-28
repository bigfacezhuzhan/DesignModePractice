using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace DesignMode.Model.Constant
{
	public static class ConstantStatic
	{
		/// <summary>
		/// 配置菜品对象的程序集
		/// </summary>
		public static string _foodTypeDLL = ConfigurationManager.AppSettings["TypeFoodByConfig"].Split(',')[0];
		/// <summary>
		/// 配置菜品对象的类名
		/// </summary>
		public static string _foodTypeCls = ConfigurationManager.AppSettings["TypeFoodByConfig"].Split(',')[1]; 

	}
}
