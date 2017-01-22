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
        #region Navegavel
        static ReceitaModel cocadaBrancaModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Cocada Branca",
            Video = new VideoModel()
            {
                Link = "https://www.youtube.com/watch?v=TvLYnVMygGs"
            },
            ImageSourceHome = "DicasDoDia/foto-dica-cocada.png",
            ImageSource = "TodasReceitas/receitas_cocada_branca.png",
            Ingredientes = new IngredienteModel[4]
            {
                new IngredienteModel()
                {
                        Quantidade = 250,
                        Texto = "  g de coco fresco ralado",
                        Substitutos = null
                },
                new IngredienteModel()
                {
                    Quantidade = 190,
                    Texto = "  ml de água",
                    Substitutos = null
                },
                new IngredienteModel()
                {
                    Quantidade = 1.5,
                    Texto = "  copo(s) de açúcar",
                    Substitutos = null
                },
                new IngredienteModel()
                {
                    Quantidade = 0.5,
                    Texto = "  lata de leite condençado",
                    Substitutos = new string[1] { "  lata de leite condençado de soja" }
                }
            },
            Modopreparo = @"Em fogo baixo uma panela grande despeje a água e o açúcar para fazer uma calda em ponto de fio. Mexa com uma espátula ou colher até ferver.
Ao atingir o ponto de fervura a calda irá começar a engrossar. Mantenha mexendo com uma espátula até que seja possível ver o fundo da panela e a calda demore para voltar a cobrir o fundo.
Despeje então o coco ralado e misture. Por último despeje o leite condensado e mexa novamente até ver o fundo da panela. Retire do fogo e passe para um recipiente.Deixe esfriar um pouco até que seja possível o toque da cocada com as mãos. Enrole as cocadas com as mãos e leve a geladeira por aproximadamente um dia, até que estejam firmes.",
            Porcoes = 14,
           // CozimentoString = "30 minutos",
           // PreparoString = "1 dia",
            Pessoas = 5,
            Favorita = false,
            Comentarios = new string[1]
            {
                @"Dica: Para esta receita utilize o coco fresco ralado no ralo grande. Os pedaços de coco

garantem a textura e estrutura para o doce no final.

O coco pode ser comprado em mercado e ralado em processador ou raladores manuais e

também em feiras e armazéns já ralado",
            }
        };

        private static ReceitaData cocadaBrancaData;

        public static ReceitaData CocadaBranca
        {
            get
            {
                if(cocadaBrancaData == null)
                {
                    cocadaBrancaData = cocadaBrancaModel.ToReceitaData();
                }
                return cocadaBrancaData;
            }
        }
        #endregion

        #region Models
        static ReceitaModel lasanhaModel = new ReceitaModel()
        {
            Categoria = "Salgado",
            Tipo = "Massa",
            Nome = "Lasanha",
            ImageSourceHome = "DicasDoDia/foto-dica-lasanha.png",
        };

        static ReceitaModel queijadinhaModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Queijadinha",
            ImageSource = "TodasReceitas/receitas_queijadinha.png",
        };
        static ReceitaModel arrozDoceModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Arroz Doce",
            ImageSource = "TodasReceitas/receitas_arroz_doce.png",
        };
        static ReceitaModel balaCocoModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Lasanha",
            ImageSource = "TodasReceitas/receitas_bala_de_coco.png",
        };

        static ReceitaModel beijinhoModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Beijinho",
            ImageSource = "TodasReceitas/receitas_beijinho.png",
        };
        static ReceitaModel bolinhoChuvaModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Bolinho de Chuva",
            ImageSource = "TodasReceitas/receitas_bolinho_de_chuva.png",
        };
        static ReceitaModel canjicaModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Canjica",
            ImageSource = "TodasReceitas/receitas_canjica.png",
        };
        static ReceitaModel paoDeMelModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Pão de Mel",
            ImageSource = "TodasReceitas/receitas_pao_de_mel.png",
        };
        static ReceitaModel paveCremeModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Pavê de creme",
            ImageSource = "TodasReceitas/receitas_pave_de_creme.png",
        };

        static ReceitaModel quindimModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Quindim",
            ImageSource = "TodasReceitas/receitas_quindim.png",
            Favorita = true
        };
        static ReceitaModel sonhoModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Sonho de padaria",
            ImageSource = "TodasReceitas/receitas_sonho_de_padaria.png",
            Favorita = true
        };

        static ReceitaModel suspiroModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Suspiro",
            ImageSource = "TodasReceitas/receitas_suspiro.png",
            Favorita = true
        };
        #endregion

        #region DatasPrivate
        private static ReceitaData lasanhaData;

        private static ReceitaData queijadinhaData;
        private static ReceitaData arrozDoceData;
        private static ReceitaData baladeCocoData;
        private static ReceitaData beijinhoData;
        private static ReceitaData bolinhoChuvaData;
        private static ReceitaData canjicaData;
        private static ReceitaData paodeMelData;
        private static ReceitaData paveCremeData;
        private static ReceitaData quindimData;
        private static ReceitaData sonhoData;
        private static ReceitaData suspiroData;
        #endregion

        #region DatasPublic
        public static ReceitaData Lasanha
        {
            get
            {
                if (lasanhaData == null)
                    lasanhaData = lasanhaModel.ToReceitaData();
                return lasanhaData;
            }
        }

        public static ReceitaData Queijadinha
        {
            get
            {
                if (queijadinhaData == null)
                    queijadinhaData = queijadinhaModel.ToReceitaData();
                return queijadinhaData;
            }
        }

        public static ReceitaData ArrozDoce
        {
            get
            {
                if (arrozDoceData == null)
                    arrozDoceData = arrozDoceModel.ToReceitaData();
                return arrozDoceData;
            }
        }

        public static ReceitaData BalaCoco
        {
            get
            {
                if (baladeCocoData == null)
                    baladeCocoData = balaCocoModel.ToReceitaData();
                return baladeCocoData;
            }
        }

        public static ReceitaData Beijinho
        {
            get
            {
                if (beijinhoData == null)
                    beijinhoData = beijinhoModel.ToReceitaData();
                return beijinhoData;
            }
        }

        public static ReceitaData BolinhoChuva
        {
            get
            {
                if (bolinhoChuvaData == null)
                    bolinhoChuvaData = bolinhoChuvaModel.ToReceitaData();
                return bolinhoChuvaData;
            }
        }

        public static ReceitaData Canjica
        {
            get
            {
                if (canjicaData == null)
                    canjicaData = canjicaModel.ToReceitaData();
                return canjicaData;
            }
        }

        public static ReceitaData PaoDeMel
        {
            get
            {
                if (paodeMelData == null)
                    paodeMelData = paoDeMelModel.ToReceitaData();
                return paodeMelData;
            }
        }

        public static ReceitaData PaveCreme
        {
            get
            {
                if (paveCremeData == null)
                    paveCremeData = paveCremeModel.ToReceitaData();
                return paveCremeData;
            }
        }

        public static ReceitaData Quindim
        {
            get
            {
                if (quindimData == null)
                    quindimData = quindimModel.ToReceitaData();
                return quindimData;
            }
        }

        public static ReceitaData Sonho
        {
            get
            {
                if (sonhoData == null)
                    sonhoData = sonhoModel.ToReceitaData();
                return sonhoData;
            }
        }

        public static ReceitaData Suspiro
        {
            get
            {
                if (suspiroData == null)
                    suspiroData = suspiroModel.ToReceitaData();
                return suspiroData;
            }
        }
        #endregion

        public static List<ReceitaData> Receitas = new List<ReceitaData>() { CocadaBranca,
         Queijadinha,
         ArrozDoce,
         BalaCoco,
         Beijinho,
         BolinhoChuva,
         Canjica,
         PaoDeMel,
         PaveCreme,
         Quindim,
         Sonho,
         Suspiro
        };
    }
}
