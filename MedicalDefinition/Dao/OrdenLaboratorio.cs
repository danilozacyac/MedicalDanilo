using System;
using System.Linq;

namespace MedicalDefinition.Dao
{
    public class OrdenLaboratorio
    {
        private int idOrden;
        private int idLaboratorio;
        private int idPaciente;
        private int idConsulta;
        private DateTime fechaEnvio;
        private DateTime fechaEntrega;
        private bool entregaATiempo;
        private double importeTotal;
        private double aCuenta;
        private String observaciones;

        public OrdenLaboratorio(int idOrden, int idLaboratorio, int idPaciente, int idConsulta, DateTime fechaEnvio, DateTime fechaEntrega, bool entregaATiempo, double importeTotal, double aCuenta, String observaciones)
        {
            this.idOrden = idOrden;
            this.idLaboratorio = idLaboratorio;
            this.idPaciente = idPaciente;
            this.idConsulta = idConsulta;
            this.fechaEnvio = fechaEnvio;
            this.fechaEntrega = fechaEntrega;
            this.entregaATiempo = entregaATiempo;
            this.importeTotal = importeTotal;
            this.aCuenta = aCuenta;
            this.observaciones = observaciones;
        }

        public OrdenLaboratorio()
        {
        }

        public int IdOrden
        {
            get
            {
                return this.idOrden;
            }
            set
            {
                this.idOrden = value;
            }
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

        public int IdPaciente
        {
            get
            {
                return this.idPaciente;
            }
            set
            {
                this.idPaciente = value;
            }
        }

        public int IdConsulta
        {
            get
            {
                return this.idConsulta;
            }
            set
            {
                this.idConsulta = value;
            }
        }

        public DateTime FechaEnvio
        {
            get
            {
                return this.fechaEnvio;
            }
            set
            {
                this.fechaEnvio = value;
            }
        }

        public DateTime FechaEntrega
        {
            get
            {
                return this.fechaEntrega;
            }
            set
            {
                this.fechaEntrega = value;
            }
        }

        public bool EntregaATiempo
        {
            get
            {
                return this.entregaATiempo;
            }
            set
            {
                this.entregaATiempo = value;
            }
        }

        public double ImporteTotal
        {
            get
            {
                return this.importeTotal;
            }
            set
            {
                this.importeTotal = value;
            }
        }

        public double ACuenta
        {
            get
            {
                return this.aCuenta;
            }
            set
            {
                this.aCuenta = value;
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
    }
}
