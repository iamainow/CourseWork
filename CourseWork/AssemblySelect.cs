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
	public partial class _assembly_select:Form
	{
		private IEnumerable<i.Data.iAssembly> DATA;
		public _assembly_select()
		{
			InitializeComponent();
			DATA=Program.DC.Where((D) => D.CID==i.Data.CID.Assembly).Cast<i.Data.iAssembly>();
			foreach(i.Data.iAssembly A in DATA)
			{
				_table.Rows.Add(ToObjects(A));
			}
		}
		public _assembly_select(IEnumerable<i.Data.iAssembly> E)
		{
			InitializeComponent();
			DATA=E;
			foreach(i.Data.iAssembly A in DATA)
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
		private object[] ToObjects(i.Data.iAssembly A)
		{
			return new object[]
			{
				A.ID,
				A.NAME,
				A.DIFF,
				A.DRAUGHTS.Count(),
			};
		}
		private IEnumerable<i.Data.iAssembly> FilterID(IEnumerable<i.Data.iAssembly> E)
		{
			return
				from A in E
				where System.Text.RegularExpressions.Regex.IsMatch(A.ID.ToString(),_id_reg_ex.Text)==true
				select A;
		}
		private IEnumerable<i.Data.iAssembly> FilterName(IEnumerable<i.Data.iAssembly> E)
		{
			return
				from A in E
				where System.Text.RegularExpressions.Regex.IsMatch(A.NAME,_name_reg_ex.Text,System.Text.RegularExpressions.RegexOptions.IgnoreCase)==true
				select A;
		}
		private IEnumerable<i.Data.iAssembly> FilterDiff(IEnumerable<i.Data.iAssembly> E)
		{
			return
				from A in E
				where System.Text.RegularExpressions.Regex.IsMatch(A.DIFF.ToString(),_diff_reg_ex.Text)==true
				select A;
		}
		private IEnumerable<i.Data.iAssembly> FilterRCount(IEnumerable<i.Data.iAssembly> E)
		{
			return
				from A in E
				where System.Text.RegularExpressions.Regex.IsMatch(A.DRAUGHTS.Count.ToString(),_rcount_reg_ex.Text)==true
				select A;
		}
		private IEnumerable<i.Data.iAssembly> Filters(IEnumerable<i.Data.iAssembly> E)
		{
			IEnumerable<i.Data.iAssembly> A=E;
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
			if(_rcount_enable.Checked)
			{
				A=FilterRCount(A);
			}
			return A;
		}
		private void _filter_Click(object sender,EventArgs e)
		{
			_table.Rows.Clear();
			foreach(i.Data.iAssembly A in Filters(this.DATA))
			{
				_table.Rows.Add(ToObjects(A));
			}
		}
		private void _filter_new_Click(object sender,EventArgs e)
		{
			_assembly_select AS=new _assembly_select(Filters(this.DATA));
			List<i.Data.iAssembly> List;
			AS.ShowDialog(out List);
			AS.Dispose();
			_table.Rows.Clear();
			foreach(i.Data.iAssembly A in List)
			{
				_table.Rows.Add(ToObjects(A));
			}
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
				i.Data.iAssembly Assembly=DATA.Single((A) => A.ID==((int)_table.SelectedRows[0].Cells[0].Value));
				_assembly_properties AP=new _assembly_properties(Assembly);
				AP.ShowDialog();
				AP.Dispose();
				System.GC.Collect(System.GC.GetGeneration(AP),GCCollectionMode.Forced);
				_table.Rows.Remove(_table.SelectedRows[0]);
				if(Program.DC.Where((D) => D==Assembly).Count()!=0)
				{
					_table.Rows.Add(ToObjects(Assembly));
				}
			}
		}
		private void _row_new_Click(object sender,EventArgs e)
		{
			i.Data.iAssembly Assembly=Program.DC.New(i.Data.CID.Assembly) as i.Data.iAssembly;
			_assembly_properties AP=new _assembly_properties(Assembly);
			AP.ShowDialog();
			AP.Dispose();
			System.GC.Collect(System.GC.GetGeneration(AP),GCCollectionMode.Forced);
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
		public DialogResult ShowDialog(out List<i.Data.iAssembly> L)
		{
			DialogResult DR=base.ShowDialog();
			IEnumerable<int> E=_table.SelectedRows.OfType<DataGridViewRow>().Select((DGVR) => DGVR.Cells[0].Value).OfType<int>();
			L=new List<i.Data.iAssembly>();
			foreach(int I in E)
			{
				foreach(i.Data.iAssembly A in DATA)
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