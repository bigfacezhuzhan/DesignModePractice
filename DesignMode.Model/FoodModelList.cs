/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 712812e0-34d0-489c-b28a-7d796c1591be
 * 创建人:   朱展
 * 创建时间: 2022/7/26 12:07:18
*/
using DesignMode.Model.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.Model
{
	/// <summary>
	/// XML文档根节点
	/// </summary>
	public class FoodModelList
	{
		public List<BaseFood> FoodList = new List<BaseFood>();
	}
}
