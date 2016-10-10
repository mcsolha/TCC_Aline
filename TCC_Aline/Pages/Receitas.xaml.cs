using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Receitas : Page, INotifyPropertyChanged
    {
        private string pageName;

        public string PageName
        {
            get { return pageName; }
            set { pageName = value; OnPropertyChanged("PageName"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public Receitas()
        {
            this.InitializeComponent();
            itens.ItemsSource = new ObservableCollection<Model.Receita>()
            {
                new Model.Receita() {Nome = "Bolo de Fubá", Preparo = new TimeSpan(0,40,5), Cozimento = new TimeSpan(0,2,5), Favorita = true, Pessoas = 5 },
                new Model.Receita() {Nome = "Bolo de Banana", Preparo = new TimeSpan(1,5,5), Cozimento = new TimeSpan(0,4,5), Favorita = false, Pessoas = 2 },
                new Model.Receita() {Nome = "Mousse de Chocolate", Preparo = new TimeSpan(0,20,5), Cozimento = new TimeSpan(1,15,5), Favorita = true, Pessoas = 3 },
                new Model.Receita() {Nome = "Teta de Nega", Preparo = new TimeSpan(0,15,5), Cozimento = new TimeSpan(0,35,5), Favorita = false, Pessoas = 7 }
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            PageName = e.Parameter is string ? e.Parameter as string : null;
        }
    }
}
