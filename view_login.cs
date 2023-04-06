using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soma_valores
{
    public partial class view_login : Form
    {
        public view_login()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_nome.Text)==true)
            {
                MessageBox.Show("Preencha o campo!");
            }
            else
            {
                var a = new view_valor(lbl_nome.Text);
                a.Show();
                this.Hide();
                
            }
        }
    }
}
