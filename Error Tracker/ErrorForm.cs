using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Tracker
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            methodOutputLabel.Text = Error.Method;
            classOutputLabel.Text = Error.Class;
            timestampOutputLabel.Text = Error.Timestamp.ToString();
            messageOutputLabel.Text = Error.Message;

        }
    }
}
