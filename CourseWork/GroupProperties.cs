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
	public partial class _group_properties:Form
	{
		private i.Data.iGroup GROUP;
		public _group_properties(i.Data.iGroup Group)
		{
			InitializeComponent();
			GROUP=Group;
			this._id.Text=GROUP.ID.ToString();
			this._name.Text=GROUP.NAME.ToString();
			foreach(int I in GROUP.PARTS)
			{
				this._parts.Items.Add(I);
			}
		}
		private void _add_parts_Click(object sender,EventArgs e)
		{
			List<i.Data.iPart> L=new List<i.Data.iPart>();
			foreach(i.Data.iPart D in Program.DC.OfType<i.Data.iPart>().ToList())
			{
				L.Add(D);
				foreach(int I in _parts.Items.OfType<int>())
				{
					if(D.ID==I)
					{
						L.Remove(D);
						break;
					}
				}
			}
			_part_select DS=new _part_select(L);
			List<i.Data.iPart> List;
			if(DS.ShowDialog(out List)==DialogResult.OK)
			{
				foreach(i.Data.iPart D in List)
				{
					GROUP.PARTS.Add(D.ID);
				}
				_parts.Items.Clear();
				foreach(int I in GROUP.PARTS)
				{
					_parts.Items.Add(I);
				}
				DS.Dispose();
			}
		}
		private void _remove_parts_Click(object sender,EventArgs e)
		{
			if(_parts.SelectedIndex>=0)
			{
				GROUP.PARTS.Remove((int)_parts.SelectedItem);
			}
			_parts.Items.Clear();
			foreach(int I in GROUP.PARTS)
			{
				_parts.Items.Add(I);
			}
		}
		private void _draughts_properties_Click(object sender,EventArgs e)
		{
			if(_parts.SelectedIndex>=0)
			{
				i.Data.iPart Part=Program.DC.OfType<i.Data.iPart>().Single((D) => (D.ID==(int)_parts.SelectedItem));
				_part_properties DP=new _part_properties(Part);
				DP.ShowDialog();
				DP.Dispose();
				if(Program.DC.Where((D) => D==Part).Count()==0)
				{
					_parts.Items.RemoveAt(_parts.SelectedIndex);
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
			if(MessageBox.Show("Are you sure you want to delete this item","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				Program.DC.Delete(GROUP);
				this.GROUP=null;
				this.Close();
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
				GROUP.NAME=_name.Text;
				_error.SetError(_name,string.Empty);
			}
		}
	}
}