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
    public partial class view_valor : Form
    {
        public view_valor(string Nome)
        {
            InitializeComponent();
            lbl_nome.Text = Nome;
        }

        static string somar(string na, string nb)
        {
            try
            {
                double r = Convert.ToDouble(na) + Convert.ToDouble(nb);
                return Convert.ToString(r);
            }catch(Exception e)
            {
                return "Não é permitido!";
            }
        }

        private void btn_somar_Click(object sender, EventArgs e) {
            lbl_resultado.Text =somar(lbl_a.Text, lbl_b.Text);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            var a = new view_login();
            a.Show();
            this.Hide();

        }
    }
}
