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
	public partial class _part_select:Form
	{
		private IEnumerable<i.Data.iPart> DATA;
		public _part_select()
		{
			InitializeComponent();
			DATA=Program.DC.Where((D) => D.CID==i.Data.CID.Part).Cast<i.Data.iPart>();
			foreach(i.Data.iPart A in DATA)
			{
				_table.Rows.Add(ToObjects(A));
			}
		}
		public _part_select(IEnumerable<i.Data.iPart> IE)
		{
			InitializeComponent();
			DATA=IE;
			foreach(i.Data.iPart A in DATA)
			{
				_table.Rows.Add(ToObjects(A));
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
		private object[] ToObjects(i.Data.iPart A)
		{
			return new object[]
			{
				A.ID,
				A.NAME,
				A.DIFF,
				A.NEW,
				A.DONE,
			};
		}
		private IEnumerable<i.Data.iPart> FilterID(IEnumerable<i.Data.iPart> IE)
		{
			return
				from A in IE
				where System.Text.RegularExpressions.Regex.IsMatch(A.ID.ToString(),_id_reg_ex.Text)==true
				select A;
		}
		private IEnumerable<i.Data.iPart> FilterName(IEnumerable<i.Data.iPart> IE)
		{
			return
				from A in IE
				where System.Text.RegularExpressions.Regex.IsMatch(A.NAME,_name_reg_ex.Text,System.Text.RegularExpressions.RegexOptions.IgnoreCase)==true
				select A;
		}
		private IEnumerable<i.Data.iPart> FilterDiff(IEnumerable<i.Data.iPart> IE)
		{
			return
				from A in IE
				where System.Text.RegularExpressions.Regex.IsMatch(A.DIFF.ToString(),_diff_reg_ex.Text)==true
				select A;
		}
		private IEnumerable<i.Data.iPart> FilterNew(IEnumerable<i.Data.iPart> IE)
		{
			return
				from A in IE
				where System.Text.RegularExpressions.Regex.IsMatch(A.NEW.ToString(),_new_reg_ex.Text,System.Text.RegularExpressions.RegexOptions.IgnoreCase)==true
				select A;
		}
		private IEnumerable<i.Data.iPart> Filters(IEnumerable<i.Data.iPart> IE)
		{
			IEnumerable<i.Data.iPart> A=IE;
			if(_id_enable.Checked)
			{
				A=FilterID(A);
			}
			if(_name_enable.Checked)
			{
				A=FilterName(A);
			}
			if(_diff_enable.Checked)
			{
				A=FilterDiff(A);
			}
			if(_new_enable.Checked)
			{
				A=FilterNew(A);
			}
			return A;
		}
		private void _filter_Click(object sender,EventArgs e)
		{
			_table.Rows.Clear();
			foreach(i.Data.iPart A in Filters(this.DATA))
			{
				_table.Rows.Add(ToObjects(A));
			}
		}
		private void _filter_new_Click(object sender,EventArgs e)
		{
			_part_select AS=new _part_select(Filters(this.DATA));
			List<i.Data.iPart> List;
			AS.ShowDialog(out List);
			_table.Rows.Clear();
			foreach(i.Data.iPart A in List)
			{
				_table.Rows.Add(ToObjects(A));
			}
			AS.Dispose();
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
				i.Data.iPart Assembly=DATA.Single((A) => A.ID==((int)_table.SelectedRows[0].Cells[0].Value));
				_part_properties Form=new _part_properties(Assembly);
				Form.ShowDialog();
				Form.Dispose();
				_table.Rows.Remove(_table.SelectedRows[0]);
				if(Program.DC.Where((D) => D==Assembly).Count()!=0)
				{
					_table.Rows.Add(ToObjects(Assembly));
				}
			}
		}
		private void _row_new_Click(object sender,EventArgs e)
		{
			i.Data.iPart Assembly=Program.DC.New(i.Data.CID.Part) as i.Data.iPart;
			_part_properties AP=new _part_properties(Assembly);
			AP.ShowDialog();
			AP.Dispose();
			if(Program.DC.Where((D) => D==Assembly).Count()!=0)
			{
				_table.Rows.Add(ToObjects(Assembly));
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
		public DialogResult ShowDialog(out List<i.Data.iPart> L)
		{
			DialogResult DR=base.ShowDialog();
			IEnumerable<int> E=_table.SelectedRows.OfType<DataGridViewRow>().Select((DGVR) => DGVR.Cells[0].Value).OfType<int>();
			L=new List<i.Data.iPart>();
			foreach(int I in E)
			{
				foreach(i.Data.iPart A in DATA)
				{
					if(A.ID==I)
					{
						L.Add(A);
						break;
					}
				}
			}
			return DR;
		}
	}
}