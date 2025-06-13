namespace CourseWork
{
	partial class Password
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components=null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing&&(components!=null))
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
			this._password=new System.Windows.Forms.TextBox();
			this.@__password=new System.Windows.Forms.Label();
			this._ok=new System.Windows.Forms.Button();
			this._cancel=new System.Windows.Forms.Button();
			this._status=new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _password
			// 
			this._password.Location=new System.Drawing.Point(87,28);
			this._password.MaxLength=32;
			this._password.Name="_password";
			this._password.Size=new System.Drawing.Size(170,20);
			this._password.TabIndex=0;
			this._password.TextChanged+=new System.EventHandler(this._password_TextChanged);
			// 
			// __password
			// 
			this.@__password.BackColor=System.Drawing.Color.Transparent;
			this.@__password.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this.@__password.Location=new System.Drawing.Point(12,28);
			this.@__password.Name="__password";
			this.@__password.Size=new System.Drawing.Size(69,20);
			this.@__password.TabIndex=1;
			this.@__password.Text="Password:";
			this.@__password.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _ok
			// 
			this._ok.DialogResult=System.Windows.Forms.DialogResult.OK;
			this._ok.Location=new System.Drawing.Point(12,54);
			this._ok.Name="_ok";
			this._ok.Size=new System.Drawing.Size(120,23);
			this._ok.TabIndex=2;
			this._ok.Text="OK";
			this._ok.UseVisualStyleBackColor=true;
			this._ok.Click+=new System.EventHandler(this._ok_Click);
			// 
			// _cancel
			// 
			this._cancel.DialogResult=System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Location=new System.Drawing.Point(138,54);
			this._cancel.Name="_cancel";
			this._cancel.Size=new System.Drawing.Size(119,23);
			this._cancel.TabIndex=3;
			this._cancel.Text="Cancel";
			this._cancel.UseVisualStyleBackColor=true;
			this._cancel.Click+=new System.EventHandler(this._cancel_Click);
			// 
			// _status
			// 
			this._status.BackColor=System.Drawing.Color.Transparent;
			this._status.Location=new System.Drawing.Point(87,12);
			this._status.Name="_status";
			this._status.Size=new System.Drawing.Size(170,13);
			this._status.TabIndex=4;
			this._status.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Password
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F,14F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode=System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage=global::CourseWork.Properties.Resources.pass;
			this.BackgroundImageLayout=System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize=new System.Drawing.Size(269,89);
			this.ControlBox=false;
			this.Controls.Add(this._status);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this.@__password);
			this.Controls.Add(this._password);
			this.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name="Password";
			this.ShowInTaskbar=false;
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text="Password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _password;
		private System.Windows.Forms.Label __password;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.Label _status;
	}
}