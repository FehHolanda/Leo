using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leo.DTO;
using Leo.BLL;

namespace Leo.UI
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Usuario _Usuario = new Usuario();
            _Usuario.nome = "Felipe";
            _Usuario.email = "ADM";
            _Usuario.senha = "1001592062";


            UserBLL _UserBLL = new UserBLL(); 
            _UserBLL.Incluir(_Usuario);
        }
	}
}
