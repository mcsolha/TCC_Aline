using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using TCC_Aline.UserControls;
using System.Collections.ObjectModel;
using Windows.UI.Input;
using Windows.Storage;
using System.IO;
using System;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Web;
using Windows.Storage.Streams;
using TCC_Aline.Helpers;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TCC_Aline.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Receita : Page, INotifyPropertyChanged
    {
        public string htmlfile = @"<!DOCTYPE html>
<html>

  <head>
      <meta charset='utf-8'>
      <title>Youtube Page</title>
      <style>
          body {
        margin: 0;
            text - align: center;
        }
          
          .videoWrapper {
              position: relative;
              padding-bottom: 56.25%;
              /* 16:9 */
              padding-top: 25px;
              height: 0;
          }
          
          .videoWrapper iframe
    {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
    }
      </style>
  </head>

  <body>
    <div class='videoWrapper'>
        <!-- Copy & Pasted from YouTube -->
        <!--<video id ='video' src='http://localhost:3000/files/Kat_Double.mp4\' controls poster = 'annie_02.jpg'/> -->
        <iframe width ='560' height='349' src='http://www.youtube.com/embed/idvideo' frameborder='0' allowfullscreen></iframe>
    </div>
  </body>
</html>";
        GestureRecognizer gestureRecognizer = new GestureRecognizer();
        Model.ReceitaData recpt;

        ObservableCollection<Info> messages = new ObservableCollection<Info>();

        public GridLength ToGridLenght(double d)
        {
            return new GridLength(d);
        }

        public double ComentWidth
        {
            get { return (double)GetValue(ComentWidthProperty); }
            set { SetValue(ComentWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComentWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComentWidthProperty =
            DependencyProperty.Register("ComentWidth", typeof(double), typeof(Receita), new PropertyMetadata(150));

        private double openWidth;

        public double OpenWidth
        {
            get { return openWidth; }
            set { openWidth = value; OnPropertyChanged("OpenWidth"); }
        }

        private double lateralMenuFrameWidth;

        public double LateralMenuFrameWidth
        {
            get { return lateralMenuFrameWidth; }
            set { lateralMenuFrameWidth = value; OnPropertyChanged("LateralMenuFrameWidth"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public Receita()
        {
            this.InitializeComponent();
            lateralMenu.RegisterPropertyChangedCallback(VisibilityProperty, new DependencyPropertyChangedCallback(ChangeVisibility));
            quantPessoas.RegisterPropertyChangedCallback(NumericUpDown.PorcoesProperty, new DependencyPropertyChangedCallback(ChangePorcoes));
        }

        private void NavigateToVideo(string id)
        {
            htmlfile = htmlfile.Replace("idvideo", id);
            Video.NavigateToString(htmlfile);
        } 

        private void ChangePorcoes(DependencyObject obj, DependencyProperty pr)
        {
            foreach (var item in recpt.IngredientesCollection)
            {
                item.QuantidadeCalculada = (item.Quantidade * recpt.PorcoesCalculadas)/recpt.Porcoes;
            }
        }

        private void ChangeVisibility(DependencyObject obj, DependencyProperty pr)
        {
            var lm = obj as LateralMenu;
            if (lm.Visibility == Visibility.Collapsed && !messages.Any(x => x.Index == 0))
                messages.Add(new Info() { Index = 0, Message = "Clique com o botão direito para visualizar o menu lateral!" });
            else if (lm.Visibility == Visibility.Visible && messages.Any(x => x.Index == 0))
                messages.RemoveAt(0);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            recpt = (Model.ReceitaData)e.Parameter;
            NavigateToVideo(recpt.Video.Id);
            //Video.Navigate(new Uri("ms-appx///Web/video_page.html"));
            if (lateralMenu.Visibility == Visibility.Collapsed && !messages.Any(x => x.Index == 0))
                messages.Add(new Info() { Index = 0, Message = "Clique com o botão direito para visualizar o menu lateral!" });
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            OpenWidth = this.ActualWidth;
            LateralMenuFrameWidth = OpenWidth - lateralMenu.PaneClosedWidth;
          //  ComentWidth = coments.ActualWidth - 20;
        }


        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var ingr = ((sender as TextBlock).DataContext as Model.IngredienteData);
            if (ingr.SubstitutosCollection != null && ingr.SubstitutosCollection.Any())
            {
                FrameworkElement senderElement = sender as FrameworkElement;
                // If you need the clicked element:
                var whichOne = (sender as TextBlock).Text;
                FlyoutBase flyoutBase = FlyoutBase.GetAttachedFlyout(senderElement);
                flyoutBase.ShowAt(senderElement);
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Any())
            {
                Model.IngredienteData ob = (sender as ListView).DataContext as Model.IngredienteData;
                ob.Aux = ob.Texto;
                ob.Texto = e.AddedItems.Single() as string;
                ob.SubstitutosCollection[ob.SubstitutosCollection.IndexOf(ob.Texto)] = ob.Aux;
            }
        }

        private void paginaReceita_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            lateralMenu.Visibility = lateralMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Info d = (sender as Button).DataContext as Info;
            messages.Remove(d);
        }


        private void dicasMedida_Tapped(object sender, TappedRoutedEventArgs e)
        {
            lateralMenu.IsOpen = !lateralMenu.IsOpen;
            lateralMenuFrame.Navigate(typeof(DicasMedida));
        }

        private void timer_Tapped(object sender, TappedRoutedEventArgs e)
        {
            DialogHelper.ShowNotImplemented();
        }

        private void glossario_Tapped(object sender, TappedRoutedEventArgs e)
        {
            lateralMenu.IsOpen = !lateralMenu.IsOpen;
        }

        private void tecnicas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            lateralMenu.IsOpen = !lateralMenu.IsOpen;
        }

        private void dicasMedida_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            dicasMedida.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void dicasMedida_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            dicasMedida.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void glossario_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            glossario.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void glossario_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            glossario.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void tecnicas_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            tecnicas.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void tecnicas_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            tecnicas.Background = (SolidColorBrush)Resources["AzulClaro"];
        }

        private void timer_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            timer.Background = (SolidColorBrush)Resources["AzulDestaque"];
        }

        private void timer_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            timer.Background = (SolidColorBrush)Resources["AzulClaro"];
        }
    }

    public sealed class StreamUriWinRTResolver : IUriToStreamResolver
    {
        public IAsyncOperation<IInputStream> UriToStreamAsync(Uri uri)
        {
            if (uri == null)
            {
                throw new Exception();
            }
            string path = uri.AbsolutePath;

            // Because of the signature of the this method, it can't use await, so we 
            // call into a seperate helper method that can use the C# await pattern.
            return GetContent(path).AsAsyncOperation();
        }

        private async Task<IInputStream> GetContent(string path)
        {
            // We use a package folder as the source, but the same principle should apply
            // when supplying content from other locations
            try
            {
                Uri localUri = new Uri("ms-appx:///html" + path);
                StorageFile f = await StorageFile.GetFileFromApplicationUriAsync(localUri);
                IRandomAccessStream stream = await f.OpenAsync(FileAccessMode.Read);
                return stream;
            }
            catch (Exception) { throw new Exception("Invalid path"); }
        }
    }

    public class Info
    {
        public string Message { get; set; }
        public int Index { get; set; }
    }
}
