using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezhkov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FillData()
        {
            dataGridView1.DataSource = FileWork.ReadTable();
        }

        private void dobavitb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(*.TXT)|*.TXT| All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileWork.FilePath = ofd.FileName;
                    FillData();
                }
                catch
                {
                    MessageBox.Show("Формат не соответствует требуемому", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addandedit aae = new addandedit();
            aae.ShowDialog();
            FillData();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0] != null)
            {
                int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                FileWork.Delete(index);
                FillData();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                addandedit aae = new addandedit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                aae.ShowDialog();
                FillData();
            }
            catch (Exception)
            {
                MessageBox.Show("Выделите заполненную строку", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbsearch.Text)
            {
                case "Пациент":
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("[ФИО больного] LIKE '%{0}%'", txtsearch.Text.Trim());
                        break;
                    }
                case "Болезнь":
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("[Болезнь] LIKE '%{0}%'", txtsearch.Text.Trim());
                        break;
                    }
                case "Должность врача":
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("[Должность врача] LIKE '%{0}%'", txtsearch.Text.Trim());
                        break;
                    }
            }
        }


        //private void dataGridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        aaemenu aae = new aaemenu(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        //        aae.ShowDialog();
        //        FillData();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Выделите заполненную строку", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}