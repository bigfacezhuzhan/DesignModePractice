/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 35127da3-4aba-41c3-9c52-597aadf4836e
 * 创建人:   朱展
 * 创建时间: 2022/7/14 17:33:54
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
	/// 抽象菜品父类
	/// </summary>
	public abstract class AbstractBaseFatory
	{
		public abstract AbstractFood CreateFood();
	}
}
