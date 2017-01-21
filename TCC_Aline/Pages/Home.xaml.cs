using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TCC_Aline.Model;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TCC_Aline.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private Model.ReceitaData salgada = Instances.Lasanha;
        private Model.ReceitaData doce = Instances.CocadaBranca;
        private DateTime today = DateTime.Now;
        private string DiaSemana { get; set; }

        public Home()
        {
            this.InitializeComponent();
            DiaSemana = "Dicas para " + ((new CultureInfo("pt-BR")).DateTimeFormat).GetDayName(today.DayOfWeek) + "!";
            var app = Application.Current as App;
            //doce = app.Receitas.ToList().Where(x => x.Categoria == "Doces").ToList().GetRandom();
            //salgada = app.Receitas.ToList().Where(x => x.Categoria == "Salgados").ToList().GetRandom();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void doce_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Receita), doce);
        }

        private void salgado_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Receita), salgada);
        }
    }
}
