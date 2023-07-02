using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AILDOTEDT.Models
{
    public class Layer
    {
        public string Name { get; set; } = "";
        public bool Visible { get; set; } = true;
        public LayerImage LayerImage { get; set; } = new LayerImage();
    }
}
