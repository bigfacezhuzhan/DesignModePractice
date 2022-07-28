/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 9c32b327-bf42-4fbc-9648-b6b9ffdcc0d1
 * 创建人:   朱展
 * 创建时间: 2022/7/28 0:06:24
*/
using DesignMode.Model.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class BuyFoodDecorator:BaseFoodDecorator
	{
		public BuyFoodDecorator(AbstractFood food):base(food)
		{ }

		public override void Cooking()
		{
			Console.WriteLine("买菜");
			base.Cooking();
		}
	}
}
