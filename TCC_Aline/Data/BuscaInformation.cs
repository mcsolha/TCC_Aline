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
        private static List<BuscaData> informacoes;

        public static List<BuscaData> Informacoes
        {
            get
            {
                if(informacoes == null)
                {
                    informacoes = new List<BuscaData>();
                    foreach (var item in Receitas)
                    {
                        informacoes.Add(new BuscaData()
                        {
                            Nome = item.Nome
                        });
                    }
                    foreach (var item in Tecnicas)
                    {
                        informacoes.Add(new BuscaData()
                        {
                            Nome = item.Titulo
                        });
                    }
                    foreach (var item in GlossarioItens)
                    {
                        informacoes.Add(new BuscaData()
                        {
                            Nome = item.Nome
                        });
                    }
                }
                return informacoes;
            }
        }
    }
}
