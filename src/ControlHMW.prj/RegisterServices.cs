using Autofac;
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
		/// <summary>Метод для регистрации модулей, формы и создания контейнера./// </summary>
		/// <returns></returns>
		public static IContainer Create()
		{
			var containerBuilder = new ContainerBuilder(); // Создаем контейнер.

			containerBuilder
				.RegisterModule<MainFormModule>(); //Регистируем все обьекты Которые находяться в классе MainFormModule.

			containerBuilder 
				.RegisterType<MainForm1>() // Регистрируем саму форму.
				.AsSelf() // Не создаем обьект данного класса , а просто просим в конструкторе.
				.SingleInstance(); // Нужен для того что бы обьект был создан только 1 раз.

			return containerBuilder.Build(); // Возращаем метод постройки.
		}
	}
}
