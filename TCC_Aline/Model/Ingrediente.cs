using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TCC_Aline.Model
{
    public class Ingrediente : INotifyPropertyChanged
    {
        private string texto;

        public string Texto
        {
            get { return texto; }
            set { texto = value; OnPropertyChanged("Texto"); }
        }

        public int Index { get; set; }
        public ObservableCollection<string> Substitutos { get; set; }
        public string Aux { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}