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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            registrarus frm = new registrarus();
            frm.Show();

            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            fmreg frm = new fmreg();
            frm.Show();

            this.Hide();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                epError.SetError(textBox1, "Introduzca su usuario existente...");
                textBox1.Focus();
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
                epError.SetError(textBox2, "Introduzca su contraseña existente...");
                textBox2.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
