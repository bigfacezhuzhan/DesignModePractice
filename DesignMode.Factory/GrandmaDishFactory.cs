/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: d8019ee9-bde3-4ee5-a9a9-bf059d0c1a1a
 * 创建人:   朱展
 * 创建时间: 2022/7/14 17:42:37
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
	/// 外婆菜工厂
	/// </summary>
	public class GrandmaDishFactory:AbstractBaseFatory
	{
		public override AbstractFood CreateFood()
		{
			return new GrandmaDish();
		}
	}
}
