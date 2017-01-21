using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_Aline.Model;

namespace TCC_Aline.Data
{
    static class Instances
    {
        static ReceitaModel cocadaBrancaModel = new ReceitaModel()
        {
            Categoria = "Doces",
            Tipo = "Doces Variados",
            Nome = "Cocada Branca",
            Video = new VideoModel()
            {
                Link = "https://www.youtube.com/watch?v=LBtTaU8ckp4"
            },
            ImageSource = "DicasDoDia/foto-dica-cocada.png",
            Ingredientes = new IngredienteModel[4]
            {
                new IngredienteModel()
                {
                        Quantidade = 250,
                        Texto = "g de coco fresco ralado",
                        Substitutos = null
                },
                new IngredienteModel()
                {
                    Quantidade = 190,
                    Texto = "ml de água",
                    Substitutos = null
                },
                new IngredienteModel()
                {
                    Quantidade = 1.5,
                    Texto = "copo(s) de açúcar",
                    Substitutos = null
                },
                new IngredienteModel()
                {
                    Quantidade = 0.5,
                    Texto = "lata de leite condençado",
                    Substitutos = new string[1] { "lata de leite condençado de soja" }
                }
            },
            Modopreparo = @"Em fogo baixo uma panela grande despeje a água e o açúcar para fazer uma

calda em ponto de fio. Mexa com uma espátula ou colher até ferver.

Ao atingir o ponto de fervura a calda irá começar a engrossar.

Mantenha mexendo com uma espátula até que seja possível ver o fundo da panela e a calda

demore para voltar a cobrir o fundo.

Despeje então o coco ralado e misture.

Por último despeje o leite condensado e mexa novamente até ver o fundo da panela.

Retire do fogo e passe para um recipiente.

Deixe esfriar um pouco até que seja possível o toque da cocada com as mãos.

Enrole as cocadas com as mãos e leve a geladeira por aproximadamente um dia, até que

estejam firmes.",
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

        static ReceitaModel lasanhaModel = new ReceitaModel()
        {
            Categoria = "Salgado",
            Tipo = "Massa",
            Nome = "Lasanha",
            ImageSource = "DicasDoDia/foto-dica-lasanha.png",
        };

        private static ReceitaData lasanhaData;

        public static ReceitaData Lasanha
        {
            get
            {
                if (lasanhaData == null)
                    lasanhaData = lasanhaModel.ToReceitaData();
                return lasanhaData;
            }
        }



    }
}
