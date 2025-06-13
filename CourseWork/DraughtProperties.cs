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
	public partial class _draught_properties:Form
	{
		private i.Data.iDraught DRAUGHT;
		public _draught_properties(i.Data.iDraught Draught)
		{
			InitializeComponent();
			DRAUGHT=Draught;
			this._id.Text=DRAUGHT.ID.ToString();
			this._name.Text=DRAUGHT.NAME.ToString();
			this._index.Text=DRAUGHT.INDEX.ToString();
			foreach(int I in DRAUGHT.PARTS)
			{
				this._parts.Items.Add(I);
			}
			_format.Items.AddRange(i.Data.Format.Formats as object[]);
			_format.Text=DRAUGHT.FORMAT.ToString();
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
					DRAUGHT.PARTS.Add(D.ID);
				}
				_parts.Items.Clear();
				foreach(int I in DRAUGHT.PARTS)
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
				DRAUGHT.PARTS.Remove((int)_parts.SelectedItem);
			}
			_parts.Items.Clear();
			foreach(int I in DRAUGHT.PARTS)
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
				Program.DC.Delete(DRAUGHT);
				this.DRAUGHT=null;
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
				DRAUGHT.NAME=_name.Text;
				_error.SetError(_name,string.Empty);
			}
		}
		private void _index_TextChanged(object sender,EventArgs e)
		{
			//индексы не должны совпадать + можно поставить текущий индекс
			IEnumerable<i.Data.iDraught> E=from D in Program.DC.OfType<i.Data.iDraught>()
				  where (D.INDEX.ToString()==_index.Text)&&(D.INDEX!=DRAUGHT.INDEX)
				  select D;
			if(E.Count<i.Data.iDraught>()>=1)
			{
				_error.SetError(_index,"that index already exists");
			}
			else
			{
				try
				{
					DRAUGHT.INDEX=int.Parse(_index.Text);
					_error.SetError(_index,string.Empty);
				}
				catch(System.Exception)
				{
					_error.SetError(_index,"invalid format");
				}
			}
		}
		private void _format_TextChanged(object sender,EventArgs e)
		{
			i.Data.Format.iFormat[] Format=i.Data.Format.Formats.Where((F) => F.ToString()==(sender as ComboBox).Text).ToArray();
			switch(Format.Count())
			{
				case 0:
					_error.SetError(_format,"non valid format");
					break;
				case 1:
					_error.SetError(_format,string.Empty);
					DRAUGHT.FORMAT=Format[0];
					break;
				default:
					break;
			}
		}
	}
}