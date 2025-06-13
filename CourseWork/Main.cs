using System;
using System.Linq;
using System.Windows.Forms;
//~2700 строк кода в 12 файлах
//~57 часов потрачено, из них:
//~15 - проектирование 
//~20 - программирование
//~8 - копипастинг кода форм (почти программирование ;))
//~2 - тестирование
//~4 - оформление + интерфейс
//~8 - рефакторинг + комментарии + отчет
namespace CourseWork
{
    public partial class Main : Form
    {
        /// <summary>
        /// конструктор (.ctor) формы
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// просмотр сборок
        /// </summary>
        private void _assembly_Click(object sender, EventArgs e)
        {
            //форма выбора сборок
            _assembly_select AS = new _assembly_select();
            //показать
            AS.ShowDialog();
            //освобождение всех ресурсов, используемых формой
            AS.Dispose();
            //фокус на главную форму
            this.Focus();
        }
        /// <summary>
        /// просмотр чертежей
        /// </summary>
        private void _draught_Click(object sender, EventArgs e)
        {
            _draught_select DS = new _draught_select();
            DS.ShowDialog();
            DS.Dispose();
            System.GC.Collect(System.GC.MaxGeneration, GCCollectionMode.Forced);
            this.Focus();
        }
        /// <summary>
        /// просмотр деталей
        /// </summary>
        private void _part_Click(object sender, EventArgs e)
        {
            _part_select DS = new _part_select();
            DS.ShowDialog();
            DS.Dispose();
            System.GC.Collect(System.GC.MaxGeneration, GCCollectionMode.Forced);
            this.Focus();
        }
        /// <summary>
        /// просмотр групп однотипных деталей
        /// </summary>
        private void _group_Click(object sender, EventArgs e)
        {
            _group_select DS = new _group_select();
            DS.ShowDialog();
            DS.Dispose();
            System.GC.Collect(System.GC.MaxGeneration, GCCollectionMode.Forced);
            this.Focus();
        }
        /// <summary>
        /// сохранение БД
        /// </summary>
        private void _save_Click(object sender, EventArgs e)
        {
            _save_db.ShowDialog();
            if (_save_db.FileName != String.Empty)
            {
                string password;
                Password P = new Password();
                if (P.ShowDialog(out password) == DialogResult.OK && password != string.Empty)
                {
                    try
                    {
                        Program.DC.Save(_save_db.FileName, password);
                        MessageBox.Show("Database encrypt and save successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Database is not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        Program.DC.Save(_save_db.FileName);
                        MessageBox.Show("Database save successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Database is not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                P.Dispose();
            }
        }
        /// <summary>
        /// загрузка БД
        /// </summary>
        private void _load_Click(object sender, EventArgs e)
        {
            _load_db.ShowDialog();
            if (_load_db.FileName != String.Empty)
            {
                string password;
                Password P = new Password();
                if (P.ShowDialog(out password) == DialogResult.OK && password != string.Empty)
                {
                    try
                    {
                        Program.DC.Load(_load_db.FileName, password);
                        MessageBox.Show("Database decrypt and load successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Exception exc)
                    {
                        Program.DC.Clear();
                        MessageBox.Show("Database is not loaded" + System.Environment.NewLine + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        Program.DC.Load(_load_db.FileName);
                        MessageBox.Show("Database load successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Exception exc)
                    {
                        Program.DC.Clear();
                        MessageBox.Show("Database is not loaded" + System.Environment.NewLine + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                P.Dispose();
            }
        }
        /// <summary>
        /// нажатие на кнопку Generate
        /// </summary>
        private void _generate_Click(object sender, EventArgs e)
        {
            Generate();
        }
        /// <summary>
        /// генерация записей четырех видов в БД
        /// </summary>
        private void Generate()
        {
            Random R = new Random();
            string chars = "йцукенгшщзхъфывапролджэячсмитьбюё";
            for (int i1 = 0; i1 < 10000; i1++)
            {
                string name = "";
                int namel = R.Next(6, 10);
                for (int i2 = 0; i2 < namel; i2++)
                {
                    name += chars[R.Next(0, chars.Length)].ToString();
                }
                i.Data.CID type = (i.Data.CID)R.Next(0, 4);
                switch (type)
                {
                    case i.Data.CID.Assembly:
                        i.Data.iAssembly A = Program.DC.New(type) as i.Data.iAssembly;
                        A.NAME = name;
                        int count = 0;
                        count++;
                        for (int i3 = 0; i3 < Program.DC.Count && i3 < i1; i3++)
                        {
                            if ((Program.DC[i3] is i.Data.iDraught) && R.NextDouble() <= 0.01)
                            {
                                A.DRAUGHTS.Add(Program.DC[i3].ID);
                            }
                        }
                        if (R.NextDouble() < 0.5)
                        {
                            A.DIFF = i.Data.iAssembly.AutoDiff(A);
                        }
                        else
                        {
                            A.DIFF = (byte)R.Next(100);
                        }
                        if (A.DRAUGHTS.Count < 2)
                        {
                            Program.DC.Delete(A);
                        }
                        break;
                    case i.Data.CID.Draught:
                        i.Data.iDraught D = Program.DC.New(type) as i.Data.iDraught;
                        D.NAME = name;
                        D.INDEX = D.ID;
                        D.FORMAT = i.Data.Format.Formats[(int)R.Next(0, i.Data.Format.Formats.Count())];
                        for (int i3 = 0; i3 < Program.DC.Count && i3 < i1; i3++)
                        {
                            if ((Program.DC[i3] is i.Data.iPart) && R.NextDouble() <= 0.01)
                            {
                                D.PARTS.Add(Program.DC[i3].ID);
                            }
                        }
                        if (D.PARTS.Count < 2)
                        {
                            Program.DC.Delete(D);
                        }
                        break;
                    case i.Data.CID.Group:
                        i.Data.iGroup G = Program.DC.New(type) as i.Data.iGroup;
                        G.NAME = name;
                        for (int i3 = 0; i3 < Program.DC.Count && i3 < i1; i3++)
                        {
                            if ((Program.DC[i3] is i.Data.iPart) && R.NextDouble() <= 0.0016)
                            {
                                G.PARTS.Add(Program.DC[i3].ID);
                            }
                        }
                        break;
                    case i.Data.CID.Part:
                        i.Data.iPart P = Program.DC.New(type) as i.Data.iPart;
                        P.NAME = name;
                        P.NEW = (byte)R.Next(100);
                        P.DIFF = (byte)R.Next(100);
                        P.DONE = R.NextDouble() < 0.03;
                        break;
                    default:
                        throw new System.Exception("Invalid type in Generate function");
                }
            }
        }
        /// <summary>
        /// представление данных в виде "ID - тип - имя"
        /// для их добавления в таблицу
        /// </summary>
        private object[] ToObjects(i.Data.iData D)
        {
            switch (D.CID)
            {
                case i.Data.CID.Assembly:
                    return new object[]
                    {
                        D.ID,
                        D.CID,
                        (D as i.Data.iAssembly).NAME,
                    };
                case i.Data.CID.Draught:
                    return new object[]
                    {
                        D.ID,
                        D.CID,
                        (D as i.Data.iDraught).NAME,
                    };
                case i.Data.CID.Group:
                    return new object[]
                    {
                        D.ID,
                        D.CID,
                        (D as i.Data.iGroup).NAME,
                    };
                case i.Data.CID.Part:
                    return new object[]
                    {
                        D.ID,
                        D.CID,
                        (D as i.Data.iPart).NAME,
                    };
                default:
                    throw new System.Exception();
            }
        }
        /// <summary>
        /// обновление БД
        /// </summary>
        private void _update_Click(object sender, EventArgs e)
        {
            _table.Rows.Clear();
            foreach (i.Data.iData A in Program.DC)
            {
                _table.Rows.Add(ToObjects(A));
            }
        }
        /// <summary>
        /// увеличение числа записей в БД
        /// </summary>
        private void _table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowsCountChanged();
        }
        /// <summary>
        /// уменьшение числа записей в БД
        /// </summary>
        private void _table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowsCountChanged();
        }
        /// <summary>
        /// отображение числа записей в БД
        /// </summary>
        private void RowsCountChanged()
        {
            _count.Text = _table.RowCount.ToString();
        }
        /// <summary>
        /// открытие окна свойств, выделенной записи
        /// </summary>
        private void _properties_Click(object sender, EventArgs e)
        {
            if (_table.SelectedRows.Count == 1)
            {
                switch ((i.Data.CID)_table.SelectedRows[0].Cells[1].Value)
                {
                    case i.Data.CID.Assembly:
                        _assembly_properties AP = new _assembly_properties(Program.DC.OfType<i.Data.iAssembly>().Single((D) => D.ID == (int)_table.SelectedRows[0].Cells[0].Value));
                        AP.ShowDialog();
                        AP.Dispose();
                        break;
                    case i.Data.CID.Draught:
                        _draught_properties DP = new _draught_properties(Program.DC.OfType<i.Data.iDraught>().Single((D) => D.ID == (int)_table.SelectedRows[0].Cells[0].Value));
                        DP.ShowDialog();
                        DP.Dispose();
                        break;
                    case i.Data.CID.Group:
                        _group_properties GP = new _group_properties(Program.DC.OfType<i.Data.iGroup>().Single((D) => D.ID == (int)_table.SelectedRows[0].Cells[0].Value));
                        GP.ShowDialog();
                        GP.Dispose();
                        break;
                    case i.Data.CID.Part:
                        _part_properties PP = new _part_properties(Program.DC.OfType<i.Data.iPart>().Single((D) => D.ID == (int)_table.SelectedRows[0].Cells[0].Value));
                        PP.ShowDialog();
                        PP.Dispose();
                        break;
                    default:
                        throw new System.Exception("Invalid Class ID");
                }
            }
        }
    }
}