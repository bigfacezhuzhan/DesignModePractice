using DesignMode.Model;
using DesignMode.Model.Menu;
using DesignMode.Model.Soup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Practice.Interface
{
	/// <summary>
	/// 北方口味
	/// </summary>
	public interface INorthFlavor
	{
		/// <summary>
		/// 三菜
		/// </summary>
		/// <returns></returns>
		AbstractFood CreateDongAnChiken();
		AbstractFood CreateTasteSnake();
		AbstractFood CreateGrandmaDish();

		/// <summary>
		/// 一汤
		/// </summary>
		/// <returns></returns>
		AbstractSoup CreateHaggisSoup();

		/// <summary>
		/// 一主食
		/// </summary>
		/// <returns></returns>
		Rice CreateRice();
	}
}
