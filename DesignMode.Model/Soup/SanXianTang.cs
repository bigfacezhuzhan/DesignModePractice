/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 80e887de-a760-43ec-bc9f-3bffedc21bf3
 * 创建人:   朱展
 * 创建时间: 2022/7/14 21:21:40
*/
using Design.Common;

namespace DesignMode.Model.Soup
{
	/// <summary>
	/// 三鲜汤
	/// </summary>
	public class SanXianTang:AbstractSoup
	{
		public SanXianTang():base("Config/SanXianTang.json")
		{ 
		
		}
		public override void Show()
		{
			LogHelper.WriteLog("三鲜汤", base._baseSoup.color);  
		}
	}
}
