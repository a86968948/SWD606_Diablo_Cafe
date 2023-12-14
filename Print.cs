using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606_Diablo_Cafe
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            printDialog = new PrintDialog();
            printDialog.Document = printDocument;
           
            printDocument.DefaultPageSettings.PrinterSettings.Copies = 1;
            printDocument.DefaultPageSettings.PrinterSettings.Duplex = Duplex.Simplex;
            printDocument.DefaultPageSettings.Color = false;
        }
        double CostCount1 = 0;//radioBt Color
        double CostCount2 = 0;//redioBt Side
        int PageCount3 = 0;//Page count
        double Price = 0;
        PrintDocument printDocument;
        PrintDialog printDialog;
        int currentPage = 1;
        int totalPages = 1;
        string SourceLocation;
        private void Back_Click(object sender, EventArgs e)
        {
            new FunctionP().Show();
            this.Hide();
        }

        private void BnWBt_Click(object sender, EventArgs e)
        {
            //0.5 per Page
            CostCount1 = 0.5;
            if (CostCount1 != 0 && CostCount2 != null && PageCount3 != 0)
            {
                Counter(CostCount1,CostCount2,PageCount3);
            }
        }

        private void FullCBt_Click(object sender, EventArgs e)
        {
            // 1 per page
            CostCount1 = 1;
            if (CostCount1 != 0 && CostCount2 != null && PageCount3 != 0)
            {
                Counter(CostCount1, CostCount2, PageCount3);
            }
        }
        private void SingleBt_Click(object sender, EventArgs e)
        {
            // free
            CostCount2 = 0;
            if (CostCount1 != 0 && CostCount2 != null && PageCount3 != 0)
            {
                Counter(CostCount1, CostCount2, PageCount3);
            }
        }
        private void DoubleBt_Click(object sender, EventArgs e)
        {
            // 0.5 per page
            CostCount2 = 0.5;
            if (CostCount1 != 0 && CostCount2 != null && PageCount3 != 0)
            {
                Counter(CostCount1, CostCount2, PageCount3);
            }
        }
        public double Counter(double a, double b ,int c)
        {
            double result = (a + b) * c;
            Price = result;
            MoneyShow.Text = result.ToString();
            return result;
        }

        private void Pagetxt_TextChanged(object sender, EventArgs e)
        {
            if (Pagetxt.Text != " " || Pagetxt.Text != "")
            {
                try
                {
                    PageCount3 = int.Parse(Pagetxt.Text);
                    if (CostCount1 != 0 && CostCount2 != null && PageCount3 != 0)
                    {
                        Counter(CostCount1, CostCount2, PageCount3);
                    }

                }
                catch
                {
                   

                }
            }
        }

        private void PrintBt_Click(object sender, EventArgs e)
        {
            
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
               
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                
                totalPages = PageCount3; 

                currentPage = 1;
                printDocument.Print();
            }


        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string content = $"这是第 {currentPage} 页，共 {totalPages} 页";
            e.Graphics.DrawString(content, new Font("Arial", 12), Brushes.Black, 50, 50);

            currentPage++;
            e.HasMorePages = currentPage <= totalPages;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                totalPages = PageCount3; 

                currentPage = 1;
                printDocument.Print();
            }
        }

        private void Location2Bt_Click(object sender, EventArgs e)
        {
            SourceLocation = FileLocation();
        }
        public string FileLocation()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "(*.*)|*.*";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedfilepath = ofd.FileName;
                Pathtxt2.Text = selectedfilepath;
                return selectedfilepath;
            }
            else
            {
                MessageBox.Show("That's not a file, pleace try again.");
                return null;
            }

        }

        private void Print_Load(object sender, EventArgs e)
        {

        }
    }
}
