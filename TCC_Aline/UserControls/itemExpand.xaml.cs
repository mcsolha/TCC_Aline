using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TCC_Aline.UserControls
{
    public sealed partial class itemExpand : UserControl
    {
        private static string VISUALSTATES_EXPANDED = "Expanded";
        private static string VISUALSTATES_COLLAPSED = "Collapsed";

        public string Texto
        {
            get { return (string)GetValue(TextoProperty); }
            set
            {
                SetValue(TextoProperty, value);
            }
        }

        public static readonly DependencyProperty IsExpandedProperty = DependencyProperty.Register(nameof(IsExpanded), typeof(bool), typeof(itemExpand), new PropertyMetadata(false, IsExpanded_OnChanged));
        public bool IsExpanded
        {
            get { return (bool)GetValue(IsExpandedProperty); }
            set { SetValue(IsExpandedProperty, value); }
        }

        private static void IsExpanded_OnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var item = (itemExpand)d;
            var oldValue = (bool)e.OldValue;
            var newValue = (bool)e.NewValue;

            if (oldValue == newValue)
                return;

            if (newValue)
                VisualStateManager.GoToState(item, VISUALSTATES_EXPANDED, true);
            else
                VisualStateManager.GoToState(item, VISUALSTATES_COLLAPSED, true);
        }

        // Using a DependencyProperty as the backing store for Porcoes.This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextoProperty =
            DependencyProperty.Register("Texto", typeof(string), typeof(itemExpand), new PropertyMetadata("undefined"));

        public string Nome
        {
            get { return (string)GetValue(NomeProperty); }
            set
            {
                SetValue(NomeProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Porcoes.This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NomeProperty =
            DependencyProperty.Register("Nome", typeof(string), typeof(itemExpand), new PropertyMetadata("undefined"));

        public BitmapImage Imagem
        {
            get { return (BitmapImage)GetValue(ImagemProperty); }
            set
            {
                SetValue(ImagemProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Porcoes.This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImagemProperty =
            DependencyProperty.Register("Imagem", typeof(BitmapImage), typeof(itemExpand), new PropertyMetadata(null));

        public itemExpand()
        {
            this.InitializeComponent();
            if (IsExpanded)
                VisualStateManager.GoToState(this, VISUALSTATES_EXPANDED, false);
            else
                VisualStateManager.GoToState(this, VISUALSTATES_COLLAPSED, false);
        }

        private void gridRowHeader_Tapped(object sender, TappedRoutedEventArgs e)
        {
            IsExpanded = !IsExpanded;
            Debug.WriteLine("TAPPED!");
        }
    }
}
