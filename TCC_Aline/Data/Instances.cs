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
        #region Receita
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
                if (cocadaBrancaData == null)
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

        #endregion

        #region Tecnicas
        private static TecnicasData baterChantilly = new TecnicasData()
        {
            Titulo = "Bater Chantilly",
            ImageSource = "tecnica_bater_chatilly.png"
        };

        private static TecnicasData cortarCarne = new TecnicasData()
        {
            Titulo = "Cortar Carne",
            ImageSource = "tecnica_cortar_carne.png"
        };

        private static TecnicasData descascarAlho = new TecnicasData()
        {
            Titulo = "Descascar Alho",
            ImageSource = "tecnica_descascar_alho.png"
        };

        private static TecnicasData cozinharOvo = new TecnicasData()
        {
            Titulo = "Cozinhar Ovo",
            ImageSource = "tecnica_cozinhar_ovo.png"
        };

        private static TecnicasData peleTomate = new TecnicasData()
        {
            Titulo = "Tirar pele do Tomate",
            ImageSource = "tecnica_tirar_pele_do_tomate.png"
        };

        private static TecnicasData untarForma = new TecnicasData()
        {
            Titulo = "Untar Forma",
            ImageSource = "tecnica_untar_forma.png",
             Descricao = @"Untar forma é uma técnica que facilita na retirada dos alimentos de assadeiras após serem assados.
Há diversos ingredientes que podem ser usados para untar forma, os mais comumente utilizados são a manteiga e a farinha de trigo. Também é possível utilizar óleo no lugar da
manteiga e outros ingredientes secos no lugar da farinha.
O chocolate em pó é um ótimo substituto para a farinha quando for assar alimentos que contenham chocolate na massa pois ao desenformar não haverá resquícios de farinha da forma untada. Para untar a forma basta espalhar a manteiga em toda a superfície da forma que entrará em contato com o alimento e depois polvilhar a farinha sobre a manteiga. Após retirar o excesso de farinha a forma estará pronta para uso!",
            VideoTecnica = new VideoModel()
            {
                Link = "https://www.youtube.com/watch?v=1bAz5KzouLw"
            }
        };
               
        public static TecnicasData BaterChantilly
        {
            get
            {
                return baterChantilly;
            }

            set
            {
                baterChantilly = value;
            }
        }

        public static TecnicasData CortarCarne
        {
            get
            {
                return cortarCarne;
            }

            set
            {
                cortarCarne = value;
            }
        }

        public static TecnicasData DescascarAlho
        {
            get
            {
                return descascarAlho;
            }

            set
            {
                descascarAlho = value;
            }
        }

        public static TecnicasData CozinharOvo
        {
            get
            {
                return cozinharOvo;
            }

            set
            {
                cozinharOvo = value;
            }
        }

        public static TecnicasData PeleTomate
        {
            get
            {
                return peleTomate;
            }

            set
            {
                peleTomate = value;
            }
        }

        public static TecnicasData UntarForma
        {
            get
            {
                return untarForma;
            }

            set
            {
                untarForma = value;
            }
        }

        public static List<TecnicasData> Tecnicas = new List<TecnicasData>() {
            UntarForma,
            BaterChantilly,
            CortarCarne,
            CozinharOvo,
            DescascarAlho,
            PeleTomate
        };
        #endregion

        #region Glossario
        public static List<GlossarioData> GlossarioItens = new List<GlossarioData>() {
                new GlossarioData()
                {
                    Nome = "Abacaxi",
                    Texto = @"O abacaxi é um fruto comestível do abacaxizeiro. Possui casca e coroa espinhosa e polpa bastante macia devido a grande quantidade de água que armazena.
        É consumido ao natural ou industrializado. Serve para fazer compota, doces cristalizados, passa, picles,suco,xarope, geleira, licor, vinho, vinagre, aguardente. Coom o suco de abacaxi podem ser preparados refrescos, sorvetes, cremes, balas e bolos. Em culiária pode ser utilizado como um poderoso amaciante de carnes. Habitualente usa-se a polpa da fruta, mas seu miolo e as cascas podem ser aferventados para a produção de sucos. 
        Possui dois tipos, hawai e pérola (mais adocicado)
        Sazonalidade: frutifica o ano todo.
        Fonte: Aplicativo guia de alimentos",
                    ImageSource = "abacaxi.png"
                },
                new GlossarioData()
                {
                    Nome = "Acelga",
                    Texto = @"A acelga é um legume de folha verde, tem um talo crocante e espesso ao qual as folhas se encontram anexadas, podendo ser lisas ou enrugadas, dependendo da variedade. Tanto o caule como as folhas da acelga são comestíveis, embora os caules variem em textura, com os brancos a serem os mais tenros.
        Sazonalidade : Junho a agosto
        Fonte: http://www.alimentacaosaudavel.org/acelga.html",
                    ImageSource = "acelga.png"
                },
                new GlossarioData()
                {
                    Nome = "Acerola",
                    Texto = @"A acerola é uma fruta pequena que contém grande concentração de vitamina C. Sua concentração é tão alta que chega a ser 100 vezes mais que o limão.
        É conhecida por ser um excelente antioxidante, bom na prevenção de gripes e resfriados. Antianêmico, cicatrizante e antiinflamatório. 
        É consumida no formato da fruta ou em sucos e sorvetes.
        Sazonalidade: setembro a dezembro
        Fonte: http://www.forumdaconstrucao.com.br/conteudo.php?a=45&Cod=796",
                    ImageSource = "acerola.png"
                },
                new GlossarioData()
                {
                    Nome = "À Milanesa",
                    Texto = @"Alimento revestido de uma envoltura de ovo e farinha de pão ou rosca, antes de fritar.
        Fonte: sonutricao.com.br",
                    ImageSource = "a-milanesa.png"
                },
                new GlossarioData()
                {
                    Nome = "Arroz",
                    Texto = @"É um alimento rico em carboidrato (amido) que fornece energia e contribui para a síntese de
proteína. É uma das principais bases alimentares em diversos países.
As variedades de arroz enriquecidas contêm ferro e vitaminas do complexo B (principalmente a vitamina B6), que reduz os níveis de homocisteína, danosa ao coração, e magnésio,
importante para a função normal da insulina. O arroz integral costuma ser indicado como uma opção mais nutritiva pois perde a maior parte
dos nutrientes ao ser beneficiado e perder a casca e o germe.
Fonte: http://mudandodiabetes.com.br/index.php/dicionario-de-alimentos/arroz-2/",
                    ImageSource = "arroz.png"
                },
                 new GlossarioData()
                {
                    Nome = "Banhar",
                    Texto = @"Colocar gordura ou molho sobre a carne que está assando.
Fonte: sonutricao.com.br",
                    ImageSource = "banhar.png"
                },
                new GlossarioData()
                {
                    Nome = "Banho-maria",
                    Texto = @"Forma de cozinhar os alimentos no forno ou à chama do fogão. É utilizada para alimentos que
já estão em recipientes, os quais deverão ser colocados dentro de um outro recipiente maior com água fervente, permanecendo desta maneira durante todo o cozimento.
Fonte: sonutricao.com.br",
                    ImageSource = "banho_maria.png"
                },
                new GlossarioData()
                {
                    Nome = "Batata",
                    Texto = @"A batata é um tubérculo de teor calórico significativo, rica em carboidratos e com baixa oferta
de gordura e proteínas. Por ter sua composição grande quantidade de amido, é um alimento de fácil digestão. Na casca é encontrada boa oferta de fibras alimentares, porém, antes de
consumi-la deve ser realizada uma higienização eficiente.
É altamente nutritiva, substituindo o pão branco com vantagem e outros alimentos também ricos em carboidratos (arroz, macarrão e mandioca). Contém vitamina A, B1, B2, C e niacina e
vários minerais como, por exemplo, o cálcio. No entanto, quando fritas podem perder a ação de algumas vitaminas, assim, o ideal é cozinha-las com a casca e sem cortar para evitar a perda destes nutrientes durante o cozimento.
Sazonalidade: Dezembro a março",
                    ImageSource = "batata.png"
                },
                new GlossarioData()
                {
                    Nome = "Cabrito",
                    Texto = @"O cabrito é uma verme muito saudável e extremamente deliciosa, sendo por natureza muito
tenra e amanteigada. O cabrito é a carne de ovelhas novas com menos de um ano de idade.
Costuma estar disponível em cinco cortes diferentes, incluindo a espádua, costeletas, peito,
lombo e perna. Existem também muitas lojas que já vendem a carne moída para cozinhar hambúrgueres, rolo de carne ou puré.
Fonte: http://www.alimentacaosaudavel.org/cabrito.html",
                    ImageSource = "cabrito.png"
                },
                new GlossarioData()
                {
                    Nome = "Camarão",
                    Texto = @"Espécie de crustáceo que pode ser marinho ou de água doce. A espécie mais conhecida e
consumida é conhecida como camarão rosado. É uma importante fonte de ômega três e é usado em diversos pratos e porções brasileiros.
Fonte: http://mudandodiabetes.com.br/index.php/dicionario-de-alimentos/camarao/",
                    ImageSource = "camarao.png"
                },
                new GlossarioData()
                {
                    Nome = "Caramelizar",
                    Texto = @"Submeter o açúcar à desidratação até formar-se o pigmento escurecido e o sabor de caramelo.
Fonte: sonutricao.com.br",
                    ImageSource = "caramelo.png"
                },
                new GlossarioData()
                {
                    Nome = "Couves De Bruxelas",
                    Texto = @"As couves-de- bruxelas são parentes próximos da couve e dos bróculos. As couves de bruxelas
fazem lembrar um mini repolho, com diâmetros de cerca de 2,5 cm, e crescem em cachos de 20 a 40 sobre o caule de uma planta que pode atingir os 90 cm de altura. Este tipo de couve é
tipicamente de cor verde, embora existam algumas variedades que apresentam uma tonalidade vermelha. Na generalidade, são vendidos separadamente, embora possam ser
encontrados nas lojas ainda em cachos e anexados ao caule. Quando cozidos, a couve de bruxelas apresenta uma textura densa e um sabor doce e “verde”.
Sazonalidade: Agosto a dezembro
Fonte: http://www.alimentacaosaudavel.org/couve-bruxelas.html",
                    ImageSource = "couve_de_bruxelas.png"
                },
                new GlossarioData()
                {
                    Nome = "Couves Flor",
                    Texto = @"A couve flor é um vegetal da mesma familia da couve de bruxelas e repolho. Têm uma cabeça
compacta (chamada de “coalhada”), com uma média de 15 cm de diâmetro, e composto por “botões” florais subdesenvolvidas. As flores estão associadas a um caule central, que quando
divididas e separadas em gomos, aparenta ser uma árvore pequenina, facto este que agrada a muitas crianças.
A couve flor crua tem uma textura esponjosa, embora firme, e um ligeiro sabor sulfuroso e amargo.
Fonte: http://www.alimentacaosaudavel.org/couve-flor.html",
                    ImageSource = "couve_flor.png"
                },
                new GlossarioData()
                {
                    Nome = "Dourar",
                    Texto = @"Alimentos à base de diferentes carnes que passam por processo tecnológico específico.
Exemplos: salsicha, chouriço, linguiça, salame, apresuntados, etc.
Fonte: sonutricao.com.br",
                    ImageSource = "dourar.png"
                },
                new GlossarioData()
                {
                    Nome = "Embutidos",
                    Texto = @"O mesmo que corar. Refere-se ao alimento passado na gordura.
Fonte: sonutricao.com.br",
                    ImageSource = "embutidos.png"
                },
                new GlossarioData()
                {
                    Nome = "Empanar",
                    Texto = @"Passar o alimento primeiro em ovos batidos depois em farinha de rosca ou somente em farinha de trigo, antes de fritá-lo ou assá-lo.",
                    ImageSource = "empanar.png"
                },
                new GlossarioData()
                {
                    Nome = "Feijão",
                    Texto = @"O feijão pertence ao grupo das leguminosas, que incluem a ervilha, lentilha, soja, grão-de- bico
e amendoim, sendo o feijão o mais popular. Sendo um dos principais alimentos da base alimentar brasileira o feijão é rico em ferro e é um dos principais alimentos no combate a anemia.",
                    ImageSource = "feijao.png"
                },
                new GlossarioData()
                {
                    Nome = "Fritar",
                    Texto = @"Submeter o alimento à cocção em gordura aquecida. Imersão em fritura, se está imerso; dourado, se uma face apenas está em contato com a gordura.
Fonte: sonutricao.com.br",
                    ImageSource = "feijao.png"
                },
                 new GlossarioData()
                {
                    Nome = "Iscas de vitela",
                    Texto = @"De origem bovina o fígado é conhecido por armazenar muitos nutrientes como pelo seu sabor
e textura. As iscas de vitela têm menos probabilidade de acumular toxinas como pesticidas, hormonas do que as iscas de animais mais velhos. As iscas de vitela são também mais tenras e
têm um sabor melhor que o das iscas de carne bovina.",
                    ImageSource = "isca_de_viela.png"
                },
                new GlossarioData()
                {
                    Nome = "Refogar",
                    Texto = @"Passar o alimento na panela quente (com ou sem gordura; com ou sem tempero) para dourar superfícies.
Fonte: sonutricao.com.br",
                    ImageSource = "refogar.png"
                },
                new GlossarioData()
                {
                    Nome = "Salpicar",
                    Texto = @"Temperar espargindo o condimento na superfície.
Fonte: sonutricao.com.br",
                    ImageSource = "salpicar.png"
                },
                new GlossarioData()
                {
                    Nome = "Saute",
                    Texto = @"O mesmo que dourar, em pouca gordura.
Fonte: sonutricao.com.br",
                    ImageSource = "saute.png"
                },
                new GlossarioData()
                {
                    Nome = "Tostar",
                    Texto = @"Obter escurecimento da superfície por ação do calor (dextrinização do amido).
Fonte: sonutricao.com.br",
                    ImageSource = "tostar.png"
                },
                new GlossarioData()
                {
                    Nome = "Untar",
                    Texto = @"Passar gordura em assadeiras ou formas, polvilhando ou não de farinha. Evita que os
alimentos grudem na travessa.
Fonte: sonutricao.com.br",
                    ImageSource = "untar.png"
                }
        };
        #endregion
    }

}
