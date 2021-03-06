﻿using System.IO;
using System.Xml.Linq;
namespace ControlHMW
{

	/// <summary> Настройки проекта. </summary>
	public class ProjectSettings
	{
		#region Data

		private LogControler _logControler;
		private string _pathXML = "project.xml";

		#endregion

		#region Property

		/// <summary>Указывает, используется ли детектор</summary>
		public bool IsDetector { get; set; }

		/// <summary>Указывает, открывать ли папки с подкаталогами. </summary>
		public bool IsUnderCatalog { get; set; }

		#endregion

		#region .ctor

		/// <summary> Создать настройки проекта. </summary>
		public ProjectSettings(LogControler logControler)
		{
			_logControler = logControler;

			if(File.Exists(_pathXML))
			{
				LoadXML();
			}
			
		}

		#endregion

		#region Methods

		/// <summary> Сохранить настройки проекта. </summary>
		public void SaveXML()
		{
			XElement element;

			XDocument xdoc = new XDocument();

			XElement project = new XElement("WinForm");

			element = new XElement("IsDetector", IsDetector);
			
			project.Add(element);

			element = new XElement("IsUnderCatalog", IsUnderCatalog);
			project.Add(element);


			xdoc.Add(project);

			xdoc.Save(_pathXML);

			_logControler.AddMessage("Save project setting in XML file.");


		}

		/// <summary> Загрузить настройки проекта.</summary>
		public void LoadXML()
		{
			XDocument xdoc = XDocument.Load(_pathXML);

			IsDetector = bool.Parse(xdoc.Root.Element("IsDetector").Value);
			IsUnderCatalog = bool.Parse(xdoc.Root.Element("IsUnderCatalog").Value);

			_logControler.AddMessage($"{IsDetector} - {IsUnderCatalog}");
		}

		#endregion
	}
}
