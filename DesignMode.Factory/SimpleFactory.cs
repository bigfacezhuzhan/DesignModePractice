using DesignMode.Model;
using DesignMode.Model.Constant;
using DesignMode.Model.Menu;
using System;
using System.Configuration;
using System.Reflection;

namespace DesignMode.Factory
{
	/// <summary>
	/// 简单工厂创建菜品对象
	/// </summary>
	public class SimpleFactory
	{
		/// <summary>
		/// 根据菜品种类枚举值创建相应的对象
		/// </summary>
		/// <param name="typeFood">菜品种类枚举值</param>
		/// <returns>菜品对象</returns>
		public static AbstractFood CreateFoodByEnum(TypeFood typeFood)
		{ 
			switch (typeFood)
			{
				case TypeFood.BeerDuck:
					return new BeerDuck();
				case TypeFood.BraisedPork:
					return new BraisedPork();
				case TypeFood.DongAnChicken:
					return new DongAnChicken();
				case TypeFood.GrandmaDish:
					return new GrandmaDish();
				case TypeFood.TasteSnake:
					return new TasteSnake();
				default:
					throw new Exception("不存在该枚举类型值的菜品对象！");
			}
		} 
		/// <summary>
		/// 通过配置的枚举值创建对象
		/// </summary>
		/// <returns></returns>
		public static AbstractFood CreateFoodByEnumConfig()
		{
			TypeFood typefood=(TypeFood)Enum.Parse(typeof(TypeFood),ConfigurationManager.AppSettings["TypeFoodByEnum"]);
			return CreateFoodByEnum(typefood);
		}
		/// <summary>
		/// 通过反射创建菜品
		/// </summary>
		/// <returns>AbstractFood菜品对象</returns>
		public static AbstractFood CreateFoodByReflectConfig()
		{
			Assembly assembly = Assembly.Load(ConstantStatic._foodTypeDLL);
			Type type= assembly.GetType(ConstantStatic._foodTypeCls);
			return Activator.CreateInstance(type) as AbstractFood;
		}
		
		public static AbstractFood CreateFoodByReflectConfig(string clsName)
		{
			Assembly assembly = Assembly.Load(ConstantStatic._foodTypeDLL);
			Type type = assembly.GetType(clsName);
			return Activator.CreateInstance(type) as AbstractFood;
		}
	}
}
