using System;
using System.Linq;

namespace MedicalDefinition.Dao
{
    public class CatalogoMedicamentos
    {
        private int idMedicamento;
        private int idConsultorio;
        private String nombreMedicina;
        private String descripcion;
        private String contraindicaciones;
        private String dosisNinos;
        private String dosisAdultos;
        private int idTipoMedicamento;

        public CatalogoMedicamentos() { }

        public CatalogoMedicamentos(int idMedicamento, int idConsultorio, String nombreMedicina, String descripcion, String contraindicaciones, String dosisNinos, String dosisAdultos, int idTipoMedicamento)
        {
            this.idMedicamento = idMedicamento;
            this.idConsultorio = idConsultorio;
            this.nombreMedicina = nombreMedicina;
            this.descripcion = descripcion;
            this.contraindicaciones = contraindicaciones;
            this.dosisNinos = dosisNinos;
            this.dosisAdultos = dosisAdultos;
            this.idTipoMedicamento = idTipoMedicamento;
        }
        public int IdMedicamento
        {
            get
            {
                return this.idMedicamento;
            }
            set
            {
                this.idMedicamento = value;
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

        public string NombreMedicina
        {
            get
            {
                return this.nombreMedicina;
            }
            set
            {
                this.nombreMedicina = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public string Contraindicaciones
        {
            get
            {
                return this.contraindicaciones;
            }
            set
            {
                this.contraindicaciones = value;
            }
        }

        public string DosisNinos
        {
            get
            {
                return this.dosisNinos;
            }
            set
            {
                this.dosisNinos = value;
            }
        }

        public string DosisAdultos
        {
            get
            {
                return this.dosisAdultos;
            }
            set
            {
                this.dosisAdultos = value;
            }
        }

        public int IdTipoMedicamento
        {
            get
            {
                return this.idTipoMedicamento;
            }
            set
            {
                this.idTipoMedicamento = value;
            }
        }
    }
}
