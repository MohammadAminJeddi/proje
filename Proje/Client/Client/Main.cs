using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadForm(object form)
        {
            if(this.pnlMain.Controls.Count>0)
            {
                this.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag= f;
            f.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            loadForm(new Main());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new monitor());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new customer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new room());
        }
    }

}
