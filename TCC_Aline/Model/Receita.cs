using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace TCC_Aline.Model
{
    public class ReceitaData : ReceitaModel
    {
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
                return new BitmapImage(new Uri("ms-appx:///Assets/"+ base.ImageSource));
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
    }

    public static class ReceitaCast
    {
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
                PreparoString = model.PreparoString,
                Video = model.Video
            };
        }
    }

    public class ReceitaModel
    {
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

        private bool favorita;

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
