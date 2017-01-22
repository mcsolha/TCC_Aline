using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace TCC_Aline.Model
{
    public class TecnicasModel
    {
        private string titulo;
        private string descricao;
        private VideoModel videoTecnica;

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public VideoModel VideoTecnica
        {
            get
            {
                return videoTecnica;
            }

            set
            {
                videoTecnica = value;
            }
        }
    }

    public class TecnicasData : TecnicasModel, INotifyPropertyChanged
    {
        private string imageSource;
        public BitmapImage Imagem
        {
            get
            {
                return new BitmapImage(new Uri("ms-appx:///Assets/Images/Tecnicas/" + ImageSource));
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public static class TecnicaCast
    {
        public static TecnicasData ToTecnicaData(this TecnicasModel model)
        {
            TecnicasData tecnica = new TecnicasData();
            tecnica.Titulo = model.Titulo;
            tecnica.Descricao = model.Descricao;
            tecnica.VideoTecnica = model.VideoTecnica;
            return tecnica;
        }
    }

    public class TecnicasInstances
    {
        private static TecnicasData baterChantilly = new TecnicasData()
        {
            Titulo = "Bater Chantilly",
            ImageSource = "tecnica_bater_chatilly.png"
        };

        private static TecnicasData cortarCarne = new TecnicasData()
        {
            Titulo = "Cortar Carne",
            ImageSource = "tecnica_cortar_carne.png"
        };

        private static TecnicasData descascarAlho = new TecnicasData()
        {
            Titulo = "Descascar Alho",
            ImageSource = "tecnica_descascar_alho.png"
        };

        private static TecnicasData cozinharOvo = new TecnicasData()
        {
            Titulo = "Cozinhar Ovo",
            ImageSource = "tecnica_cozinhar_ovo.png"
        };

        private static TecnicasData peleTomate = new TecnicasData()
        {
            Titulo = "Tirar pele do Tomate",
            ImageSource = "tecnica_tirar_pele_do_tomate.png"
        };

        private static TecnicasData untarForma = new TecnicasData()
        {
            Titulo = "Untar Forma",
            ImageSource = "tecnica_untar_forma.png"
        };

     

        public static TecnicasData BaterChantilly
        {
            get
            {
                return baterChantilly;
            }

            set
            {
                baterChantilly = value;
            }
        }

        public static TecnicasData CortarCarne
        {
            get
            {
                return cortarCarne;
            }

            set
            {
                cortarCarne = value;
            }
        }

        public static TecnicasData DescascarAlho
        {
            get
            {
                return descascarAlho;
            }

            set
            {
                descascarAlho = value;
            }
        }

        public static TecnicasData CozinharOvo
        {
            get
            {
                return cozinharOvo;
            }

            set
            {
                cozinharOvo = value;
            }
        }

        public static TecnicasData PeleTomate
        {
            get
            {
                return peleTomate;
            }

            set
            {
                peleTomate = value;
            }
        }

        public static  TecnicasData UntarForma
        {
            get
            {
                return untarForma;
            }

            set
            {
                untarForma = value;
            }
        }

        public static List<TecnicasData> Tecnicas = new List<TecnicasData>() { UntarForma,
         BaterChantilly,
         CortarCarne,
         CozinharOvo,
         DescascarAlho,
         PeleTomate
        };
    }
}
