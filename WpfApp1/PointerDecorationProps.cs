using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
    public class PointerDecorationProps
    {
        public int OuterRadius { get; set; } = 0;
        public int InnerRadius { get; set; } = 0;
        public int OuterThickness { get; set; } = 0;
        public int InnerThickness { get; set; } = 0;
        public Color OuterColor { get; set; } 
        public Color InnerColor { get; set; } 
        public int OuterAlpha { get; set; } = 0;
        public int InnerAlpha { get; set; } = 0;
    }
}
