using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TCC_Aline.Model
{
    public class IngredienteData : IngredienteModel, INotifyPropertyChanged
    {
        public new string Texto
        {
            get { return base.Texto; }
            set { texto = value; OnPropertyChanged("Texto"); }
        }

        private ObservableCollection<string> substitutosCollection;

        public ObservableCollection<string> SubstitutosCollection
        {
            get
            {
                if (substitutosCollection == null)
                {
                    substitutosCollection = new ObservableCollection<string>();
                    foreach (var item in Substitutos)
                        substitutosCollection.Add(item);
                }
                return substitutosCollection;
            }
        }

        public string Aux { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public static class IngredienteCast
    {
        public static IngredienteData ToIngredienteData(this IngredienteModel model, int index)
        {
            return new IngredienteData()
            {
                Texto = model.Texto,
                Index = index,
                Substitutos = model.Substitutos,
                Aux = null,
            };
        }
    }

    public class IngredienteModel
    {
        protected string texto;
        public string Texto { get { return texto; } set { texto = value; } }

        public int Index { get; set; }
        public string[] Substitutos { get; set; }
    }
}