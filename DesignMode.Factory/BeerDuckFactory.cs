/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 21d92340-a980-4be8-b604-0ee229778570
 * 创建人:   朱展
 * 创建时间: 2022/7/14 17:36:45
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
	/// 啤酒鸭工厂
	/// </summary>
	public class BeerDuckFactory:AbstractBaseFatory
	{
		public override AbstractFood CreateFood()
		{
			return new BeerDuck();
		}
	}
}
