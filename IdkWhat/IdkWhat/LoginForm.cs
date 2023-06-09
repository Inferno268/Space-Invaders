using Database_project;
using Microsoft.Win32;
using System.Configuration;
using System.Data.SqlClient;

namespace IdkWhat
{
    public partial class LoginForm : Form
    {
        Users user = new Users();

        static string conn = ConfigurationManager.ConnectionStrings["justDatabase"].ConnectionString;
        SqlConnection sqlConnection = DatabaseSingleton.GetInstance();

        public LoginForm()
        {
            InitializeComponent();

        }

        //method for checking if the user input is the same as one of records in database
        public void Validator()
        {
            string userName = userNameInput.Text;
            string pass = passInput.Text;
            string email;
            int bestScore;

            SqlCommand command;
            SqlCommand emailCommand;
            SqlCommand bestScoreCommand;
            SqlCommand IDcommand;
            SqlDataReader reader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string query = "";
            string emailQuery = "";
            string bestScoreQuery = "";
            string IDquery = "";
            string output = "";
            string IDoutput = "";
            int ID;

            query = "SELECT user_name, password FROM Users WHERE user_name = '" + userName + "'";
            emailQuery = "SELECT user_email FROM Users WHERE user_name = '" + userName + "'";
            bestScoreQuery = "SELECT user_best_score FROM Users WHERE user_name = '" + userName + "'";
            IDquery = "SELECT user_id FROM Users WHERE user_name = '" + userName + "'";
            command = new SqlCommand(query, sqlConnection);
            emailCommand = new SqlCommand(emailQuery, sqlConnection);
            bestScoreCommand = new SqlCommand(bestScoreQuery, sqlConnection);
            IDcommand = new SqlCommand(IDquery, sqlConnection);


            //Reading from database 
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                output = output + reader.GetValue(0) + "-" + reader.GetValue(1) + " \n"; //the \n makes sure that the output is well formated


            }
            //formating the output of records from database
            string[] pairs = output.Split(' ');

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            //spliting the records from database 
            foreach (string pair in pairs)
            {
                string[] keyValue = pair.Split('-');
                if (keyValue.Length >= 2)
                {
                    keyValuePairs.Add(keyValue[0].Trim(), keyValue[1].Trim());

                }
            }
            //checking if user input is one of the valid records in database
            if (keyValuePairs.ContainsKey(userName) && keyValuePairs.ContainsValue(pass))
            {
                reader.Close();
                email = emailCommand.ExecuteScalar()?.ToString();
                bestScore = Convert.ToInt32(bestScoreCommand.ExecuteScalar());

                reader = IDcommand.ExecuteReader();
                reader.Read();
                IDoutput = IDoutput + reader.GetValue(0);
                reader.Close();

                int.TryParse(IDoutput, out ID);

                user.SetUserName(userName);
                user.SetPassword(pass);
                user.SetEmail(email);
                user.SetBestScore(bestScore);

                MainpageForm mainPage = new MainpageForm(user);
                mainPage.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong user name or password");
                reader.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Validator();
        }

        //Kill app on close
        static void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
