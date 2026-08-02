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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("This is a  test Message ");
            }
            catch (Exception ex)
            {
                Error.Method = "throwErrorButton_Click()";
                Error.Message = ex.Message;
                Error.Timestamp = DateTime.Now;
                Error.Class = "Form1";

                openErrorForm();
            }
        }
       private void openErrorForm()
        {
            ErrorForm tempForm = new ErrorForm();
            tempForm.ShowDialog();
        }
    }
}
