using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;

namespace ControlHMW
{
	/// <summary> Контрол видеопроигрывателя. </summary>
	public partial class PlayerControl : UserControl
	{
		#region Data

		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;
		private ProjectSettings _projectSettings;

		#endregion

		#region .ctor

		/// <summary> Создает контрол видеопроигрывателя. </summary>
		public PlayerControl(
			LogControler logControler,
			VideoPlayerControler videoPlayerControler,
			ProjectSettings projectSettings)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_logControler = logControler;
			_videoPlayerControler = videoPlayerControler;
			_projectSettings = projectSettings;

			_videoPlayerControler.ChangeImage += OnChangeImage;
			_videoPlayerControler.ChangeFrame += OnChangeFrame;
			_opnFileDialog.Filter = "Image|*.png; *.jpg|Video|*.mp4; *.avi;";

		}
		private void OnChangeFrame(object sender, Mat image)
		{
			_picPlayerContorl.ImageIpl = image;
			_picPlayerContorl.Refresh();

		}
		#endregion

		#region Handler

		/// <summary> Вызывается при необходимости изменить картинку на панели. </summary>
		private void OnChangeImage(object sender, string path) => _picPlayerContorl.Image = Image.FromFile(path);

		/// <summary> Вызывается по нажатию на кнопку открыть файл. </summary>
		private void OnOpenFileClick(object sender, EventArgs e)
		{
			if(_opnFileDialog.ShowDialog() == DialogResult.Cancel) return;

			if(_opnFileDialog.FilterIndex == (int)FilterType.Image)
			{
				_videoPlayerControler.OpenImage(_opnFileDialog.FileName);
			}
			else if(_opnFileDialog.FilterIndex == (int)FilterType.Video)
			{
				_videoPlayerControler.OpenVideo(_opnFileDialog.FileName);
			}
		}

		/// <summary>Вызывается при нажатии открыть папку. </summary>
		private void OnOpenFolderClick(object sender, EventArgs e)
		{
			if(_opnFolderDialog.ShowDialog() == DialogResult.Cancel) return;

			_videoPlayerControler.OpenFolderWithImages(_opnFolderDialog.SelectedPath);
		}

		/// <summary> Вызывается при нажатие на кнопку следующая картинка. </summary>
		private void OnNextClick(object sender, EventArgs e) => _videoPlayerControler.NextImage();

		/// <summary> Вызывается при нажатие на кнопку предыдущая картинка. </summary>
		private void OnPreviousClick(object sender, EventArgs e) => _videoPlayerControler.PreviousImage();

		#endregion

		

		/// <summary> Вызывается при нажатие на кнопку Пауз. </summary>
		private void _btnPause_Click(object sender, EventArgs e) => _videoPlayerControler.PauseVideo();


		/// <summary> Вызывается при нажатие на кнопку Стоп. </summary>
		private void _btnStop_Click(object sender, EventArgs e) => _videoPlayerControler.StopVideo();

		/// <summary> Вызывается при нажатие на кнопку Старт. </summary>
		//private void OnStartClick(object sender, EventArgs e) => _videoPlayerControler.PlayVideo();
		private void OnStartClick(object sender, EventArgs e) => _videoPlayerControler.PlayVideo();
		
	}
}
