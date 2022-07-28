/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: e535552a-03e2-4263-a9cf-d7473ab5a91b
 * 创建人:   朱展
 * 创建时间: 2022/7/14 21:40:44
*/
using System;
using Design.Common;
namespace DesignMode.Model.Soup
{
	/// <summary>
	/// 玉米排骨汤
	/// </summary>
	public class CornBornSoup:AbstractSoup
	{
		public CornBornSoup() : base("Config/CornBornSoup.json")
		{ }
		public override void Show()
		{ 
			LogHelper.WriteLog("玉米排骨汤一份", base._baseSoup.color);
		}
	}
}
