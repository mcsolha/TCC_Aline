using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_Aline.Helpers;
using Windows.UI.Xaml.Media.Imaging;

namespace TCC_Aline.Model
{
    public enum Categorias
    {
        [Display(Description ="Salgados")]
        Salgados,
        [Display(Description = "Doces")]
        Doces
    }
    public enum Salgados
    {
        [Display(Description = "Aperitivos")]
        Aperitivos,
        [Display(Description = "Carnes")]
        Carnes,
        [Display(Description = "Massas")]
        Massas,
        [Display(Description = "Molhos")]
        Molhos,
        [Display(Description = "Pães")]
        Paes,
        [Display(Description = "Saladas")]
        Saladas,
        [Display(Description = "Sopas")]
        Sopas,
        [Display(Description = "Tortas")] //Queijadinha
        Tortas
    }

    public enum Doces
    {
        [Display(Description = "Biscoitos")]
        Biscoitos,
        [Display(Description = "Bolos")] //Bolinho de chuva - Pão de mel
        Bolos,
        [Display(Description = "Doces com frutas")]
        Doces_com_frutas,
        [Display(Description = "Doces Variados")] //Cocada Branca - Arroz Doce - Canjica - Sonho de padaria - Suspiro
        Doces_variados,
        [Display(Description = "Gelados")] //Bala de coco - Pavê de creme
        Gelados,
        [Display(Description = "Pudins")] //Quindim
        Pudins,
        [Display(Description = "Rocamboles")]
        Rocamboles,
        [Display(Description = "Roscas")]
        Roscas
    }

    public enum Carnes
    {
        [Display(Description = "Frangos")]
        Frangos,
        [Display(Description = "Bovinos")]
        Bovinos,
        [Display(Description = "Suínos")]
        Suinos
    }

    public class Tipo
    {
        private string imageSource;
        public BitmapImage Imagem
        {
            get
            {
                return new BitmapImage(new Uri("ms-appx:///Assets/Images/" + ImageSource));
            }
        }
        public Enum nome; 
        public string Nome { get; set; }
        private Categorias? categoria;
        public Categorias? Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

        public string ImageSource
        {
            get
            {
                return imageSource;
            }

            set
            {
                imageSource = value;
            }
        }

        public Tipo(Salgados nome, Categorias categoria)
        {
            this.nome = nome;
            Nome = EnumHelper.GetEnumDescription(nome);
            Categoria = categoria;
        }

        public Tipo(Doces nome, Categorias categoria)
        {
            this.nome = nome;
            Nome = EnumHelper.GetEnumDescription(nome);
            Categoria = categoria;
        }

        public Tipo(Enum item)
        {
            this.nome = item;
            Nome = EnumHelper.GetEnumDescription(nome);
            Categoria = null;
        }

        public static ObservableCollection<Tipo> GetBySubcategory(Type e)
        {
            var ret = new ObservableCollection<Tipo>();
            foreach (var item in Enum.GetValues(e))
            {
                if(item is Enum)
                    ret.Add(new Tipo(item as Enum));
            }
            return ret;
        }

        public static ObservableCollection<Tipo> GetByCategory(Categorias cat)
        {
            var ret = new ObservableCollection<Tipo>();
            switch (cat)
            {
                case Categorias.Salgados:
                    foreach (Salgados item in Enum.GetValues(typeof(Salgados)))
                    {
                        ret.Add(new Tipo(item, Categorias.Salgados) { ImageSource = "/ReceitasSalgadas/" + EnumHelper.GetEnumDescription(item) + ".png"});
                    }
                    break;
                case Categorias.Doces:
                    foreach (Doces item in Enum.GetValues(typeof(Doces)))
                    {
                        ret.Add(new Tipo(item, Categorias.Doces) { ImageSource = "/ReceitasDoces/" + EnumHelper.GetEnumDescription(item) + ".png" });
                    }
                    break;
            }
            return ret;
        }
    }
}
