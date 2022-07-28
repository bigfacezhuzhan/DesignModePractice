using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design.Common;
namespace DesignMode.Model.Menu
{
	/// <summary>
	/// 红烧肉
	/// </summary>
	public class BraisedPork: AbstractFood
	{
		public BraisedPork() : base("Config/BraisedPork.json")
		{ }
		public override void Show()
		{
			LogHelper.WriteLog("红烧肉一份", base.baseFood.color);
		}
		public override void Cooking()
		{
			LogHelper.WriteLog("后厨正在做红烧肉...", baseFood.color);
		} 
	}
}
