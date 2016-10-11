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
using TCC_Aline.UserControls;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Receita : Page, INotifyPropertyChanged
    {
        Model.ReceitaData recpt;

        ObservableCollection<Info> messages = new ObservableCollection<Info>();

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
            lateralMenu.RegisterPropertyChangedCallback(VisibilityProperty, new DependencyPropertyChangedCallback(ChangeVisibility));
        }

        private void ChangeVisibility(DependencyObject obj, DependencyProperty pr)
        {
            var lm = obj as LateralMenu;
            if (lm.Visibility == Visibility.Collapsed && !messages.Any(x => x.Index == 0))
                messages.Add(new Info() { Index = 0, Message = "Clique com o botão direito para visualizar o menu lateral!" });
            else if (lm.Visibility == Visibility.Visible && messages.Any(x => x.Index == 0))
                messages.RemoveAt(0);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            recpt = (Model.ReceitaData)e.Parameter;
            if (lateralMenu.Visibility == Visibility.Collapsed && !messages.Any(x => x.Index == 0))
                messages.Add(new Info() { Index = 0, Message = "Clique com o botão direito para visualizar o menu lateral!" });
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            OpenWidth = this.ActualWidth;
            LateralMenuFrameWidth = OpenWidth - lateralMenu.PaneClosedWidth;
            ComentWidth = coments.ActualWidth - 20;
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            lateralMenu.IsOpen = !lateralMenu.IsOpen;
            lateralMenuFrame.Navigate(typeof(MainPage));
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var ingr = ((sender as TextBlock).DataContext as Model.IngredienteData);
            if (ingr.SubstitutosCollection != null && ingr.SubstitutosCollection.Any())
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
                Model.IngredienteData ob = (sender as ListView).DataContext as Model.IngredienteData;
                ob.Aux = ob.Texto;
                ob.Texto = e.AddedItems.Single() as string;
                ob.SubstitutosCollection[ob.SubstitutosCollection.IndexOf(ob.Texto)] = ob.Aux;
            }
        }

        private void paginaReceita_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            lateralMenu.Visibility = lateralMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Info d = (sender as Button).DataContext as Info;
            messages.Remove(d);
        }
    }

    public class Info
    {
        public string Message { get; set; }
        public int Index { get; set; }
    }
}
