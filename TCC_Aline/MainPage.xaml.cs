using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
                    FramePrincipal.Navigate(typeof(Receita));
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
                    FramePrincipal.Navigate(typeof(Receitas),PageName.Favoritos);
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
