using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Aline.Model
{
    public class BuscaModel
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private object owner;

        public object Owner
        {
            get { return owner; }
            set { owner = value; }
        }
    }

    public class BuscaData : BuscaModel
    {
        private Type tipo;

        public Type Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
