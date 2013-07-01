using System;
using System.Linq;

namespace MedicalDefinition.Dao
{
    public class HistorialMedicoBucal
    {
        private int id;
        private int valorDecimal;
        private String padecimiento;

        public HistorialMedicoBucal() { }

        public HistorialMedicoBucal(int id, int valorDecimal, String padecimiento)
        {
            this.id = id;
            this.valorDecimal = valorDecimal;
            this.padecimiento = padecimiento;
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

        public int ValorDecimal
        {
            get
            {
                return this.valorDecimal;
            }
            set
            {
                this.valorDecimal = value;
            }
        }

        public string Padecimiento
        {
            get
            {
                return this.padecimiento;
            }
            set
            {
                this.padecimiento = value;
            }
        }
    }
}
