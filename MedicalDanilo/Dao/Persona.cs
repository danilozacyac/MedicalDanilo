using System;
using System.Linq;

namespace MedicalDanilo.Dao
{
    public class Persona
    {
        private int id;
        private int edad;
        private int sexo;
        private string fNacimiento;
        private string nombre;
        private string paterno;
        private string materno;
        private string direccion;
        private int estado;
        private int municipio;
        private string cp;
        private string telefono;
        private string photoPath = @"C:\Users\Luis\Documents\12.jpg";
        
        public Persona(int id, int edad, int sexo, string fNacimiento, string nombre, string paterno, string materno, string direccion, int estado, int municipio, string cp, string telefono, string photoPath)
        {
            this.id = id;
            this.edad = edad;
            this.sexo = sexo;
            this.fNacimiento = fNacimiento;
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.direccion = direccion;
            this.estado = estado;
            this.municipio = municipio;
            this.cp = cp;
            this.telefono = telefono;
            this.photoPath = photoPath;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public int Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        public string FNacimiento
        {
            get
            {
                return this.fNacimiento;
            }
            set
            {
                this.fNacimiento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Paterno
        {
            get
            {
                return this.paterno;
            }
            set
            {
                this.paterno = value;
            }
        }

        public string Materno
        {
            get
            {
                return this.materno;
            }
            set
            {
                this.materno = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public int Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public int Municipio
        {
            get
            {
                return this.municipio;
            }
            set
            {
                this.municipio = value;
            }
        }

        public string Cp
        {
            get
            {
                return this.cp;
            }
            set
            {
                this.cp = value;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        public string PhotoPath
        {
            get
            {
                return this.photoPath;
            }
            set
            {
                this.photoPath = value;
            }
        }
    }
}
