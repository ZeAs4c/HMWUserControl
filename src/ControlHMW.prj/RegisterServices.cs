﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHMW
{
	/// <summary>Кдасс регистрации./// </summary>
	public static class RegisterServices
	{
		#region Method
		/// <summary>Метод для регистрации модулей, формы и создания контейнера./// </summary>
		/// <returns></returns>
		public static IContainer Create()
		{
			var containerBulder = new ContainerBuilder();

			containerBulder
				.RegisterModule<MainFormModule>();

			containerBulder
				.RegisterType<MainForm1>()
				.AsSelf();

			return containerBulder.Build();

		}
		#endregion
	}
}
