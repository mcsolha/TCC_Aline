using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TCC_Aline.Helpers;
using TCC_Aline.Pages;
using TCC_Aline.Configuration;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace TCC_Aline.Model
{
    public class ReceitaData : ReceitaModel, INotifyPropertyChanged
    {
        public new bool Favorita { get { return base.favorita; }
            set
            {
                base.favorita = value;
                OnPropertyChanged("Favorita");
            }
        }

        private int porcoesCalculadas;
        public int PorcoesCalculadas { get { return porcoesCalculadas; } set { porcoesCalculadas = value; } }

        private Enum enumTipo = null;

        public Enum EnumTipo
        {
            get
            {
                if(enumTipo == null)
                {
                    foreach (var item in EnumHelper.GetEnumDescriptions(typeof(Doces)))
                    {
                        if (item == Tipo)
                            enumTipo = EnumHelper.GetEnumFromDescription<Doces>(item);
                    }
                    foreach (var item in EnumHelper.GetEnumDescriptions(typeof(Salgados)))
                    {
                        if (item == Tipo)
                            enumTipo = EnumHelper.GetEnumFromDescription<Salgados>(item);
                    }
                    foreach (var item in EnumHelper.GetEnumDescriptions(typeof(Carnes)))
                    {
                        if (item == Tipo)
                            enumTipo = EnumHelper.GetEnumFromDescription<Carnes>(item);
                    }
                }
                return enumTipo;
            }
        }   

        public TimeSpan Preparo
        {
            get
            {
                return TimeSpan.Parse(PreparoString);
            }
        }

        public TimeSpan Cozimento
        {
            get
            {
                return TimeSpan.Parse(CozimentoString);
            }
        }

        public BitmapImage Imagem
        {
            get
            {
                return new BitmapImage(new Uri("ms-appx:///Assets/Images/"+ base.ImageSource));
            }
        }

        private ObservableCollection<IngredienteData> ingredientesCollection;
        public ObservableCollection<IngredienteData> IngredientesCollection
        {
            get
            {
                if(ingredientesCollection == null)
                {
                    ingredientesCollection = new ObservableCollection<IngredienteData>();
                    foreach (var item in Ingredientes)
                    {
                        ingredientesCollection.Add(item.ToIngredienteData(ingredientesCollection.Count + 1));
                    }
                }
                return ingredientesCollection;
            }
        }

        private ObservableCollection<string> comentariosCollection;

        public ObservableCollection<string> ComentariosCollection
        {
            get
            {
                if(comentariosCollection == null)
                {
                    comentariosCollection = new ObservableCollection<string>();
                    foreach (var item in Comentarios)
                    {
                        comentariosCollection.Add(item);
                    }
                }
                return comentariosCollection;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public static class ReceitaCast
    {
        public static IEnumerable<ReceitaData> GetReceipt(this ObservableCollection<ReceitaData> recpts, Enum value)
        {
            dynamic valor = null;
            if (value is Doces)
            {
                valor = (Doces)value;
            }
            else if (value is Salgados)
            {
                valor = (Salgados)value;
            }else if(value is Carnes)
            {
                valor = (Carnes)value;
            }
            foreach (var item in recpts)
            {
                if (item.EnumTipo.Equals(valor))
                    yield return item;
            }
        }

        public static IEnumerable<ReceitaData> GetFavorites(this ObservableCollection<ReceitaData> recpts)
        {
            foreach (var item in recpts)
            {
                if (item.Favorita)
                    yield return item;
            }
        }

        public static ReceitaData ToReceitaData(this ReceitaModel model)
        {
            return new ReceitaData()
            {
                Comentarios = model.Comentarios,
                CozimentoString = model.CozimentoString,
                Favorita = model.Favorita,
                ImageSource = model.ImageSource,
                Ingredientes = model.Ingredientes,
                Modopreparo = model.Modopreparo,
                Nome = model.Nome,
                Pessoas = model.Pessoas,
                Porcoes = model.Porcoes,
                PorcoesCalculadas = model.Porcoes,
                PreparoString = model.PreparoString,
                Video = model.Video,
                Tipo = model.Tipo,
                Categoria = model.Categoria
            };
        }
    }

    public class ReceitaModel
    {
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private VideoModel video;

        public VideoModel Video
        {
            get { return video; }
            set { video = value; }
        }

        private string imageSource;

        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }

        private IngredienteModel[] ingredientes;

        public IngredienteModel[] Ingredientes
        {
            get { return ingredientes; }
            set { ingredientes = value; }
        }

        private string modoPreparo;

        public string Modopreparo
        {
            get { return modoPreparo; }
            set { modoPreparo = value; }
        }

        private int porcoes;

        public int Porcoes
        {
            get { return porcoes; }
            set { porcoes = value; }
        }

        private string cozimentoString;

        public string CozimentoString
        {
            get { return cozimentoString; }
            set { cozimentoString = value; }
        }

        private string preparoString;

        public string PreparoString
        {
            get { return preparoString; }
            set { preparoString = value; }
        }

        private int pessoas;

        public int Pessoas
        {
            get { return pessoas; }
            set { pessoas = value; }
        }

        protected bool favorita;

        public bool Favorita
        {
            get { return favorita; }
            set { favorita = value; }
        }

        private string[] comentarios;

        public string[] Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
    }
}
