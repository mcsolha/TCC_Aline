using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_Aline.Helpers;

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
        [Display(Description = "Tortas")]
        Tortas,
        [Display(Description = "Massas")]
        Massas,
        [Display(Description = "Saladas")]
        Saladas,
        [Display(Description = "Carnes")]
        Carnes,
        [Display(Description = "Molhos")]
        Molhos,
        [Display(Description = "Pães")]
        Paes,
        [Display(Description = "Entradas")]
        Entradas,
        [Display(Description = "Sopas / Caldos")]
        SopasCaldos
    }

    public enum Doces
    {
        [Display(Description = "Bolos")]
        Bolos,
        [Display(Description = "Tortas")]
        Tortas,
        [Display(Description = "Mousses")]
        Mousses,
        [Display(Description = "Sorvetes")]
        Sorvetes,
        [Display(Description = "Brigadeiros")]
        Brigadeiros,
        [Display(Description = "Geleias")]
        Geleias,
        [Display(Description = "Gelatinas")]
        Gelatinas
    }
    public class Tipo
    {
        public string Nome { get; set; }
        private Categorias categoria;
        public Categorias Categoria
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

        public Tipo(string nome, Categorias categoria)
        {
            Nome = nome;
            Categoria = categoria;
        }

        public static ObservableCollection<Tipo> GetByCategory(Categorias cat)
        {
            var ret = new ObservableCollection<Tipo>();
            switch (cat)
            {
                case Categorias.Salgados:
                    foreach (Salgados item in Enum.GetValues(typeof(Salgados)))
                    {
                        ret.Add(new Tipo(EnumHelper.GetEnumDescription(item), Categorias.Salgados));
                    }
                    break;
                case Categorias.Doces:
                    foreach (Doces item in Enum.GetValues(typeof(Doces)))
                    {
                        ret.Add(new Tipo(EnumHelper.GetEnumDescription(item), Categorias.Doces));
                    }
                    break;
            }
            return ret;
        }
    }
}
