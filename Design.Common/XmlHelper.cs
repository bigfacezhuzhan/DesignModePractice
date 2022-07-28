/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 986a3304-464e-43ce-ae7b-c9b824d70d4f
 * 创建人:   朱展
 * 创建时间: 2022/7/26 11:45:36
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Design.Common
{
	public class XmlHelper
	{
		/// <summary>
		/// 反序列化XML文件
		/// </summary>
		/// <typeparam name="T">返回类型</typeparam>
		/// <param name="xmlConfig">XML根目录路径</param>
		/// <param name="encoding">编码格式</param>
		/// <returns></returns>
		public static T ToObjXml<T>(string xmlConfig,Encoding encoding)
		{
			xmlConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, xmlConfig);
			string xmlStr= File.ReadAllText(xmlConfig, Encoding.UTF8);//读取xml文件内容
			XmlSerializer xs = new XmlSerializer(typeof(T));//xml序列化器
			using (MemoryStream ms=new MemoryStream (encoding.GetBytes(xmlStr)))
			{
				using (StreamReader sr=new StreamReader (ms))
				{
					return (T)xs.Deserialize(sr);
				}
			} 
		}
	}
}
