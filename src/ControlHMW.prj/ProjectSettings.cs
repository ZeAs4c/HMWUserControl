using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlHMW
{
	public class ProjectSettings
	{
		/// <summary>Свойство Path./// </summary>
		public string Path { get; set; }

		/// <summary>Свойство Count./// </summary>
		public int Count { get; set; }
		/// <summary>Конструктор класса./// </summary>
		public ProjectSettings()
		{
			Path = "Тут что то должно быть написано =)"; // Присваиваем значение Path.
			Count = 4; // Присваеиваем значение Count.
		}
	}
}
