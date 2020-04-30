namespace ControlHMW
{
	partial class SettingsControl
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
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._btnOpenFolder = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnRightward = new System.Windows.Forms.Button();
			this._btnLeftward = new System.Windows.Forms.Button();
			this._btnStop = new System.Windows.Forms.Button();
			this._btnPause = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.Location = new System.Drawing.Point(15, 15);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(107, 23);
			this._btnOpenFile.TabIndex = 0;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// _btnOpenFolder
			// 
			this._btnOpenFolder.Location = new System.Drawing.Point(128, 15);
			this._btnOpenFolder.Name = "_btnOpenFolder";
			this._btnOpenFolder.Size = new System.Drawing.Size(104, 23);
			this._btnOpenFolder.TabIndex = 1;
			this._btnOpenFolder.Text = "Открыть папку";
			this._btnOpenFolder.UseVisualStyleBackColor = true;
			// 
			// _btnStart
			// 
			this._btnStart.Location = new System.Drawing.Point(3, 270);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(75, 23);
			this._btnStart.TabIndex = 2;
			this._btnStart.Text = "Старт";
			this._btnStart.UseVisualStyleBackColor = true;
			// 
			// _btnRightward
			// 
			this._btnRightward.Location = new System.Drawing.Point(128, 308);
			this._btnRightward.Name = "_btnRightward";
			this._btnRightward.Size = new System.Drawing.Size(75, 23);
			this._btnRightward.TabIndex = 3;
			this._btnRightward.Text = ">>";
			this._btnRightward.UseVisualStyleBackColor = true;
			// 
			// _btnLeftward
			// 
			this._btnLeftward.Location = new System.Drawing.Point(30, 308);
			this._btnLeftward.Name = "_btnLeftward";
			this._btnLeftward.Size = new System.Drawing.Size(75, 23);
			this._btnLeftward.TabIndex = 4;
			this._btnLeftward.Text = "<<";
			this._btnLeftward.UseVisualStyleBackColor = true;
			// 
			// _btnStop
			// 
			this._btnStop.Location = new System.Drawing.Point(170, 270);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(75, 23);
			this._btnStop.TabIndex = 5;
			this._btnStop.Text = "Стоп";
			this._btnStop.UseVisualStyleBackColor = true;
			// 
			// _btnPause
			// 
			this._btnPause.Location = new System.Drawing.Point(89, 270);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(75, 23);
			this._btnPause.TabIndex = 6;
			this._btnPause.Text = "Пауза";
			this._btnPause.UseVisualStyleBackColor = true;
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Controls.Add(this._btnPause);
			this.Controls.Add(this._btnStop);
			this.Controls.Add(this._btnLeftward);
			this.Controls.Add(this._btnRightward);
			this.Controls.Add(this._btnStart);
			this.Controls.Add(this._btnOpenFolder);
			this.Controls.Add(this._btnOpenFile);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(250, 343);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.Button _btnOpenFolder;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnRightward;
		private System.Windows.Forms.Button _btnLeftward;
		private System.Windows.Forms.Button _btnStop;
		private System.Windows.Forms.Button _btnPause;
	}
}
