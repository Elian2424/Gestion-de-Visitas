using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class evisitas
    {
        private int idregistro;
        private String nombre;
        private String apellido;
        private String carrera;
        private String correo;
        private String edificio;
        private String area;
        private DateTime hora_e;
        private DateTime hora_s;
        private String motivo;
        private int idedificio;
        private int idarea;
        private String n_edificio;
        private String contraseña;
        private string consulta;
        private int idusuario;
        private DateTime fechan;
        private String usuario;
        private String tipo;

        public int Idregistro { get => idregistro; set => idregistro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Edificio { get => edificio; set => edificio = value; }
        public string Area { get => area; set => area = value; }
        public DateTime Hora_e { get => hora_e; set => hora_e = value; }
        public DateTime Hora_s { get => hora_s; set => hora_s = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public int Idedificio { get => idedificio; set => idedificio = value; }
        public int Idarea { get => idarea; set => idarea = value; }
        public string N_edificio { get => n_edificio; set => n_edificio = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Consulta { get => consulta; set => consulta = value; }
        public DateTime Fechan { get => fechan; set => fechan = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
