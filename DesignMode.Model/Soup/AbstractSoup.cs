/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 298a5aeb-9245-44f9-b8a2-7d6db0502cab
 * 创建人:   朱展
 * 创建时间: 2022/7/14 21:47:46
*/
using Design.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.Model.Soup
{
	/// <summary>
	/// 汤类抽象
	/// </summary>
	public class AbstractSoup
	{
		public BaseSoup _baseSoup;
		public AbstractSoup(string config)
		{
			this._baseSoup = JsonHelper.ToObj<BaseSoup>(config); 
		}
		public virtual void Show()
		{
			Console.WriteLine("汤类");
		}
	}
}
