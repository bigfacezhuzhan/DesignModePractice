/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 86cd906b-dc26-46ba-a6d4-5a6b1d5cf65a
 * 创建人:   朱展
 * 创建时间: 2022/7/14 17:11:42
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
	/// 口味蛇工厂
	/// </summary>
	public class TasteSnakeFactory:AbstractBaseFatory
	{
		public override AbstractFood CreateFood()
		{
			return new TasteSnake();
		}
	}
}
