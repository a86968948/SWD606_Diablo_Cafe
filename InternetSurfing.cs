using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606_Diablo_Cafe
{
    public partial class InternetSurfing : Form
    {
        private TcpListener tcpListener;
        private Thread listenerThread;
        private static double hourlyRate = 2.0;
        private static bool isRunning = true;
        const int MaxLength = 5;
        public InternetSurfing()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            isRunning = true;
            WebLunch(isRunning = true);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            WebShutdown(isRunning= false);
            new Fastpay().ShowDialog();
            this.Hide();
        }
        public bool WebLunch(bool isRunning)
        {
            WebBrowser wb = new WebBrowser();
            panel1.Controls.Add(wb);
            wb.Dock = DockStyle.Fill;
            wb.Navigate("https://www.google.com");
            Thread billingThread = new Thread(BillingLoop);
            billingThread.Start();
            return isRunning;
        }
        public bool WebShutdown(bool isRunning)
        {
            isRunning = false;
            Fastpay.Transfer1 = Timetxt.Text;
            Fastpay.Transfer2 = Costtxt.Text;
            
            return isRunning;
        }
        private void InternetSurfing_Load(object sender, EventArgs e)
        {
            Timetxt.Text = "00";
            Costtxt.Text = "00";
        }
       
        public void BillingLoop()
        {
            double totalCost = 0;
            DateTime startTime = DateTime.Now;

            while (isRunning)
            {
                
                //double elapsedHours = (DateTime.Now - startTime).TotalHours;
                double elapsedHours = (DateTime.Now - startTime).TotalMinutes;

                
                double currentCost = CalculateCost(elapsedHours);

                
                if (currentCost != totalCost)
                {
                    totalCost = currentCost;
                    Costtxt.Text = totalCost.ToString();
                    Timetxt.Text = elapsedHours.ToString();
                   
                    if (Costtxt.Text.Length > MaxLength)
                        Costtxt.Text = Costtxt.Text.Substring(0, MaxLength);
                    if (Timetxt.Text.Length > MaxLength)
                        Timetxt.Text = Timetxt.Text.Substring(0, MaxLength);

                }

                
                Thread.Sleep(1000);//60000 == 1 min
            }
        }
        public double CalculateCost(double hours)
        {
            return hours * hourlyRate;
        }

       

    }
}
