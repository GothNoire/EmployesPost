using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmployesPost
{
    public partial class MainForm : Form
    {

        SqlConnection con = new SqlConnection(EmployesPost.Properties.Settings.Default.EmployeeDepartmentConnectionString);
        InsertUpdateForm IUF = new InsertUpdateForm();

        public MainForm()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);

            var SelectQuery =
                from a in dc.Employes
                join b in dc.Post on a.id_post equals b.id
                select new {a.LastName, a.FirstName, a.Patronymic, b.Name};
            //var list = new List<string>();
            int i = 0;
            dataGridView1.RowCount = 1;
            foreach (var l in SelectQuery)
            {
                dataGridView1.RowCount +=1;
                dataGridView1.Rows[i].Cells[0].Value = l.LastName + ' ' + l.FirstName + ' ' + l.Patronymic;
                dataGridView1.Rows[i].Cells[1].Value = l.Name;
                i ++;
            }
        }
        private void BInsert_Click(object sender, EventArgs e)
        {
            Cflag.flag = 0;
            Program.f2.textBox1.Text = "";
            Program.f2.textBox2.Text = "";
            Program.f2.textBox3.Text = "";
            Program.f2.comboBox1.Text = (string)Program.f2.comboBox1.Items[1];
            this.Hide();
            IUF.ShowDialog();
            this.Show();
        }
        private void Bdelete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            var SelectQuery =
                from a in dc.Employes_view
                where a.row_id == dataGridView1.CurrentRow.Index+1 
                select a;
            //var items = SelectQuery.ToList();
            foreach (var item in SelectQuery)
            {
                dc.Employes_view.DeleteOnSubmit(item);
            }
            try
            {
                dc.SubmitChanges();
                dataGridView1.Refresh();
                if (dataGridView1.CurrentRow != null)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
            catch
            {
            }
        }
        private void Bchange_Click(object sender, EventArgs e)
        {
            Cflag.flag = 1;
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            try
            {
                var SelectQuery =
                from a in dc.Employes_view
                where a.row_id == dataGridView1.CurrentRow.Index + 1 // переделать
                select a;
                foreach (var item in SelectQuery)
                {
                    Program.f2.textBox1.Text = item.LastName;
                    Program.f2.textBox2.Text = item.FirstName;
                    Program.f2.textBox3.Text = item.Patronymic;
                    Program.f2.comboBox1.Text = (string)Program.f2.comboBox1.Items[(int)item.id_post - 1];
                    if (item.row_id != null)
                    {
                        this.Hide();
                        IUF.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch
            {
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void table1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dbmecinesDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
