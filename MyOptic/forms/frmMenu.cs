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
    public partial class frmMenu : Form
    {
        private Form activeForm;
        public frmMenu()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Commandes";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Clients";
            OpenChildForm(new forms.frmClients(), sender);
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Collections";
            OpenChildForm(new forms.frmCollections(), sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Lunettes";
            OpenChildForm(new forms.frmLunettes(), sender);
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Employés";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Livreurs";
            OpenChildForm(new forms.frmLivreurs(), sender);
        }
    }
}
