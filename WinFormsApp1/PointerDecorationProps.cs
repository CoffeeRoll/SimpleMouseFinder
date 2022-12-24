using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class PointerDecorationProps
    {
        public int OuterRadius { get; set; } = 0;
        public int InnerRadius { get; set; } = 0;
        public int OuterThickness { get; set; } = 0;
        public int InnerThickness { get; set; } = 0;
        public Color OuterColor { get; set; } = Color.White;  
        public Color InnerColor { get; set; } = Color.White;

        public int Alpha { get; set; } = 0;
    }
}
