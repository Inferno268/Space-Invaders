using Database_project;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IdkWhat
{
    public partial class ScoreboardForm : Form
    {
        Users user = new Users();

        static string conn = ConfigurationManager.ConnectionStrings["justDatabase"].ConnectionString;
        SqlConnection sqlConnection = DatabaseSingleton.GetInstance();

        public ScoreboardForm()
        {
            
        }
        public ScoreboardForm(Users user)
        {
            this.user = user;
            InitializeComponent();
            LoadUsers();
        }
        /// <summary>
        /// Select 10 best players
        /// </summary>
        public void LoadUsers()
        {
            string query = "SELECT TOP 10 u.user_name, s.score, s.position " +
                       "FROM Users u " +
                       "JOIN Scoreboard s ON u.user_id = s.user_id " +
                       "ORDER BY s.position ASC";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                int score = reader.GetInt32(1);
                int position = reader.GetInt32(2);

                string item = name + " - " +"Score: " +score + " - " + "Position: " + position;
                scoreboardList.Items.Add(item);
            }

        }

        /// <summary>
        /// back to mainPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            MainpageForm mainpage = new MainpageForm(user);
            mainpage.ShowDialog();
            Visible = false;
        }

        private void scroboardList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
