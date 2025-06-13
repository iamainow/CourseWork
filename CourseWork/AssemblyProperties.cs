using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CourseWork
{
	public partial class _assembly_properties:Form
	{
		private i.Data.iAssembly ASSEMBLY;
		public _assembly_properties(i.Data.iAssembly Assembly)
		{
			InitializeComponent();
			ASSEMBLY=Assembly;
			this._id.Text=ASSEMBLY.ID.ToString();
			this._name.Text=ASSEMBLY.NAME.ToString();
			this._diff.Text=ASSEMBLY.DIFF.ToString();
			foreach(int I in ASSEMBLY.DRAUGHTS)
			{
				this._draughts.Items.Add(I);
			}
			ChangeItemCount();
		}
		private void _diff_TextChanged(object sender,EventArgs e)
		{
			if(_diff.Text==String.Empty)
			{
				_error.SetError(_diff,"string is empty");
			}
			else
			{
				byte B;
				if(byte.TryParse(_diff.Text,out B))
				{
					if(B>100)
					{
						_error.SetError(_diff,"value greater then 100");
					}
					else
					{
						ASSEMBLY.DIFF=B;
						_error.SetError(_diff,String.Empty);
					}
				}
				else
				{
					_error.SetError(_diff,"invalid format");
				}
			}
		}
		private void _name_TextChanged(object sender,EventArgs e)
		{
			if(_name.Text==string.Empty)
			{
				_error.SetError(_name,"string is empty");
			}
			else
			{
				ASSEMBLY.NAME=_name.Text;
				_error.SetError(_name,string.Empty);
			}
		}
		private void _auto_diff_Click(object sender,EventArgs e)
		{
			ASSEMBLY.DIFF=i.Data.iAssembly.AutoDiff(ASSEMBLY);
			_diff.Text=ASSEMBLY.DIFF.ToString();
		}
		private void _add_draughts_Click(object sender,EventArgs e)
		{
			List<i.Data.iDraught> L=new List<i.Data.iDraught>();
			foreach(i.Data.iDraught D in Program.DC.OfType<i.Data.iDraught>())
			{
				L.Add(D);
				foreach(int I in _draughts.Items.OfType<int>())
				{
					if(D.ID==I)
					{
						L.Remove(D);
						break;
					}
				}
			}
			_draught_select DS=new _draught_select(L);
			List<i.Data.iDraught> List;
			if(DS.ShowDialog(out List)==DialogResult.OK)
			{
				foreach(i.Data.iDraught D in List)
				{
					ASSEMBLY.DRAUGHTS.Add(D.ID);
				}
				_draughts.Items.Clear();
				foreach(int I in ASSEMBLY.DRAUGHTS)
				{
					_draughts.Items.Add(I);
				}
				DS.Dispose();
				ChangeItemCount();
			}
		}
		private void _remove_draughts_Click(object sender,EventArgs e)
		{
			if(_draughts.SelectedIndex>=0)
			{
				ASSEMBLY.DRAUGHTS.Remove((int)_draughts.SelectedItem);
			}
			_draughts.Items.Clear();
			foreach(int I in ASSEMBLY.DRAUGHTS)
			{
				_draughts.Items.Add(I);
			}
			ChangeItemCount();
		}
		private void _draughts_properties_Click(object sender,EventArgs e)
		{
			if(_draughts.SelectedIndex>=0)
			{
				i.Data.iDraught Draught=Program.DC.OfType<i.Data.iDraught>().Single((D) => (D.ID==(int)_draughts.SelectedItem));
				_draught_properties DP=new _draught_properties(Draught);
				DP.ShowDialog();
				DP.Dispose();
				if(Program.DC.Where((D) => D==Draught).Count()==0)
				{
					_draughts.Items.RemoveAt(_draughts.SelectedIndex);
				}
				this.Focus();
			}
		}
		private void _close_Click(object sender,EventArgs e)
		{
			this.Close();
		}
		private void _delete_Click(object sender,EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to delete this Item?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				this.Close();
				Program.DC.Delete(ASSEMBLY);
			}
		}
		private void ChangeItemCount()
		{
			if(_draughts.Items.Count<2)
			{
				_error.SetError(_draughts,"items count less than 2");
			}
			else
			{
				_error.SetError(_draughts,string.Empty);
			}
		}
	}
}