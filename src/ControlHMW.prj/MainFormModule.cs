using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHMW
{
	/// <summary>Класс модулей унаследованный от класса Module из AutoFac./// </summary>
	class MainFormModule : Module
	{
		/// <summary>Переопределяем метод Load из AutoFac./// </summary>
		/// <param name="builder">Передаем контейнер.</param>
		protected override void Load(ContainerBuilder builder)
		{
			builder
			.RegisterType<ProjectSettings>()  // Регистрируем тип ProjectSettings.
			.AsSelf() // Не создаем обьект данного класса , а просто просим в конструкторе.
			.SingleInstance(); // Нужен для того что бы обьект был создан только 1 раз.
		}
	}
}
