namespace CourseWork
{
	partial class Main
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
			this._assembly=new System.Windows.Forms.Button();
			this._draught=new System.Windows.Forms.Button();
			this._group=new System.Windows.Forms.Button();
			this._part=new System.Windows.Forms.Button();
			this._save_db=new System.Windows.Forms.SaveFileDialog();
			this._save=new System.Windows.Forms.Button();
			this._load=new System.Windows.Forms.Button();
			this._load_db=new System.Windows.Forms.OpenFileDialog();
			this._table=new System.Windows.Forms.DataGridView();
			this._table_id=new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._table_type=new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._table_name=new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._generate=new System.Windows.Forms.Button();
			this._update=new System.Windows.Forms.Button();
			this.@__count=new System.Windows.Forms.Label();
			this._count=new System.Windows.Forms.Label();
			this._properties=new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._table)).BeginInit();
			this.SuspendLayout();
			// 
			// _assembly
			// 
			this._assembly.Location=new System.Drawing.Point(12,13);
			this._assembly.Name="_assembly";
			this._assembly.Size=new System.Drawing.Size(154,25);
			this._assembly.TabIndex=0;
			this._assembly.Text="Assembly";
			this._assembly.UseVisualStyleBackColor=true;
			this._assembly.Click+=new System.EventHandler(this._assembly_Click);
			// 
			// _draught
			// 
			this._draught.Location=new System.Drawing.Point(12,44);
			this._draught.Name="_draught";
			this._draught.Size=new System.Drawing.Size(154,25);
			this._draught.TabIndex=1;
			this._draught.Text="Draught";
			this._draught.UseVisualStyleBackColor=true;
			this._draught.Click+=new System.EventHandler(this._draught_Click);
			// 
			// _group
			// 
			this._group.Location=new System.Drawing.Point(12,75);
			this._group.Name="_group";
			this._group.Size=new System.Drawing.Size(154,25);
			this._group.TabIndex=3;
			this._group.Text="Group";
			this._group.UseVisualStyleBackColor=true;
			this._group.Click+=new System.EventHandler(this._group_Click);
			// 
			// _part
			// 
			this._part.Location=new System.Drawing.Point(12,107);
			this._part.Name="_part";
			this._part.Size=new System.Drawing.Size(154,25);
			this._part.TabIndex=2;
			this._part.Text="Part";
			this._part.UseVisualStyleBackColor=true;
			this._part.Click+=new System.EventHandler(this._part_Click);
			// 
			// _save_db
			// 
			this._save_db.Filter="Database|*.ibdb";
			// 
			// _save
			// 
			this._save.Location=new System.Drawing.Point(12,220);
			this._save.Name="_save";
			this._save.Size=new System.Drawing.Size(154,25);
			this._save.TabIndex=4;
			this._save.Text="Save DB";
			this._save.UseVisualStyleBackColor=true;
			this._save.Click+=new System.EventHandler(this._save_Click);
			// 
			// _load
			// 
			this._load.Location=new System.Drawing.Point(12,250);
			this._load.Name="_load";
			this._load.Size=new System.Drawing.Size(154,25);
			this._load.TabIndex=5;
			this._load.Text="Load DB";
			this._load.UseVisualStyleBackColor=true;
			this._load.Click+=new System.EventHandler(this._load_Click);
			// 
			// _load_db
			// 
			this._load_db.Filter="Database|*.ibdb";
			// 
			// _table
			// 
			this._table.AllowUserToAddRows=false;
			this._table.AllowUserToDeleteRows=false;
			this._table.AllowUserToOrderColumns=true;
			this._table.AllowUserToResizeColumns=false;
			this._table.AllowUserToResizeRows=false;
			this._table.BackgroundColor=System.Drawing.SystemColors.Control;
			this._table.BorderStyle=System.Windows.Forms.BorderStyle.Fixed3D;
			this._table.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._table_id,
            this._table_type,
            this._table_name});
			this._table.EditMode=System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this._table.Location=new System.Drawing.Point(172,13);
			this._table.Name="_table";
			this._table.ReadOnly=true;
			this._table.RowHeadersVisible=false;
			this._table.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this._table.RowTemplate.ReadOnly=true;
			this._table.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
			this._table.ScrollBars=System.Windows.Forms.ScrollBars.Vertical;
			this._table.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this._table.Size=new System.Drawing.Size(347,275);
			this._table.TabIndex=6;
			this._table.RowsAdded+=new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._table_RowsAdded);
			this._table.RowsRemoved+=new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this._table_RowsRemoved);
			// 
			// _table_id
			// 
			this._table_id.HeaderText="ID";
			this._table_id.MaxInputLength=10;
			this._table_id.Name="_table_id";
			this._table_id.ReadOnly=true;
			this._table_id.Resizable=System.Windows.Forms.DataGridViewTriState.False;
			this._table_id.Width=70;
			// 
			// _table_type
			// 
			this._table_type.HeaderText="Type";
			this._table_type.MaxInputLength=32;
			this._table_type.Name="_table_type";
			this._table_type.ReadOnly=true;
			this._table_type.Resizable=System.Windows.Forms.DataGridViewTriState.False;
			// 
			// _table_name
			// 
			this._table_name.HeaderText="Name";
			this._table_name.MaxInputLength=256;
			this._table_name.Name="_table_name";
			this._table_name.ReadOnly=true;
			this._table_name.Resizable=System.Windows.Forms.DataGridViewTriState.False;
			this._table_name.Width=175;
			// 
			// _generate
			// 
			this._generate.Location=new System.Drawing.Point(12,291);
			this._generate.Name="_generate";
			this._generate.Size=new System.Drawing.Size(154,25);
			this._generate.TabIndex=7;
			this._generate.Text="Generate";
			this._generate.UseVisualStyleBackColor=true;
			this._generate.Click+=new System.EventHandler(this._generate_Click);
			// 
			// _update
			// 
			this._update.Location=new System.Drawing.Point(12,179);
			this._update.Name="_update";
			this._update.Size=new System.Drawing.Size(154,25);
			this._update.TabIndex=10;
			this._update.Text="Update";
			this._update.UseVisualStyleBackColor=true;
			this._update.Click+=new System.EventHandler(this._update_Click);
			// 
			// __count
			// 
			this.@__count.BackColor=System.Drawing.Color.Transparent;
			this.@__count.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this.@__count.Location=new System.Drawing.Point(171,291);
			this.@__count.Name="__count";
			this.@__count.Size=new System.Drawing.Size(254,27);
			this.@__count.TabIndex=14;
			this.@__count.Text="Count:";
			this.@__count.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _count
			// 
			this._count.BackColor=System.Drawing.Color.Transparent;
			this._count.Location=new System.Drawing.Point(431,291);
			this._count.Name="_count";
			this._count.Size=new System.Drawing.Size(88,27);
			this._count.TabIndex=21;
			this._count.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _properties
			// 
			this._properties.Location=new System.Drawing.Point(12,148);
			this._properties.Name="_properties";
			this._properties.Size=new System.Drawing.Size(154,25);
			this._properties.TabIndex=22;
			this._properties.Text="Properties";
			this._properties.UseVisualStyleBackColor=true;
			this._properties.Click+=new System.EventHandler(this._properties_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F,14F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode=System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage=global::CourseWork.Properties.Resources.main;
			this.BackgroundImageLayout=System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize=new System.Drawing.Size(538,328);
			this.Controls.Add(this._properties);
			this.Controls.Add(this._count);
			this.Controls.Add(this.@__count);
			this.Controls.Add(this._update);
			this.Controls.Add(this._generate);
			this.Controls.Add(this._table);
			this.Controls.Add(this._load);
			this.Controls.Add(this._save);
			this.Controls.Add(this._group);
			this.Controls.Add(this._part);
			this.Controls.Add(this._draught);
			this.Controls.Add(this._assembly);
			this.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox=false;
			this.Name="Main";
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text="Main";
			((System.ComponentModel.ISupportInitialize)(this._table)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _assembly;
		private System.Windows.Forms.Button _draught;
		private System.Windows.Forms.Button _group;
		private System.Windows.Forms.Button _part;
		private System.Windows.Forms.SaveFileDialog _save_db;
		private System.Windows.Forms.Button _save;
		private System.Windows.Forms.Button _load;
		private System.Windows.Forms.OpenFileDialog _load_db;
		private System.Windows.Forms.DataGridView _table;
		private System.Windows.Forms.Button _generate;
		private System.Windows.Forms.DataGridViewTextBoxColumn _table_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn _table_type;
		private System.Windows.Forms.DataGridViewTextBoxColumn _table_name;
		private System.Windows.Forms.Button _update;
		private System.Windows.Forms.Label __count;
		private System.Windows.Forms.Label _count;
		private System.Windows.Forms.Button _properties;

	}
}

