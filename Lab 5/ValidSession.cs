using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class ValidSession : Form
    {
       
        int _sessionID;
        string _sessionName;
        string _sessionPassword;
        public ValidSession()
        {
            InitializeComponent();

           
        }

        private void ValidSession_Load(object sender, EventArgs e)
        {
            if (Session.ID != 0)
            {
                _sessionPassword = Session.User.Password;
                _sessionID = Session.ID;
                _sessionName = Session.User.UserName;
            }
            label1.Text = $@"ID : {_sessionID}{Environment.NewLine} UserName :{_sessionName}{Environment.NewLine} Password: {_sessionPassword}";
        }
    }
}
