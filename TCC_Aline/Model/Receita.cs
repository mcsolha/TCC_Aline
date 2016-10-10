using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace TCC_Aline.Model
{
    public class Receita
    {
        public string Nome { get; set; }
        public VideoModel Video { get; set; }
        public Image Imagem { get; set; }
        public ObservableCollection<Ingrediente> Ingredientes { get; set; }
        public string Modopreparo { get; set; }
        public int Porcoes { get; set; }
        public TimeSpan Cozimento { get; set; }
        public TimeSpan Preparo { get; set; }
        public int Pessoas { get; set; }
        public bool Favorita { get; set; }
        public ObservableCollection<string> Comentarios { get; set; }
    }
}
