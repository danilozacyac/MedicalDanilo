using System;
using System.Linq;

namespace MedicalDefinition.Dao
{
    public class EstadosMunicipios
    {
        private int idEstado;
        private int idMunicipio;
        private String nombreEdoMun;

        public EstadosMunicipios(int idEstado, String nombreEdoMun)
        {
            this.idEstado = idEstado;
            this.nombreEdoMun = nombreEdoMun;
        }

        public EstadosMunicipios(int idEstado, int idMunicipio, String nombreEdoMun)
        {
            this.idEstado = idEstado;
            this.idMunicipio = idMunicipio;
            this.nombreEdoMun = nombreEdoMun;
        }
        public int IdEstado
        {
            get
            {
                return this.idEstado;
            }
            set
            {
                this.idEstado = value;
            }
        }

        public int IdMunicipio
        {
            get
            {
                return this.idMunicipio;
            }
            set
            {
                this.idMunicipio = value;
            }
        }

        public string NombreEdoMun
        {
            get
            {
                return this.nombreEdoMun;
            }
            set
            {
                this.nombreEdoMun = value;
            }
        }
    }
}
