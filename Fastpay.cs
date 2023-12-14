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
    public partial class Fastpay : Form
    {
        public Fastpay()
        {
            InitializeComponent();
        }
        public static string Transfer1;
        public static string Transfer2;
        private void Fastpay_Load(object sender, EventArgs e)
        {
            Timelab.Text = Transfer1;
            Costlab.Text = Transfer2;
        }

        private void PayBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you so much!!");
            new FunctionP().Show();
            this.Hide();
            
        }
    }
}
