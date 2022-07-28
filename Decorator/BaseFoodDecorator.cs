/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: d789d511-12b2-49d2-8c16-be1804ce8085
 * 创建人:   朱展
 * 创建时间: 2022/7/28 0:01:26
*/
using DesignMode.Model.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class BaseFoodDecorator:AbstractFood
	{
		private AbstractFood _food = null;
		public BaseFoodDecorator(AbstractFood food)
		{
			this._food = food;
		}
		public override void Cooking()
		{
			this._food.Cooking();
		}




		public override void Show()
		{
			throw new NotImplementedException();
		}
	}
}
