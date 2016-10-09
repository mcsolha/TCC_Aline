﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_Aline.Configuration;
using TCC_Aline.Helpers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TCC_Aline.Configuration
{
    public enum PageName
    {
        [Display(Description = "Home")]
        Home,
        [Display(Description = "Receitas")]
        Receitas,
        [Display(Description = "Doces")]
        Doces,
        [Display(Description = "Salgados")]
        Salgados,
        [Display(Description = "Favoritos")]
        Favoritos,
        [Display(Description = "Glossário")]
        Glossario,
        [Display(Description = "Dicas de Medida")]
        DicasMedida,
        [Display(Description = "Técnicas")]
        Tecnicas,
        [Display(Description = "Vídeos")]
        Videos,
        [Display(Description = "Timer")]
        Timer
    }
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
        public PageType(string pageName, bool _subItem, params string[] _subItens)
        {
            this.pageName = pageName;
            this._subItem = _subItem;
            this._subItens = _subItens;
        }

        public static IEnumerable<PageName> GeneratePageTypes()
        {
            foreach (PageName item in Enum.GetValues(typeof(PageName)))
            {
                if (!item.Equals(Configuration.PageName.Doces) || !item.Equals(Configuration.PageName.Salgados))
                {
                    yield return item;
                }
            }
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
            foreach (var item in PageType.GeneratePageTypes())
            {
                if (item.Equals(PageName.Receitas))
                    Paginas.Add(new PageType(EnumHelper.GetEnumDescription(item), true, EnumHelper.GetEnumDescription(PageName.Doces), EnumHelper.GetEnumDescription(PageName.Salgados)));
                else
                    Paginas.Add(new PageType(EnumHelper.GetEnumDescription(item), false));
            }
        }
    }
}
