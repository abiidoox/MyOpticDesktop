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
    public partial class frmListeLunettes : Form
    {
        private Form activeForm;
        public frmListeLunettes()
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
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.frmListeLunettes(), sender);
            panel2.Visible = true;
            panel1.Visible = false;
            
        }

        private void frmListeLunettes_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
