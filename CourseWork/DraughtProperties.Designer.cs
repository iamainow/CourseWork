namespace CourseWork
{
	partial class _draught_properties
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
			this.components=new System.ComponentModel.Container();
			this._name=new System.Windows.Forms.TextBox();
			this._parts=new System.Windows.Forms.ListBox();
			this._add_draughts=new System.Windows.Forms.Button();
			this._remove_draughts=new System.Windows.Forms.Button();
			this.@__name=new System.Windows.Forms.Label();
			this.@__index=new System.Windows.Forms.Label();
			this._index=new System.Windows.Forms.TextBox();
			this._close=new System.Windows.Forms.Button();
			this._error=new System.Windows.Forms.ErrorProvider(this.components);
			this.@__id=new System.Windows.Forms.Label();
			this._id=new System.Windows.Forms.Label();
			this._delete=new System.Windows.Forms.Button();
			this._draughts_properties=new System.Windows.Forms.Button();
			this.@__format=new System.Windows.Forms.Label();
			this._format=new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this._error)).BeginInit();
			this.SuspendLayout();
			// 
			// _name
			// 
			this._name.Location=new System.Drawing.Point(77,40);
			this._name.MaxLength=256;
			this._name.Name="_name";
			this._name.Size=new System.Drawing.Size(303,20);
			this._name.TabIndex=0;
			this._name.TextChanged+=new System.EventHandler(this._name_TextChanged);
			// 
			// _parts
			// 
			this._parts.FormattingEnabled=true;
			this._parts.ItemHeight=14;
			this._parts.Location=new System.Drawing.Point(12,96);
			this._parts.Name="_parts";
			this._parts.Size=new System.Drawing.Size(289,102);
			this._parts.TabIndex=3;
			// 
			// _add_draughts
			// 
			this._add_draughts.Location=new System.Drawing.Point(307,96);
			this._add_draughts.Name="_add_draughts";
			this._add_draughts.Size=new System.Drawing.Size(75,30);
			this._add_draughts.TabIndex=4;
			this._add_draughts.Text="Add";
			this._add_draughts.UseVisualStyleBackColor=true;
			this._add_draughts.Click+=new System.EventHandler(this._add_parts_Click);
			// 
			// _remove_draughts
			// 
			this._remove_draughts.Location=new System.Drawing.Point(307,132);
			this._remove_draughts.Name="_remove_draughts";
			this._remove_draughts.Size=new System.Drawing.Size(75,30);
			this._remove_draughts.TabIndex=5;
			this._remove_draughts.Text="Remove";
			this._remove_draughts.UseVisualStyleBackColor=true;
			this._remove_draughts.Click+=new System.EventHandler(this._remove_parts_Click);
			// 
			// __name
			// 
			this.@__name.BackColor=System.Drawing.Color.Transparent;
			this.@__name.Location=new System.Drawing.Point(12,40);
			this.@__name.Name="__name";
			this.@__name.Size=new System.Drawing.Size(59,22);
			this.@__name.TabIndex=4;
			this.@__name.Text="Name:";
			this.@__name.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// __index
			// 
			this.@__index.BackColor=System.Drawing.Color.Transparent;
			this.@__index.Location=new System.Drawing.Point(12,68);
			this.@__index.Name="__index";
			this.@__index.Size=new System.Drawing.Size(59,22);
			this.@__index.TabIndex=5;
			this.@__index.Text="Index:";
			this.@__index.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _index
			// 
			this._index.Location=new System.Drawing.Point(77,68);
			this._index.MaxLength=8;
			this._index.Name="_index";
			this._index.Size=new System.Drawing.Size(107,20);
			this._index.TabIndex=1;
			this._index.TextChanged+=new System.EventHandler(this._index_TextChanged);
			// 
			// _close
			// 
			this._close.Location=new System.Drawing.Point(12,203);
			this._close.Name="_close";
			this._close.Size=new System.Drawing.Size(370,46);
			this._close.TabIndex=7;
			this._close.Text="Close";
			this._close.UseVisualStyleBackColor=true;
			this._close.Click+=new System.EventHandler(this._close_Click);
			// 
			// _error
			// 
			this._error.BlinkStyle=System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
			this._error.ContainerControl=this;
			this._error.RightToLeft=true;
			// 
			// __id
			// 
			this.@__id.BackColor=System.Drawing.Color.Transparent;
			this.@__id.Location=new System.Drawing.Point(12,10);
			this.@__id.Name="__id";
			this.@__id.Size=new System.Drawing.Size(59,22);
			this.@__id.TabIndex=12;
			this.@__id.Text="ID:";
			this.@__id.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _id
			// 
			this._id.BackColor=System.Drawing.Color.Transparent;
			this._id.Location=new System.Drawing.Point(77,10);
			this._id.Name="_id";
			this._id.Size=new System.Drawing.Size(89,22);
			this._id.TabIndex=13;
			this._id.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _delete
			// 
			this._delete.ForeColor=System.Drawing.Color.Red;
			this._delete.Location=new System.Drawing.Point(277,9);
			this._delete.Name="_delete";
			this._delete.Size=new System.Drawing.Size(105,25);
			this._delete.TabIndex=8;
			this._delete.Text="Delete this item";
			this._delete.UseVisualStyleBackColor=true;
			this._delete.Click+=new System.EventHandler(this._delete_Click);
			// 
			// _draughts_properties
			// 
			this._draughts_properties.Location=new System.Drawing.Point(307,168);
			this._draughts_properties.Name="_draughts_properties";
			this._draughts_properties.Size=new System.Drawing.Size(75,30);
			this._draughts_properties.TabIndex=6;
			this._draughts_properties.Text="Properties";
			this._draughts_properties.UseVisualStyleBackColor=true;
			this._draughts_properties.Click+=new System.EventHandler(this._draughts_properties_Click);
			// 
			// __format
			// 
			this.@__format.BackColor=System.Drawing.Color.Transparent;
			this.@__format.Location=new System.Drawing.Point(208,66);
			this.@__format.Name="__format";
			this.@__format.Size=new System.Drawing.Size(59,22);
			this.@__format.TabIndex=15;
			this.@__format.Text="Format:";
			this.@__format.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _format
			// 
			this._format.FormattingEnabled=true;
			this._format.Location=new System.Drawing.Point(273,66);
			this._format.Name="_format";
			this._format.Size=new System.Drawing.Size(109,22);
			this._format.TabIndex=16;
			this._format.TextChanged+=new System.EventHandler(this._format_TextChanged);
			// 
			// _draught_properties
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F,14F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode=System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage=global::CourseWork.Properties.Resources.draugh;
			this.BackgroundImageLayout=System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize=new System.Drawing.Size(390,261);
			this.ControlBox=false;
			this.Controls.Add(this._format);
			this.Controls.Add(this.@__format);
			this.Controls.Add(this._draughts_properties);
			this.Controls.Add(this._delete);
			this.Controls.Add(this._id);
			this.Controls.Add(this.@__id);
			this.Controls.Add(this._close);
			this.Controls.Add(this._index);
			this.Controls.Add(this.@__index);
			this.Controls.Add(this.@__name);
			this.Controls.Add(this._remove_draughts);
			this.Controls.Add(this._add_draughts);
			this.Controls.Add(this._parts);
			this.Controls.Add(this._name);
			this.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name="_draught_properties";
			this.ShowInTaskbar=false;
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text="Draught Properties";
			((System.ComponentModel.ISupportInitialize)(this._error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _name;
		private System.Windows.Forms.ListBox _parts;
		private System.Windows.Forms.Button _add_draughts;
		private System.Windows.Forms.Button _remove_draughts;
		private System.Windows.Forms.Label __name;
		private System.Windows.Forms.Label __index;
		private System.Windows.Forms.TextBox _index;
		private System.Windows.Forms.Button _close;
		private System.Windows.Forms.ErrorProvider _error;
		private System.Windows.Forms.Label _id;
		private System.Windows.Forms.Label __id;
		private System.Windows.Forms.Button _delete;
		private System.Windows.Forms.Button _draughts_properties;
		private System.Windows.Forms.Label __format;
		private System.Windows.Forms.ComboBox _format;
	}
}