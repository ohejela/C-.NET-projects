using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1_interface_game
{
    public class Player
    {
        private string _password;
        private string _login;
        private string _first;
        private string _last;

        public string loginError;
        public string passwordError;
        public string firstError;
        public string lastError;
        public bool IsValid = false;
        public string First { get { return _first; } set 
            {
                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                         firstError = "Your first name cannot contain a digit value";
                    }

                    _first = value;
                    IsValid = true;
                }
            } }
        public string Last { get { return _last; } set {

                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        lastError = "Your last name cannot contain a digit value";
                    }

                    _last = value;
                    IsValid = true;
                }
            } }
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                foreach (char c in value)
                {
                    if (char.IsWhiteSpace(c))  
                    {
                        loginError = "Login name cannot contain white space!";
                    }
                }

                
                if (File.Exists("PlayerData.txt"))
                {
                    StreamReader infile = new StreamReader("PlayerData.txt");

                    while (!infile.EndOfStream)  
                    {
                        string line = infile.ReadLine();
                        if (line == value)
                        {
                            infile.Close();
                            loginError = "This login name already exists!";
                        }
                    }
                    infile.Close();
                }

               
                _login = value;
                IsValid = true;
            }
        }
        public string Password {
            get
            { return _password; } 
            set {

                if (value.Length < 5)
                {
                    passwordError = "Password must be at least 5 characters long!";
                }
                bool hasUpper = false;
                bool hasLower = false;
                bool hasNumber = false;

               
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i])) hasUpper = true;
                    if (char.IsLower(value[i])) hasLower = true;
                    if (char.IsDigit(value[i])) hasNumber = true;
                }

                
                if (!hasUpper)
                {
                    passwordError = "Password must contain at least one uppercase letter!";
                }
                if (!hasLower)
                {
                    passwordError = "Password must contain at least one lowercase letter!";
                }
                if (!hasNumber)
                {
                    passwordError = "Password must contain at least one number!";
                }

                
                _password = value;
                IsValid = true;
            }
        }
        public int Level = 1;
        public int Wins { get; set; }
    }
}
