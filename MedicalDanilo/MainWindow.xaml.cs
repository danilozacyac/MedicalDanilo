using System;
using System.Linq;
using System.Windows;

namespace MedicalDanilo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            ScheduleVision vision = new ScheduleVision();
            vision.Show();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            //FrmCatalogoMedicamentos catalogo = new FrmCatalogoMedicamentos();
            //catalogo.Show();
        }
    }
}
