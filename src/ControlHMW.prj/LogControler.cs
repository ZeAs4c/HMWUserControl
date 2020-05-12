﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ControlHMW
{
	/// <summary> Лог контроллер </summary>
	public class LogControler
	{
		#region Data

		private string _path = "Logs\\Log.txt";

		#endregion

		#region .ctor

		/// <summary> Создает контроллер лога. </summary>
		public LogControler()
		{
			var dirLog = new DirectoryInfo($"Logs");
			IsDirectoryExists(dirLog);

		}

		#endregion

		#region Events

		/// <summary> Вызывается при добавлении сообщения в лог. </summary>
		public event EventHandler<string> AddMessageInLog;

		#endregion

		#region Handler
		/// <summary> Обработчик события добавления сообщения в лог. </summary>
		/// <param name="text"> Текст добавляемого сообщения. </param>
		private void OnAddMessageInLog(string text)
		{
			if(AddMessageInLog != null)
			{
				AddMessageInLog.Invoke(null, text);
			}
		}

		#endregion

		#region Methods

		/// <summary> Добавить Сообщение в лог.</summary>
		/// <param name="text">Тест сообщения.</param>
		public void AddMessage(string text)
		{
			var msg = $"[{DateTime.Now}] - " + text + "\n";
			OnAddMessageInLog(msg);
			SaveLogInFile(msg);
		}

		/// <summary> Сохраняет тест лога в файл. </summary>
		public void SaveLogInFile(string text)
		{
			using(FileStream fileStreamWriter = new FileStream(_path, FileMode.Append))
			{

				byte[] array = Encoding.Default.GetBytes(text);
				fileStreamWriter.Write(array, 0, array.Length);
			}
		}

		/// <summary>Проверка существет ли катлог, если нет, то создает его.</summary>
		/// <param name="directoryInfo"> Информация о директории.</param>
		public void IsDirectoryExists(DirectoryInfo directoryInfo)
		{

			if(!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
		}

		/// <summary> Считывает данные из файла с логом.</summary>
		public void OpenFileInLog()
		{
			using(StreamReader streamReader = new StreamReader(_path))
			{
				MessageBox.Show(streamReader.ReadToEnd(), "Лог", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		#endregion
	}
}
