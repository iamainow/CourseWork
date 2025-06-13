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
	public partial class _part_properties:Form
	{
		private i.Data.iPart PART;
		public _part_properties(i.Data.iPart Part)
		{
			InitializeComponent();
			PART=Part;
			this._id.Text=PART.ID.ToString();
			this._name.Text=PART.NAME.ToString();
			this._diff.Text=PART.DIFF.ToString();
			this._done.Checked=PART.DONE;
			this._new.Text=PART.NEW.ToString();
			if(PART.DRAUGHT==0)
			{
				this._draught.Text=string.Empty;
			}
			else
			{
				this._draught.Text=PART.DRAUGHT.ToString();
				DrawAssembly(Program.DC.Where((D) => D.CID==i.Data.CID.Draught && D.ID.ToString()==_draught.Text).First() as i.Data.iDraught);
			}
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
						PART.DIFF=B;
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
				PART.NAME=_name.Text;
				_error.SetError(_name,string.Empty);
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
				Program.DC.Delete(PART);
			}
		}
		private void _done_CheckedChanged(object sender,EventArgs e)
		{
			PART.DONE=_done.Checked;
		}
		private void DrawAssembly(i.Data.iDraught Draught)
		{
			_assembly.Text=string.Empty;
			PART.DRAUGHT=Draught.ID;
			foreach(i.Data.iAssembly A in Program.DC.OfType<i.Data.iAssembly>())
			{
				foreach(int I in A.DRAUGHTS)
				{
					if(I==Draught.ID)
					{
						_assembly.Text=A.ID.ToString();
						break;
					}
					if(_assembly.Text!=string.Empty)
					{
						break;
					}
				}
			}
			_error.SetError(_draught,string.Empty);
		}
		private void _draught_select_Click(object sender,EventArgs e)
		{
			_draught_select DS=new _draught_select();
			List<i.Data.iDraught> List=new List<i.Data.iDraught>();
			if(DS.ShowDialog(out List)==DialogResult.Cancel)
			{
				_draught.Text=string.Empty;
				PART.DRAUGHT=0;
			}
			else
			{
				if(List.Count==1)
				{
					_draught.Text=List[0].ID.ToString();
					PART.DRAUGHT=List[0].ID;
				}
				else
				{
					_draught.Text=string.Empty;
					PART.DRAUGHT=0;
				}
			}
			if(_draught.Text!=string.Empty)
			{
				var V1=Program.DC.Where((D) => D.CID==i.Data.CID.Draught && D.ID.ToString()==_draught.Text);
				if(V1.Count()==0)
				{
					_error.SetError(_draught,"invalid value");
				}
				else
				{
					DrawAssembly(V1.First() as i.Data.iDraught);
				}
			}
			else
			{
				_error.SetError(_draught,string.Empty);
				_assembly.Text=string.Empty;
			}
			DS.Dispose();
		}
		private void _new_TextChanged(object sender,EventArgs e)
		{
			if(_new.Text==String.Empty)
			{
				_error.SetError(_new,"string is empty");
			}
			else
			{
				byte B;
				if(byte.TryParse(_new.Text,out B))
				{
					if(B>100)
					{
						_error.SetError(_new,"value greater then 100");
					}
					else
					{
						PART.NEW=B;
						_error.SetError(_new,String.Empty);
					}
				}
				else
				{
					_error.SetError(_new,"invalid format");
				}
			}
		}
	}
}