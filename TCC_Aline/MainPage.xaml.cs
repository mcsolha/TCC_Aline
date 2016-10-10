using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Configuration;
using TCC_Aline.Helpers;
using TCC_Aline.Pages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TCC_Aline
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SuggestBoxIconClickable_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)SuggestBoxIconClickable.IsChecked)
            {
                AppName.Visibility = Logo.Visibility = Visibility.Collapsed;
            }
            else
            {
                AppName.Visibility = Logo.Visibility = Visibility.Visible;
            }
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Window.Current.Bounds.Width > 640)
            {
                SuggestBoxIconClickable.IsChecked = false;
                Logo.Visibility = AppName.Visibility = Visibility.Visible;
            }
        }

        private void BotaoMenu_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender is Button) ? (sender as Button).Content as string : "";
            var p = EnumHelper.GetEnumFromDescription<PageName>(content);
            switch (p)
            {
                case PageName.Home:
                    var recpt = new Model.Receita()
                    {
                        Nome = "Batata Assada",
                        Preparo = new TimeSpan(0, 40, 5),
                        Cozimento = new TimeSpan(0, 2, 5),
                        Favorita = true,
                        Pessoas = 55,
                        Ingredientes = new ObservableCollection<Model.Ingrediente>(),
                        Modopreparo = "Primeiro bata tudo\nDepois se mata\nAgora voce estara no inferno\nCaia da ppk loca",
                        Comentarios = new ObservableCollection<string>()
                        {
                            "Para esta receita você deve ficar atento que pode usar itens alternativos.\nOs itens alternativos são sugeridos ao clicar nos ingredientes verdes!",
                            "Quer deixar o prato ainda mais gostoso? Adicione um pouco de queijo ralado antes de levar ao forno e deixe gratinar!!",
                            "Asdfjaisdjfi asdifjasijfiojaiod asdifjasdfj asuidfjauisdjf sdfdu sudfhusndfiu sdufjusidfuisd sdfusdj sudfhusidfsdui sduisuidfhsui isdjfisdjfn isdfsdui sdufhuisdhfuisdfnui isudfnisdn isudfhnusdifnsdui iusdsudfh isudfsuidfsdui sdifnsuifhsduihf usdfh uisdfhsdui sudf siufhsduih usduhf"
                        }
                    };
                    recpt.Ingredientes.Add(new Model.Ingrediente()
                    {
                        Index = recpt.Ingredientes.Count,
                        Texto = "5 batatas",
                        Substitutos = new ObservableCollection<string>() { "pereca", "xereca" }
                    });
                    recpt.Ingredientes.Add(new Model.Ingrediente()
                    {
                        Index = recpt.Ingredientes.Count,
                        Texto = "2 colheres de sopa de manteiga",
                        Substitutos = new ObservableCollection<string>() { "ppk", "xrka" }
                    });
                    recpt.Ingredientes.Add(new Model.Ingrediente()
                    {
                        Index = recpt.Ingredientes.Count,
                        Texto = "1 pitada de sal",
                        Substitutos = new ObservableCollection<string>() { "xeroso", "xerinho" }
                    });
                    recpt.Ingredientes.Add(new Model.Ingrediente()
                    {
                        Index = recpt.Ingredientes.Count,
                        Texto = "1 pitada de pimenta"
                    });
                    FramePrincipal.Navigate(typeof(Receita), recpt);
                    break;
                case PageName.Receitas:
                    break;
                case PageName.Doces:
                    FramePrincipal.Navigate(typeof(Doces));
                    break;
                case PageName.Salgados:
                    FramePrincipal.Navigate(typeof(Salgados));
                    break;
                case PageName.Favoritos:
                    FramePrincipal.Navigate(typeof(Receitas),"Favoritos");
                    break;
                case PageName.Glossario:
                    break;
                case PageName.DicasMedida:
                    break;
                case PageName.Tecnicas:
                    break;
                case PageName.Videos:
                    break;
                case PageName.Timer:
                    break;
                default:
                    break;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateSplit();
            Menu.ItemsSource = Paginas;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = !menuPrincipal.IsPaneOpen;
        }
    }
}
