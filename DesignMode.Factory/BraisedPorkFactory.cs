/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 38dd25c3-296a-4f1e-b20c-77539e674175
 * 创建人:   朱展
 * 创建时间: 2022/7/14 17:39:08
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
	/// 红烧肉工厂
	/// </summary>
	public class BraisedPorkFactory:AbstractBaseFatory
	{
		public override AbstractFood CreateFood()
		{
			return new BraisedPork();
		}
	}
}
