using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_Aline.Configuration;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TCC_Aline.Configuration
{
    public class CustomDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var viewModel = item as PageType;
            if (viewModel.SubItem)
                return ReceitasTemplate;
            else
                return OthersTemplate;
        }

        public DataTemplate ReceitasTemplate { get; set; }
        public DataTemplate OthersTemplate { get; set; }
    }

    public class PageType
    {
        private string pageName;

        public string PageName
        {
            get
            {
                return pageName;
            }
        }

        public bool SubItem
        {
            get
            {
                return _subItem;
            }
        }

        public string[] SubItens
        {
            get
            {
                return _subItens;
            }
        }

        private bool _subItem = false;
        private string[] _subItens;
        public PageType(string pageName, bool _subItem)
        {
            this.pageName = pageName;
            this._subItem = _subItem;
        }
        public PageType(string pageName, bool _subItem, string[] _subItens)
        {
            this.pageName = pageName;
            this._subItem = _subItem;
            this._subItens = _subItens;
        }
    }

}

namespace TCC_Aline
{
    public partial class MainPage
    {
        public static MainPage Current;
        /// <summary>
        /// Contais the items that will be added to the Split Pane
        /// </summary>
        private ObservableCollection<PageType> Paginas = new ObservableCollection<PageType>();

        public const string FEATURE_NAME = "Livro de Receitas";

        /// <summary>
        /// Method that populate the ViewModel responsible for showing possible pages in the Split Pane
        /// </summary>
        private void PopulateSplit()
        {
            Paginas.Add(new PageType("Home", false));
            Paginas.Add(new PageType("Receitas", true, new string[] { "Doces", "Salgados" }));
            Paginas.Add(new PageType("Favoritos", false));
            Paginas.Add(new PageType("Glossário", false));
            Paginas.Add(new PageType("Dicas de medidas", false));
            Paginas.Add(new PageType("Técnicas", false));
            Paginas.Add(new PageType("Vídeos", false));
            Paginas.Add(new PageType("Timer", false));
        }
    }
}
