using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;

namespace TCC_Aline.Helpers
{
    class WindowHelper
    {
        public static Size GetWindowSize()
        {
            var bounds = ApplicationView.GetForCurrentView().VisibleBounds;
            var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            return new Size(bounds.Width * scaleFactor, bounds.Height * scaleFactor);
        }
    }
}
