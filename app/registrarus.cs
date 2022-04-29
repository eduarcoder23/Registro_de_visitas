using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class registrarus : Form
    {
        public registrarus()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();

            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            login frm = new login();
            frm.Show();

            this.Hide();
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if(textBox3.Text.Trim() == "")
            {
                epError.SetError(textBox3, "Introduzca el nombre...");
                textBox3.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                epError.SetError(textBox2, "Introduzca el apellido...");
                textBox2.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                epError.SetError(textBox1, "Introduzca la fecha de nacimiento...");
                textBox1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "")
            {
                epError.SetError(textBox4, "Introduzca la contraseña...");
                textBox4.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
