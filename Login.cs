using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SWD606_Diablo_Cafe;

namespace SWD606_Diablo_Cafe
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int UserID;
        public string Password;
        public string UserName;
        SqlCommand sqlcmd = new SqlCommand("");
        SqlDataReader SqlReader;
        string sqlStmt;
        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        //Data Source=(localdb)\localA2;Initial Catalog=SWD606_Assessment2;Integrated Security=True    //Winston db
        //Data Source=(localdb)\local;Initial Catalog=SWD606_Assessment2;Integrated Security=True      //Chenxi  db
        public bool LoginValidation(string UserName, string Password)
        {
            //well get the function from System.Data.SqlClient
            SqlConnection SqlConn = new SqlConnection("Data Source=(localdb)\\localA2;Initial Catalog=SWD606_Assessment2;Integrated Security=True");
            SqlCommand SqlStr = new SqlCommand();
            SqlDataReader SqlReader;
            string sqlStmt;
            try
            {
                
                //connect the database
                SqlConn.Open();
                //loop through you could use while or if
                SqlCommand sqlcmd = new SqlCommand("select * from UserInform where UserName = @UserName and PassWord = @Password", SqlConn);
                sqlcmd.Parameters.AddWithValue("@UserName", UserName);
                sqlcmd.Parameters.AddWithValue("@PassWord", Password);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    UserID = int.Parse(dt.Rows[0][0].ToString());
                    MessageBox.Show("Login Succesful");
                    new FunctionP().Show();
                    this.Hide();
                    SqlConn.Close();
                    return true;
                }
                //which the table does not have the customer name, ask user to register then
                else
                {
                    MessageBox.Show("Check Username/Password, or you can Register if you haven't");
                    //Clear the two text box input
                    Logintxt.Clear();
                    Passwordtxt.Clear();
                    SqlConn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Exception" + ex.Message);
                SqlConn.Close();
                return false;
            }
        }
        private void Loginbt_Click_1(object sender, EventArgs e)
        {
            LoginValidation(Logintxt.Text, Passwordtxt.Text);
        }
        private void Registerbt_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

    }

}
