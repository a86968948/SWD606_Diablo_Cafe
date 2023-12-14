using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD606_Diablo_Cafe
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public string UserName;
        public string Password;
        public string Email;
        public int Age;
        private void reRegisterbt_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\localA2;Initial Catalog=SWD606_Assessment2;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    //took me 3 hourse to do this, it is not hard, you have to be very careful
                    //otherwise you are gonna delete the database serveral times to make it right.
                    AccountValidationStrategy checkAccount = new AccountValidationStrategy();
                    PasswordValidationStrategy checkpassword = new PasswordValidationStrategy();
                    if (checkpassword.Validate(rePasswordtxt.Text) || (checkAccount.Validate(reUsernametxt.Text)))
                    {
                        MessageBox.Show("Password is Validated");
                        MessageBox.Show("Username is Validated");
                        sqlCommand.Connection = sqlConn;

                        // Use parameterized queries to prevent SQL injection
                        string sqlInsert = "INSERT INTO UserInform " +
                            "([UserName], [PassWord], [Email], [Age]) " +
                            "VALUES (@UserName, @PassWord, @Email, @Age)";

                        sqlCommand.CommandText = sqlInsert;

                        // Add parameters to the SqlCommand
                        sqlCommand.Parameters.AddWithValue("@UserName", reUsernametxt.Text);
                        sqlCommand.Parameters.AddWithValue("@PassWord", rePasswordtxt.Text);
                        sqlCommand.Parameters.AddWithValue("@Email", reEmailtxt.Text);
                        sqlCommand.Parameters.AddWithValue("@Age", reAgetxt.Text);

                        // Open the connection and execute the query
                        sqlConn.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        // Check the number of rows affected to determine if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Created");
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Please try again.");
                        }
                        // Close the connection
                        sqlConn.Close();
                        //Go back to login page
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong please try again");
                    }
                }
            }
        }
        public interface ValidationStrategy
        {
            bool Validate(string input);
        }
        public class AccountValidationStrategy : ValidationStrategy
        {
            public bool Validate(string input)
            {
                // Account/Username strength validation logic
                // Any account below 8 digits or above 14 digits returns false
                if (input.Length < 8 || input.Length > 14)
                    return true;
                return false; // Return true if all conditions are met
            }
        }
        public class PasswordValidationStrategy : ValidationStrategy
        {
            public bool Validate(string input)
            {
                // Password strength validation logic
                // Any password below 8 digits or above 14 digits returns false
                if (input.Length < 8 || input.Length > 14)
                    return true;
                // At least one upper case letter
                if (!input.Any(char.IsUpper))
                    return true;
                // No blank space
                if (input.Contains(" "))
                    return true;
                //MessageBox.Show("password is not wrong");
                // If all conditions are met, the password is valid
                return true;
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
