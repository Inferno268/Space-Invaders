using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdkWhat
{
    public class Users
    {
        public string userName;
        public string password;
        public string email;
        public int bestScore;


        public Users() { 
        
                }
        // constructor
        public Users(string userName, string password, string email, int bestScore)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.bestScore = bestScore;
        }
        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetEmail()
        {
            return email;
        }

        public int GetBestScore()
        {
            return bestScore;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetBestScore(int bestScore)
        {
            this.bestScore = bestScore;
        }

    }
}
