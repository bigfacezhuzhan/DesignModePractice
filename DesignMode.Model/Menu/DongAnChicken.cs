using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design.Common;
namespace DesignMode.Model.Menu
{
	/// <summary>
	/// 东安鸡
	/// </summary>
	public class DongAnChicken : AbstractFood
	{
		public DongAnChicken() : base("Config/DongAnChicken.json")
		{ }
		public override void Show()
		{
			LogHelper.WriteLog("东安鸡一份", base.baseFood.color);
		}
		public override void Cooking()
		{
			LogHelper.WriteLog("后厨正在做东安鸡...", baseFood.color);
		} 
	}
}
