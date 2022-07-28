/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 196d4e59-df64-4d75-aa74-b25264b8c574
 * 创建人:   朱展
 * 创建时间: 2022/7/14 21:47:59
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.Model.Soup
{
	public class BaseSoup
	{
		public int SoupId { get; set; }
		public string SoupName { get; set; }
		public string Description { get; set; }
		public ConsoleColor color { get; set; }
	}
}
