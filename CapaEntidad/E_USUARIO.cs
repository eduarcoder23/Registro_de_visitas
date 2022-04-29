using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class E_USUARIO
    {
        private int _idusuario;
        private string _Nombre;
        private string _Apellido;
        private string _Carrera;
        private string _Correo;
        private string _Edificio;
        private string _Horase;
        private string _Horass;
        private string _Motivo;
        private string _Aula;

        public int Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Edificio { get => _Edificio; set => _Edificio = value; }
        public string Horase { get => _Horase; set => _Horase = value; }
        public string Horass { get => _Horass; set => _Horass = value; }
        public string Motivo { get => _Motivo; set => _Motivo = value; }
        public string Aula { get => _Aula; set => _Aula = value; }
    }
}