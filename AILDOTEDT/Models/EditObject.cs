using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AILDOTEDT.Models
{
    public class EditObject
    {
        public string Name { get; set; } = "";
        public List<Layer> LayerList { get; set; } = new List<Layer>();
    }
}
