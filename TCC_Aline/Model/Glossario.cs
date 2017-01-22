using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace TCC_Aline.Model
{
    public class GlossarioData : GlossarioModel, INotifyPropertyChanged
    {
        private BitmapImage imagem;

        public BitmapImage Imagem
        {
            get
            {
                if (imagem == null)
                    imagem = new BitmapImage(new Uri("ms-appx:///Assets/Images/Glossario/" + base.ImageSource));
                OnPropertyChanged("Imagem");
                return imagem;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    static class GlossarioCast
    {
        public static GlossarioData ToGlossarioData(this GlossarioModel model)
        {
            return new GlossarioData()
            {
                Texto = model.Texto,
                ImageSource = model.ImageSource,
                Nome = model.Nome
            };
        }
    }

    public class GlossarioModel
    {
        private string nome;

        private string imageSource;

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

        public string Texto
        {
            get
            {
                return texto;
            }

            set
            {
                texto = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        private string texto;
    }
}
