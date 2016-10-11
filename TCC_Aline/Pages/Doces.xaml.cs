using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Model;
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
    public sealed partial class Doces : Page
    {
        public Doces()
        {
            this.InitializeComponent();
            Itens.ItemsSource = Tipo.GetByCategory(Categorias.Doces);
        }

        private void image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var t = ((sender as FrameworkElement).DataContext as Tipo);
            if (t.nome is Model.Doces)
            {
                switch ((Model.Doces)t.nome)
                {
                    case Model.Doces.Bolos:
                        Frame.Navigate(typeof(Receitas), Model.Doces.Bolos);
                        break;
                    case Model.Doces.Tortas:
                        Frame.Navigate(typeof(Receitas), Model.Doces.Tortas);
                        break;
                    case Model.Doces.Mousses:
                        Frame.Navigate(typeof(Receitas), Model.Doces.Mousses);
                        break;
                    case Model.Doces.Sorvetes:
                        Frame.Navigate(typeof(Receitas), Model.Doces.Sorvetes);
                        break;
                    case Model.Doces.Brigadeiros:
                        Frame.Navigate(typeof(Receitas), Model.Doces.Brigadeiros);
                        break;
                    case Model.Doces.Geleias:
                        Frame.Navigate(typeof(Receitas), Model.Doces.Geleias);
                        break;
                    case Model.Doces.Gelatinas:
                        Frame.Navigate(typeof(Receitas), Model.Doces.Gelatinas);
                        break;
                    default:
                        break;
                }
            }
            else if (t.nome is Model.Salgados)
            {
                switch ((Model.Salgados)t.nome)
                {
                    case Model.Salgados.Tortas:
                        break;
                    case Model.Salgados.Massas:
                        break;
                    case Model.Salgados.Saladas:
                        break;
                    case Model.Salgados.Carnes:
                        break;
                    case Model.Salgados.Molhos:
                        break;
                    case Model.Salgados.Paes:
                        break;
                    case Model.Salgados.Entradas:
                        break;
                    case Model.Salgados.SopasCaldos:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
