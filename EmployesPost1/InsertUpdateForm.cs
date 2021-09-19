using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace EmployesPost
{
    public partial class InsertUpdateForm : Form
    {
        SqlConnection con = new SqlConnection(EmployesPost.Properties.Settings.Default.EmployeeDepartmentConnectionString);
        public InsertUpdateForm()
        {
            Program.f2 = this;
            InitializeComponent();
            DataClasses1DataContext dc = new DataClasses1DataContext(con);

            var SelectQuery =
                from a in dc.Post
                select new { a.Name };
            foreach (var item in SelectQuery)
            {
                comboBox1.Items.Add(item.Name);
            }
        }
        private void Bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertUpdateForm_Load(object sender, EventArgs e)
        {
        }
        private void Bsave_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            if (Cflag.flag == 0)
            {
                int i = -1;
                Employes emp = new Employes
                {
                    LastName = textBox1.Text,
                    FirstName = textBox2.Text,
                    Patronymic = textBox3.Text,
                    id_post = comboBox1.SelectedIndex + 1,
                    id = i
                };
                try
                {
                    if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        throw new Exception("Заполните все данные!");
                    }
                    dc.Employes.InsertOnSubmit(emp);
                    dc.SubmitChanges();
                    int q = Program.f1.dataGridView1.RowCount;
                    Program.f1.dataGridView1.RowCount += 1;
                    Program.f1.dataGridView1.Rows[q - 1].Cells[0].Value = textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text;
                    Program.f1.dataGridView1.Rows[q - 1].Cells[1].Value = comboBox1.SelectedItem;
                    Program.f2.textBox1.Text = "";
                    Program.f2.textBox2.Text = "";
                    Program.f2.textBox3.Text = "";
                    Program.f2.comboBox1.Text = (string)Program.f2.comboBox1.Items[1];
                    MessageBox.Show("Данные вставлены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            if (Cflag.flag == 1)
            {
                Employes_view empl = dc.Employes_view.FirstOrDefault(emp => emp.row_id.Equals(Program.f1.dataGridView1.CurrentRow.Index + 1));
                empl.LastName = textBox1.Text;
                empl.FirstName = textBox2.Text;
                empl.Patronymic = textBox3.Text;
                empl.id_post = comboBox1.SelectedIndex + 1;
                try
                {
                    if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        throw new Exception("Заполните все данные!");
                    }
                    dc.SubmitChanges();
                    var SelectQuery =
                        from a in dc.Employes_view
                        select a;
                    int i = 0;
                    foreach (var l in SelectQuery)
                    {
                        Program.f1.dataGridView1.Rows[i].Cells[0].Value = l.LastName + ' ' + l.FirstName + ' ' + l.Patronymic;
                        Program.f1.dataGridView1.Rows[i].Cells[1].Value = comboBox1.Items[(int)l.id_post - 1];
                        i++;
                    }
                    MessageBox.Show("Данные обновлены!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Bcancel_Click(object sender, EventArgs e)
        {
            if (Cflag.flag == 0)
            {
                Program.f2.textBox1.Text = "";
                Program.f2.textBox2.Text = "";
                Program.f2.textBox3.Text = "";
                Program.f2.comboBox1.Text = (string)Program.f2.comboBox1.Items[1];
            }
            if (Cflag.flag == 1)
            {
                DataClasses1DataContext dc = new DataClasses1DataContext(con);
                var SelectQuery =
                    from a in dc.Employes_view
                    where a.row_id == Program.f1.dataGridView1.CurrentRow.Index + 1 
                    select a;
                foreach (var item in SelectQuery)
                {
                    Program.f2.textBox1.Text = item.LastName;
                    Program.f2.textBox2.Text = item.FirstName;
                    Program.f2.textBox3.Text = item.Patronymic;
                    Program.f2.comboBox1.Text = (string)Program.f2.comboBox1.Items[(int)item.id_post - 1];
                }
            }
        }
    }
}
