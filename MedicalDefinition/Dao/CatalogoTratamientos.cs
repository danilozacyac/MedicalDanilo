using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDefinition.Dao
{
    public class CatalogoTratamientos
    {
        private bool isSelected;
        private int idTratamiento;
        private int idConsultorio;
        private String tratamiento;
        private int costo;
        private String descripcionTratamiento;

        public CatalogoTratamientos() { }

        public CatalogoTratamientos(bool isSelected, int idTratamiento, int idConsultorio, String tratamiento, int costo, String descripcionTratamiento)
        {
            this.isSelected = isSelected;
            this.idTratamiento = idTratamiento;
            this.idConsultorio = idConsultorio;
            this.tratamiento = tratamiento;
            this.costo = costo;
            this.descripcionTratamiento = descripcionTratamiento;
        }
        public bool IsSelected
        {
            get
            {
                return this.isSelected;
            }
            set
            {
                this.isSelected = value;
            }
        }

        public int IdTratamiento
        {
            get
            {
                return this.idTratamiento;
            }
            set
            {
                this.idTratamiento = value;
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

        public string Tratamiento
        {
            get
            {
                return this.tratamiento;
            }
            set
            {
                this.tratamiento = value;
            }
        }

        public int Costo
        {
            get
            {
                return this.costo;
            }
            set
            {
                this.costo = value;
            }
        }

        public string DescripcionTratamiento
        {
            get
            {
                return this.descripcionTratamiento;
            }
            set
            {
                this.descripcionTratamiento = value;
            }
        }
    }
}
