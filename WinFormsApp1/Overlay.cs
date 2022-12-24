using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Overlay : Form
    {
        private Pen outerPen;
        private Pen innerPen;

        PointerDecorationProps props;

        public Overlay(PointerDecorationProps props)
        {
            this.props = props;

            var outerColor = Color.FromArgb(props.Alpha, props.OuterColor);
            var innerColor = Color.FromArgb(props.Alpha, props.InnerColor);

            outerPen = new Pen(new SolidBrush(outerColor), props.OuterThickness);
            innerPen = new Pen(new SolidBrush(innerColor), props.InnerThickness);

            // Use a custom bg color to avoid colliding with a named color 
            // Since transparent winforms require a transparency key, one choses color will not be displayable
            var backColor = Color.FromArgb(1, 1, 1);

            TopMost = true;
            ShowInTaskbar = false;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
            BackColor = backColor;
            TransparencyKey = BackColor;
            WindowState = FormWindowState.Maximized;
            Paint += Overlay_Paint;
            InitializeComponent();
            Invalidate();
        }
        private void Overlay_Paint(object? sender, PaintEventArgs e)
        {
            var pos = Cursor.Position;

            e.Graphics.DrawEllipse(outerPen, pos.X - props.OuterRadius, pos.Y - props.OuterRadius, props.OuterRadius * 2, props.OuterRadius * 2);
            e.Graphics.DrawEllipse(innerPen, pos.X - props.InnerRadius, pos.Y - props.InnerRadius, props.InnerRadius * 2, props.InnerRadius * 2);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();  
        }
    }
}
