using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_HR_System
{
    public partial class _login : Form
    {
        public _login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form mainFunction = new _mainFunction();
            mainFunction.Show();
            this.Visible = false;
        }
    }
}
