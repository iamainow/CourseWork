namespace CourseWork
{
	partial class _group_select
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
			this._table=new System.Windows.Forms.DataGridView();
			this._table_id=new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._table_name=new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._table_relations_count=new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.@__count=new System.Windows.Forms.Label();
			this._count=new System.Windows.Forms.Label();
			this._tab=new System.Windows.Forms.TabControl();
			this._tab_id=new System.Windows.Forms.TabPage();
			this._id_reg_ex=new System.Windows.Forms.TextBox();
			this._id_enable=new System.Windows.Forms.CheckBox();
			this._tab_name=new System.Windows.Forms.TabPage();
			this._name_reg_ex=new System.Windows.Forms.TextBox();
			this._name_enable=new System.Windows.Forms.CheckBox();
			this._tab_rcount=new System.Windows.Forms.TabPage();
			this._rcount_reg_ex=new System.Windows.Forms.TextBox();
			this._rcount_enable=new System.Windows.Forms.CheckBox();
			this.@__reg_ex=new System.Windows.Forms.Label();
			this.@__filters=new System.Windows.Forms.Label();
			this._filter=new System.Windows.Forms.Button();
			this._reg_ex_help=new System.Windows.Forms.Button();
			this._select=new System.Windows.Forms.Button();
			this._cancel=new System.Windows.Forms.Button();
			this._row_add=new System.Windows.Forms.Button();
			this._row_remove=new System.Windows.Forms.Button();
			this._row_properties=new System.Windows.Forms.Button();
			this._filter_new=new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._table)).BeginInit();
			this._tab.SuspendLayout();
			this._tab_id.SuspendLayout();
			this._tab_name.SuspendLayout();
			this._tab_rcount.SuspendLayout();
			this.SuspendLayout();
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
            this._table_name,
            this._table_relations_count});
			this._table.EditMode=System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this._table.Location=new System.Drawing.Point(160,12);
			this._table.Name="_table";
			this._table.ReadOnly=true;
			this._table.RowHeadersVisible=false;
			this._table.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this._table.RowTemplate.ReadOnly=true;
			this._table.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
			this._table.ScrollBars=System.Windows.Forms.ScrollBars.Vertical;
			this._table.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this._table.Size=new System.Drawing.Size(341,216);
			this._table.TabIndex=1;
			this._table.RowsAdded+=new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._table_RowsAdded);
			this._table.RowsRemoved+=new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this._table_RowsRemoved);
			// 
			// _table_id
			// 
			this._table_id.HeaderText="ID";
			this._table_id.MaxInputLength=8;
			this._table_id.Name="_table_id";
			this._table_id.ReadOnly=true;
			this._table_id.Resizable=System.Windows.Forms.DataGridViewTriState.False;
			this._table_id.Width=60;
			// 
			// _table_name
			// 
			this._table_name.HeaderText="Name";
			this._table_name.MaxInputLength=256;
			this._table_name.Name="_table_name";
			this._table_name.ReadOnly=true;
			this._table_name.Resizable=System.Windows.Forms.DataGridViewTriState.False;
			this._table_name.Width=140;
			// 
			// _table_relations_count
			// 
			this._table_relations_count.HeaderText="Relations Count";
			this._table_relations_count.MaxInputLength=4;
			this._table_relations_count.Name="_table_relations_count";
			this._table_relations_count.ReadOnly=true;
			this._table_relations_count.Width=110;
			// 
			// __count
			// 
			this.@__count.BackColor=System.Drawing.Color.Transparent;
			this.@__count.Location=new System.Drawing.Point(342,231);
			this.@__count.Name="__count";
			this.@__count.Size=new System.Drawing.Size(65,25);
			this.@__count.TabIndex=2;
			this.@__count.Text="Count:";
			this.@__count.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _count
			// 
			this._count.BackColor=System.Drawing.Color.Transparent;
			this._count.Location=new System.Drawing.Point(413,231);
			this._count.Name="_count";
			this._count.Size=new System.Drawing.Size(88,25);
			this._count.TabIndex=3;
			this._count.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _tab
			// 
			this._tab.Controls.Add(this._tab_id);
			this._tab.Controls.Add(this._tab_name);
			this._tab.Controls.Add(this._tab_rcount);
			this._tab.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this._tab.Location=new System.Drawing.Point(160,234);
			this._tab.Name="_tab";
			this._tab.SelectedIndex=0;
			this._tab.Size=new System.Drawing.Size(176,93);
			this._tab.TabIndex=4;
			// 
			// _tab_id
			// 
			this._tab_id.Controls.Add(this._id_reg_ex);
			this._tab_id.Controls.Add(this._id_enable);
			this._tab_id.Location=new System.Drawing.Point(4,23);
			this._tab_id.Name="_tab_id";
			this._tab_id.Padding=new System.Windows.Forms.Padding(3);
			this._tab_id.Size=new System.Drawing.Size(168,66);
			this._tab_id.TabIndex=0;
			this._tab_id.Text="ID";
			this._tab_id.UseVisualStyleBackColor=true;
			// 
			// _id_reg_ex
			// 
			this._id_reg_ex.Font=new System.Drawing.Font("Arial",9.75F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this._id_reg_ex.Location=new System.Drawing.Point(6,34);
			this._id_reg_ex.MaxLength=256;
			this._id_reg_ex.Name="_id_reg_ex";
			this._id_reg_ex.Size=new System.Drawing.Size(156,22);
			this._id_reg_ex.TabIndex=6;
			// 
			// _id_enable
			// 
			this._id_enable.Location=new System.Drawing.Point(6,6);
			this._id_enable.Name="_id_enable";
			this._id_enable.Size=new System.Drawing.Size(156,22);
			this._id_enable.TabIndex=0;
			this._id_enable.Text="Enable";
			this._id_enable.UseVisualStyleBackColor=true;
			// 
			// _tab_name
			// 
			this._tab_name.Controls.Add(this._name_reg_ex);
			this._tab_name.Controls.Add(this._name_enable);
			this._tab_name.Location=new System.Drawing.Point(4,23);
			this._tab_name.Name="_tab_name";
			this._tab_name.Padding=new System.Windows.Forms.Padding(3);
			this._tab_name.Size=new System.Drawing.Size(168,66);
			this._tab_name.TabIndex=1;
			this._tab_name.Text="Name";
			this._tab_name.UseVisualStyleBackColor=true;
			// 
			// _name_reg_ex
			// 
			this._name_reg_ex.Font=new System.Drawing.Font("Arial",9.75F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this._name_reg_ex.Location=new System.Drawing.Point(6,34);
			this._name_reg_ex.MaxLength=256;
			this._name_reg_ex.Name="_name_reg_ex";
			this._name_reg_ex.Size=new System.Drawing.Size(156,22);
			this._name_reg_ex.TabIndex=4;
			// 
			// _name_enable
			// 
			this._name_enable.Location=new System.Drawing.Point(6,6);
			this._name_enable.Name="_name_enable";
			this._name_enable.Size=new System.Drawing.Size(156,22);
			this._name_enable.TabIndex=1;
			this._name_enable.Text="Enable";
			this._name_enable.UseVisualStyleBackColor=true;
			// 
			// _tab_rcount
			// 
			this._tab_rcount.Controls.Add(this._rcount_reg_ex);
			this._tab_rcount.Controls.Add(this._rcount_enable);
			this._tab_rcount.Location=new System.Drawing.Point(4,23);
			this._tab_rcount.Name="_tab_rcount";
			this._tab_rcount.Padding=new System.Windows.Forms.Padding(3);
			this._tab_rcount.Size=new System.Drawing.Size(168,66);
			this._tab_rcount.TabIndex=3;
			this._tab_rcount.Text="Relations Count";
			this._tab_rcount.UseVisualStyleBackColor=true;
			// 
			// _rcount_reg_ex
			// 
			this._rcount_reg_ex.Font=new System.Drawing.Font("Arial",9.75F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this._rcount_reg_ex.Location=new System.Drawing.Point(6,34);
			this._rcount_reg_ex.MaxLength=256;
			this._rcount_reg_ex.Name="_rcount_reg_ex";
			this._rcount_reg_ex.Size=new System.Drawing.Size(156,22);
			this._rcount_reg_ex.TabIndex=6;
			// 
			// _rcount_enable
			// 
			this._rcount_enable.Location=new System.Drawing.Point(6,6);
			this._rcount_enable.Name="_rcount_enable";
			this._rcount_enable.Size=new System.Drawing.Size(156,22);
			this._rcount_enable.TabIndex=1;
			this._rcount_enable.Text="Enable";
			this._rcount_enable.UseVisualStyleBackColor=true;
			// 
			// __reg_ex
			// 
			this.@__reg_ex.BackColor=System.Drawing.Color.Transparent;
			this.@__reg_ex.Location=new System.Drawing.Point(43,291);
			this.@__reg_ex.Name="__reg_ex";
			this.@__reg_ex.Size=new System.Drawing.Size(111,22);
			this.@__reg_ex.TabIndex=5;
			this.@__reg_ex.Text="Regular Expression:";
			this.@__reg_ex.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			// 
			// __filters
			// 
			this.@__filters.BackColor=System.Drawing.Color.Transparent;
			this.@__filters.Location=new System.Drawing.Point(12,234);
			this.@__filters.Name="__filters";
			this.@__filters.Size=new System.Drawing.Size(142,22);
			this.@__filters.TabIndex=5;
			this.@__filters.Text="Filters:";
			this.@__filters.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _filter
			// 
			this._filter.Location=new System.Drawing.Point(342,290);
			this._filter.Name="_filter";
			this._filter.Size=new System.Drawing.Size(125,37);
			this._filter.TabIndex=6;
			this._filter.Text="Filter";
			this._filter.UseVisualStyleBackColor=true;
			this._filter.Click+=new System.EventHandler(this._filter_Click);
			// 
			// _reg_ex_help
			// 
			this._reg_ex_help.Location=new System.Drawing.Point(12,292);
			this._reg_ex_help.Name="_reg_ex_help";
			this._reg_ex_help.Size=new System.Drawing.Size(25,22);
			this._reg_ex_help.TabIndex=7;
			this._reg_ex_help.Text="?";
			this._reg_ex_help.UseVisualStyleBackColor=true;
			this._reg_ex_help.Click+=new System.EventHandler(this._reg_ex_help_Click);
			// 
			// _select
			// 
			this._select.DialogResult=System.Windows.Forms.DialogResult.OK;
			this._select.Font=new System.Drawing.Font("Arial",9.75F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this._select.Location=new System.Drawing.Point(160,333);
			this._select.Name="_select";
			this._select.Size=new System.Drawing.Size(125,35);
			this._select.TabIndex=8;
			this._select.Text="Select";
			this._select.UseVisualStyleBackColor=true;
			this._select.Click+=new System.EventHandler(this._select_Click);
			// 
			// _cancel
			// 
			this._cancel.DialogResult=System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Font=new System.Drawing.Font("Arial",9.75F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this._cancel.Location=new System.Drawing.Point(291,333);
			this._cancel.Name="_cancel";
			this._cancel.Size=new System.Drawing.Size(125,35);
			this._cancel.TabIndex=9;
			this._cancel.Text="Cancel";
			this._cancel.UseVisualStyleBackColor=true;
			this._cancel.Click+=new System.EventHandler(this._cancel_Click);
			// 
			// _row_add
			// 
			this._row_add.Location=new System.Drawing.Point(43,12);
			this._row_add.Name="_row_add";
			this._row_add.Size=new System.Drawing.Size(111,28);
			this._row_add.TabIndex=10;
			this._row_add.Text="New";
			this._row_add.UseVisualStyleBackColor=true;
			this._row_add.Click+=new System.EventHandler(this._row_new_Click);
			// 
			// _row_remove
			// 
			this._row_remove.Location=new System.Drawing.Point(43,46);
			this._row_remove.Name="_row_remove";
			this._row_remove.Size=new System.Drawing.Size(111,28);
			this._row_remove.TabIndex=11;
			this._row_remove.Text="Delete";
			this._row_remove.UseVisualStyleBackColor=true;
			this._row_remove.Click+=new System.EventHandler(this._row_delete_Click);
			// 
			// _row_properties
			// 
			this._row_properties.Location=new System.Drawing.Point(43,80);
			this._row_properties.Name="_row_properties";
			this._row_properties.Size=new System.Drawing.Size(111,28);
			this._row_properties.TabIndex=12;
			this._row_properties.Text="Properties";
			this._row_properties.UseVisualStyleBackColor=true;
			this._row_properties.Click+=new System.EventHandler(this._row_properties_Click);
			// 
			// _filter_new
			// 
			this._filter_new.Location=new System.Drawing.Point(342,259);
			this._filter_new.Name="_filter_new";
			this._filter_new.Size=new System.Drawing.Size(125,25);
			this._filter_new.TabIndex=13;
			this._filter_new.Text="Filter in new window";
			this._filter_new.UseVisualStyleBackColor=true;
			this._filter_new.Click+=new System.EventHandler(this._filter_new_Click);
			// 
			// _group_select
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F,14F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode=System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage=global::CourseWork.Properties.Resources.group;
			this.BackgroundImageLayout=System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize=new System.Drawing.Size(517,376);
			this.ControlBox=false;
			this.Controls.Add(this._filter_new);
			this.Controls.Add(this.@__reg_ex);
			this.Controls.Add(this._row_properties);
			this.Controls.Add(this._row_remove);
			this.Controls.Add(this._row_add);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._select);
			this.Controls.Add(this._reg_ex_help);
			this.Controls.Add(this._filter);
			this.Controls.Add(this.@__filters);
			this.Controls.Add(this._tab);
			this.Controls.Add(this._count);
			this.Controls.Add(this.@__count);
			this.Controls.Add(this._table);
			this.Font=new System.Drawing.Font("Arial",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(204)));
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name="_group_select";
			this.ShowInTaskbar=false;
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text="Group Select";
			((System.ComponentModel.ISupportInitialize)(this._table)).EndInit();
			this._tab.ResumeLayout(false);
			this._tab_id.ResumeLayout(false);
			this._tab_id.PerformLayout();
			this._tab_name.ResumeLayout(false);
			this._tab_name.PerformLayout();
			this._tab_rcount.ResumeLayout(false);
			this._tab_rcount.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView _table;
		private System.Windows.Forms.Label __count;
		private System.Windows.Forms.Label _count;
		private System.Windows.Forms.TabControl _tab;
		private System.Windows.Forms.TabPage _tab_id;
		private System.Windows.Forms.CheckBox _id_enable;
		private System.Windows.Forms.TabPage _tab_name;
		private System.Windows.Forms.CheckBox _name_enable;
		private System.Windows.Forms.TabPage _tab_rcount;
		private System.Windows.Forms.CheckBox _rcount_enable;
		private System.Windows.Forms.TextBox _name_reg_ex;
		private System.Windows.Forms.Label __filters;
		private System.Windows.Forms.TextBox _id_reg_ex;
		private System.Windows.Forms.Label __reg_ex;
		private System.Windows.Forms.TextBox _rcount_reg_ex;
		private System.Windows.Forms.Button _filter;
		private System.Windows.Forms.Button _reg_ex_help;
		private System.Windows.Forms.Button _select;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.Button _row_add;
		private System.Windows.Forms.Button _row_remove;
		private System.Windows.Forms.Button _row_properties;
		private System.Windows.Forms.Button _filter_new;
		private System.Windows.Forms.DataGridViewTextBoxColumn _table_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn _table_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn _table_relations_count;



	}
}