using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design.Common;
namespace DesignMode.Model.Menu
{
	public abstract class AbstractFood
	{
		public AbstractFood() { }//为了配合装饰器模式
		public BaseFood baseFood;
		public AbstractFood(string config)
		{
			baseFood = JsonHelper.ToObj<BaseFood>(config);
		}
		public abstract void Show();
		/// <summary>
		/// 品尝
		/// </summary>
		public void Taste(string name) {
			LogHelper.WriteLog($"顾客{name}正在品尝...",ConsoleColor.Yellow);
		}
		/// <summary>
		/// 点评
		/// </summary>
		public  int Comment() {
			int result= new Random(DateTime.Now.Millisecond).Next(1, 6);
			Console.WriteLine($"给出了{result}的评分");
			if (result == 5)
			{
				this.OnFullScoreHandle();
			}
			return result;
		}
		/// <summary>
		/// 做菜
		/// </summary>
		public abstract void Cooking();

		/// <summary>
		/// 满分事件
		/// </summary>
		public event Action FullScoreHandle;
		/// <summary>
		/// 触发满分事件条件
		/// </summary>
		public void OnFullScoreHandle()
		{
			if (FullScoreHandle != null)
			{
				this.FullScoreHandle.Invoke();
			}
		}
	}
}
