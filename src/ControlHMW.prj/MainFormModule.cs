﻿using Autofac;


namespace ControlHMW
{
	/// <summary>Класс модулей унаследованный от класса Module из AutoFac./// </summary>
	class MainFormModule : Module
	{
		/// <summary>Переопределяем метод Load из AutoFac./// </summary>
		/// <param name="builder">Передаем контейнер.</param>
		protected override void Load(ContainerBuilder builder)
		{
			//builder
			//.RegisterType<ProjectSettings>()  // Регистрируем тип ProjectSettings.
			//.AsSelf() // Не создаем обьект данного класса , а просто просим в конструкторе.
			//.SingleInstance(); // Нужен для того что бы обьект был создан только 1 раз.
			base.Load(builder);
			builder
				.RegisterType<LogControler>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<ProjectSettings>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<VideoPlayerControler>()
				.AsSelf()
				.SingleInstance();
		}
	}
}
