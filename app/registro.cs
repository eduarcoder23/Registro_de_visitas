using Capa_logica_de_negocio;
using CapaEntidad;
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


namespace app
{

    public partial class registro : Form
    {
        private string idusuario;
        private bool Editarse = false;

        E_USUARIO objEntidad = new E_USUARIO();
        N_USUARIO objNegocio = new N_USUARIO();
        public registro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEntidad.Nombre = textNombre.Text.ToUpper();
                    objEntidad.Apellido = textApellido.Text.ToUpper();
                    objEntidad.Carrera = textCarrera.Text.ToUpper();
                    objEntidad.Correo = textCorreo.Text.ToUpper();
                    objEntidad.Edificio = comboBoxEdificio.Text.ToUpper();
                    objEntidad.Horase = textHorase.Text.ToUpper();
                    objEntidad.Horass = textHorass.Text.ToUpper();
                    objEntidad.Motivo = textMotivo.Text.ToUpper();
                    objEntidad.Aula = comboBoxAula.Text.ToUpper();

                    objNegocio.InsertandoUsuario(objEntidad);

                    MessageBox.Show("Registro guardado correctamente");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if (Editarse == true)
            {
                try
                {
                    objEntidad.Idusuario = Convert.ToInt32(idusuario);
                    objEntidad.Nombre = textNombre.Text.ToUpper();
                    objEntidad.Apellido = textApellido.Text.ToUpper();
                    objEntidad.Carrera = textCarrera.Text.ToUpper();
                    objEntidad.Correo = textCorreo.Text.ToUpper();
                    objEntidad.Edificio = comboBoxEdificio.Text.ToUpper();
                    objEntidad.Horase = textHorase.Text.ToUpper();
                    objEntidad.Horass = textHorass.Text.ToUpper();
                    objEntidad.Motivo = textMotivo.Text.ToUpper();
                    objEntidad.Aula = comboBoxAula.Text.ToUpper();

                    objNegocio.InsertandoUsuario(objEntidad);

                    MessageBox.Show("Registro editado correctamente");
                    Editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rEGDataSet.USUARIOS' table. You can move, or remove it, as needed.
            this.uSUARIOSTableAdapter.Fill(this.rEGDataSet.USUARIOS);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaCategoria.SelectedRows.Count > 0)
            {
                Editarse = true;
                idusuario = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                textApellido.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                textCarrera.Text = tablaCategoria.CurrentRow.Cells[3].Value.ToString();
                textCorreo.Text = tablaCategoria.CurrentRow.Cells[4].Value.ToString();
                comboBoxEdificio.Text = tablaCategoria.CurrentRow.Cells[5].Value.ToString();
                textHorase.Text = tablaCategoria.CurrentRow.Cells[6].Value.ToString();
                textHorass.Text = tablaCategoria.CurrentRow.Cells[7].Value.ToString();
                textMotivo.Text = tablaCategoria.CurrentRow.Cells[8].Value.ToString();
                comboBoxAula.Text = tablaCategoria.CurrentRow.Cells[9].Value.ToString();


            }
            else
            {
                MessageBox.Show("Por favor, seleccione la fila que desea editar");
            }
        }

        private void limpiarCaja()
        {
            Editarse = false;
            textNombre.Text = "";
            textApellido.Text = "";
            textCarrera.Text = "";
            textCorreo.Text = "";
            comboBoxEdificio.Text = "";
            textHorase.Text = "";
            textHorass.Text = "";
            textMotivo.Text = "";
            comboBoxAula.Text = "";
            textNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            fmreg frm = new fmreg();
            frm.Show();

            this.Hide();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            fmreg frm = new fmreg();
            frm.Show();

            this.Hide();
        }
    }
    }



    

