/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 11863e30-e3e3-4314-8fdd-422171def5ae
 * 创建人:   朱展
 * 创建时间: 2022/7/14 22:38:01
*/
using Design.Common;

namespace DesignMode.Model.Soup
{
	/// <summary>
	/// 羊杂汤
	/// </summary>
	public class HaggisSoup:AbstractSoup
	{
		public HaggisSoup() : base("Config/HaggisSoup.json")
		{ }
		public override void Show()
		{
			LogHelper.WriteLog("羊杂汤", base._baseSoup.color);  
		}
	}
}
