using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Data;
using TCC_Aline.Helpers;
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
    public sealed partial class CategoriaPage : Page
    {
        public string PageName { get; set; }

        public CategoriaPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(e.Parameter is Categorias)
            {
                Categorias c = (Categorias)e.Parameter;
                PageName = EnumHelper.GetEnumDescription(c);
                switch (c)
                {
                    case Categorias.Salgados:
                        Itens.ItemsSource = Tipo.GetByCategory(Categorias.Salgados);
                        break;
                    case Categorias.Doces:
                        Itens.ItemsSource = Tipo.GetByCategory(Categorias.Doces);
                        break;
                    default:
                        break;
                }
            }
        }

        private void image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var t = ((sender as FrameworkElement).DataContext as Tipo);
            if (t.nome is Doces)
            {
                switch ((Doces)t.nome)
                {
                    case Doces.Bolos:
                        DialogHelper.ShowNotImplemented();
                        break;
                    case Doces.Biscoitos:
                        DialogHelper.ShowNotImplemented(); break;
                    case Doces.Doces_com_frutas:
                        DialogHelper.ShowNotImplemented(); break;
                    case Doces.Doces_variados:
                        Frame.Navigate(typeof(Receitas), Doces.Doces_variados);
                        break;
                    case Doces.Gelados:
                        DialogHelper.ShowNotImplemented(); break;
                    case Doces.Pudins:
                        DialogHelper.ShowNotImplemented(); break;
                    case Doces.Rocamboles:
                        DialogHelper.ShowNotImplemented(); break;
                    case Doces.Roscas:
                        DialogHelper.ShowNotImplemented(); break;
                    default:
                        break;
                }
            }
            else if (t.nome is Salgados)
            {
                switch ((Salgados)t.nome)
                {
                    case Salgados.Tortas:
                        DialogHelper.ShowNotImplemented(); break;
                    case Salgados.Massas:
                        DialogHelper.ShowNotImplemented(); break;
                    case Salgados.Saladas:
                        DialogHelper.ShowNotImplemented(); break;
                    case Salgados.Carnes:
                        DialogHelper.ShowNotImplemented(); break;
                    case Salgados.Molhos:
                        DialogHelper.ShowNotImplemented(); break;
                    case Salgados.Paes:
                        DialogHelper.ShowNotImplemented(); break;
                    case Salgados.Aperitivos:
                        DialogHelper.ShowNotImplemented(); break;
                    case Salgados.Sopas:
                        DialogHelper.ShowNotImplemented(); break;
                    default:
                        break;
                }
            }
        }
    }
}
