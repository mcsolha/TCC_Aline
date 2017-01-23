using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Helpers;
using TCC_Aline.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class MenuTecnicas : Page
    {
        private ObservableCollection<TecnicasData> TecnicasDados = new ObservableCollection<TecnicasData>();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            foreach (var item in TecnicasInstances.Tecnicas)
            {
                TecnicasDados.Add(item);
            }
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
           AppViewBackButtonVisibility.Visible;
        }

        public MenuTecnicas()
        {
            this.InitializeComponent();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TecnicasData tec = (sender as FrameworkElement).DataContext as TecnicasData;
            if (tec.Equals(TecnicasInstances.UntarForma))
            {
                Receita.lateralPage = "VideoTecnica";
                Frame.Navigate(typeof(VideoTecnica), tec);
            }                
            else
                DialogHelper.ShowNotImplemented();
        }
    }
}
