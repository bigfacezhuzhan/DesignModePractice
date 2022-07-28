using System;
using Design.Common;
namespace DesignMode.Model.Menu
{
	/// <summary>
	/// 口味蛇
	/// </summary>
	public class TasteSnake : AbstractFood
	{
		public TasteSnake() : base("Config/TasteSnake.json") { }
		public override void Show()
		{
			LogHelper.WriteLog("口味蛇一份", base.baseFood.color);
		}
		public override void Cooking()
		{
			LogHelper.WriteLog("后厨正在做口味蛇...", baseFood.color);
		} 
	}
}
