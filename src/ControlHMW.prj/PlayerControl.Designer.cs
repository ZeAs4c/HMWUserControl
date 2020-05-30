using System.Threading.Tasks;
namespace ControlHMW
{
	partial class PlayerControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlButControl = new System.Windows.Forms.Panel();
			this._btnStop = new System.Windows.Forms.Button();
			this._btnPause = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnOpenFolder = new System.Windows.Forms.Button();
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._btnLeftward = new System.Windows.Forms.Button();
			this._btnRightward = new System.Windows.Forms.Button();
			this._opnFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._opnFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._picPlayerContorl = new OpenCvSharp.UserInterface.PictureBoxIpl();
			this._pnlButControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._picPlayerContorl)).BeginInit();
			this.SuspendLayout();
			// 
			// _pnlButControl
			// 
			this._pnlButControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlButControl.BackColor = System.Drawing.Color.Black;
			this._pnlButControl.Controls.Add(this._btnStop);
			this._pnlButControl.Controls.Add(this._btnPause);
			this._pnlButControl.Controls.Add(this._btnStart);
			this._pnlButControl.Controls.Add(this._btnOpenFolder);
			this._pnlButControl.Controls.Add(this._btnOpenFile);
			this._pnlButControl.Controls.Add(this._btnLeftward);
			this._pnlButControl.Controls.Add(this._btnRightward);
			this._pnlButControl.Location = new System.Drawing.Point(-5, 307);
			this._pnlButControl.Name = "_pnlButControl";
			this._pnlButControl.Size = new System.Drawing.Size(604, 87);
			this._pnlButControl.TabIndex = 1;
			// 
			// _btnStop
			// 
			this._btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnStop.Location = new System.Drawing.Point(506, 34);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(75, 23);
			this._btnStop.TabIndex = 10;
			this._btnStop.Text = "Стоп";
			this._btnStop.UseVisualStyleBackColor = true;
			this._btnStop.Click += new System.EventHandler(this._btnStop_ClickAsync);
			// 
			// _btnPause
			// 
			this._btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnPause.Location = new System.Drawing.Point(425, 34);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(75, 23);
			this._btnPause.TabIndex = 9;
			this._btnPause.Text = "Пауза";
			this._btnPause.UseVisualStyleBackColor = true;
			this._btnPause.Click += new System.EventHandler(this._btnPause_ClickAsync);
			// 
			// _btnStart
			// 
			this._btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnStart.Location = new System.Drawing.Point(344, 34);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(75, 23);
			this._btnStart.TabIndex = 8;
			this._btnStart.Text = "Старт";
			this._btnStart.UseVisualStyleBackColor = true;
			this._btnStart.Click += new System.EventHandler(this.OnStartClickAsync);
			// 
			// _btnOpenFolder
			// 
			this._btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnOpenFolder.Location = new System.Drawing.Point(8, 47);
			this._btnOpenFolder.Name = "_btnOpenFolder";
			this._btnOpenFolder.Size = new System.Drawing.Size(107, 23);
			this._btnOpenFolder.TabIndex = 7;
			this._btnOpenFolder.Text = "Открыть папку";
			this._btnOpenFolder.UseVisualStyleBackColor = true;
			this._btnOpenFolder.Click += new System.EventHandler(this.OnOpenFolderClick);
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnOpenFile.Location = new System.Drawing.Point(8, 18);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(107, 23);
			this._btnOpenFile.TabIndex = 6;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = true;
			this._btnOpenFile.Click += new System.EventHandler(this.OnOpenFileClick);
			// 
			// _btnLeftward
			// 
			this._btnLeftward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnLeftward.Location = new System.Drawing.Point(133, 34);
			this._btnLeftward.Name = "_btnLeftward";
			this._btnLeftward.Size = new System.Drawing.Size(75, 23);
			this._btnLeftward.TabIndex = 5;
			this._btnLeftward.Text = "<<";
			this._btnLeftward.UseVisualStyleBackColor = true;
			this._btnLeftward.Click += new System.EventHandler(this.OnPreviousClick);
			// 
			// _btnRightward
			// 
			this._btnRightward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnRightward.Location = new System.Drawing.Point(214, 34);
			this._btnRightward.Name = "_btnRightward";
			this._btnRightward.Size = new System.Drawing.Size(75, 23);
			this._btnRightward.TabIndex = 4;
			this._btnRightward.Text = ">>";
			this._btnRightward.UseVisualStyleBackColor = true;
			this._btnRightward.Click += new System.EventHandler(this.OnNextClick);
			// 
			// _opnFileDialog
			// 
			this._opnFileDialog.FileName = "openFileDialog1";
			// 
			// _picPlayerContorl
			// 
			this._picPlayerContorl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._picPlayerContorl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this._picPlayerContorl.Location = new System.Drawing.Point(0, 0);
			this._picPlayerContorl.Name = "_picPlayerContorl";
			this._picPlayerContorl.Size = new System.Drawing.Size(596, 319);
			this._picPlayerContorl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._picPlayerContorl.TabIndex = 11;
			this._picPlayerContorl.TabStop = false;
			// 
			// PlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.Controls.Add(this._picPlayerContorl);
			this.Controls.Add(this._pnlButControl);
			this.Name = "PlayerControl";
			this.Size = new System.Drawing.Size(594, 394);
			this._pnlButControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._picPlayerContorl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel _pnlButControl;
		private System.Windows.Forms.Button _btnRightward;
		private System.Windows.Forms.Button _btnLeftward;
		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.Button _btnOpenFolder;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnPause;
		private System.Windows.Forms.Button _btnStop;
		private System.Windows.Forms.OpenFileDialog _opnFileDialog;
		private System.Windows.Forms.FolderBrowserDialog _opnFolderDialog;
		private OpenCvSharp.UserInterface.PictureBoxIpl _picPlayerContorl;
	}
}
