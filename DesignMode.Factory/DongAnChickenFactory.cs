/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 1f6d6a62-c640-4ccd-b7dd-417d5c65b18f
 * 创建人:   朱展
 * 创建时间: 2022/7/14 17:41:01
*/
using DesignMode.Model.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.Factory
{
	/// <summary>
	/// 东安鸡工厂
	/// </summary>
	public class DongAnChickenFactory:AbstractBaseFatory
	{
		public override AbstractFood CreateFood()
		{
			return new DongAnChicken();
		}
	}
}
