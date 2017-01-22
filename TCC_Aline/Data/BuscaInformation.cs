using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_Aline.Model;

namespace TCC_Aline.Data
{
    static partial class Instances
    {
        private static List<BuscaData> informacoes = new List<BuscaData>()
        {
            new BuscaData()
            {
                Nome = "Teste"
            }
        };

        public static List<BuscaData> Informacoes
        {
            get
            {
                return informacoes;
            }
        }
    }
}
