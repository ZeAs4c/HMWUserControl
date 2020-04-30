using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlHMW
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			using(var container = RegisterServices.Create()) // Контейнер существет пока существет наша программа.
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(container.Resolve<MainForm1>()); // Методом Resolve разрешаем зависимость от MainForm1.
			}
		}
	}
}
