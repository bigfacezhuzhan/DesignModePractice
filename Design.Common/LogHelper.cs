/*
 * Copyright (c) 2022 Microsoft All Rights Reserved.
 * CLR版本:  4.0.30319.42000
 * 唯一标识: 7547e536-c5f9-4fe6-aede-572e885ef36a
 * 创建人:   朱展
 * 创建时间: 2022/7/22 18:44:43
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Design.Common
{
	public class LogHelper
	{
		public static readonly object logLock = new object();//日志锁
		public static readonly object writeLock = new object();//打印锁
		/// <summary>
		/// 记录日志
		/// </summary>
		/// <param name="msg"></param>
		public static void MyLog(string msg)
		{
			StreamWriter sw = null;
			try
			{
				string path = AppDomain.CurrentDomain.BaseDirectory + "/MyLog";
				string fileName = DateTime.Now.ToString("yyyy-MM--dd") + "log.txt";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string virPath = Path.Combine(path, fileName);
				Task.Run(()=> {
					lock (logLock)
					{
						sw = File.AppendText(virPath);
						sw.WriteLine(msg + $" {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
						sw.Flush();
						sw.Close();
						sw.Dispose();
					}
				});

			}
			catch (Exception ex)
			{
				ErrorLog(ex);
			}
			finally {

			}
		}

		/// <summary>
		/// 记录错误日志
		/// </summary>
		/// <param name="ex"></param>
		public static void ErrorLog(Exception ex)
		{
			File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "/MyLog/Exception.txt",ex.Message+" "+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		}

		/// <summary>
		/// 打印信息并记录
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="color"></param>
		public static void WriteLog(string msg,ConsoleColor color=ConsoleColor.White)
		{ 
			lock (writeLock)
			{
				Thread.Sleep(200);
				Console.ForegroundColor = color;
				Console.WriteLine(msg);
				Console.ForegroundColor = ConsoleColor.White;
			} 
			MyLog(msg);
		}
	}
}
