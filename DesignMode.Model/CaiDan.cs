/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 60d1c36f-7fbd-40cc-b086-58886c129299
 * 创建人:   朱展
 * 创建时间: 2022/7/25 16:48:02
*/
using Design.Common;
using DesignMode.Model.Menu;
using DesignMode.Model.Soup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.Model
{
	public class CaiDan
	{
		public List<BaseFood> baseFoods = new List<BaseFood>();//菜品集合
		public List<BaseSoup> baseSoups = new List<BaseSoup>();//汤类集合
		private CaiDan() { }
		private static CaiDan cai = null;
		public static readonly object cd = new object();//静态锁
		/// <summary>
		/// 创建菜单列表单例
		/// </summary>
		/// <returns>菜单列表</returns>
		public static CaiDan CreateMenuList()
		{
			if (cai == null)
			{
				lock (cd)
				{
					if (cai == null)
					{
						cai = new CaiDan()
						{
							//json格式传递数据
							baseFoods = JsonHelper.ToObj<List<BaseFood>>("Config/FoodList.json"),
							baseSoups = JsonHelper.ToObj<List<BaseSoup>>("Config/SoupList.json")

							//XML格式传递数据
							//baseFoods = XmlHelper.ToObjXml<FoodModelList>("Config/FoodList.xml", Encoding.UTF8).FoodList
						};
					}
				}
			}
			return cai;
		}
		public List<BaseFood> GetRandFood(int rand = 5)
		{
			var fiveFood = baseFoods.Select(f => new { f, NewId = Guid.NewGuid() }).OrderBy(b => b.NewId);
			if (fiveFood.Count() > 0)
			{
				return fiveFood.Take(5).Select(s => s.f).ToList();
			}
			else
			{
				throw new Exception("菜单列表中无数据");
			}
		}
	}
}
