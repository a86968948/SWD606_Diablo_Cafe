using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606_Diablo_Cafe
{
    public partial class FunctionP : Form
    {
        public FunctionP()
        {
            InitializeComponent();
        }

        private void InterSur_Click(object sender, EventArgs e)
        {

            InternetSurfing internetSurfing = new InternetSurfing();
            internetSurfing.Show();
            this.Hide();
        }

        private void DownLoad_Click(object sender, EventArgs e)
        {
            new DownLoad().Show();
            this.Hide();
        }

        private void UpLoad_Click(object sender, EventArgs e)
        {
            new UpLoad().Show();
            this.Hide();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            new Print().Show();
            this.Hide();
        }
    }
}
