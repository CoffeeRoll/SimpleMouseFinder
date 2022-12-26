using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList<ColorOption> colors;
        private Overlay overlay;
        private bool isShowing = false;

        public const int WS_EX_TRANSPARENT = 0x00000020;
        public const int GWL_EXSTYLE = (-20);


        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        public MainWindow()
        {
            InitializeComponent();
            PopulateColorComboBoxes();
        }

        private void PopulateColorComboBoxes()
        {
            colors = webColors
                .Select(c =>
                {
                    var webColor = System.Drawing.Color.FromName(c);
                    return new ColorOption()
                    {
                        Name = c,
                        Color = Color.FromRgb(webColor.R, webColor.G, webColor.B)
                    };
                })
                .ToList();

            cbOuterColor.ItemsSource = colors;
            cbOuterColor.SelectedIndex = colors.IndexOf(colors.Single(c => c.Name == "Black"));

            cbInnerColor.ItemsSource = colors;
            cbInnerColor.SelectedIndex = colors.IndexOf(colors.Single(c => c.Name == "White"));
        }

        private void StartStop_Click(object sender, RoutedEventArgs e)
        {
            if (isShowing)
            {
                overlay.Close();
                bStartStop.Content = "Start";
            }
            else
            {
                var props = new PointerDecorationProps()
                {
                    OuterColor = (cbOuterColor.SelectedItem as ColorOption).Color,
                    InnerColor = (cbInnerColor.SelectedItem as ColorOption).Color,
                    OuterRadius = int.Parse(tbOuterRadius.Text),
                    InnerRadius = int.Parse(tbInnerRadius.Text),
                    OuterThickness = int.Parse(tbOuterThickness.Text),
                    InnerThickness = int.Parse(tbInnerThickness.Text),
                    OuterAlpha = int.Parse(tbOuterAlpha.Text),
                    InnerAlpha = int.Parse(tbInnerAlpha.Text)
                };

                overlay = new Overlay(props);
                overlay.Show();

                // Disable all user interaction with the window to prevent it from stealing focus
                // Setting Focusable = False in the overlay xaml doesn't have the same effect
                var hwnd = new WindowInteropHelper(overlay).Handle;
                int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                _ = SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);

                bStartStop.Content = "Stop";
            }

            isShowing = !isShowing;
        }

        private void EnforceNumeric_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int value) && value >= 0 && value <= 255)
            {
                e.Handled = true;
            }
            e.Handled = false;
        }

        private string[] webColors = {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGreen",
            "LightGray",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "RebeccaPurple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"
        };
    }
}
