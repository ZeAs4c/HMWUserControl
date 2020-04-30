namespace ControlHMW
{
	partial class MainForm1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._panelPlayerControl = new System.Windows.Forms.Panel();
			this._panelSettingsControl = new System.Windows.Forms.Panel();
			this._panelLogControl = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _panelPlayerControl
			// 
			this._panelPlayerControl.BackColor = System.Drawing.Color.White;
			this._panelPlayerControl.Location = new System.Drawing.Point(0, 12);
			this._panelPlayerControl.Name = "_panelPlayerControl";
			this._panelPlayerControl.Size = new System.Drawing.Size(267, 426);
			this._panelPlayerControl.TabIndex = 0;
			// 
			// _panelSettingsControl
			// 
			this._panelSettingsControl.BackColor = System.Drawing.Color.White;
			this._panelSettingsControl.Location = new System.Drawing.Point(273, 12);
			this._panelSettingsControl.Name = "_panelSettingsControl";
			this._panelSettingsControl.Size = new System.Drawing.Size(258, 426);
			this._panelSettingsControl.TabIndex = 1;
			// 
			// _panelLogControl
			// 
			this._panelLogControl.BackColor = System.Drawing.Color.White;
			this._panelLogControl.Location = new System.Drawing.Point(537, 12);
			this._panelLogControl.Name = "_panelLogControl";
			this._panelLogControl.Size = new System.Drawing.Size(263, 426);
			this._panelLogControl.TabIndex = 2;
			// 
			// MainForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this._panelSettingsControl);
			this.Controls.Add(this._panelLogControl);
			this.Controls.Add(this._panelPlayerControl);
			this.Name = "MainForm1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _panelPlayerControl;
		private System.Windows.Forms.Panel _panelSettingsControl;
		private System.Windows.Forms.Panel _panelLogControl;
	}
}

