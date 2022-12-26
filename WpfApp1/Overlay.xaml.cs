using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Overlay.xaml
    /// </summary>
    public partial class Overlay : Window
    {
        private PointerDecorationProps props;

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

        public Overlay(PointerDecorationProps props)
        {
            this.props = props;
            InitializeComponent();
            
            SetupElipses();

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dispatcherTimer.Start();
        }

        private void SetupElipses()
        {
            OuterElipse.Stroke = new SolidColorBrush(props.OuterColor);
            var outerOpacity = props.OuterAlpha / 255.0;
            OuterElipse.Opacity = outerOpacity <= 1.0 ? outerOpacity : 1.0;
            OuterElipse.StrokeThickness = props.OuterThickness;
            OuterElipse.Width = props.OuterRadius * 2;
            OuterElipse.Height = props.OuterRadius * 2;

            InnerElipse.Stroke = new SolidColorBrush(props.InnerColor);
            var innerOpacity = props.InnerAlpha / 255.0;
            InnerElipse.Opacity = innerOpacity <= 1.0 ? innerOpacity : 1.0;
            InnerElipse.StrokeThickness = props.InnerThickness;
            InnerElipse.Width = props.InnerRadius * 2;
            InnerElipse.Height = props.InnerRadius * 2;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            GetCursorPos(out var pos);
            
            Canvas.SetLeft(OuterElipse, pos.X - props.OuterRadius);
            Canvas.SetTop(OuterElipse, pos.Y - props.OuterRadius);

            Canvas.SetLeft(InnerElipse, pos.X - props.InnerRadius);
            Canvas.SetTop(InnerElipse, pos.Y - props.InnerRadius);

            cOverlay.Dispatcher.Invoke(DispatcherPriority.Render, () => { });
        }
    }
}
