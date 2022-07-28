using Decorator;
using Design.Common;
using DesignMode.Factory;
using DesignMode.Model;
using DesignMode.Model.Menu;
using DesignMode.Model.Soup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignModePractice
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				#region 普通方法展示菜品
				//DongAnChicken dongAnChicken = new DongAnChicken();
				//dongAnChicken.Show();
				//TasteSnake tasteSnake = new TasteSnake();
				//tasteSnake.Show();
				//GrandmaDish grandmaDish = new GrandmaDish();
				//grandmaDish.Show();
				//BraisedPork braised = new BraisedPork();
				//braised.Show();
				//BeerDuck beerDuck = new BeerDuck();
				//beerDuck.Show();
				#endregion
				#region 简单工厂、工厂分类、抽象工厂
				//使用枚举传值
				//SimpleFactory.CreateFoodByEnum(TypeFood.BeerDuck).Show();
				////使用配置文件给枚举传值
				//SimpleFactory.CreateFoodByEnumConfig().Show();
				////使用配置文件信息利用反射创建菜品对象
				//SimpleFactory.CreateFoodByReflectConfig().Show();

				////使用工厂分类创建菜品
				//new DongAnChickenFactory().CreateFood().Show();
				//new BraisedPorkFactory().CreateFood().Show();

				//使用抽象工厂创建菜品  产品簇

				//南方菜品抽象
				//ISouthFlavor southFlavor = new SouthFlavorAbstractFactory();
				//southFlavor.CreateBeerDuck().Show();
				//southFlavor.CreateBraisedPork().Show();
				//southFlavor.CreateGrandmaDish().Show();
				//southFlavor.CreateCornBornSoup().Show();
				//southFlavor.CreateRice().Show(); 
				////北方菜品抽象
				//INorthFlavor northFlavor = new NorthFlavorAbstractFactory();
				//northFlavor.CreateDongAnChiken();
				//northFlavor.CreateGrandmaDish();
				//northFlavor.CreateTasteSnake();
				//northFlavor.CreateHaggisSoup();
				//northFlavor.CreateRice();
				#endregion
				#region 单例生成菜单、根据id点菜
				//菜单
				//CaiDan cais = CaiDan.CreateMenuList();
				//Console.WriteLine("菜类：");
				//foreach (BaseFood food in cais.baseFoods)
				//{
				//	LogHelper.WriteLog($"编号：{food.FoodId} 菜名：{food.FoodName}", ConsoleColor.Green);
				//}
				//Console.WriteLine();
				//Console.WriteLine("汤类：");
				//foreach (BaseSoup soup in cais.baseSoups.OrderBy(o => o.SoupId))
				//{
				//	LogHelper.WriteLog($"编号：{soup.SoupId} 汤名：{soup.SoupName}", ConsoleColor.Yellow);
				//}
				//LogHelper.WriteLog("请输入菜名编号：");
				//while (true)
				//{
				//	if (!int.TryParse(Console.ReadLine(), out int input))
				//	{
				//		LogHelper.WriteLog("请输入正确的数字！", ConsoleColor.DarkBlue);
				//	}
				//	else
				//	{
				//		var cur_food = cais.baseFoods.FirstOrDefault(x => x.FoodId == input);
				//		if (cur_food == null)
				//		{
				//			LogHelper.WriteLog("请输入菜单列表中的对应编号", ConsoleColor.DarkCyan);
				//		}
				//		else
				//		{
				//			LogHelper.WriteLog($"菜名：{cur_food.FoodName} 价格为：{cur_food.Price} 综合评分：{cur_food.Score}", ConsoleColor.DarkMagenta);
				//			AbstractFood abstractFood = SimpleFactory.CreateFoodByReflectConfig();
				//			abstractFood.Cooking();
				//			abstractFood.Taste();
				//			abstractFood.Comment();
				//			break;
				//		}
				//	}
				//}

				{
					//char[] title = "*****下面开始多线程点菜模式*****".ToCharArray();
					//List<Task> taskList = new List<Task>();
					//for (int i = 0; i < title.Length; i++)
					//{
					//	Thread.Sleep(10);
					//	Console.Write(title[i].ToString());
					//}
					//Console.WriteLine();
					//CaiDan menu = CaiDan.CreateMenuList();
					//char[] customs = { '甲', '乙', '丙'};
					//Dictionary<string, Dictionary<AbstractFood, int>> pairs = new Dictionary<string, Dictionary<AbstractFood, int>>();
					//foreach (var cus in customs)
					//{ 
					//		List<BaseFood> foodList = menu.GetRandFood();//客人随机点的五个菜
					//		LogHelper.WriteLog($"客人 ({cus}) 点了 {string.Join('、', foodList.Select(x => x.FoodName))}", ConsoleColor.Cyan);
					//		Dictionary<AbstractFood, int> dicFiveMax = new Dictionary<AbstractFood, int>();//这里的key也可以用菜名(5个菜各不相同)
					//		foreach (var food in foodList)
					//		{
					//			AbstractFood food1 = SimpleFactory.CreateFoodByReflectConfig(food.simpleStr);
					//			food1.Cooking();//做菜中...
					//			food1.Taste(cus.ToString());//品尝...
					//			food1.baseFood.Score = food1.Comment();//评分 （此处是1-5的随机数）
					//			LogHelper.WriteLog($"客人 ({cus}) 给《{food.FoodName}》点评 （{food1.baseFood.Score}）分", ConsoleColor.Blue);
					//			dicFiveMax.Add(food1, (int)food1.baseFood.Score);
					//		}
					//		pairs.Add(cus.ToString(), dicFiveMax);//多线程时考虑到线程安全 此处应加锁

					//		int maxScore = dicFiveMax.Values.Max();//五个菜中的最高分
					//		//遍历评分为maxScore的菜 （被评满分的菜可能不止一个）
					//		foreach (var item in dicFiveMax.Where(x => x.Value == maxScore))
					//		{
					//			LogHelper.WriteLog($"客人{cus.ToString()}中的最高评分为{item.Value} 菜名《{item.Key.baseFood.FoodName}》", ConsoleColor.Yellow);
					//		}
					//		Console.WriteLine(); 
					//}

					//Console.WriteLine("*****************计算所有人中的最高分菜系****************");
					//int totalMax= pairs.Values.Max(x => x.Values.Max());//所有已点菜中的最高分
					//foreach (var cus in pairs)
					//{
					//	foreach (var item in cus.Value.Where(x=>x.Value==totalMax))
					//	{
					//		LogHelper.WriteLog($"客人({cus.Key}) 的最高分食物是《{item.Key.baseFood.FoodName}》 分数为{item.Value}分",ConsoleColor.Cyan);
					//	}
					//}
				}
				#endregion
				#region 装饰器模式
				AbstractFood food= SimpleFactory.CreateFoodByReflectConfig();
				food= new BuyFoodDecorator(food);
				food= new WashFoodDecorator(food);
				food= new CutFoodDecorator(food); 
				food= new PlateFoodDecorator(food);
				food= new ServeFoodDecorator(food);
				food.Cooking();
				#endregion
				#region 观察者模式
				//AbstractFood food2 = SimpleFactory.CreateFoodByReflectConfig();
				//food2.FullScoreHandle += () => { Console.WriteLine("食客"); };
				//food2.FullScoreHandle += () => { Console.WriteLine("媒体朋友"); };
				//food2.FullScoreHandle += () => { Console.WriteLine("围观群众"); };
				//food2.Comment();
				#endregion
			}
			catch (Exception ex)
			{
				LogHelper.ErrorLog(ex);
			}
		}
	}
}
