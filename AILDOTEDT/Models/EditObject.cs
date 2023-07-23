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
        public Palette Palette { get; set; } = new Palette(Enums.MachineType.PC_6001MK2_Screen_3);
        public List<Layer> LayerList { get; set; } = new List<Layer>();

        public EditObject() 
        {
        }
    }
}
