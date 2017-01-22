using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Configuration;
using TCC_Aline.Data;
using TCC_Aline.Helpers;
using TCC_Aline.Pages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TCC_Aline
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private string nomePag;
        public string NomePag {
            get
            {
                return nomePag;
            }
            set
            {
                nomePag = value;
                OnPropertyChanged("NomePag");
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
            Current = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string t)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(t));
        }

        /* private void SuggestBoxIconClickable_Click(object sender, RoutedEventArgs e)
         {
             if ((bool)SuggestBoxIconClickable.IsChecked)
             {
                 AppName.Visibility = Logo.Visibility = Visibility.Collapsed;
             }
             else
             {
                 AppName.Visibility = Logo.Visibility = Visibility.Visible;
             }
         }*/

        /* private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
          {
              if (Window.Current.Bounds.Width > 640)
              {
                  SuggestBoxIconClickable.IsChecked = false;
                  Logo.Visibility = AppName.Visibility = Visibility.Visible;
              }
          }*/

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateSplit();
            //Menu.ItemsSource = Paginas;
            FramePrincipal.Navigate(typeof(Home));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = !menuPrincipal.IsPaneOpen;
        }

        private void FramePrincipal_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void receitasDocesBotao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;
            NomePag = "Receitas Doces";
            Logo.Visibility = Visibility.Collapsed;
            FramePrincipal.Navigate(typeof(CategoriaPage), Model.Categorias.Doces);
        }

        private void receitasDocesBotao_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            receitasDocesBotao.Background = (SolidColorBrush)Resources["AzulDestaque"];
            Debug.WriteLine("pressed");
        }

        private void receitasDocesBotao_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            receitasDocesBotao.Background = (SolidColorBrush)Resources["AzulClaro"];
            Debug.WriteLine("released");
        }

        private void HamburgerButton_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "VisualStateNormal", false);
        }

        private void HamburgerButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "VisualStateNormal", false);
        }

        private void dicasMediaPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;
            FramePrincipal.Navigate(typeof(DicasMedida));
        }

        private void receitasSalgadoBotao_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            receitasSalgadoBotao.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void receitasSalgadoBotao_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            receitasSalgadoBotao.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void favoritosBotao_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            favoritosBotao.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void favoritosBotao_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            favoritosBotao.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void dicasMediaPanel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            dicasMediaPanel.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void dicasMediaPanel_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            dicasMediaPanel.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void glossarioBotao_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            glossarioBotao.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void glossarioBotao_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            glossarioBotao.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void tecnicasBotao_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            tecnicasBotao.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void tecnicasBotao_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            tecnicasBotao.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void receitasSalgadoBotao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;

            NomePag = "Receitas Salgadas";
            Logo.Visibility = Visibility.Collapsed;
            FramePrincipal.Navigate(typeof(CategoriaPage), Model.Categorias.Salgados);
        }

        private void favoritosBotao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;
            NomePag = "Favoritos";
            Logo.Visibility = Visibility.Collapsed;
            FramePrincipal.Navigate(typeof(Receitas), PageName.Favoritos);
        }

        private void glossarioBotao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;
            NomePag = "Glossário";
            Logo.Visibility = Visibility.Collapsed;
            FramePrincipal.Navigate(typeof(Gloss));
        }

        private void tecnicasBotao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;
            NomePag = "Técnicas";
            Logo.Visibility = Visibility.Collapsed;
            FramePrincipal.Navigate(typeof(MenuTecnicas));
        }

        private void Logo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FramePrincipal.Navigate(typeof(Home));
        }

        private void timerBotao_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            timerBotao.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void timerBotao_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            timerBotao.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void timerBotao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;
            DialogHelper.ShowNotImplemented();
        }

        private void sobreBotao_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            sobreBotao.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void sobreBotao_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            sobreBotao.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void sobreBotao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            menuPrincipal.IsPaneOpen = false;
            FramePrincipal.Navigate(typeof(Informacoes));
        }

        private void searchIcon_Click(object sender, RoutedEventArgs e)
        {
            if (searchIcon.IsChecked == true)
                ((Storyboard)Resources["visible"]).Begin();
            else
                ((Storyboard)Resources["collapsed"]).Begin();
        }

        private void suggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Only get results when it was a user typing, 
            // otherwise assume the value got filled in by TextMemberPath 
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                sender.ItemsSource = Instances.Informacoes.Where(x => x.Nome.IndexOf(sender.Text, StringComparison.CurrentCultureIgnoreCase) >= 0).OrderBy(x => x.Nome).ToList().ToObservableCollection();
            }
        }
    }
}
