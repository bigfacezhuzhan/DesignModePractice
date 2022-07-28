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
	/// 南方口味
	/// </summary>
	public interface ISouthFlavor
	{
		/// <summary>
		/// 三菜
		/// </summary>
		/// <returns></returns>
		AbstractFood CreateBeerDuck();
		AbstractFood CreateBraisedPork();
		AbstractFood CreateGrandmaDish();

		/// <summary>
		/// 一汤
		/// </summary>
		/// <returns></returns>
		AbstractSoup CreateCornBornSoup();

		/// <summary>
		/// 一主食
		/// </summary>
		/// <returns></returns>
		Rice CreateRice();
	}
}
