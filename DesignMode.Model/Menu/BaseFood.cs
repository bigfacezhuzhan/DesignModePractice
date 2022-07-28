/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: fb07789a-0df5-4a60-86ca-67226e6639da
 * 创建人:   朱展
 * 创建时间: 2022/7/22 18:42:21
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.Model.Menu
{
	public class BaseFood
	{
		/// <summary>
		/// 菜品编号
		/// </summary>
		public int FoodId { get; set; }
		/// <summary>
		/// 菜名
		/// </summary>
		public string FoodName { get; set; }
		/// <summary>
		/// 菜品描述
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// 菜品做法
		/// </summary>
		public string Doing { get; set; }
		/// <summary>
		/// 控制台打印颜色 
		/// </summary>
		public ConsoleColor color { get; set; }
		public decimal Price { get; set; }
		public double Score { get; set; }
		/// <summary>
		/// 简单工厂配置类名
		/// </summary>
		public string simpleStr { get; set; }

	}
}
