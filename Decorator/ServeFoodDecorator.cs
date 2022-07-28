/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 3aeb5853-3cdc-47c9-9806-c83abf39bf81
 * 创建人:   朱展
 * 创建时间: 2022/7/28 0:09:10
*/
using DesignMode.Model.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class ServeFoodDecorator:BaseFoodDecorator
	{
		public ServeFoodDecorator(AbstractFood food):base(food)
		{ }
		public override void Cooking()
		{
			base.Cooking();
			Console.WriteLine("上菜");
		}
	}
}
