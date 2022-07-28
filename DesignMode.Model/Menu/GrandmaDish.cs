using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design.Common;
namespace DesignMode.Model.Menu
{
	/// <summary>
	/// 外婆菜
	/// </summary>
	public class GrandmaDish : AbstractFood
	{
		public GrandmaDish() : base("Config/GrandmaDish.json") { }
		public override void Show() {
			LogHelper.WriteLog("外婆菜一份", base.baseFood.color);
		}
		public override void Cooking()
		{
			LogHelper.WriteLog("后厨正在做外婆菜...", baseFood.color);
		} 
	}
}
