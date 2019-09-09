using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leo.UI
{
	public partial class Form1 : Form
	{

        bool userOk = false;

		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!userOk)
            {
                Login _Login = new Login();
                _Login.ShowDialog();
            }
        }
    }
}
