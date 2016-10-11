using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Receitas : Page, INotifyPropertyChanged
    {
        private ObservableCollection<Model.ReceitaData> ReceitasDados = new ObservableCollection<Model.ReceitaData>();
        private Configuration.PageName pageType;

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
            if(e.Parameter is Configuration.PageName)
                pageType = (Configuration.PageName)e.Parameter;
            PageName = EnumHelper.GetEnumDescription((Configuration.PageName)e.Parameter);
            if (pageType == Configuration.PageName.Favoritos)
            {
                App application = (Application.Current as App);
                foreach (var item in GetFavorites(application.Receitas))
                {
                    ReceitasDados.Add(item);
                }
            }
        }

        private IEnumerable<Model.ReceitaData> GetFavorites(ObservableCollection<Model.ReceitaData> recpts)
        {
            foreach (var item in recpts)
            {
                if (item.Favorita)
                    yield return item;
            }
        }

        private void FavoriteButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(pageType == Configuration.PageName.Favoritos)
            {
                var ele = (sender as FrameworkElement).DataContext as Model.ReceitaData;
                if(!ele.Favorita)
                    ReceitasDados.Remove(ele);
            }
        }
    }
}
