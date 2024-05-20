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
    public partial class frmLunettes : Form
    {
        private Form activeForm;
        public frmLunettes()
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
            OpenChildForm(new forms.frmListeLunettes(), sender);
            panel1.Visible = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.frmDetail(), sender);
            panel1.Visible = true;
        }

        private void frmLunettes_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
