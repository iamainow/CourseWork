namespace CourseWork
{
	partial class _part_properties
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
			this.@__name=new System.Windows.Forms.Label();
			this._close=new System.Windows.Forms.Button();
			this._error=new System.Windows.Forms.ErrorProvider(this.components);
			this.@__id=new System.Windows.Forms.Label();
			this._id=new System.Windows.Forms.Label();
			this._delete=new System.Windows.Forms.Button();
			this._new=new System.Windows.Forms.TextBox();
			this.@__new=new System.Windows.Forms.Label();
			this._done=new System.Windows.Forms.CheckBox();
			this.@__diff=new System.Windows.Forms.Label();
			this._diff=new System.Windows.Forms.TextBox();
			this.@__draught=new System.Windows.Forms.Label();
			this.@__assembly=new System.Windows.Forms.Label();
			this._assembly=new System.Windows.Forms.Label();
			this._select_draught=new System.Windows.Forms.Button();
			this._draught=new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._error)).BeginInit();
			this.SuspendLayout();
			// 
			// _name
			// 
			this._name.Location=new System.Drawing.Point(81,43);
			this._name.MaxLength=256;
			this._name.Name="_name";
			this._name.Size=new System.Drawing.Size(303,20);
			this._name.TabIndex=0;
			this._name.TextChanged+=new System.EventHandler(this._name_TextChanged);
			// 
			// __name
			// 
			this.@__name.BackColor=System.Drawing.Color.Transparent;
			this.@__name.Location=new System.Drawing.Point(16,43);
			this.@__name.Name="__name";
			this.@__name.Size=new System.Drawing.Size(59,22);
			this.@__name.TabIndex=4;
			this.@__name.Text="Name:";
			this.@__name.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _close
			// 
			this._close.Location=new System.Drawing.Point(14,123);
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
			this.@__id.Location=new System.Drawing.Point(16,13);
			this.@__id.Name="__id";
			this.@__id.Size=new System.Drawing.Size(59,22);
			this.@__id.TabIndex=12;
			this.@__id.Text="ID:";
			this.@__id.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _id
			// 
			this._id.BackColor=System.Drawing.Color.Transparent;
			this._id.Location=new System.Drawing.Point(81,13);
			this._id.Name="_id";
			this._id.Size=new System.Drawing.Size(89,22);
			this._id.TabIndex=13;
			this._id.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _delete
			// 
			this._delete.ForeColor=System.Drawing.Color.Red;
			this._delete.Location=new System.Drawing.Point(281,12);
			this._delete.Name="_delete";
			this._delete.Size=new System.Drawing.Size(105,25);
			this._delete.TabIndex=8;
			this._delete.Text="Delete this item";
			this._delete.UseVisualStyleBackColor=true;
			this._delete.Click+=new System.EventHandler(this._delete_Click);
			// 
			// _new
			// 
			this._new.Location=new System.Drawing.Point(206,69);
			this._new.MaxLength=3;
			this._new.Name="_new";
			this._new.Size=new System.Drawing.Size(54,20);
			this._new.TabIndex=14;
			this._new.TextChanged+=new System.EventHandler(this._new_TextChanged);
			// 
			// __new
			// 
			this.@__new.BackColor=System.Drawing.Color.Transparent;
			this.@__new.Location=new System.Drawing.Point(141,69);
			this.@__new.Name="__new";
			this.@__new.Size=new System.Drawing.Size(59,22);
			this.@__new.TabIndex=15;
			this.@__new.Text="New:";
			this.@__new.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _done
			// 
			this._done.BackColor=System.Drawing.Color.Transparent;
			this._done.Location=new System.Drawing.Point(176,12);
			this._done.Name="_done";
			this._done.Size=new System.Drawing.Size(84,24);
			this._done.TabIndex=16;
			this._done.Text="Done";
			this._done.UseVisualStyleBackColor=false;
			this._done.CheckedChanged+=new System.EventHandler(this._done_CheckedChanged);
			// 
			// __diff
			// 
			this.@__diff.BackColor=System.Drawing.Color.Transparent;
			this.@__diff.Location=new System.Drawing.Point(16,71);
			this.@__diff.Name="__diff";
			this.@__diff.Size=new System.Drawing.Size(59,22);
			this.@__diff.TabIndex=5;
			this.@__diff.Text="Diff:";
			this.@__diff.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _diff
			// 
			this._diff.Location=new System.Drawing.Point(81,71);
			this._diff.MaxLength=3;
			this._diff.Name="_diff";
			this._diff.Size=new System.Drawing.Size(54,20);
			this._diff.TabIndex=1;
			this._diff.TextChanged+=new System.EventHandler(this._diff_TextChanged);
			// 
			// __draught
			// 
			this.@__draught.BackColor=System.Drawing.Color.Transparent;
			this.@__draught.Location=new System.Drawing.Point(16,97);
			this.@__draught.Name="__draught";
			this.@__draught.Size=new System.Drawing.Size(59,22);
			this.@__draught.TabIndex=18;
			this.@__draught.Text="Draught:";
			this.@__draught.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// __assembly
			// 
			this.@__assembly.BackColor=System.Drawing.Color.Transparent;
			this.@__assembly.Location=new System.Drawing.Point(260,96);
			this.@__assembly.Name="__assembly";
			this.@__assembly.Size=new System.Drawing.Size(59,22);
			this.@__assembly.TabIndex=20;
			this.@__assembly.Text="Assembly:";
			this.@__assembly.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _assembly
			// 
			this._assembly.BackColor=System.Drawing.Color.Transparent;
			this._assembly.Location=new System.Drawing.Point(325,96);
			this._assembly.Name="_assembly";
			this._assembly.Size=new System.Drawing.Size(59,22);
			this._assembly.TabIndex=21;
			this._assembly.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _select_draught
			// 
			this._select_draught.Location=new System.Drawing.Point(154,97);
			this._select_draught.Name="_select_draught";
			this._select_draught.Size=new System.Drawing.Size(75,20);
			this._select_draught.TabIndex=22;
			this._select_draught.Text="Select";
			this._select_draught.UseVisualStyleBackColor=true;
			this._select_draught.Click+=new System.EventHandler(this._draught_select_Click);
			// 
			// _draught
			// 
			this._draught.BackColor=System.Drawing.Color.Transparent;
			this._draught.Location=new System.Drawing.Point(81,96);
			this._draught.Name="_draught";
			this._draught.Size=new System.Drawing.Size(67,22);
			this._draught.TabIndex=23;
			this._draught.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _part_properties
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F,14F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode=System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage=global::CourseWork.Properties.Resources.part;
			this.BackgroundImageLayout=System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize=new System.Drawing.Size(398,181);
			this.ControlBox=false;
			this.Controls.Add(this._draught);
			this.Controls.Add(this._select_draught);
			this.Controls.Add(this._assembly);
			this.Controls.Add(this.@__assembly);
			this.Controls.Add(this.@__draught);
			this.Controls.Add(this._done);
			this.Controls.Add(this._new);
			this.Controls.Add(this.@__new);
			this.Controls.Add(this._delete);
			this.Controls.Add(this._id);
			this.Controls.Add(this.@__id);
			this.Controls.Add(this._close);
			this.Controls.Add(this._diff);
			this.Controls.Add(this.@__diff);
			this.Controls.Add(this.@__name);
			this.Controls.Add(this._name);
			this.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name="_part_properties";
			this.ShowInTaskbar=false;
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text="Assembly Properties";
			((System.ComponentModel.ISupportInitialize)(this._error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _name;
		private System.Windows.Forms.Label __name;
		private System.Windows.Forms.Button _close;
		private System.Windows.Forms.ErrorProvider _error;
		private System.Windows.Forms.Label _id;
		private System.Windows.Forms.Label __id;
		private System.Windows.Forms.Button _delete;
		private System.Windows.Forms.TextBox _new;
		private System.Windows.Forms.Label __new;
		private System.Windows.Forms.CheckBox _done;
		private System.Windows.Forms.Label _assembly;
		private System.Windows.Forms.Label __assembly;
		private System.Windows.Forms.Label __draught;
		private System.Windows.Forms.TextBox _diff;
		private System.Windows.Forms.Label __diff;
		private System.Windows.Forms.Button _select_draught;
		private System.Windows.Forms.Label _draught;
	}
}