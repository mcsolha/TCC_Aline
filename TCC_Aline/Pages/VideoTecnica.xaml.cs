using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCC_Aline.Data;
using TCC_Aline.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class VideoTecnica : Page
    {

        #region htmlfile
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
        #endregion


        public TecnicasData untarForma = new TecnicasData();
       
        private void NavigateToVideo(string id)
        {
            htmlfile = htmlfile.Replace("idvideo", id);
            Video.NavigateToString(htmlfile);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NavigateToVideo(untarForma.VideoTecnica.Id);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
           AppViewBackButtonVisibility.Visible;
        }

        public VideoTecnica()
        {
            this.InitializeComponent();
            untarForma = Instances.Tecnicas.Find(x => x.Titulo == "Untar Forma");
        }
    }
}
