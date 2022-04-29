using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using Capa_Datos;

namespace Capa_logica_de_negocio
{
    public class N_USUARIO
    {
        D_USUARIO objDato = new D_USUARIO();
        public List<E_USUARIO> ListarUsuario(string buscar)
        {
            return objDato.ListarUsuarios(buscar);
        }
        public void InsertandoUsuario(E_USUARIO Categoria)
        {
            objDato.InsertarUsuario(Categoria);
        }
        public void EditandoCategoria(E_USUARIO Categoria)
        {
            objDato.EditarUsuario(Categoria);
        }
        public void EliminandoUsuario(E_USUARIO Categoria)
        {
            objDato.EliminarUsuario(Categoria);
        }
    }
}
