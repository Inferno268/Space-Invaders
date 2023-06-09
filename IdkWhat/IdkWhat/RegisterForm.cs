using Database_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdkWhat
{
    public partial class RegisterForm : Form
    {

        static string conn = ConfigurationManager.ConnectionStrings["justDatabase"].ConnectionString;
        SqlConnection sqlConnection = DatabaseSingleton.GetInstance();
        public RegisterForm()
        {
            InitializeComponent();
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }

        public void Validator()
        {
            string usernameRegex = "^[a-zA-Z0-9]{4,20}$";
            string passwordRegex = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d]{8,}$";
            string emailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z0-9.-]+$";
            string userNameInput = userName.Text;
            string email = emailInput.Text;
            string passwordInput = passInput.Text;
            string scndPassInput = passCheckInput.Text;


            if (Regex.IsMatch(userNameInput, usernameRegex) && Regex.IsMatch(passwordInput, passwordRegex) && Regex.IsMatch(email, emailRegex))
            {
                string query = "Insert into Users (user_name, password, user_email, user_best_score) values('" + userNameInput + "','" + passwordInput + "','" + email + "',"+ 0+ ")";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();

                Users user = new Users(userNameInput, passwordInput, email, 0);

                MainpageForm mainpage= new MainpageForm(user);
                mainpage.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("You have not met the requirements for registration");
            }
        }
        //Kill app on close
        static void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Validator();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.ShowDialog();


        }
    }
}
