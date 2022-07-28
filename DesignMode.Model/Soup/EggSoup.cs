/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: f28f6ae4-ce7a-49aa-b072-497e99e5ca55
 * 创建人:   朱展
 * 创建时间: 2022/7/14 21:35:09
*/
using System;
using Design.Common;
namespace DesignMode.Model.Soup
{
	/// <summary>
	/// 西红柿蛋汤
	/// </summary>
	public class EggSoup:AbstractSoup
	{
		public EggSoup() : base("Config/EggSoup.json")
		{ 
			
		}
		public override void Show()
		{
			LogHelper.WriteLog("西红柿蛋汤", base._baseSoup.color); 
		}
	}
}
