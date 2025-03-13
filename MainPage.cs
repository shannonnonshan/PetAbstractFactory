using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnHouse_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            OpenChildForm(fHome);
        }

        private void btnWild_Click(object sender, EventArgs e)
        {
            FWild fwild = new FWild();
            OpenChildForm(fwild);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDesert fDesert = new FDesert();
            OpenChildForm(fDesert);
        }
    }
}
