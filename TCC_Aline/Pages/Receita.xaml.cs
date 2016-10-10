using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Helpers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.UI.Animations;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Receita : Page, INotifyPropertyChanged
    {
        public GridLength ToGridLenght(double d)
        {
            return new GridLength(d);
        }

        private double openWidth;

        public double OpenWidth
        {
            get { return openWidth; }
            set { openWidth = value; OnPropertyChanged("OpenWidth"); }
        }

        private double lateralMenuFrameWidth;

        public double LateralMenuFrameWidth
        {
            get { return lateralMenuFrameWidth; }
            set { lateralMenuFrameWidth = value; OnPropertyChanged("LateralMenuFrameWidth"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public Receita()
        {
            this.InitializeComponent();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            OpenWidth = this.ActualWidth;
            LateralMenuFrameWidth = OpenWidth - lateralMenu.PaneClosedWidth;
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            lateralMenu.IsOpen = !lateralMenu.IsOpen;
            lateralMenuFrame.Navigate(typeof(MainPage));
        }
    }
}
