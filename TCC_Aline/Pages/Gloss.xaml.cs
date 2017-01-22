using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Gloss : Page
    {
        public GlossarioData abacaxi = new GlossarioData()
        {
            Nome = "Abacaxi",
            Texto = @"O abacaxi é um fruto comestível do abacaxizeiro. Possui casca e coroa espinhosa e polpa bastante macia devido a grande quantidade de água que armazena.
É consumido ao natural ou industrializado. Serve para fazer compota, doces cristalizados, passa, picles,suco,xarope, geleira, licor, vinho, vinagre, aguardente. Coom o suco de abacaxi podem ser preparados refrescos, sorvetes, cremes, balas e bolos. Em culiária pode ser utilizado como um poderoso amaciante de carnes. Habitualente usa-se a polpa da fruta, mas seu miolo e as cascas podem ser aferventados para a produção de sucos. 
Possui dois tipos, hawai e pérola (mais adocicado)
Sazonalidade: frutifica o ano todo.
Fonte: Aplicativo guia de alimentos",
            ImageSource = "abacaxi.png"
        };

        public ObservableCollection<GlossarioData> itensGloss = new ObservableCollection<GlossarioData>()
        {
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
            }
        };

        public Gloss()
        {
            this.InitializeComponent();
            glossario.ItemsSource = itensGloss;
        }
    }
}
