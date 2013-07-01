using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MedicalDefinition.Singletons;
using Telerik.Windows.Controls;

namespace MedicalDanilo.Formularios
{
    /// <summary>
    /// Interaction logic for FrmConsultorio.xaml
    /// </summary>
    public partial class FrmConsultorio
    {
        public FrmConsultorio()
        {
            InitializeComponent();
        }

        private void RadWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RcbxEstado.DataContext = EstadosMunicipiosSingleton.Estados;
        }

        private void RcbxEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RcbxMunicipio.DataContext = EstadosMunicipiosSingleton.Municipios(Convert.ToInt16(RcbxEstado.SelectedValue));
        }
    }
}
