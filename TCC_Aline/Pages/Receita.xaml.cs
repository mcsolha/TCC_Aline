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
        Model.Receita recpt;

        public GridLength ToGridLenght(double d)
        {
            return new GridLength(d);
        }

        public double ComentWidth
        {
            get { return (double)GetValue(ComentWidthProperty); }
            set { SetValue(ComentWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComentWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComentWidthProperty =
            DependencyProperty.Register("ComentWidth", typeof(double), typeof(Receita), new PropertyMetadata(150));

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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            recpt = (Model.Receita)e.Parameter;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            OpenWidth = this.ActualWidth;
            LateralMenuFrameWidth = OpenWidth - lateralMenu.PaneClosedWidth;
            ComentWidth = coments.ActualWidth - 20;
            Debug.WriteLine(this.ActualWidth);
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            lateralMenu.IsOpen = !lateralMenu.IsOpen;
            lateralMenuFrame.Navigate(typeof(MainPage));
        }

        private void TextBlock_Holding(object sender, HoldingRoutedEventArgs e)
        {
            FrameworkElement senderElement = sender as FrameworkElement;
            // If you need the clicked element:
            var whichOne = (sender as TextBlock).Text;
            Debug.WriteLine(whichOne);
            FlyoutBase flyoutBase = FlyoutBase.GetAttachedFlyout(senderElement);
            flyoutBase.ShowAt(senderElement);
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var ingr = ((sender as TextBlock).DataContext as Model.Ingrediente);
            if (ingr.Substitutos != null && ingr.Substitutos.Any())
            {
                FrameworkElement senderElement = sender as FrameworkElement;
                // If you need the clicked element:
                var whichOne = (sender as TextBlock).Text;
                Debug.WriteLine(whichOne);
                FlyoutBase flyoutBase = FlyoutBase.GetAttachedFlyout(senderElement);
                flyoutBase.ShowAt(senderElement);
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Any())
            {
                Model.Ingrediente ob = (sender as ListView).DataContext as Model.Ingrediente;
                ob.Aux = ob.Texto;
                ob.Texto = e.AddedItems.Single() as string;
                ob.Substitutos[ob.Substitutos.IndexOf(ob.Texto)] = ob.Aux;
            }
        }
    }
}
