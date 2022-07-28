/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 0fd9f89e-cccb-43c1-99bd-13c46394db9c
 * 创建人:   朱展
 * 创建时间: 2022/7/14 23:08:26
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
	public class NorthFlavorAbstractFactory : INorthFlavor
	{
		public AbstractFood CreateDongAnChiken()
		{
			return new DongAnChicken();
		}

		public AbstractFood CreateGrandmaDish()
		{
			return new GrandmaDish();
		}
		public AbstractFood CreateTasteSnake()
		{
			return new TasteSnake();
		}

		public AbstractSoup CreateHaggisSoup()
		{
			return new HaggisSoup();
		}

		public Rice CreateRice()
		{
			return new Rice() { Name="米饭"};
		}

	}
}
