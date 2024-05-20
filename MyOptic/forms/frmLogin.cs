using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOptic.forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void frmClients_Load(object sender, EventArgs e)
        {

        }

        private void tsShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (tsShowPass.Checked)
            {
                txtMdp.UseSystemPasswordChar = false;
            }
            else
                txtMdp.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "info@myoptic.com" && txtMdp.Text == "myoptic123")
            {
                forms.frmMenu frm = new frmMenu();
                frm.Show();
            }
            else
            {
                MessageBox.Show("login ou mot de passe invalide");
                txtMdp.Clear();
            }
        }
    }
}
