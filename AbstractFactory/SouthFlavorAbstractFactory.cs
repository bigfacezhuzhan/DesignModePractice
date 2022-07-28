/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 4a68eeac-5b22-44b5-a828-2b9bf020bb07
 * 创建人:   朱展
 * 创建时间: 2022/7/14 23:03:08
*/
using Design.Practice.Interface;
using DesignMode.Model;
using DesignMode.Model.Menu;
using DesignMode.Model.Soup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	/// <summary>
	/// 南方口味抽象工厂
	/// </summary>
	public class SouthFlavorAbstractFactory : ISouthFlavor
	{
		/// <summary>
		/// 三菜
		/// </summary>
		/// <returns></returns>
		public AbstractFood CreateBeerDuck()
		{
			return new BeerDuck();
		}

		public AbstractFood CreateBraisedPork()
		{
			return new BraisedPork();
		}

		public AbstractFood CreateGrandmaDish()
		{
			return new GrandmaDish();
		}

		/// <summary>
		/// 一汤
		/// </summary>
		/// <returns></returns>
		public AbstractSoup CreateCornBornSoup()
		{
			return new CornBornSoup();
		}
		/// <summary>
		/// 一主食
		/// </summary>
		/// <returns></returns>
		public Rice CreateRice()
		{
			return new Rice() { Name = "糯米饭" };
		}
	}
}
