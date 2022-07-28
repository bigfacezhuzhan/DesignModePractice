using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design.Common;
namespace DesignMode.Model.Menu
{
	/// <summary>
	/// 啤酒鸭
	/// </summary>
	public class BeerDuck: AbstractFood
	{
		public BeerDuck() : base("Config/BeerDuck.json")
		{ }
		public override void Show()
		{
			LogHelper.WriteLog("啤酒鸭一份", baseFood.color);
		}
		public override void Cooking()
		{
			LogHelper.WriteLog("后厨正在做啤酒鸭...", baseFood.color); 
		} 
	}
}
