/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 1c7c6ceb-cc7a-496a-a6bc-a61a1e5f09c6
 * 创建人:   朱展
 * 创建时间: 2022/7/14 22:54:42
*/
using System;

using Design.Common;
namespace DesignMode.Model
{
	public class Rice
	{
		public string Name = "米饭";
		public void Show()
		{ 
			LogHelper.WriteLog("米饭一份");
		}
	}
}
