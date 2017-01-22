using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TCC_Aline.UserControls
{
    public sealed partial class NumericUpDown : UserControl
    {
        public int ValorMinimo
        {
            get { return (int)GetValue(ValorMinimoProperty); }
            set
            {
                SetValue(ValorMinimoProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Porcoes.This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValorMinimoProperty =
            DependencyProperty.Register("ValorMinimo", typeof(int), typeof(NumericUpDown), new PropertyMetadata(0));

        public int Porcoes
        {
            get { return (int)GetValue(PorcoesProperty); }
            set
            {
                if(value > 0)
                    SetValue(PorcoesProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Porcoes.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PorcoesProperty =
            DependencyProperty.Register("Porcoes", typeof(int), typeof(NumericUpDown), new PropertyMetadata(0));

        public NumericUpDown()
        {
            this.InitializeComponent();
            Porcoes = 0;
        }

     
        private void add_Click(object sender, RoutedEventArgs e)
        {
            Porcoes*=2;
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            //Fixado para Cocada --- Melhor nao manter assim
            if (Porcoes/2 >= ValorMinimo)
                Porcoes /= 2;
        }

        private void TextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if (!Regex.IsMatch(sender.Text, "^\\d*\\.?\\d*$") && sender.Text != "")
            {
                int pos = sender.SelectionStart - 1;
                sender.Text = sender.Text.Remove(pos, 1);
                sender.SelectionStart = pos;
            }
        }

        private void add_Holding(object sender, HoldingRoutedEventArgs e)
        {
            Porcoes++;
        }

        private void remove_Holding(object sender, HoldingRoutedEventArgs e)
        {
            Porcoes--;
        }
    }
}
