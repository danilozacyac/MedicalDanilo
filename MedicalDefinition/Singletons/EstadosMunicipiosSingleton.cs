using System;
using System.Collections.Generic;
using System.Linq;
using MedicalDefinition.Dao;
using MedicalDefinition.ViewModel;

namespace MedicalDefinition.Singletons
{
    public class EstadosMunicipiosSingleton
    {
        private static List<EstadosMunicipios> estados;

        private EstadosMunicipiosSingleton()
        {
        }

        public static List<EstadosMunicipios> Estados
        {
            get
            {
                if (estados == null)
                    estados = new EstadosMunicipiosViewModel().GetEstados();

                return estados;
            }
        }

        private static List<EstadosMunicipios> municipios;

        public static List<EstadosMunicipios> Municipios(int idEstado)
        {
            if (municipios == null)
                municipios = new EstadosMunicipiosViewModel().GetMunicipios();

            return (from n in municipios
                    where n.IdEstado == idEstado
                    select n).ToList();
        }
    }
}