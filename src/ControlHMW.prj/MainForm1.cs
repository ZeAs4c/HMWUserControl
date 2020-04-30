using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlHMW
{
	public partial class MainForm1 : Form
	{
		private ProjectSettings _projectSettings;

		/// <summary>Конструктор Формы./// </summary>
		/// <param name="projectSettings">Передаем в конструктор обьект.</param>
		public MainForm1(ProjectSettings projectSettings)
		{
			InitializeComponent();
			var playerControl = new PlayerControl(); // Cоздаем обьект playerControl.
			_panelPlayerControl.Controls.Add(playerControl); // Добовляем его на панель.
			playerControl.Dock = DockStyle.Fill; // Расстягиваем контрол на всю панель.


		   var settingControls = new SettingsControl(); // Cоздаем обьект settingControls.
			_panelSettingsControl.Controls.Add(settingControls); // Добовляем его на панель.
			settingControls.Dock = DockStyle.Fill; // Расстягиваем контрол на всю панель.

			var logControl = new LogControl(); // Cоздаем обьект logControl.
			_panelLogControl.Controls.Add(logControl); // Добовляем его на панель.
			logControl.Dock = DockStyle.Fill; // Расстягиваем контрол на всю панель.

			_projectSettings = projectSettings; // Присваиваем обьект projectSettings.

		}

		
	}
}
