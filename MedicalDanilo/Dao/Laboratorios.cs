using System;
using System.Linq;

namespace MedicalDanilo.Dao
{
    public class Laboratorios
    {
        private int idLaboratorio;
        private int idConsultorio;
        private String nombre;
        private String direccion;
        private String telefono;
        private int estado;
        private int municipio;
        private String cp;
        private String mail;
        private String responsable;
        private String observaciones;
        private DateTime fechaAlta;

        public Laboratorios(int idLaboratorio, int idConsultorio, String nombre, String direccion, String telefono, int estado, int municipio, String cp, String mail, String responsable, String observaciones, DateTime fechaAlta)
        {
            this.idLaboratorio = idLaboratorio;
            this.idConsultorio = idConsultorio;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.estado = estado;
            this.municipio = municipio;
            this.cp = cp;
            this.mail = mail;
            this.responsable = responsable;
            this.observaciones = observaciones;
            this.fechaAlta = fechaAlta;
        }

        public Laboratorios()
        {
        }

        public int IdLaboratorio
        {
            get
            {
                return this.idLaboratorio;
            }
            set
            {
                this.idLaboratorio = value;
            }
        }

        public int IdConsultorio
        {
            get
            {
                return this.idConsultorio;
            }
            set
            {
                this.idConsultorio = value;
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

        public string Responsable
        {
            get
            {
                return this.responsable;
            }
            set
            {
                this.responsable = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return this.observaciones;
            }
            set
            {
                this.observaciones = value;
            }
        }

        public DateTime FechaAlta
        {
            get
            {
                return this.fechaAlta;
            }
            set
            {
                this.fechaAlta = value;
            }
        }
    }
}
