/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 7e7f6fff-b50e-4594-a876-2823a8e95d6f
 * 创建人:   朱展
 * 创建时间: 2022/7/14 21:54:19
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Design.Common
{
	public class JsonHelper
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T">返回T对象</typeparam>
		/// <param name="path">json文件路径</param>
		/// <returns></returns>
		public static T ToObj<T>(string config) where T:new()
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,config);
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
			string content= File.ReadAllText(path,Encoding.GetEncoding("gb2312"));
			return JsonConvert.DeserializeObject<T>(content);
		}
	}
}
