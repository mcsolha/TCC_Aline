using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Data;
using TCC_Aline.Helpers;
using TCC_Aline.Model;
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
        private ObservableCollection<ReceitaData> ReceitasDados = new ObservableCollection<ReceitaData>();
        private Configuration.PageName? pageType = null;

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
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is Configuration.PageName)
            {
                pageType = (Configuration.PageName)e.Parameter;
                PageName = EnumHelper.GetEnumDescription((Configuration.PageName)e.Parameter);
                if (pageType == Configuration.PageName.Favoritos)
                {
                    //foreach (var item in application.Receitas.GetFavorites())
                    //{
                    //    ReceitasDados.Add(item);
                    //}
                }
            }else if(e.Parameter is Doces)
            {
                Doces doce = (Doces)e.Parameter;
                PageName = EnumHelper.GetEnumDescription((Doces)e.Parameter);
                foreach (var item in Instances.Receitas.Where(x=> x.Tipo == "Doces Variados").ToList())
                {
                    ReceitasDados.Add(item);
                }
            }
        }

        private void FavoriteButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(pageType != null && pageType == Configuration.PageName.Favoritos)
            {
                var ele = (sender as FrameworkElement).DataContext as Model.ReceitaData;
                if(!ele.Favorita)
                    ReceitasDados.Remove(ele);
            }
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ReceitaData rc = (sender as FrameworkElement).DataContext as ReceitaData;
            Frame.Navigate(typeof(Receita), rc);
        }
    }
}
