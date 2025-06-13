using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CourseWork
{
	public partial class _group_select:Form
	{
		private IEnumerable<i.Data.iGroup> DATA;
		public _group_select()
		{
			InitializeComponent();
			DATA=Program.DC.OfType<i.Data.iGroup>();
			foreach(i.Data.iGroup D in DATA)
			{
				_table.Rows.Add(ToObjects(D));
			}
		}
		public _group_select(IEnumerable<i.Data.iGroup> IE)
		{
			InitializeComponent();
			DATA=IE;
			foreach(i.Data.iGroup D in DATA)
			{
				_table.Rows.Add(ToObjects(D));
			}
		}
		private void _table_RowsAdded(object sender,DataGridViewRowsAddedEventArgs e)
		{
			RowsCountChanged();
		}
		private void _table_RowsRemoved(object sender,DataGridViewRowsRemovedEventArgs e)
		{
			RowsCountChanged();
		}
		private void RowsCountChanged()
		{
			_count.Text=_table.RowCount.ToString();
		}
		private object[] ToObjects(i.Data.iGroup D)
		{
			return new object[]
			{
				D.ID,
				D.NAME,
				D.PARTS.Count,
			};
		}
		private IEnumerable<i.Data.iGroup> FilterID(IEnumerable<i.Data.iGroup> IE)
		{
			return
				from D in IE
				where System.Text.RegularExpressions.Regex.IsMatch(D.ID.ToString(),_id_reg_ex.Text)==true
				select D;
		}
		private IEnumerable<i.Data.iGroup> FilterName(IEnumerable<i.Data.iGroup> IE)
		{
			return
				from D in IE
				where System.Text.RegularExpressions.Regex.IsMatch(D.NAME,_name_reg_ex.Text,System.Text.RegularExpressions.RegexOptions.IgnoreCase)==true
				select D;
		}
		private IEnumerable<i.Data.iGroup> FilterRCount(IEnumerable<i.Data.iGroup> IE)
		{
			return
				from D in IE
				where System.Text.RegularExpressions.Regex.IsMatch(D.PARTS.Count.ToString(),_rcount_reg_ex.Text)==true
				select D;
		}
		private IEnumerable<i.Data.iGroup> Filters(IEnumerable<i.Data.iGroup> IE)
		{
			IEnumerable<i.Data.iGroup> D=IE;
			if(_id_enable.Checked)
			{
				D=FilterID(D);
			}
			if(_name_enable.Checked)
			{
				D=FilterName(D);
			}
			if(_rcount_enable.Checked)
			{
				D=FilterRCount(D);
			}
			return D;
		}
		private void _filter_Click(object sender,EventArgs e)
		{
			_table.Rows.Clear();
			foreach(i.Data.iGroup D in Filters(this.DATA))
			{
				_table.Rows.Add(ToObjects(D));
			}
		}
		private void _filter_new_Click(object sender,EventArgs e)
		{
			_group_select DS=new _group_select(Filters(this.DATA));
			List<i.Data.iGroup> List;
			DS.ShowDialog(out List);
			_table.Rows.Clear();
			foreach(i.Data.iGroup D in List)
			{
				_table.Rows.Add(ToObjects(D));
			}
			DS.Dispose();
		}
		private void _reg_ex_help_Click(object sender,EventArgs e)
		{
			if(MessageBox.Show("Do you want to visit "+Program.RegExHelp+" ?","What is the regular expression?",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				System.Diagnostics.Process.Start(Program.RegExHelp);
			}
		}
		private void _select_Click(object sender,EventArgs e)
		{
			this.Close();
		}
		private void _cancel_Click(object sender,EventArgs e)
		{
			this.Close();
		}
		private void _row_properties_Click(object sender,EventArgs e)
		{
			if(_table.SelectedRows.Count==1)
			{
				i.Data.iGroup Draught=DATA.Single((D) => D.ID==((int)_table.SelectedRows[0].Cells[0].Value));
				_group_properties Form=new _group_properties(Draught);
				Form.ShowDialog();
				Form.Dispose();
				_table.Rows.Remove(_table.SelectedRows[0]);
				if(Program.DC.Where((D) => D==Draught).Count()!=0)
				{
					_table.Rows.Add(ToObjects(Draught));
				}
			}
		}
		private void _row_new_Click(object sender,EventArgs e)
		{
			i.Data.iGroup Draught=Program.DC.New(i.Data.CID.Group) as i.Data.iGroup;
			_group_properties DP=new _group_properties(Draught);
			DP.ShowDialog();
			DP.Dispose();
			if(Program.DC.Where((D) => D==Draught).Count()!=0)
			{
				_table.Rows.Add(ToObjects(Draught));
			}
		}
		private void _row_delete_Click(object sender,EventArgs e)
		{
			foreach(DataGridViewRow DGVR in _table.SelectedRows)
			{
				_table.Rows.Remove(DGVR);
				Program.DC.Delete(Program.DC.Single((D) => D.ID==(int)DGVR.Cells[0].Value));
			}
		}
		public DialogResult ShowDialog(out List<i.Data.iGroup> L)
		{
			DialogResult DR=base.ShowDialog();
			IEnumerable<int> E=_table.SelectedRows.OfType<DataGridViewRow>().Select((DGVR) => DGVR.Cells[0].Value).OfType<int>();
			L=new List<i.Data.iGroup>();
			foreach(int I in E)
			{
				foreach(i.Data.iGroup D in DATA)
				{
					if(D.ID==I)
					{
						L.Add(D);
						break;
					}
				}
			}
			return DR;
		}
	}
}