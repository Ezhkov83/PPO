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
    public partial class addandedit : Form
    {
        private int Id;
        public addandedit()
        {
            InitializeComponent();
            btnaaeedit.Visible = false;
        }

        public addandedit(int id)
        {
            Id = id;
            InitializeComponent();
            btnaaeadd.Visible = false;
            BolBol bb = new BolBol(id);
            txtfiopac.Text = bb.FIObol;
            txtbolezn.Text = bb.Bolezn;
            dtppost.Text= Convert.ToString(bb.Prishel);
            dtpvip.Text = Convert.ToString(bb.Ushel);
            txtdolzhn.Text = bb.DolzVracha;
            txtfiovr.Text = bb.FIOvr;
        }

        private void btnaaeedit_Click(object sender, EventArgs e)
        {
            if (txtfiopac.Text == "" || txtbolezn.Text == "" || dtppost.Text == "" || dtpvip.Text == "" || txtdolzhn.Text == "" || txtfiovr.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileWork.AddUpdate(
                    Id,
                    txtfiopac.Text,
                    txtbolezn.Text,
                    Convert.ToDateTime(dtppost.Text),
                    Convert.ToDateTime(dtpvip.Text),
                    txtdolzhn.Text,
                    txtfiovr.Text);
                Close();
            }
        }

        private void btnaaeadd_Click(object sender, EventArgs e)
        {
            try
            {
                BolBol bb = new BolBol();
                bb.FIObol = txtfiopac.Text;
                bb.Bolezn = txtbolezn.Text;
                bb.Prishel = Convert.ToDateTime(dtppost.Text);
                bb.Ushel = Convert.ToDateTime(dtpvip.Text);
                bb.DolzVracha = txtdolzhn.Text;
                bb.FIOvr = txtfiovr.Text;
                bb.Save();
                Close();
            }
            catch
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaaeexit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
