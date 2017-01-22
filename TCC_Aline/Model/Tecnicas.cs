using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
