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
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private Model.ReceitaData salgada;
        private Model.ReceitaData doce;
        private DateTime today = DateTime.Now;
        private string DiaSemana { get; set; }

        public Home()
        {
            this.InitializeComponent();
            DiaSemana = "Dicas para " + ((new CultureInfo("pt-BR")).DateTimeFormat).GetDayName(today.DayOfWeek) + "!";
            doce = salgada = (Application.Current as App).Receitas[0];
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Debug.WriteLine(b.ActualWidth);
            Debug.WriteLine(g.ActualWidth);
        }
    }
}
