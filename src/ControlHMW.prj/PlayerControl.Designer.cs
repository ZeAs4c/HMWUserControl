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
			this._pictureBoxPlayerContorl = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._pictureBoxPlayerContorl)).BeginInit();
			this.SuspendLayout();
			// 
			// _pictureBoxPlayerContorl
			// 
			this._pictureBoxPlayerContorl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._pictureBoxPlayerContorl.Location = new System.Drawing.Point(0, 0);
			this._pictureBoxPlayerContorl.Name = "_pictureBoxPlayerContorl";
			this._pictureBoxPlayerContorl.Size = new System.Drawing.Size(163, 287);
			this._pictureBoxPlayerContorl.TabIndex = 0;
			this._pictureBoxPlayerContorl.TabStop = false;
			// 
			// PlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.Controls.Add(this._pictureBoxPlayerContorl);
			this.Name = "PlayerControl";
			this.Size = new System.Drawing.Size(163, 287);
			((System.ComponentModel.ISupportInitialize)(this._pictureBoxPlayerContorl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _pictureBoxPlayerContorl;
	}
}
