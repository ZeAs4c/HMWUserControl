using System.Windows.Forms;


namespace ControlHMW
{
	public partial class MainForm1 : Form
	{
		#region Data

		private LogControl _log;
		private SettingsControl _setting;
		private PlayerControl _videoPlayer;

		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;
		private ProjectSettings _projectSettings;

		#endregion

		#region .ctor

		/// <summary> Запуск главной формы. </summary>
		public MainForm1(
			LogControler logControler,
			VideoPlayerControler videoPlayerControler,
			ProjectSettings projectSettings)
		{
			InitializeComponent();


			_logControler = logControler;
			_videoPlayerControler = videoPlayerControler;
			_projectSettings = projectSettings;

			_log = new LogControl(_logControler);
			_setting = new SettingsControl(_logControler, _projectSettings);
			_videoPlayer = new PlayerControl(_logControler, _videoPlayerControler, _projectSettings);

			_pnlLog.Controls.Add(_log);
			_pnlSetting.Controls.Add(_setting);
			_pnlVideoPlayer.Controls.Add(_videoPlayer);

		}

		#endregion

	}
}
