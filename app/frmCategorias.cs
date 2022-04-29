using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app;
using CapaEntidad;
using Capa_logica_de_negocio;




namespace app
{
    public partial class fmreg : Form
    {
        private string idusuario;
        private bool Editarse = false;

        E_USUARIO objEntidad = new E_USUARIO();
        N_USUARIO objNegocio = new N_USUARIO();
        public fmreg()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }
        public void accionesTabla()
        {
            tablaCategoria.Columns[0].Visible = false;

            tablaCategoria.ClearSelection();
            
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_USUARIO objNegocio = new N_USUARIO();
            tablaCategoria.DataSource = objNegocio.ListarUsuario(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }


        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tablaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro frm = new registro();
            frm.ShowDialog();

            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            registro frm = new registro();
            frm.Show();

            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();

            this.Hide();

        }

        private void topFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
