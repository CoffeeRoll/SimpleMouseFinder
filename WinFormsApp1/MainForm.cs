using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private List<KeyValuePair<string, Color>> colors;

        private Overlay overlay;
        private bool showing = false;
        private bool initialized = false;

        public MainForm()
        {
            var r = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            colors = colorNames
           .Select(c => new KeyValuePair<string, Color>
           (
               string.Join(" ", r.Replace(c.ToString(), " ")),
               Color.FromName(c)
           ))
           .ToList();

            InitializeComponent();

            PopulateComboBoxes();

            initialized = true;

            UpdatePreview();
        }

        private void PopulateComboBoxes()
        {
            cbOuterColor.BindingContext = new BindingContext();
            cbOuterColor.DataSource = colors;
            cbOuterColor.DisplayMember = "Name";
            cbOuterColor.ValueMember = "Value";
            cbOuterColor.SelectedIndex = colors.IndexOf(colors.Single(c => c.Key == "Black"));

            cbInnerColor.BindingContext = new BindingContext();
            cbInnerColor.DataSource = colors;
            cbInnerColor.DisplayMember = "Name";
            cbInnerColor.ValueMember = "Value";
            cbInnerColor.SelectedIndex = colors.IndexOf(colors.Single(c => c.Key == "White")); ;
        }

        private void UpdatePreview()
        {
            if (!initialized)
            {
                return;
            }

            var graphics = pPreview.CreateGraphics();
            
            graphics.Clear(Color.FromKnownColor(KnownColor.Control));

            var alpha = (int)nAlpha.Value;
            var outerColor = Color.FromArgb(alpha, ((KeyValuePair<string, Color>)cbOuterColor.SelectedItem).Value);
            var innerColor = Color.FromArgb(alpha, ((KeyValuePair<string, Color>)cbInnerColor.SelectedItem).Value);

            var outerRad = (int)nOuterRad.Value;
            var innerRad = (int)nInnerRad.Value;

            var outerThick = (int)nOuterThick.Value;
            var innerThick = (int)nInnerThick.Value;

            var penOuter = new Pen(outerColor, outerThick);
            var penInner = new Pen(innerColor, innerThick);

            var offsetX = pPreview.Size.Width / 2;
            var offsetY = pPreview.Size.Height / 2;

            // e.Graphics.DrawEllipse(pen, pos.X - (w1 / 2), pos.Y - (w1 / 2), w1, w1);
            graphics.DrawEllipse(penOuter,offsetX - outerRad, offsetY - outerRad, outerRad*2, outerRad * 2);
            graphics.DrawEllipse(penInner, offsetX - innerRad, offsetY - innerRad, innerRad * 2, innerRad * 2);

            Invalidate();
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if(!showing)
            {
                var props = new PointerDecorationProps()
                {
                    InnerColor = ((KeyValuePair<string, Color>)cbInnerColor.SelectedItem).Value,
                    OuterColor = ((KeyValuePair<string, Color>)cbOuterColor.SelectedItem).Value,
                    InnerRadius = (int)nInnerRad.Value,
                    OuterRadius = (int)nOuterRad.Value,
                    InnerThickness = (int)nInnerThick.Value,
                    OuterThickness = (int)nOuterThick.Value,
                    Alpha = (int)nAlpha.Value
            };

                overlay = new Overlay(props);
                overlay.Show();
                bStartStop.Text = "Stop";
            }
            else
            {
                overlay.Close();
                bStartStop.Text = "Start";
            }

            showing = !showing;
        }

        private void cbOuterColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void nOuterRad_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void nOuterThick_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void cbInnerColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void nInnerRad_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void nInnerThick_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void nAlpha_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private string[] colorNames = {
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
