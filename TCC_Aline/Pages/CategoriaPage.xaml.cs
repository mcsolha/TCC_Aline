using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            }else if(e.Parameter is Salgados)
            {
                Salgados s = (Salgados)e.Parameter;
                PageName = EnumHelper.GetEnumDescription(s);
                switch (s)
                {
                    case Salgados.Tortas:
                        break;
                    case Salgados.Massas:
                        break;
                    case Salgados.Saladas:
                        break;
                    case Salgados.Carnes:
                        Itens.ItemsSource = Tipo.GetBySubcategory(typeof(Carnes));
                        break;
                    case Salgados.Molhos:
                        break;
                    case Salgados.Paes:
                        break;
                    case Salgados.Entradas:
                        break;
                    case Salgados.SopasCaldos:
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
                        Frame.Navigate(typeof(Receitas), Doces.Bolos);
                        break;
                    case Doces.Tortas:
                        Frame.Navigate(typeof(Receitas), Doces.Tortas);
                        break;
                    case Doces.Mousses:
                        Frame.Navigate(typeof(Receitas), Doces.Mousses);
                        break;
                    case Doces.Sorvetes:
                        Frame.Navigate(typeof(Receitas), Doces.Sorvetes);
                        break;
                    case Doces.Brigadeiros:
                        Frame.Navigate(typeof(Receitas), Doces.Brigadeiros);
                        break;
                    case Doces.Geleias:
                        Frame.Navigate(typeof(Receitas), Doces.Geleias);
                        break;
                    case Doces.Gelatinas:
                        Frame.Navigate(typeof(Receitas), Doces.Gelatinas);
                        break;
                    default:
                        break;
                }
            }
            else if (t.nome is Salgados)
            {
                switch ((Salgados)t.nome)
                {
                    case Salgados.Tortas:
                        Frame.Navigate(typeof(Receitas), Salgados.Tortas);
                        break;
                    case Salgados.Massas:
                        Frame.Navigate(typeof(Receitas), Salgados.Massas);
                        break;
                    case Salgados.Saladas:
                        Frame.Navigate(typeof(Receitas), Salgados.Saladas);
                        break;
                    case Salgados.Carnes:
                        Frame.Navigate(typeof(CategoriaPage), Salgados.Carnes);
                        break;
                    case Salgados.Molhos:
                        Frame.Navigate(typeof(Receitas), Salgados.Molhos);
                        break;
                    case Salgados.Paes:
                        Frame.Navigate(typeof(Receitas), Salgados.Paes);
                        break;
                    case Salgados.Entradas:
                        Frame.Navigate(typeof(Receitas), Salgados.Entradas);
                        break;
                    case Salgados.SopasCaldos:
                        Frame.Navigate(typeof(Receitas), Salgados.SopasCaldos);
                        break;
                    default:
                        break;
                }
            }else if(t.nome is Carnes)
            {
                Carnes c = (Carnes)t.nome;
                switch (c)
                {
                    case Carnes.Frangos:
                        Frame.Navigate(typeof(Receitas), Carnes.Frangos);
                        break;
                    case Carnes.Bovinos:
                        Frame.Navigate(typeof(Receitas), Carnes.Bovinos);
                        break;
                    case Carnes.Suinos:
                        Frame.Navigate(typeof(Receitas), Carnes.Suinos);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
