using System;
using System.Linq;

namespace MedicalDanilo.Dao
{
    public class Pacientes : Persona
    {
        public String mail;
        public int idDoctor;
        public DateTime fechaRegistro;

        public Pacientes(int id, int edad, int sexo, string fNacimiento, string nombre, string paterno, string materno, string direccion, int estado, int municipio, string cp, string telefono, string photoPath, String mail, int idDoctor, DateTime fechaRegistro) 
            : base(id, edad, sexo, fNacimiento, nombre, paterno, materno, direccion, estado, municipio, cp, telefono, photoPath)
        {
            this.mail = mail;
            this.idDoctor = idDoctor;
            this.fechaRegistro = fechaRegistro;
        }
        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public int IdDoctor
        {
            get
            {
                return this.idDoctor;
            }
            set
            {
                this.idDoctor = value;
            }
        }

        public DateTime FechaRegistro
        {
            get
            {
                return this.fechaRegistro;
            }
            set
            {
                this.fechaRegistro = value;
            }
        }
    }
}
