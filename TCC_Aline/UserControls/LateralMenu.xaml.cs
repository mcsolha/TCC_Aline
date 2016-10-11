using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TCC_Aline.UserControls
{
    public sealed partial class LateralMenu : UserControl
    {
        #region Events
        private event EventHandler PaneOpening;
        private event EventHandler PaneClosing;

        private void OnPaneOpening(object sender, EventArgs e)
        {
            PaneOpening?.Invoke(sender, e);
        }

        private void OnPaneClosing(object sender, EventArgs e)
        {
            PaneClosing?.Invoke(sender, e);
        }
        #endregion

        #region DPs
        public UIElement PaneContent
        {
            get { return (UIElement)GetValue(PaneContentProperty); }
            set { SetValue(PaneContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PaneContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PaneContentProperty =
            DependencyProperty.Register("PaneContent", typeof(UIElement), typeof(LateralMenu), new PropertyMetadata(null));


        public double RealWidth
        {
            get { return (double)GetValue(RealWidthProperty); }
            set { SetValue(RealWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RealWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RealWidthProperty =
            DependencyProperty.Register("RealWidth", typeof(double), typeof(LateralMenu), new PropertyMetadata(500));

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set
            {
                if (value)
                    OnPaneOpening(this, EventArgs.Empty);
                else
                    OnPaneClosing(this, EventArgs.Empty);
                SetValue(IsOpenProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(LateralMenu), new PropertyMetadata(false));

        public double PaneClosedWidth
        {
            get { return (double)GetValue(PaneClosedWidthProperty); }
            set { SetValue(PaneClosedWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PaneClosedWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PaneClosedWidthProperty =
            DependencyProperty.Register("PaneClosedWidth", typeof(double), typeof(LateralMenu), new PropertyMetadata(100));


        public double PaneOpenWidth
        {
            get { return (double)GetValue(PaneOpenWidthProperty); }
            set
            {
                SetValue(PaneOpenWidthProperty, value);
                if (IsOpen)
                    OnPaneOpening(this, EventArgs.Empty);
            }
        }

        // Using a DependencyProperty as the backing store for PaneOpenWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PaneOpenWidthProperty =
            DependencyProperty.Register("PaneOpenWidth", typeof(double), typeof(LateralMenu), new PropertyMetadata(500));
        #endregion

        public LateralMenu()
        {
            this.PaneOpening += MyUserControl1_PaneOpening;
            this.PaneClosing += MyUserControl1_PaneClosing;
            this.InitializeComponent();
        }

        private void MyUserControl1_PaneClosing(object sender, EventArgs e)
        {
            RealWidth = PaneClosedWidth;
        }

        private void MyUserControl1_PaneOpening(object sender, EventArgs e)
        {
            RealWidth = PaneOpenWidth;
        }
    }

}
