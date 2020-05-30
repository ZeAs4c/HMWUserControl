using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OpenCvSharp;
using System.Threading.Tasks;

namespace ControlHMW
{
	/// <summary> Контроллер для видеопроигрывателя. </summary>
	public class VideoPlayerControler
	{
		#region Data

		private List<string> _listImage;
		private int _curerntIamge;
		private int _countImage;

		private ProjectSettings _projectSettings;
		private LogControler _logControler;

		private VideoCapture _capture;
		private int _fps;

		private bool _pause;
		private bool _stop;

		string transmitted; // Эта переменная нужна для того что бы сохранять(запоминать) передоваемый параметр в методе OpenVideo.
		#endregion

		#region Event

		/// <summary> Вызывается при  изменении картинки.</summary>
		public event EventHandler<string> ChangeImage;

		/// <summary> Вызывается при  изменении кадра.</summary>
		public event EventHandler<Mat> ChangeFrame;

		#endregion

		#region Handler

		/// <summary> Обработчик события изменения картинки на панели. </summary>
		/// <param name="path"> Путь к картинке. </param>
		private void OnChangeImage(string path)
		{
			if(ChangeImage != null)
			{
				ChangeImage.Invoke(null, path);
			}
		}


		/// <summary> Обработчик события изменения кадра. </summary>
		/// <param name="image"> кадр. </param>
		private void OnChangeFrame(Mat image)
		{
			if(ChangeFrame != null)
			{
				ChangeFrame.Invoke(null, image);
			}
		}

		#endregion

		#region .ctor

		/// <summary> Создает контролер для видеопроигрывателя. </summary>
		public VideoPlayerControler(
			ProjectSettings projectSettings,
			LogControler logControler)
		{
			_projectSettings = projectSettings;
			_logControler = logControler;
		}

		#endregion

		#region MethodsImage

		/// <summary> Открыть одну картинку. </summary>
		/// <param name="path">Путь к картинке. </param>
		public void OpenImage(string path)
		{
			AddImageOnControl(path);
		}

		/// <summary> Открыть директорию с картинками. </summary>
		/// <param name="path"> Путь к директории. </param>
		public void OpenFolderWithImages(string path)
		{
			try
			{
				IEnumerable<string> _filesDirectory = null;

				if(_projectSettings.IsUnderCatalog)
				{
					_filesDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
					   .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"));
				}
				else
				{
					_filesDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
						.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"));
				}


				_listImage = _filesDirectory.ToList();

				_curerntIamge = 0;
				_countImage = _filesDirectory.Count();

				AddImageOnControl(_listImage[_curerntIamge]);
				_logControler.AddMessage($"{_curerntIamge} {_countImage}");
			}
			catch(Exception ex)
			{
				//_logControler.AddMessage("Изображений не найдено!");
				DialogResult result = MessageBox.Show(
				 "Изображений не найдено!  \n" + ex.Message + ex.TargetSite + ex.StackTrace,
				 "Сообщение",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			}
		}

		/// <summary> Добавить картинку на Контрол. </summary>
		/// <param name="path"> Путь к картинке. </param>
		private void AddImageOnControl(string path)
		{
			OnChangeImage(path);
		}

		/// <summary> Переход к следующей картинке. </summary>
		public void NextImage()
		{
			if(_listImage != null && _listImage.Count != 0)
			{
				
				_curerntIamge++;

				if(_curerntIamge == _countImage)
				{
					_curerntIamge = 0;
				}
				
					
			
				AddImageOnControl(_listImage[_curerntIamge]);
				_logControler.AddMessage($"{_curerntIamge} {_countImage}");
			}
		}

		/// <summary> Переход к предыдущей картинке. </summary>
		public void PreviousImage()
		{
			if(_listImage != null && _listImage.Count != 0)
			{
				if(_curerntIamge <= 0)
				{
					_curerntIamge = _countImage - 1;
				}
				else
					_curerntIamge--;
				
				AddImageOnControl(_listImage[_curerntIamge]);
				_logControler.AddMessage($"{_curerntIamge} {_countImage}");
			}
		}
		#endregion

		#region MethodsVideo
		/// <summary> открыть видео </summary>
		/// <param name="path"></param>
		public async Task OpenVideo(string path)
		{
				transmitted = path;                      // Запоминаем параметр что бы использовать его для возврата на 1 кадр, когда нажмаем кнопку стоп.
				if(_capture != null) _capture.Dispose();
				_capture = new VideoCapture(path);
				_fps =1;

				using(Mat image = new Mat())
				{
					_capture.Read(image);
					if(!image.Empty())
					{
						await NextFrameAddInVideoControl(image);
						_pause = false;
						if(_stop)
						{
							_stop = false;
						}
						else
						{
							_stop = false;
							await PlayVideo();
						}
					
					}
					else
					{
						_logControler.AddMessage("Некорректное видео!");
					}
				}
		}

		/// <summary> Воспроизвести видео. </summary>
		public async Task PlayVideo()
		{
				if(_pause) _pause = false;
				if(_stop) _stop = false;
				while(true)
				{
					if(_capture != null)
					{

						if(_pause) break;
						if(_stop)
						{
							_capture.Dispose();

						await OpenVideo(transmitted); // Вызываем функцию OpenVideo и передаем ей параметр, что бы при нажатии на кнопку старт видео запустилось с самого начала.
							 break;
						}
						using(Mat image = new Mat())
						{
							_capture.Read(image);
							if(image.Empty())
							{
								_logControler.AddMessage("Конец видео!");
								break;
							}
						await NextFrameAddInVideoControl(image);
						await Task.Delay(_fps);
						}

					}

				}
		}

		/// <summary> Остановить видео </summary>
		public async Task StopVideo()
		{
				_stop = true;
		}
		/// <summary> Пауза в видео </summary>
		public async Task PauseVideo()
		{
			await Task.Run(() =>
			{
				if(_capture != null) _pause = true;
			});
		}

		/// <summary>Отобразить следующий кадр</summary>
		/// <param name="image"></param>
		private async Task NextFrameAddInVideoControl(Mat image)
		{
			OnChangeFrame(image);
		}
		#endregion
	}
} 
