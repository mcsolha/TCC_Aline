using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace TCC_Aline.Helpers
{
    static class DialogHelper
    {
        public async static void ShowNotImplemented()
        {
            await (new ContentDialog()
            {
                Title = "Desculpe!", // Required for Mobile!
                Content = "Conteúdo não implementado.",
                PrimaryButtonText = "Ok"
            }).ShowAsync();
        }
        
    }
}
