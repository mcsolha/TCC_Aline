using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TCC_Aline.Model
{
    public class IngredienteData : IngredienteModel, INotifyPropertyChanged
    {
        private double quantidadeCalculada;
        public double QuantidadeCalculada { get { return Math.Round(quantidadeCalculada, 2); } set { quantidadeCalculada = value; OnPropertyChanged("QuantidadeCalculada"); } }

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
                if (substitutosCollection == null && Substitutos != null)
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
                Substitutos = model.Substitutos,
                Quantidade = model.Quantidade,
                QuantidadeCalculada = model.Quantidade,
                Aux = null,
            };
        }
    }

    public class IngredienteModel
    {
        protected double quantidade;
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }

        protected string texto;
        public string Texto { get { return texto; } set { texto = value; } }

        public string[] Substitutos { get; set; }
    }
}