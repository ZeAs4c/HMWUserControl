namespace ControlHMW
{
	partial class LogControl
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
			this._txtControlRichTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _txtControlRichTextBox
			// 
			this._txtControlRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txtControlRichTextBox.Location = new System.Drawing.Point(0, 0);
			this._txtControlRichTextBox.Name = "_txtControlRichTextBox";
			this._txtControlRichTextBox.Size = new System.Drawing.Size(223, 327);
			this._txtControlRichTextBox.TabIndex = 0;
			this._txtControlRichTextBox.Text = "";
			// 
			// LogControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Chartreuse;
			this.Controls.Add(this._txtControlRichTextBox);
			this.Name = "LogControl";
			this.Size = new System.Drawing.Size(223, 327);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox _txtControlRichTextBox;
	}
}
